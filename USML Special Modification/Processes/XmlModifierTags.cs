using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace USML_Special_Modification.Processes
{
    internal class XmlModifierTags : Abstracts.ViewModelBase, ISpecialAutoTagging
    {
        private readonly IEnumerable<string> ignoredTags = new List<string>
                {
                    "longTitle", "docTitle", "officialTitle", "authority", "sidenote", "enactingFormula",
                    "section", "action", "resolvingClause", "article", "chapter",
                    "actionDescription", "content", "page", "num", "preamble", "recital", "block", "p", "/enactingFormula"
                };

        public Task<string> AutoTaggingScan(string documentText, string volumeNumber)
        {
            return AutoTaggingScan(documentText);
        }

        public async Task<string> AutoTaggingScan(string documentText)
        {
            string result = documentText;
            try
            {
                await Task.Run(() =>
                {


                    string enactingFormula = TaggingOfEnactingFormula(result);
                    if (!string.IsNullOrWhiteSpace(enactingFormula))
                    {
                        result = enactingFormula;
                    }

                    string sectionNumber = AutoAddSectionNumber(result);
                    if (!string.IsNullOrWhiteSpace(sectionNumber))
                    {
                        result = sectionNumber;
                    }

                    string insertChapNumberTags = InsertDocNumber(result);
                    if (!string.IsNullOrWhiteSpace(insertChapNumberTags))
                    {
                        result = insertChapNumberTags;
                    }

                    string genericTags = InsertGenericTags(result);
                    if (!string.IsNullOrWhiteSpace(genericTags))
                    {
                        result = genericTags;
                    }

                    string actionDescription = ApprovedDateInSidenoteAndActionDescriptionTagging(result);
                    if (!string.IsNullOrWhiteSpace(actionDescription))
                    {
                        result = actionDescription;
                    }
                });
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }
            return result;
        }



        /// <summary>
        /// Add <section> with class and <num> tag in in "Sec. 2."
        /// Add sub element <content>
        /// Added words [", Sec. 2."] ["Seo. 2."] ["Section. 2."]
        /// <section class="firstIndent1 fontsize10"><num value="2">Sec. 2. </num><content>That if the Secretary</content></section>
        /// </summary>
        /// <param name="documentText"></param>
        /// <returns></returns>
        private string AutoAddSectionNumber(string documentText)
        {
            string result = documentText;
            try
            {
                string pattern = @"(.*?|<inline[^>]*>])?(Sec|Seo|Sect|Section)\s*([\.,/])?(<\/inline>)?\s*(\d+)[\.,/]\s*(.*)";
                string mainPattern = @"<main>([\s\S]*?)<\/main>";

                documentText = Regex.Replace(documentText, mainPattern, match =>
                {
                    string mainContent = match.Groups[1].Value;

                    mainContent = Regex.Replace(mainContent, pattern, mainMatch =>
                    {
                        string beforeSec = mainMatch.Groups[1].Value;
                        string sectionName = mainMatch.Groups[2].Value == "Seo" ? "Sec" : mainMatch.Groups[2].Value;
                        //string sectionPunctuation = mainMatch.Groups[3].Value;
                        string enclosingTag = mainMatch.Groups[4].Value;
                        string sectionNumber = mainMatch.Groups[5].Value;
                        string sectionContent = mainMatch.Groups[6].Value;
                        return $@"<section class=""firstIndent1 fontsize10""><num value=""{sectionNumber}"">{beforeSec}{sectionName}. {enclosingTag}{sectionNumber}. </num><content>{sectionContent}</content></section>";
                    });

                    return $"<main>\n{mainContent}\n</main>";
                });

                result = documentText;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }
            return result;
            #region dump
            //string pattern = @"(.*?)Sec\.\s*(\d+)\.\s*(.*)";
            //string pattern = @"(.*?)(?:Sec|Seo)[\.,/]\s*(\d+)\.\s*(.*)";
            //string pattern = @"\b(?:Sec|Seo|Section)\s*[\.,/]?\s*(\d+)\.\s*(.*)";
            //documentText = Regex.Replace(documentText, pattern, mainMatch =>
            //{
            //    //Capture the original prefix (Sec., Seo., Section)
            //    string sectionPrefix = mainMatch.Groups[0].Value.Split(' ')[0];
            //    string sectionNumber = mainMatch.Groups[1].Value;
            //    string sectionContent = mainMatch.Groups[2].Value.Trim();

            //    return $@"<section class=""firstIndent1 fontsize10""><num value=""{sectionNumber}"">{sectionPrefix} {sectionNumber}. </num><content>{sectionContent}</content></section>";
            //}); 
            #endregion
        }



        private string TaggingOfEnactingFormula(string documentText)
        {
            string result = string.Empty;
            try
            {


                //string resolvePattern = @"(Be it enacted[^,]*,?|[^<]*<enactingFormula><i>Be it enacted[^<]*<\/i>)(.*)";
                //string resolvePattern = @"([^<]*<enactingFormula>)(Be it enacted[^,]*,?|<i>Be it enacted[^<]*<\/i>)(.*)";

                string resolvePattern = @"(Be it enacted[^,]*,?|<i>Be it enacted[^<]*<\/i>)(.*)";
                string mainPattern = @"<main>([\s\S]*?)<\/main>";

                documentText = Regex.Replace(documentText, mainPattern, match =>
                {
                    string mainContent = match.Groups[1].Value;

                    mainContent = Regex.Replace(mainContent, resolvePattern, mainMatch =>
                    {
                        string enactingFormulaTitle = mainMatch.Groups[1].Value;
                        string enactingFormulaContent = mainMatch.Groups[2].Value;

                        if (Regex.IsMatch(enactingFormulaTitle, @"(,|<\/i>)$"))
                        {
                            enactingFormulaTitle = Regex.Replace(enactingFormulaTitle, @"<\/?i>", "");
                            enactingFormulaTitle = Regex.Replace(enactingFormulaTitle, @",$", "");
                            enactingFormulaTitle = $"<i>{enactingFormulaTitle}</i>,</enactingFormula>";
                            //enactingFormulaTitle = $"<enactingFormula><i>{enactingFormulaTitle}</i>,</enactingFormula>\n";
                        }
                        else
                        {
                            enactingFormulaTitle = $"<i>{enactingFormulaTitle}</i>,</enactingFormula>";
                            //enactingFormulaTitle = $"<enactingFormula><i>{enactingFormulaTitle}</i>,</enactingFormula>\n";
                        }


                        return enactingFormulaTitle;

                        //return $"" +
                        //enactingFormulaTitle +
                        //$"<section class=\"inline\">\n<content class=\"inline\">{enactingFormulaContent}</content>\n</section>\n";
                    });

                    return $"<main>\n{mainContent}\n</main>";
                });

                result = documentText;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }
            return result;
        }

        private string ApprovedDateInSidenoteAndActionDescriptionTagging(string documentText)
        {
            string result = string.Empty;
            try
            {
                //string publicLawsPattern = @"<publicLaws>([\s\S]*?)<\/publicLaws>";
                //public and private laws
                string publicLawsPattern = @"(<publicLaws>|<privateLaws>)([\s\S]*?)(<\/publicLaws>|<\/privateLaws)";
                string presidentialPattern = @"<presidentialDocs>([\s\S]*?)<\/presidentialDocs>";
                string ResolutionsPattern = @"<concurrentResolutions>([\s\S]*?)<\/concurrentResolutions>";

                string dcDatePattern = @"<dc:date>(.*?)<\/dc:date>";

                //presidentialDocs
                documentText = Regex.Replace(documentText, presidentialPattern, matchpresidential =>
                {
                    string mainContent = matchpresidential.Groups[1].Value;

                    Match dcDateMatch = Regex.Match(mainContent, dcDatePattern);
                    if (dcDateMatch.Success)
                    {
                        string dcDateValue = dcDateMatch.Groups[1].Value;
                        // format date time
                        if (DateTime.TryParse(dcDateValue, out DateTime parsedDate))
                        {
                            string newSidenote = $@"<sidenote><p class=""centered fontsize8""><date date=""{parsedDate:yyyy-MM-dd}"">{parsedDate:MMMM dd, yyyy}</date>.</p></sidenote>";

                            mainContent = Regex.Replace(mainContent, dcDatePattern, match =>
                            {
                                return $"<dc:date>{parsedDate:MMMM dd, yyyy}</dc:date>";
                            });

                            mainContent = Regex.Replace(mainContent, @"</preface>", match =>
                            {
                                return $"{newSidenote}\n</preface>";
                            });
                        }
                    }

                    return $"<presidentialDocs>{mainContent}</presidentialDocs>";
                });

                //publiclaws
                documentText = Regex.Replace(documentText, publicLawsPattern, matchpubliclaws =>
                {

                    #region dump regex
                    //string actionDescriptionPattern = @"<actionDescription>\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?)(.*)<\/actionDescription>";
                    //string actionDescriptionPattern = @"<actionDescription><sidenote><p class=""firstIndent1 fontsize8"">\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?)(.*)<\/actionDescription>";
                    //string actionDescriptionPattern = @"<actionDescription>\b(Approved By|Approved|Received By|Received)\b.*?([A-Z][a-z]+\s\d{1,2},\d{4}).*?<\/actionDescription>";
                    //string actionDescriptionPublicPattern = @"<actionDescription>.*?\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?).*?([A-Z][a-z]+\s\d{1,2},\s\d{4}).*?<\/actionDescription>";
                    //string actionDescriptionPublicPattern = @"<actionDescription>.*?\b(Approved By|Approved|Received By|Received)\b.*?([A-Z][a-z]+\s\d{1,2},\s\d{4}).*?<\/actionDescription>";
                    //string actionDescriptionPublicPattern = @"<actionDescription>.*?\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?).*?([A-Z][a-z]+\s\d{1,2},\s\d{4})([\s.,\/]?).*?<\/actionDescription>";
                    //string actionDescriptionPublicPattern = @"<actionDescription>.*?\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?).*?([A-Z][a-z]+\s\d{1,2}([\s.,\/]?)\s\d{4})([\s.,\/]?).*?<\/actionDescription>";
                    //string actionDescriptionPublicPattern = @"<actionDescription>.*?\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?).*?([A-Z][a-z]+\s\d{1,2})([\s.,\/]?)\s(\d{4})([\s.,\/]?).*?<\/actionDescription>";
                    //string actionDescriptionPublicPattern = @"\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?).*?([A-Z][a-z]+\s\d{1,2})([\s.,\/]?)\s(\d{4})([\s.,\/]?)";
                    #endregion

                    string mainContent = matchpubliclaws.Groups[2].Value;
                    string actionDescriptionPublicPattern = @".*\b(Approved By|Approved|Received By|Received)\b([\s.,\/]?).*?([A-Z][a-z]+\s\d{1,2})([\s.,\/]?)\s(\d{4})([\s.,\/]?).*";

                    Match match = Regex.Match(mainContent, actionDescriptionPublicPattern);

                    string fullapprovedvalue = match.Groups[0].Value;
                    string approvedByValue = match.Groups[1].Value;
                    string extraValue = match.Groups[2].Value;
                    string approvedDateValue = match.Groups[3].Value;
                    string extraValue2 = match.Groups[4].Value;
                    string approvedYearValue = match.Groups[5].Value;
                    string extraValue3 = match.Groups[6].Value;
                    string newSidenote = string.Empty;
                    string fulldate = $"{approvedDateValue}, {approvedYearValue}";

                    if (DateTime.TryParse(fulldate, out DateTime parsedDate))
                    {
                        mainContent = Regex.Replace(mainContent, dcDatePattern, match1 =>
                        {
                            //return $"<dc:date>{parsedDate:yyyy-MM-dd}</dc:date>";
                            return $"<dc:date>{parsedDate:MMMM dd, yyyy}</dc:date>";
                        });

                        newSidenote = $@"<sidenote><p class=""centered fontsize8""><approvedDate date=""{parsedDate:yyyy-MM-dd}"">{fulldate}</approvedDate>.</p></sidenote>";
                    }

                   


                    mainContent = mainContent.Replace(fullapprovedvalue, $"<action><actionDescription>{approvedByValue}, {approvedDateValue}, {approvedYearValue}</actionDescription></action>");

                    string resultpublic = mainContent.Replace("</officialTitle>", $"</officialTitle>\n{newSidenote}");

                    return $"<publicLaws>{resultpublic}</publicLaws>";

                });

                //recolution
                documentText = Regex.Replace(documentText, ResolutionsPattern, matchresolution =>
                {
                    string mainContent = matchresolution.Groups[1].Value;

                    string actionDescriptionPattern = @"<actionDescription>\b(Approved By|Approved|Received By|Received|Passed By|Passed|Agreed By|Agreed)\b([\s.,\/]?)(.*)<\/actionDescription>";
                    string newSidenote = string.Empty;


                    Match actionDescriptionMatch = Regex.Match(mainContent, actionDescriptionPattern);
                    string approvedDateValue = actionDescriptionMatch.Groups[3].Value;


                    if (DateTime.TryParse(approvedDateValue, out DateTime parsedDate))
                    {
                        mainContent = Regex.Replace(mainContent, dcDatePattern, match =>
                        {
                            //return $"<dc:date>{parsedDate:yyyy-MM-dd}</dc:date>";
                            return $"<dc:date>{parsedDate:MMMM dd, yyyy}</dc:date>";
                        });

                        newSidenote = $@"<sidenote><p class=""centered fontsize8"">{approvedDateValue.Trim()}</p></sidenote>";
                    }

                    string resultresolution = mainContent.Replace("</officialTitle>", $"</officialTitle>\n{newSidenote}");

                    return $"<concurrentResolutions>{resultresolution}</concurrentResolutions>";
                });


                result = documentText;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }
            return result;
        }

        private string InsertDocNumber(string documentText)
        {
            string result = string.Empty;
            try
            {
                //string chapPattern = @"\b(Chap\.\s*|CHAPTER\s*)(\d+\.&#x[0-9a-fA-F]+;|[\w\s&#;—.-]*)";
                //string chapPattern = @"<dc:title>\b(Chap\.\s*|CHAPTER\s*)(\d*)([\s.,\/]?).*";
                string chapPattern = @"<dc:title>\b(Chap\.\s*|CHAPTER\s*)(\d*)([\s.,\/]?)";
                string docnumPattern = @"<docNumber>([\s\S]*?)<\/docNumber>";

                string extraChar = "";


                Match pattern = Regex.Match(documentText, chapPattern);
                if (pattern.Success)
                {
                    string dcTitle = pattern.Groups[0].Value;
                    string chapvalue = pattern.Groups[1].Value;
                    string chapNumber = pattern.Groups[2].Value;
                    extraChar = pattern.Groups[3].Value;

                    documentText = documentText.Replace(dcTitle, $"<dc:title>{chapvalue} {chapNumber}{extraChar}");

                    Match docnumMatch = Regex.Match(documentText, docnumPattern);
                    string docnumFull = docnumMatch.Groups[0].Value;
                    string docnumValue = docnumMatch.Groups[1].Value;

                    if (docnumValue == "" )
                    {
                        documentText = documentText.Replace(docnumFull, $"<docNumber>{chapNumber}</docNumber>");
                    }
                }

                result = documentText;
            }
            catch (Exception ex)
            {

                ErrorMessage(ex);
            }
            return result;
        }

        private string InsertGenericTags(string documentText)
        {
            string result = documentText;
            try
            {
                /**
				 * Data that do not fall on these instructions and without element, please tag inside level.
				 * With Label:
				 * <level class="firstIndent1 fontsize10">
				 * <num value="1">1.—</num>
				 * <content>
				 * Value of <num> is the number of label.
				 * 
				 * Data without Label
				 * <level class="firstIndent1 fontsize10">
				 * <content>
				 */
                Match mainMatch = Regex.Match(documentText, @"<main>([\s\S]*?)<\/main>");
                if (!mainMatch.Success)
                {
                    return result;
                }

                // inner contents
                List<string> documentList = Regex.Split(mainMatch.Groups[1].Value, @"\r?\n").ToList();
                List<string> updatedDocumentList = documentList
                    // Filter out null, whitespace, or already formatted documents starting with "<"
                    .Where(document => !string.IsNullOrWhiteSpace(document))
                    .Select(document =>
                    {
                        string ignoredPattern = $@"^<\/?({string.Join("|", ignoredTags)})";
                        if (Regex.IsMatch(document, ignoredPattern))
                        {
                            return document; // Preserve already formatted documents
                        }

                        Match pattern = Regex.Match(document, @"(1)((?:\.\s?|\.?\s?&#x[0-9a-fA-F]+;))(\s?\w+)", RegexOptions.IgnoreCase);
                        return pattern.Success
                            ? $"<level class=\"firstIndent1 fontsize10\">" +
                              $"<num value=\"{pattern.Groups[1].Value.Trim()}\">{pattern.Groups[1].Value.Trim()}{pattern.Groups[2].Value.Trim()}</num>" +
                              $"<content>{pattern.Groups[3].Value.Trim()}</content>" +
                              $"</level>"
                            : $"<level class=\"firstIndent1 fontsize10\">\n<content>{document}</content>\n</level>";
                    })
                    .ToList();


                string updatedDocumentText = string.Join("\n", updatedDocumentList);

                result = Regex.Replace(documentText, "<main>[\\s\\S]*?<\\/main>", $"<main>\n{updatedDocumentText}\n</main>");
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }

            return result;
        }
    }
}
