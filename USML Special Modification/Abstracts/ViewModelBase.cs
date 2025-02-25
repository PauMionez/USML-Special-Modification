using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace USML_Special_Modification.Abstracts
{
    /// <summary>
    /// Contains the iNotifyPropertyChanged, Shared commands and properties, and Dialog functions
    /// </summary>
    class ViewModelBase : RaisePropertyChanged
    {
        #region Properties

        #region Version
        /// <summary>
        /// Set the application name
        /// </summary>
        public string ApplicationName { get { return "USLM Special Modification 2025"; } }

        /// <summary>
        /// Set the application version here.
        /// </summary>
        public string Title
        {
            get
            {
                return $"{ApplicationName} v1.2";
            }
        }

        #endregion

        //private ObservableCollection<TagModel> _TagCollection;

        //public ObservableCollection<TagModel> TagCollection
        //{
        //    get { return _TagCollection; }
        //    set { _TagCollection = value; OnPropertyChanged(); }
        //}

        #endregion

        public ViewModelBase()
        {
            // Complete tag model. This is confusing. Please be careful. Edit in a text editor like Sublime Text
            // As of 12/23/2024
            #region TAG LIST

//            TagCollection = new ObservableCollection<TagModel>
//{
//// Tag only
//new TagModel { ButtonContent = "backMatter",
//OpeningTag = "<backMatter>",
//Required = "Optional, repeatable",
//TagAs = "<backMatter></backMatter>",
//Instruction2 = "tag only",
//Example = "<backMatter></backMatter>",
//Description = "A backmatter" },

//new TagModel { ButtonContent = "collection",
//OpeningTag = "<collection>",
//Required = "Mandatory, one only",
//TagAs = "<collection></collection>",
//Instruction2 = "tag only",
//Example = "<collection></collection>",
//Description = "A collection of items or component" },

//new TagModel { ButtonContent = "component",
//OpeningTag = "<component>",
//ClosingTag = "</component>",
//Required = "Optional, repeatable",
//TagAs = "<component></component>",
//Instruction2 = "tag only",
//Example = "<component></component>",
//Description = "A container element for the content of the article" },

//new TagModel { ButtonContent = "concurrentResolutions",
//OpeningTag = "<concurrentResolutions>",
//Required = "Optional, repeatable",
//TagAs = "<concurrentResolutions>",
//Instruction2 = "tag only",
//Example = "<concurrentResolutions></concurrentResolutions>",
//Description = "A concurrent resolutions" },

//new TagModel { ButtonContent = "Empty table data",
//OpeningTag = "<td />",
//ClosingTag = "",
//Shortcut="Shift+X",
//Required = "Optional, repeatable",
//TagAs = "<td />",
//Instruction2 = "tag only",
//Example = "<td />",
//Description = "Empty element for data in table rows" },

//new TagModel { ButtonContent = "Group Item",
//OpeningTag = "<groupItem>",
//Shortcut = "Ctrl+G",
//Required = "Optional, repeatable",
//TagAs = "<groupItem></groupItem>",
//Instruction2 = "tag only",
//Example = "<groupItem></groupItem>",
//Description = "A group in the toc" },

//new TagModel { ButtonContent = "legislativeHistory",
//OpeningTag = "<legislativeHistory>",
//ClosingTag = "</legislativeHistory>",
//Required = "Optional, repeatable",
//TagAs = "<legislativeHistory></legislativeHistory>",
//Instruction2 = "tag only",
//Example = "<legislativeHistory></legislativeHistory>",
//Description = "A legislative history" },

//new TagModel { ButtonContent = "main",
//OpeningTag = "<main>",
//Required = "Mandatory, repeatable",
//TagAs = "<main></main>",
//Instruction2 = "tag only",
//Example = "<main></main>",
//Description = "The main part or body of the document or article" },

//new TagModel { ButtonContent = "meta",
//OpeningTag = "<meta>",
//ClosingTag = "</meta>",
//Required = "Optional, repeatable",
//TagAs = "<meta></meta>",
//Instruction2 = "tag only",
//Example = "<meta></meta>",
//Description = "The metadata of an article" },

//new TagModel { ButtonContent = "pLaw",
//OpeningTag = "<pLaw>",
//ClosingTag = "</pLaw>",
//Required = "Optional, repeatable",
//TagAs = "<pLaw></pLaw>",
//Instruction2 = "tag only",
//Example = "<pLaw></pLaw>",
//Description = "A public law" },

//new TagModel { ButtonContent = "popularNameIndex",
//OpeningTag = "<popularNameIndex>",
//Required = "Optional, repeatable",
//TagAs = "<popularNameIndex></popularNameIndex>",
//Instruction2 = "tag only",
//Example = "<popularNameIndex></popularNameIndex>",
//Description = "A Popular Name Index" },

//new TagModel { ButtonContent = "preface",
//OpeningTag = "<preface>",
//Required = "Optional, repeatable",
//TagAs = "<preface></preface>",
//Instruction2 = "tag only",
//Example = "<preface></preface>",
//Description = "A container element for preface or part of the frontmatter" },

//new TagModel { ButtonContent = "presidentialDocs",
//OpeningTag = "<presidentialDocs>",
//Required = "Optional, repeatable",
//TagAs = "<presidentialDocs></presidentialDocs>",
//Instruction2 = "tag only",
//Example = "<presidentialDocs></presidentialDocs>",
//Description = "A presidential Document" },

//new TagModel { ButtonContent = "privateLaws",
//OpeningTag = "<privateLaws>",
//Required = "Optional, repeatable",
//TagAs = "<privateLaws></privateLaws>",
//Instruction2 = "tag only",
//Example = "<privateLaws></privateLaws>",
//Description = "A private laws" },

//new TagModel { ButtonContent = "subjectIndex",
//OpeningTag = "<subjectIndex>",
//Required = "Optional, repeatable",
//TagAs = "<subjectIndex></subjectIndex>",
//Instruction2 = "tag only",
//Example = "<subjectIndex></subjectIndex>",
//Description = "A subject Index" },

//new TagModel { ButtonContent = "Table rows",
//OpeningTag = "<tr>",
//ClosingTag = "</tr>",
//Required = "Optional, repeatable",
//TagAs = "<tr>data</tr>",
//Instruction2 = "tag only",
//Example = "<tr>……………………</tr>",
//Description = "The element for rows" },

//new TagModel { ButtonContent = "Table",
//OpeningTag = "<table>",
//ClosingTag = "</table>",
//Required = "Optional, repeatable",
//TagAs = "<table>data</table>",
//Instruction2 = "tag only",
//Example = "<table></table>",
//Description = "The tag for table" },

//// With closing tags
//new TagModel { ButtonContent = "action",
//OpeningTag = "<action>",
//ClosingTag = "</action>",
//Shortcut = "Ctrl+J",
//Required = "Optional, repeatable",
//TagAs = "<action>\n<actionDescription>data</actionDescription>\n</action>",
//Example = "<action>Approved February 1, 2012.</action>",
//Description = "An action" },

//new TagModel { ButtonContent = "amendingAction",
//OpeningTag = "<amendingAction>",
//ClosingTag = "</amendingAction>",
//Required = "Optional, repeatable",
//Attributes = "type",
//TagAs = "<amendingAction>type|data</amendingAction>",
//Instruction2 = "value of type should be any of the following: A = Amend D = Delete or Strike I = Insert, or R = Redesignate",
//Example = "<amendingAction>D|striking</amendingAction>",
//Description = "An amending action" },

//new TagModel { ButtonContent = "approvedDate",
//OpeningTag = "<approvedDate>",
//ClosingTag = "</approvedDate>",
//Shortcut = "Ctrl+M",
//SubShortcut = "Q",
//Required = "Optional, repeatable",
//TagAs = "<approvedDate date=\"yyyy-MM-dd\">data</approvedDate>",
//Example = "<approvedDate>July 27, 1789</approvedDate>",
//Description = "The approved date" },

//new TagModel { ButtonContent = "Date",
//OpeningTag = "<date>",
//ClosingTag = "</date>",
//Shortcut = "Ctrl+M",
//SubShortcut = "W",
//Required = "Optional, repeatable",
//TagAs = "<date date=\"yyyy-MM-dd\">data</date>",
//Example = "<date>July 27, 1789</date>",
//Description = "The date" },

//new TagModel { ButtonContent = "article",
//OpeningTag = "<article>",
//ClosingTag = "</article>",
//Shortcut="Shift+R",
//SubShortcut="R",
//Required = "Optional, repeatable",
//Attributes = "num",
//TagAs = "<article>data</article>",
//Instruction2 = "Data may contains another tags",
//Example = "<article>Art 1.| <content>This Act may be cited as the airport</content></article>",
//Description = "Article" },

//new TagModel { ButtonContent = "article",
//OpeningTag = "<article>",
//ClosingTag = "</article>",
//Shortcut="Shift+R",
//SubShortcut="C",
//TagAs = "<article class=\"centered\">data</article>",
//Description = "ArticleCentered" },

//new TagModel { ButtonContent = "article",
//OpeningTag = "<article>",
//ClosingTag = "</article>",
//Shortcut="Shift+R",
//SubShortcut="I",
//TagAs = "<article class=\"indent0 fontsize10\">data</article>",
//Description = "ArticleIndent0" },


//new TagModel { ButtonContent = "authority",
//OpeningTag = "<authority>",
//ClosingTag = "</authority>",
//Required = "Optional, repeatable",
//TagAs = "<authority>data</authority>",
//Example = "<authority>BY AUTHORITY OF CONGRESS. THE <b>Public Statutes at Large</b> OF THE UNITED STATES OF AMERICA</authority>",
//Description = "An authority statement" },

//new TagModel { ButtonContent = "Bold text",
//OpeningTag = "<b>",
//ClosingTag = "</b>",
//Shortcut="Ctrl+B",
//Required = "Optional, repeatable",
//TagAs = "<b>data</b>",
//Example = "<b>Public> Statutes at Large</b>",
//Description = "Bold text. " },

//new TagModel { ButtonContent = "Bold text",
//OpeningTag = "<b xmlns=\"http://schemas.gpo.gov/xml/uslm\">",
//ClosingTag = "</b>",
//Shortcut="Ctrl+B",
//SubShortcut="X",
//    Required = "Optional, repeatable",
//TagAs = "<b xmlns=\"http://schemas.gpo.gov/xml/uslm\">data</b>",
//Example = "<b>Public> Statutes at Large</b>",
//Description = "BoldAttrib" },

//new TagModel { ButtonContent = "Caption",
//OpeningTag = "<caption>",
//ClosingTag = "</caption>",
//Shortcut="Alt+0",
//Required = "Optional, repeatable",
//TagAs = "<caption>data</caption>",
//Instruction2 = "",
//Example = "<caption>……………………</caption>",
//Description = "Table Caption" },

//new TagModel {
//    ButtonContent = "ChapeauFirstIndent",
//    Shortcut = "Shift+P",
//    SubShortcut= "F",
//    OpeningTag = "<chapeau>",
//    TagAs = "<chapeau class=\"firstIndent1 fontsize10\">data</chapeau>",
//    Description = "ChapeauFirstIndent"
//},

//new TagModel {
//    ButtonContent = "ChapeauIndent0",
//    Shortcut = "Shift+P",
//    SubShortcut= "I",
//    OpeningTag = "<chapeau>",
//    TagAs = "<chapeau class=\"indent0 fontsize10\">data</chapeau>",
//    Description = "ChapeauIndent0"
//},

//new TagModel {
//    ButtonContent = "ChapeauInline",
//    Shortcut = "Shift+P",
//    SubShortcut= "L",
//    OpeningTag = "<chapeau>",
//    TagAs = "<chapeau class=\"inline\">data</chapeau>",
//    Description = "ChapeauInline"
//},

//new TagModel {
//    ButtonContent = "chapeau",
//    Shortcut = "Shift+P",
//    SubShortcut= "P",
//    OpeningTag = "<chapeau>",
//    ClosingTag = "</chapeau>",
//    TagAs = "<chapeau>data</chapeau>",
//    Description = "chapeau"
//},

//new TagModel { ButtonContent = "chapter",
//OpeningTag = "<chapter>",
//ClosingTag = "</chapter>",
//Shortcut = "Alt+H",
//Required = "Optional, repeatable",
//Attributes = "num heading",
//TagAs = "<chapter>data</chapter>",
//Description = "A chapter" },

//new TagModel { ButtonContent = "citableAs",
//OpeningTag = "<citableAs>",
//ClosingTag = "</citableAs>",
//Shortcut = "Alt+A",
//Required = "Optional, repeatable",
//TagAs = "<citableAs>data</citableAs>",
//Example = @"<citableAs><inline class=""smallCaps"">Chapter</inline> II</citableAs>",
//Description = "Citable as information" },

//new TagModel { ButtonContent = "Concat_Attribute",
//OpeningTag = "F2",
//Shortcut = "F2",
//TagAs = "|",
//Description = "Concat '|' shortcut" },

//new TagModel { ButtonContent = "congress",
//OpeningTag = "<congress>",
//Required = "Mandatory, one only",
//TagAs = "<congress>data</congress>",
//Example = "<congress>112",
//Description = "The volume congress" },

//new TagModel { ButtonContent = "congress",
//OpeningTag = "<congress>",
//ClosingTag = "</congress>",
//Required = "Optional, repeatable",
//TagAs = "<congress>data</congress>",
//Example = "<congress>112</congress>",
//Description = "Congress" },

//new TagModel {
//    ButtonContent = "ContentInline",
//    Shortcut = "Alt+C",
//    SubShortcut= "L",
//    OpeningTag = "<content>",
//    TagAs = "<content class=\"inline\">data</content>",
//    Description = "ContentInline"
//},

//new TagModel {
//    ButtonContent = "content",
//    Shortcut = "Alt+C",
//    SubShortcut= "C",
//    OpeningTag = "<content>",
//    ClosingTag = "</content>",
//    TagAs = "<content>data</content>",
//    Description = "content"
//},


//new TagModel { ButtonContent = "continuation",
//OpeningTag = "<continuation>",
//ClosingTag = "</continuation>",
//Shortcut = "Alt+U",
//Required = "Optional, repeatable",
//TagAs = "<continuation class=\"indent0 firstIndent0 fontsize10\">data</continuation>",
//Example = "<continuation>Not later than June 15, 2013, the Commission shall submit to the Committees</continuation>",
//Description = "A continuation" },

//new TagModel { ButtonContent = "continuation-change",
//OpeningTag = "<continuation>",
//ClosingTag = "</continuation>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+8",
//Attributes = "indent0",
//TagAs = "<continuation class=\"indent[X] firstIndent0 fontsize10\">data</continuation>",
//Example = "<continuation>Not later than June 15, 2013, the Commission shall submit to the Committees</continuation>",
//Description = "A continuation" },

//new TagModel { ButtonContent = "coverTitle",
//OpeningTag = "<coverTitle>",
//Required = "Mandatory, repeatable",
//TagAs = "<coverTitle>data</coverTitle>",
//Example = "<coverTitle>UNITED STATES STATUTES AT LARGE</coverTitle>",
//Description = "The title in the cover" },

//new TagModel { ButtonContent = "docNumber",
//OpeningTag = "<docNumber>",
//ClosingTag = "</docNumber>",
//Shortcut = "Ctrl+D",
//Required = "Optional, repeatable",
//TagAs = "<docNumber>data</docNumber>",
//Example = "<docNumber>14</docNumber>",
//Description = "The document number" },

//new TagModel { ButtonContent = "docPart",
//OpeningTag = "<docPart>",
//ClosingTag = "</docPart>",
//Required = "Optional, repeatable",
//TagAs = "<docPart>data</docPart>",
//Example = "<docPart>1</docPart>",
//Description = "A document part" },

//new TagModel { ButtonContent = "docTitle",
//OpeningTag = "<docTitle>",
//ClosingTag = "</docTitle>",
//Shortcut = "Alt+T",
//Required = "Optional, repeatable",
//TagAs = "<docTitle>data</docTitle>",
//Example = "<docTitle>An Act</docTitle>",
//Description = "A document title" },

//new TagModel { ButtonContent = "Elipses",
//OpeningTag = "<el>",
//ClosingTag = "</el>",
//Required = "Optional, repeatable",
//TagAs = "<el>data</el>",
//Example = "<el>...</el>",
//Description = "An elipses" },

//new TagModel { ButtonContent = "empty page ",
//OpeningTag = "<page />",
//Required = "Optional, repeatable",
//TagAs = "<page />",
//Instruction2 = "empty tag",
//Example = "<page />",
//Description = "An empty page" },

//new TagModel { ButtonContent = "enactingFormula",
//OpeningTag = "<enactingFormula>",
//ClosingTag = "</enactingFormula>",
//Shortcut = "Shift+E",
//Required = "Optional, repeatable",
//TagAs = "<enactingFormula>data</enactingFormula>",
//Example = "<enactingFormula>Be it enacted by the Senate</enactingFormula>",
//Description = "An enacting formula" },

//new TagModel { ButtonContent = "enrolledDateline",
//OpeningTag = "<enrolledDateline>",
//ClosingTag = "</enrolledDateline>",
//Shortcut = "Alt+E",
//Required = "Optional, repeatable",
//TagAs = "<enrolledDateline>data</enrolledDateline>",
//Example = "<enrolledDateline><i>Passed at the first session, which was begun and held at the City of New York on Wednesday, March 9, 1946</i></enrolledDateline>",
//Description = "The enrolled date line" },

//new TagModel { ButtonContent = "explanationNote",
//OpeningTag = "<explanationNote>",
//ClosingTag = "</explanationNote>",
//Shortcut = "Alt+X",
//Required = "Optional, repeatable",
//TagAs = "<explanationNote>data</explanationNote>",
//Example = @"<xn>""The United States Statutes at Large shall be legal evidence of laws""</explanationNote>",
//Description = "An explanation note" },

//new TagModel { ButtonContent = "Figure",
//OpeningTag = "<figure>",
//ClosingTag = "</figure>",
//Required = "Optional, repeatable",
//Attributes = "width height",
//TagAs = "<figure>data</figure>",
//Example = "<figure>318|397</referenceItem>",
//Description = "Figure" },

//new TagModel { ButtonContent = "Granule Type",
//OpeningTag = "<granuleType>",
//Required = "Optional, repeatable",
//Attributes = "grtype, pagerange",
//TagAs = "<granuleType>grtype|pagerange</granuleType>",
//Instruction2 = "This will be the first tag in the text file. Attributes will be coded manually by the operator. Once text file is created, please output this tag at the first line of the text file.",
//Example = "<granuleType>fm|i-iii</granuleType>",
//Description = "Granule Type" },

//new TagModel { ButtonContent = "Header",
//OpeningTag = "<header>",
//ClosingTag = "</header>",
//Required = "Optional, repeatable",
//TagAs = "<header>data</header>",
//Example = "<header>A header</header>",
//Description = "A heading row in a <layout> structure. " },

//new TagModel { ButtonContent = "Heading Item",
//OpeningTag = "<headingItem>",
//ClosingTag = "</headingItem>",
//Shortcut="Shift+H",
//Required = "Optional, repeatable",
//TagAs = "<headingItem>data</headingItem>",
//Example = "<headingItem>Page</headingItem>",
//Description = "The heading item in the groupItem" },

//new TagModel { ButtonContent = "item",
//OpeningTag = "<item>",
//ClosingTag = "</item>",
//Shortcut = "Alt+I",
//Required = "Optional, repeatable",
//Attributes = "num",
//TagAs = "<item class=\"indent5 fontsize10\">data</item>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<item>(a)|a Foreign Service Officer</item>",
//Description = "An item" },

//new TagModel { ButtonContent = "item-change",
//OpeningTag = "<item>",
//ClosingTag = "</item>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+5",
//Attributes = "indent5",
//TagAs = "<item class=\"indent[X] fontsize10\">data</item>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<item>(a)|a Foreign Service Officer</item>",
//Description = "An item" },

//new TagModel { ButtonContent = "item-inline",
//OpeningTag = "<item>",
//ClosingTag = "</item>",
//Required = "Optional, repeatable",
//Shortcut = "Alt+5",
//TagAs = "<item class=\"inline\">data</item>",
//Instruction2 = "Just output the data inside the main tag.",
//Example = "<item>a Foreign Service Officer</item>",
//Description = "An item" },

//new TagModel { ButtonContent = "subitem",
//OpeningTag = "<subitem>",
//ClosingTag = "</subitem>",
//Required = "Optional, repeatable",
//TagAs = "<subitem class=\"indent4 fontsize10\">data</subitem>",
//Example = "<subitem>Foreign Service Officer</subitem>",
//Description = "SubItem" },

//new TagModel { ButtonContent = "subitem-change",
//OpeningTag = "<subitem>",
//ClosingTag = "</subitem>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+6",
//Attributes = "indent4",
//TagAs = "<subitem class=\"indent[X] fontsize10\">data</subitem>",
//Example = "<subitem>Foreign Service Officer</subitem>",
//Description = "SubItem" },


//new TagModel { ButtonContent = "subitem-inline",
//OpeningTag = "<subitem>",
//ClosingTag = "</subitem>",
//Required = "Optional, repeatable",
//Shortcut = "Alt+6",
//TagAs = "<subitem class=\"inline\">data</subitem>",
//Example = "<subitem>Foreign Service Officer</subitem>",
//Description = "SubItem" },

//new TagModel { ButtonContent = "subsubitem",
//OpeningTag = "<subsubitem>",
//ClosingTag = "</subsubitem>",
//Required = "Optional, repeatable",
//TagAs = "<subsubitem class=\"indent5 fontsize10\">data</subsubitem>",
//Example = "<subsubitem>Foreign Service Officer</subsubitem>",
//Description = "SubSubItem" },

//new TagModel { ButtonContent = "subsubitem-change",
//OpeningTag = "<subsubitem>",
//ClosingTag = "</subsubitem>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+7",
//Attributes = "indent5",
//TagAs = "<subsubitem class=\"indent[X] fontsize10\">data</subsubitem>",
//Example = "<subsubitem>Foreign Service Officer</subsubitem>",
//Description = "SubSubItem" },


//new TagModel { ButtonContent = "subsubitem-inline",
//OpeningTag = "<subsubitem>",
//ClosingTag = "</subsubitem>",
//Required = "Optional, repeatable",
//Shortcut = "Alt+7",
//TagAs = "<subsubitem class=\"inline\">data</subsubitem>",
//Example = "<subsubitem>Foreign Service Officer</subsubitem>",
//Description = "SubSubItem" },


//new TagModel { ButtonContent = "Label in group item",
//OpeningTag = "<label>",
//ClosingTag = "</label>",
//Shortcut = "Ctrl+L",
//Required = "Optional, repeatable",
//TagAs = "<label>data</label>",
//Example = "<label><i>Baggage and tools of trade.</i></label>",
//Description = "The label of the groupItem" },

//new TagModel { ButtonContent = "organizationNote",
//OpeningTag = "<organizationNote>",
//ClosingTag = "</organizationNote>",
//Required = "Optional, repeatable",
//TagAs = "<organizationNote>data</organizationNote>",
//Example = "<organizationNote>BOSTON: CHARLES C. LITTLE AND JAMES BROWN. 1845. </organizationNote>",
//Description = "An organization note" },


//new TagModel { ButtonContent = "paragraph",
//OpeningTag = "<paragraph>",
//ClosingTag = "</paragraph>",
//Shortcut = "Alt+P",
//Required = "Optional, repeatable",
//Attributes = "num",
//TagAs = "<paragraph class=\"indent1 fontsize10\">data</paragraph>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<paragraph>1.|If such captain or captains be under the immediate command of a commander in chief</paragraph>",
//Description = "A paragraph" },

//new TagModel { ButtonContent = "paragraph-change",
//OpeningTag = "<paragraph>",
//ClosingTag = "</paragraph>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+1",
//Attributes="indent1",
//TagAs = "<paragraph class=\"indent[X] fontsize10\">data</paragraph>",
//Example = "<paragraph>If such captain or captains be under the immediate command of a commander in chief</paragraph>",
//Description = "A paragraph" },

//new TagModel { ButtonContent = "paragraph-inline",
//OpeningTag = "<paragraph>",
//ClosingTag = "</paragraph>",
//Required = "Optional, repeatable",
//Shortcut = "Alt+1",
//TagAs = "<paragraph class=\"inline\">data</paragraph>",
//Example = "<paragraph class=\"inline\">If such captain or captains be under the immediate command of a commander in chief</paragraph>",
//Description = "A paragraph" },

//new TagModel { ButtonContent = "part",
//OpeningTag = "<part>",
//ClosingTag = "</part>",
//Shortcut = "Shift+V",
//Required = "Optional, repeatable",
//Attributes = "num heading",
//TagAs = "<part>data</part>",
//Instruction2 = "attributes will be marked manually by the operator. Just output the data inside the main tag. Note that <division> may contains different tags inside.",
//Example = "<part>PART III|TECHNICAL AMENDMENTS <section>Sec. 2|AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</section> <subSection>Sec. 2|AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</subSection> </part>",
//Description = "A part" },

//new TagModel { ButtonContent = "preamble",
//OpeningTag = "<preamble>",
//ClosingTag = "</preamble>",
//Shortcut = "Ctrl+W",
//Required = "Optional, repeatable",
//TagAs = "<preamble>data</preamble>",
//Example = "<preamble>Whereas, on July 20, 2012, an armed gunman opened fire Whereas many individuals at the theater selflessly sought to aid Whereas the Aurora Police Department and the Aurora Fire</preamble>",
//Description = "A preamble" },

//new TagModel { ButtonContent = "proviso",
//OpeningTag = "<proviso>",
//ClosingTag = "</proviso>",
//Required = "Optional, repeatable",
//TagAs = "<proviso>data</proviso>",
//Example = "<proviso><i>Provided always</i>, That where the amount of duties shall exceed fifty dollars</proviso>",
//Description = "Proviso" },

//new TagModel { ButtonContent = "publicLaws",
//OpeningTag = "<publicLaws>",
//Required = "Optional, repeatable",
//TagAs = "<publicLaws></publicLaws>",
//Example = "<publicLaws></publicLaws>",
//Description = "A container element for public laws" },

//new TagModel { ButtonContent = "quotedContent",
//OpeningTag = "<quotedContent>",
//ClosingTag = "</quotedContent>",
//Shortcut = "Ctrl+Q",
//Required = "Optional, repeatable",
//TagAs = "<quotedContent>data</quotedContent>",
//Example = @"<quotedContent><i>December</i> 16, 
//1843 ""I have examined a prospectus of an edition of the Laws"" ?There are few persons, 
//I imagine""</quotedContent>""",
//Description = "A quoted content" },

//new TagModel { ButtonContent = "quotedText",
//OpeningTag = "<quotedText>",
//ClosingTag = "</quotedText>",
//Shortcut = "Alt+Q",
//Required = "Optional, repeatable",
//TagAs = "<quotedText>data</quotedText>",
//Example = "<quotedText>An act to establish the Judicial courts of the United States</quotedText>",
//Description = "A quoted text" },

//new TagModel { ButtonContent = "recital",
//OpeningTag = "<recital>",
//ClosingTag = "</recital>",
//Shortcut = "Shift+Z",
//Required = "Optional, repeatable",
//Instruction2 = "to be handled in output",
//TagAs = "<recital class=\"indent1 firstIndent-1 fontsize10\">data</recital>",
//Description = "A recital" },

//new TagModel { ButtonContent = "recital-change",
//OpeningTag = "<recital>",
//ClosingTag = "</recital>",
//Required = "Optional, repeatable",
//Attributes = "indent1",
//TagAs = "<recital class=\"indent[X] firstIndent[Z] fontsize10\">data</recital>",
//Instruction2 = "to be handled in output",
//Description = "A recital" },

//new TagModel { ButtonContent = "Reference Item",
//OpeningTag = "<referenceItem>",
//ClosingTag = "</referenceItem>",
//Shortcut = "Shift+I",
//Required = "Optional, repeatable",
//Attributes = "char align target",
//TagAs = "<referenceItem>data</referenceItem>",
//Instruction2 = "input for the attribute align should be l or r only.",
//Example = "<referenceItem>An act to establish the Treasury Department.|65</referenceItem>",
//Description = "The individual items in the toc/list" },

//new TagModel { ButtonContent = "resolvingClause-change",
//OpeningTag = "<resolvingClause>",
//ClosingTag = "</resolvingClause>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+0",
//Attributes = "indent0",
//TagAs = "<resolvingClause class=\"indent[X] firstIndent0 fontsize10\">data</resolvingClause>",
//Example = "<resolvingClause>Resolved</resolvingClause>",
//Description = "A resolving clause" },

//new TagModel { ButtonContent = "Row",
//OpeningTag = "<row>",
//ClosingTag = "</row>",
//Shortcut="Shift+W",
//Required = "Optional, repeatable",
//Attributes = "no. of columns",
//TagAs = "<row>data</row>",
//Example = "<row>3|Sealed and delivered Ten per centum ad On other enumerated articles</row>",
//Description = "A normal row in a <layout> structure. In general, this level can be omitted. " },

//new TagModel { ButtonContent = "section",
//OpeningTag = "<section>",
//ClosingTag = "</section>",
//Shortcut = "Alt+S",
//Required = "Optional, repeatable",
//TagAs = "<section>data</section>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<section>Sec. 2|AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</section>",
//Description = "A section of an article" },

//new TagModel { ButtonContent = "section-inline",
//OpeningTag = "<section>",
//ClosingTag = "</section>",
//Required = "Optional, repeatable",
//TagAs = "<section class=\"inline\">data</section>",
//Instruction2 = "Just output the data inside the main tag.",
//Example = "<section>AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</section>",
//Description = "A section of an article" },



//new TagModel { ButtonContent = "session",
//OpeningTag = "<session>",
//Required = "Mandatory, one only",
//TagAs = "<session>data</session>",
//Example = "<session>2</session>",
//Description = "The volume session" },

//new TagModel { ButtonContent = "sidenote (float)",
//OpeningTag = "<sidenote>",
//ClosingTag = "</sidenote>",
//Required = "Optional, repeatable",
//TagAs = "<sidenote>data</sidenote>",
//Example = "<sidenote>Jan. 31, 2012</sidenote>",
//Description = "A sidenote" },

//new TagModel { ButtonContent = "sidenote",
//OpeningTag = "<sidenote>",
//ClosingTag = "</sidenote>",
//Shortcut = "Alt+Z",
//Required = "Optional, repeatable",
//TagAs = "<sidenote>data</sidenote>",
//Example = "<sidenote>Jan. 31, 2012</sidenote>",
//Description = "A sidenote" },

//new TagModel { ButtonContent = "subclause",
//OpeningTag = "<subclause>",
//ClosingTag = "</subclause>",
//Shortcut = "Alt+B",
//Required = "Optional, repeatable",
//Attributes = "num",
//TagAs = "<subclause class=\"indent4 fontsize10\">data</subclause>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<subclause>(1)|the amount that otherwise would be apportioned",
//Description = "A subclause" },

//new TagModel { ButtonContent = "subclause-change",
//OpeningTag = "<subclause>",
//ClosingTag = "</subclause>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+4",
//Attributes = "indent4",
//TagAs = "<subclause class=\"indent[X] fontsize10\">data</subclause>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<subclause>(1)|the amount that otherwise would be apportioned",
//Description = "A subclause" },


//new TagModel { ButtonContent = "subclause-inline",
//OpeningTag = "<subclause>",
//ClosingTag = "</subclause>",
//Required = "Optional, repeatable",
//Shortcut = "Alt+4",
//TagAs = "<subclause class=\"inline\">data</subclause>",
//Instruction2 = "Just output the data inside the main tag.",
//Example = "<subclause>the amount that otherwise would be apportioned",
//Description = "A subclause" },


//new TagModel { ButtonContent = "Subheading",
//OpeningTag = "<subheading>",
//ClosingTag = "</subheading>",
//Required = "Optional, repeatable",
//TagAs = "<subheading>data</subheading>",
//Example = "<subheading>Acts of the First Congress of the United States.</subheading>",
//Description = "The subheading" },

//new TagModel { ButtonContent = "subparagraph",
//OpeningTag = "<subparagraph>",
//ClosingTag = "</subparagraph>",
//Shortcut = "Shift+B",
//Required = "Optional, repeatable",
//TagAs = "<subparagraph class=\"indent2 fontsize10\">data</subparagraph>",
//Example = "<subparagraph>On bohea tea, per pound, eight cents.</subparagraph>",
//Description = "A sub paragraph" },

//new TagModel { ButtonContent = "subparagraph-change",
//OpeningTag = "<subparagraph>",
//ClosingTag = "</subparagraph>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+2",
//Attributes = "indent2",
//TagAs = "<subparagraph class=\"indent[X] fontsize10\">data</subparagraph>",
//Example = "<subparagraph>On bohea tea, per pound, eight cents.</subparagraph>",
//Description = "A sub paragraph" },


//new TagModel { ButtonContent = "subparagraph-inline",
//OpeningTag = "<subparagraph>",
//ClosingTag = "</subparagraph>",
//Required = "Optional, repeatable",
//Shortcut = "Alt+2",
//SubShortcut="2",
//TagAs = "<subparagraph class=\"inline\">data</subparagraph>",
//Example = "<subparagraph>On bohea tea, per pound, eight cents.</subparagraph>",
//Description = "A sub paragraph" },

//new TagModel { ButtonContent = "Subscripted text",
//OpeningTag = "<sub>",
//ClosingTag = "</sub>",
//Required = "Optional, repeatable",
//TagAs = "<sub>data</sub>",
//Example = "<sub>280</sub>",
//Description = "Subscripted text. " },

//new TagModel { ButtonContent = "subsection",
//OpeningTag = "<subsection>",
//ClosingTag = "</subsection>",
//Shortcut = "Shift+S",
//Required = "Optional, repeatable",
//Attributes = "num heading",
//TagAs = "<subsection class=\"indent0 fontsize10\">data</subsection>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<subSection>Sec. 2|AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</subSection>",
//Description = "A sub section" },

//new TagModel { ButtonContent = "subsection-change",
//OpeningTag = "<subsection>",
//ClosingTag = "</subsection>",
//Required = "Optional, repeatable",
//Shortcut = "Ctrl+9",
//Attributes = "indent0",
//TagAs = "<subsection class=\"indent[X] fontsize10\">data</subsection>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<subSection>Sec. 2|AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</subSection>",
//Description = "A sub section" },

//new TagModel { ButtonContent = "subsection-inline",
//OpeningTag = "<subsection>",
//ClosingTag = "</subsection>",
//Shortcut = "Alt+9",
//Required = "Optional, repeatable",
//TagAs = "<subsection class=\"inline\">data</subsection>",
//Example = "<subsection>AMENDMENTS TO TITLE 49|Except as otherwise expressly provided, whenever ?..</subSection>",
//Description = "A sub section" },


//new TagModel { ButtonContent = "subtitle",
//OpeningTag = "<subtitle>",
//ClosingTag = "</subtitle>",
//Shortcut = "Alt+V",
//Required = "Optional, repeatable",
//Attributes = "num heading",
//TagAs = "<subtitle>data</subtitle>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<subtitle>Subtitle A|Funding of FAA Programs|data</subtitle>",
//Description = "A subtitle" },

//new TagModel { ButtonContent = "Superscripted text",
//OpeningTag = "<sup>",
//ClosingTag = "</sup>",
//Required = "Optional, repeatable",
//TagAs = "<sup>data</sup>",
//Example = "<sup>160</sup>",
//Description = "Superscripted text. " },

//new TagModel { ButtonContent = "Table body",
//OpeningTag = "<tbody>",
//ClosingTag = "</tbody>",
//Required = "Optional, and only one",
//Attributes = "no. of rows",
//TagAs = "<tbody>data</tbody>",
//Instruction2 = "",
//Example = "<tbody>5……………………</tbody>",
//Description = "The body of the table" },

//new TagModel { ButtonContent = "Table data",
//OpeningTag = "<td>",
//ClosingTag = "</td>",
//Shortcut="Shift+T",
//Required = "Mandatory, repeatable",
//TagAs = "<td>data</td>",
//Instruction2 = "",
//Example = "<td>$0.001</td>",
//Description = "The data in table rows" },

//new TagModel { ButtonContent = "Table footnote",
//OpeningTag = "<tfoot>",
//ClosingTag = "</tfoot>",
//Required = "Optional, repeatable",
//Attributes = "colspanstyletext-indentfont size",
//TagAs = "<tfoot>data</tfoot>",
//Instruction2 = "",
//Example = "<tfoot>6|j|1|8|1|Notwithstanding the basic pay rates specified in this table.",
//Description = "The footnote in table" },

//new TagModel { ButtonContent = "Table Header",
//OpeningTag = "<thead>",
//ClosingTag = "</thead>",
//Required = "Optional, and only one",
//Attributes = "no. of columns",
//TagAs = "<thead>data</thead>",
//Instruction2 = "",
//Example = "<thead>4|Pay Grades2 or lessOver 2Over 3</thead>",
//Description = "The table header" },

//new TagModel { ButtonContent = "text",
//OpeningTag = "<text>",
//ClosingTag = "</text>",
//Required = "Optional, repeatable",
//TagAs = "<text>data</text>",
//Example = "<text>?????</text>",
//Description = "Text" },

//new TagModel { ButtonContent = "title",
//OpeningTag = "<title>",
//ClosingTag = "</title>",
//Shortcut = "",
//Required = "Optional, repeatable",
//Attributes = "num heading",
//TagAs = "<title>data</title>",
//Instruction2 = "attributes will be coded manually by the operator. Just output the data inside the main tag.",
//Example = "<title>TITLE I|AVIATION INSURANCE|data</title>",
//Description = "A title" },

//new TagModel { ButtonContent = "volume",
//OpeningTag = "<volume>",
//Required = "Mandatory, one only",
//TagAs = "<volume>data</volume>",
//Example = "<volume>126</volume>",
//Description = "The volume number" },

//new TagModel { ButtonContent = "break",
//Shortcut = "Ctrl+R",
//OpeningTag = "<br />",
//TagAs = "<br />",
//Example = "<br />",
//Description = "Break" },

//new TagModel { ButtonContent = "AppropIntermediate",
//Shortcut = "Alt+O",
//SubShortcut= "I",
//OpeningTag = "<appropriations level=\"intermediate\"><heading>",
//TagAs = "<appropriations level=\"intermediate\"><heading>data</heading></appropriations>",
//Description = "AppropIntermediate" },

//new TagModel { ButtonContent = "AppropMajor",
//Shortcut = "Alt+O",
//SubShortcut= "M",
//OpeningTag = "<appropriations level=\"major\"><heading>",
//TagAs = "<appropriations level=\"major\"><heading>data</heading></appropriations>",
//Description = "AppropMajor" },

//new TagModel { ButtonContent = "AppropSmall",
//Shortcut = "Alt+O",
//SubShortcut= "S",
//OpeningTag = "<appropriations level=\"small\"><heading>",
//TagAs = "<appropriations level=\"small\"><heading>data</heading></appropriations>",
//Description = "AppropSmall" },

//new TagModel { ButtonContent = "BlockCentered",
//Shortcut = "Alt+G",
//SubShortcut= "C",
//OpeningTag = "<block>",
//TagAs = "<block class=\"centered\">data</block>",
//Description = "BlockCentered" },

//new TagModel {
//    ButtonContent = "BlockAgreement",
//    Shortcut = "Alt+G",
//    SubShortcut= "G",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"agreement\" xml:lang=\"en\">data</block>",
//    Description = "BlockAgreement"
//},

//new TagModel {
//    ButtonContent = "BlockAnnex",
//    Shortcut = "Alt+G",
//    SubShortcut= "A",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"annex\" xml:lang=\"en\">data</block>",
//    Description = "BlockAnnex"
//},

//new TagModel {
//    ButtonContent = "BlockAppendix",
//    Shortcut = "Alt+G",
//    SubShortcut= "P",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"appendix\" xml:lang=\"en\">data</block>",
//    Description = "BlockAppendix"
//},

//new TagModel {
//    ButtonContent = "BlockConvention",
//    Shortcut = "Alt+G",
//    SubShortcut= "V",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"convention\" xml:lang=\"en\">data</block>",
//    Description = "BlockConvention"
//},

//new TagModel {
//    ButtonContent = "BlockDeclaration",
//    Shortcut = "Alt+G",
//    SubShortcut= "D",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"declaration\" xml:lang=\"en\">data</block>",
//    Description = "BlockDeclaration"
//},

//new TagModel {
//    ButtonContent = "BlockLeftSideLanguage",
//    Shortcut = "Alt+G",
//    SubShortcut= "S",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"leftSide\" xml:lang=\"en\">data</block>",
//    Description = "BlockLeftSideLanguage"
//},

//new TagModel {
//    ButtonContent = "BlockLetter",
//    Shortcut = "Alt+G",
//    SubShortcut= "L",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"letter\" xml:lang=\"en\">data</block>",
//    Description = "BlockLetter"
//},

//new TagModel {
//    ButtonContent = "BlockLetters",
//    Shortcut = "Alt+G",
//    SubShortcut= "T",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"letters\" xml:lang=\"en\">data</block>",
//    Description = "BlockLetters"
//},

//new TagModel {
//    ButtonContent = "BlockProtocol",
//    Shortcut = "Alt+G",
//    SubShortcut= "O",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"protocol\" xml:lang=\"en\">data</block>",
//    Description = "BlockProtocol"
//},

//new TagModel {
//    ButtonContent = "BlockRelatedPapers",
//    Shortcut = "Alt+G",
//    SubShortcut= "R",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"relatedPapers\" xml:lang=\"en\">data</block>",
//    Description = "BlockRelatedPapers"
//},

//new TagModel {
//    ButtonContent = "BlockTreatyContent",
//    Shortcut = "Alt+G",
//    SubShortcut= "T",
//    OpeningTag = "<block>",
//    TagAs = "<block role=\"treatyContent\" xml:lang=\"en\">data</block>",
//    Description = "BlockTreatyContent"
//},

//new TagModel {
//    ButtonContent = "BlockLang",
//    Shortcut = "Alt+G",
//    SubShortcut= "E",
//    OpeningTag = "<block>",
//    TagAs = "<block xml:lang=\"en\">data</block>",
//    Description = "BlockLang"
//},

//new TagModel {
//    ButtonContent = "Block",
//    Shortcut = "Alt+G",
//    SubShortcut= "B",
//    OpeningTag = "<block>",
//    TagAs = "<block>data</block>",
//    Description = "Block"
//},


//new TagModel {
//    ButtonContent = "ClauseCentered",
//    Shortcut = "Alt+K",
//    SubShortcut= "C",
//    OpeningTag = "<clause>",
//    TagAs = "<clause class=\"centered\">data</clause>",
//    Description = "ClauseCentered"
//},

//new TagModel {
//    ButtonContent = "ClauseFirstIndent",
//    Shortcut = "Alt+K",
//    SubShortcut= "F",
//    OpeningTag = "<clause>",
//    TagAs = "<clause class=\"firstIndent1 fontsize10\">data</clause>",
//    Description = "ClauseFirstIndent"
//},

//new TagModel {
//    ButtonContent = "ClauseIndent0",
//    Shortcut = "Alt+K",
//    SubShortcut= "I",
//    OpeningTag = "<clause>",
//    TagAs = "<clause class=\"indent0 fontsize10\">data</clause>",
//    Description = "ClauseIndent0"
//},

//new TagModel {
//    ButtonContent = "clause",
//    Shortcut = "Alt+K",
//    SubShortcut= "K",
//    OpeningTag = "<clause>",
//    TagAs = "<clause class=\"indent3 fontsize10\">data</clause>",
//    Description = "clause"
//},

//new TagModel {
//    ButtonContent = "ClauseIndentUp",
//    Shortcut = "Alt+K",
//    SubShortcut= "U",
//    OpeningTag = "<clause>",
//    TagAs = "<clause class=\"indentUp1 fontsize10\">data</clause>",
//    Description = "ClauseIndentUp"
//},
//new TagModel {
//    ButtonContent = "ColumnDefinition",
//    Shortcut = "Alt+W",
//    SubShortcut= "D",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"definition\">data</column>",
//    Description = "ColumnDefinition"
//},

//new TagModel {
//    ButtonContent = "ColumnLeftsideItalic",
//    Shortcut = "Alt+W",
//    SubShortcut= "Z",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"leftSide\" class=\"italic\">data</column>",
//    Description = "ColumnLeftsideItalic"
//},

//new TagModel {
//    ButtonContent = "ColumnLeftsideSmallcaps",
//    Shortcut = "Alt+W",
//    SubShortcut= "C",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"leftSide\" class=\"smallCaps\">data</column>",
//    Description = "ColumnLeftsideSmallcaps"
//},

//new TagModel {
//    ButtonContent = "ColumnLeftsideLang",
//    Shortcut = "Alt+W",
//    SubShortcut= "X",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"leftSide\" xml:lang=\"en\">data</column>",
//    Description = "ColumnLeftsideLang"
//},

//new TagModel {
//    ButtonContent = "ColumnMiddleSmallcaps",
//    Shortcut = "Alt+W",
//    SubShortcut= "V",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"middle\" class=\"smallCaps\">data</column>",
//    Description = "ColumnMiddleSmallcaps"
//},

//new TagModel {
//    ButtonContent = "ColumnRightsideItalic",
//    Shortcut = "Alt+W",
//    SubShortcut= "B",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"rightSide\" class=\"italic\">data</column>",
//    Description = "ColumnRightsideItalic"
//},

//new TagModel {
//    ButtonContent = "ColumnRightsideSmallcaps",
//    Shortcut = "Alt+W",
//    SubShortcut= "M",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"rightSide\" class=\"smallCaps\">data</column>",
//    Description = "ColumnRightsideSmallcaps"
//},

//new TagModel {
//    ButtonContent = "ColumnRightsideLng",
//    Shortcut = "Alt+W",
//    SubShortcut= "N",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"rightSide\" xml:lang=\"en\">data</column>",
//    Description = "ColumnRightsideLng"
//},

//new TagModel {
//    ButtonContent = "ColumnTerm",
//    Shortcut = "Alt+W",
//    SubShortcut= "T",
//    OpeningTag = "<column>",
//    TagAs = "<column role=\"term\">data</column>",
//    Description = "ColumnTerm"
//},

//new TagModel {
//    ButtonContent = "Column",
//    Shortcut = "Alt+W",
//    SubShortcut= "W",
//    OpeningTag = "<column>",
//    TagAs = "<column>data</column>",
//    Description = "Column"
//},

//new TagModel {
//    ButtonContent = "CoverTextCenteredBold",
//    Shortcut = "Shift+J",
//    SubShortcut= "B",
//    OpeningTag = "<coverText class=\"centered bold\">",
//    TagAs = "<coverText class=\"centered bold\">data</coverText>",
//    Description = "CoverTextCenteredBold"
//},

//new TagModel {
//    ButtonContent = "CoverTextCentered",
//    Shortcut = "Shift+J",
//    SubShortcut= "C",
//    OpeningTag = "<coverText class=\"centered\">",
//    TagAs = "<coverText class=\"centered\">data</coverText>",
//    Description = "CoverTextCentered"
//},

//new TagModel {
//    ButtonContent = "coverText",
//    Shortcut = "Shift+J",
//    SubShortcut= "J",
//    OpeningTag = "<coverText>",
//    ClosingTag = "</coverText>",
//    TagAs = "<coverText>data</coverText>",
//    Description = "coverText"
//},

//new TagModel {
//    ButtonContent = "CoverTitleCentered",
//    Shortcut = "Shift+K",
//    SubShortcut= "C",
//    OpeningTag = "<coverTitle class=\"centered\">",
//    TagAs = "<coverTitle class=\"centered\">data</coverTitle>",
//    Description = "CoverTitleCentered"
//},

//new TagModel {
//    ButtonContent = "CoverTitleFontSize",
//    Shortcut = "Shift+K",
//    SubShortcut= "F",
//    OpeningTag = "<coverTitle style=\"font-size:larger;\">",
//    TagAs = "<coverTitle style=\"font-size:larger;\">data</coverTitle>",
//    Description = "CoverTitleFontSize"
//},

//new TagModel {
//    ButtonContent = "coverTitle",
//    Shortcut = "Shift+K",
//    SubShortcut= "K",
//    OpeningTag = "<coverTitle>",
//    TagAs = "<coverTitle>data</coverTitle>",
//    Description = "coverTitle"
//},

//new TagModel {
//    ButtonContent = "dc:date",
//    Shortcut = "Alt+4",
//    SubShortcut= "",
//    OpeningTag = "<dc:date>",
//    TagAs = "<dc:date>data</dc:date>",
//    Description = "dc:date"
//},

//new TagModel {
//    ButtonContent = "dc:title",
//    Shortcut = "Shift+F",
//    SubShortcut= "",
//    OpeningTag = "<dc:title>",
//    TagAs = "<dc:title>data</dc:title>",
//    Description = "dc:title"
//},


//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "X",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>[CHAPTER </dc:type>",
//    Description = "DcTypeChapter2"
//},

//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "P",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>A Proclamation</dc:type>",
//    Description = "DcTypeProclamation"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "A",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Agreement</dc:type>",
//    Description = "DcTypeAgreement"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "C",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Chapter</dc:type>",
//    Description = "DcTypeChapter1"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "O",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Convention</dc:type>",
//    Description = "DcTypeConvention"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "H",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>House Concurrent Resolution</dc:type>",
//    Description = "DcTypeHouseConRes"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "M",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Memorandum</dc:type>",
//    Description = "DcTypeMemo"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "T",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Protocol</dc:type>",
//    Description = "DcTypeProtocol"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "B",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Public Law</dc:type>",
//    Description = "DcTypePubliclaw"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "V",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Private Law</dc:type>",
//    Description = "DcTypePrivatelaw"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "R",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Resolution</dc:type>",
//    Description = "DcTypeResolution"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "S",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Senate Concurrent Resolution</dc:type>",
//    Description = "DcTypeSenateConRes"
//},
//new TagModel {
//    ButtonContent = "dc:type",
//    Shortcut = "Ctrl+T",
//    SubShortcut= "D",
//    OpeningTag = "<dc:type>",
//    TagAs = "<dc:type>Treaty</dc:type>",
//    Description = "DctypeTreaty"
//},

//new TagModel {
//    ButtonContent = "DivisionIndent",
//    Shortcut = "Alt+D",
//    SubShortcut= "F",
//    OpeningTag = "<division>",
//    ClosingTag = "",
//    TagAs = "<division class=\"firstIndent0 fontsize10\">data</division>"
//},
//new TagModel {
//    ButtonContent = "division",
//    Shortcut = "Alt+D",
//    SubShortcut= "D",
//    OpeningTag = "<division>",
//    ClosingTag = "</division>",
//    TagAs = "<division>data</division>"
//},
//new TagModel {
//    ButtonContent = "FillInUnderscore",
//    Shortcut = "Alt+F",
//    SubShortcut= "U",
//    OpeningTag = "<fillIn>",
//    ClosingTag = "",
//    TagAs = "<fillIn class=\"underline\">_</fillIn>"
//},
//new TagModel {
//    ButtonContent = "FillIn005F",
//    Shortcut = "Alt+F",
//    SubShortcut= "B",
//    OpeningTag = "<fillIn>",
//    ClosingTag = "",
//    TagAs = "<fillIn style=\"font-family:monoscape\">&#x005F; &#x005F; &#x005F;</fillIn>"
//},
//new TagModel {
//    ButtonContent = "FillIndots",
//    Shortcut = "Alt+F",
//    SubShortcut= "O",
//    OpeningTag = "<fillIn>",
//    ClosingTag = "",
//    TagAs = "<fillIn style=\"font-family:monospace\">...</fillIn>"
//},
//new TagModel {
//    ButtonContent = "FillInDashes",
//    Shortcut = "Alt+F",
//    SubShortcut= "D",
//    OpeningTag = "<fillIn>",
//    ClosingTag = "",
//    TagAs = "<fillIn style=\"font-family:monospace\">---</fillIn>"
//},
//new TagModel {
//    ButtonContent = "FillInBlank",
//    Shortcut = "Alt+F",
//    SubShortcut= "B",
//    OpeningTag = "<fillIn>",
//    ClosingTag = "",
//    TagAs = "<fillIn style=\"font-family:monospace\">data</fillIn>"
//},
//new TagModel {
//    ButtonContent = "fillIn",
//    Shortcut = "Alt+F",
//    SubShortcut= "T",
//    OpeningTag = "<fillIn>",
//    ClosingTag = "</fillIn>",
//    TagAs = "<fillIn>|data</fillIn>"
//},

//new TagModel {
//    ButtonContent = "FootnoteID",
//    Shortcut = "Shift+N",
//    SubShortcut = "I",
//    OpeningTag = "<footnote>",
//    ClosingTag = "",
//    TagAs = "<footnote id=\"fn000040\">data</footnote>"
//},
//new TagModel {
//    ButtonContent = "Footnote",
//    Shortcut = "Shift+N",
//    SubShortcut = "X",
//    OpeningTag = "<footnote>",
//    ClosingTag = "",
//    TagAs = "<footnote xmlns=\"http://schemas.gpo.gov/xml/uslm\" id=\"fntable1112001\">data</footnote>"
//},
//new TagModel {
//    ButtonContent = "footnote",
//    Shortcut = "Shift+N",
//    SubShortcut = "N",
//    OpeningTag = "<footnote>",
//    ClosingTag = "<footnote>",
//    TagAs = "<footnote>data<footnote>"
//},
//new TagModel {
//    ButtonContent = "HeadingBoldCentered",
//    Shortcut = "Shift+G",
//    SubShortcut = "B",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"bold centered\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingCentered",
//    Shortcut = "Shift+G",
//    SubShortcut = "C",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"centered\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingIndent",
//    Shortcut = "Shift+G",
//    SubShortcut = "F",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"firstIndent-1 fontsize10\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingInline",
//    Shortcut = "Shift+G",
//    SubShortcut = "L",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"inline\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingItalicCentered",
//    Shortcut = "Shift+G",
//    SubShortcut = "I",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"italic centered\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingItalic",
//    Shortcut = "Shift+G",
//    SubShortcut = "T",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"italic\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingSmallcapsCentered",
//    Shortcut = "Shift+G",
//    SubShortcut = "D",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"smallCaps centered\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingSmallcaps",
//    Shortcut = "Shift+G",
//    SubShortcut = "S",
//    OpeningTag = "<heading>",
//    ClosingTag = "",
//    TagAs = "<heading class=\"smallCaps\">data</heading>"
//},
//new TagModel {
//    ButtonContent = "Heading",
//    Shortcut = "Shift+G",
//    SubShortcut = "H",
//    OpeningTag = "<heading>",
//    ClosingTag = "</heading>",
//    TagAs = "<heading>data</heading>"
//},
//new TagModel {
//    ButtonContent = "HeadingTextCentered",
//    Shortcut = "Ctrl+H",
//    SubShortcut = "C",
//    OpeningTag = "<headingText>",
//    ClosingTag = "",
//    TagAs = "<headingText class=\"centered\">data</headingText>"
//},
//new TagModel {
//    ButtonContent = "headingText",
//    Shortcut = "Ctrl+H",
//    SubShortcut = "H",
//    OpeningTag = "<headingText>",
//    ClosingTag = "</headingText>",
//    TagAs = "<headingText>data</headingText>"
//},
//new TagModel {
//    ButtonContent = "ItalicAttrib",
//    Shortcut = "Ctrl+I",
//    SubShortcut = "X",
//    OpeningTag = "<i xmlns=\"http://schemas.gpo.gov/xml/uslm\">",
//    ClosingTag = "",
//    TagAs = "<i xmlns=\"http://schemas.gpo.gov/xml/uslm\">data</i>"
//},
//new TagModel {
//    ButtonContent = "Italic text",
//    Shortcut = "Ctrl+I",
//    SubShortcut = "I",
//    OpeningTag = "<i>",
//    ClosingTag = "</i>",
//    TagAs = "<i>data</i>"
//},
//new TagModel {
//    ButtonContent = "InlineSmallcaps",
//    Shortcut = "Alt+Y",
//    SubShortcut = "S",
//    OpeningTag = "<inline class=\"smallCaps\">",
//    ClosingTag = "",
//    TagAs = "<inline class=\"smallCaps\">data</inline>"
//},
//new TagModel {
//    ButtonContent = "InlineUnderline",
//    Shortcut = "Alt+Y",
//    SubShortcut = "U",
//    OpeningTag = "<inline class=\"underline\">",
//    ClosingTag = "",
//    TagAs = "<inline class=\"underline\">data</inline>"
//},
//new TagModel {
//    ButtonContent = "LayoutFourcolumn",
//    Shortcut = "Alt+2",
//    SubShortcut = "F",
//    OpeningTag = "<layout>",
//    ClosingTag = "",
//    TagAs = "<layout role=\"fourColumn\">data</layout>"
//},
//new TagModel {
//    ButtonContent = "LayoutInterleaved",
//    Shortcut = "Alt+2",
//    SubShortcut = "I",
//    OpeningTag = "<layout>",
//    ClosingTag = "",
//    TagAs = "<layout role=\"interleavedPages\">data</layout>"
//},
//new TagModel {
//    ButtonContent = "LayoutSidebySide2columns",
//    Shortcut = "Alt+2",
//    SubShortcut = "D",
//    OpeningTag = "<layout>",
//    ClosingTag = "",
//    TagAs = "<layout role=\"sideBySide\" class=\"twoColumn\">data</layout>"
//},
//new TagModel {
//    ButtonContent = "LayoutSidebyside",
//    Shortcut = "Alt+2",
//    SubShortcut = "S",
//    OpeningTag = "<layout>",
//    ClosingTag = "",
//    TagAs = "<layout role=\"sideBySide\">data</layout>"
//},
//new TagModel {
//    ButtonContent = "LayoutTermlist",
//    Shortcut = "Alt+2",
//    SubShortcut = "L",
//    OpeningTag = "<layout>",
//    ClosingTag = "",
//    TagAs = "<layout role=\"termList\">data</layout>"
//},
//new TagModel {
//    ButtonContent = "LayoutThreecolumn",
//    Shortcut = "Alt+2",
//    SubShortcut = "T",
//    OpeningTag = "<layout>",
//    ClosingTag = "",
//    TagAs = "<layout role=\"threeColumn\">data</layout>"
//},
//new TagModel {
//    ButtonContent = "layout",
//    Shortcut = "Alt+2",
//    SubShortcut = "O",
//    OpeningTag = "<layout>",
//    ClosingTag = "</layout>",
//    TagAs = "<layout>data</layout>"
//},
//new TagModel {
//    ButtonContent = "LevelIndentDepth",
//    Shortcut = "Shift+L",
//    SubShortcut = "D",
//    OpeningTag = "<level>",
//    ClosingTag = "",
//    TagAs = "<level class=\"firstIndent0 fontsize10 depth0\">data</level>"
//},
//new TagModel {
//    ButtonContent = "LevelFirstIndent",
//    Shortcut = "Shift+L",
//    SubShortcut = "1",
//    OpeningTag = "<level>",
//    ClosingTag = "",
//    TagAs = "<level class=\"firstIndent0 fontsize10\">data</level>"
//},
//new TagModel {
//    ButtonContent = "LevelFirstIndent",
//    Shortcut = "Shift+L",
//    SubShortcut = "F",
//    OpeningTag = "<level>",
//    ClosingTag = "",
//    TagAs = "<level class=\"firstIndent1 fontsize10\">data</level>"
//},
//new TagModel {
//    ButtonContent = "LevelIndentUp",
//    Shortcut = "Shift+L",
//    SubShortcut = "U",
//    OpeningTag = "<level>",
//    ClosingTag = "",
//    TagAs = "<level class=\"indentUp1 firstIndent-1 fontsize10\">data</level>"
//},
//new TagModel {
//    ButtonContent = "LevelInline",
//    Shortcut = "Shift+L",
//    SubShortcut = "I",
//    OpeningTag = "<level>",
//    ClosingTag = "",
//    TagAs = "<level class=\"inline\">data</level>"
//},
//new TagModel {
//    ButtonContent = "level",
//    Shortcut = "Shift+L",
//    SubShortcut = "L",
//    OpeningTag = "<level>",
//    ClosingTag = "</level>",
//    TagAs = "<level>data</level>"
//},
//new TagModel {
//    ButtonContent = "ListContentCenteredDepth",
//    Shortcut = "Alt+L",
//    SubShortcut = "C",
//    OpeningTag = "<listContent>",
//    ClosingTag = "</listContent>",
//    TagAs = "<listContent class=\"centered fontsize10 depth0\">data</listContent>"
//},
//new TagModel {
//    ButtonContent = "ListContentFirstIndentDepth",
//    Shortcut = "Alt+L",
//    SubShortcut = "F",
//    OpeningTag = "<listContent>",
//    ClosingTag = "</listContent>",
//    TagAs = "<listContent class=\"firstIndent1 fontsize10 depth0\">data</listContent>"
//},
//new TagModel {
//    ButtonContent = "ListContentIndentDepth",
//    Shortcut = "Alt+L",
//    SubShortcut = "A",
//    OpeningTag = "<listContent>",
//    ClosingTag = "</listContent>",
//    TagAs = "<listContent class=\"indent0 fontsize10 depth0\">data</listContent>"
//},
//new TagModel {
//    ButtonContent = "ListContentIndent0",
//    Shortcut = "Alt+L",
//    SubShortcut = "I",
//    OpeningTag = "<listContent>",
//    ClosingTag = "</listContent>",
//    TagAs = "<listContent class=\"indent0 fontsize10\">data</listContent>"
//},
//new TagModel {
//    ButtonContent = "ListContentSmallcapsCentered",
//    Shortcut = "Alt+L",
//    SubShortcut = "S",
//    OpeningTag = "<listContent>",
//    ClosingTag = "</listContent>",
//    TagAs = "<listContent class=\"smallCaps centered fontsize10 depth0\">data</listContent>"
//},
//new TagModel {
//    ButtonContent = "ListContent",
//    Shortcut = "Alt+L",
//    SubShortcut = "L",
//    OpeningTag = "<listContent>",
//    ClosingTag = "</listContent>",
//    TagAs = "<listContent>data</listContent>"
//},
//new TagModel {
//    ButtonContent = "ListItemCentered",
//    Shortcut = "Alt+M",
//    SubShortcut = "C",
//    OpeningTag = "<listItem>",
//    ClosingTag = "</listItem>",
//    TagAs = "<listItem class=\"centered\">data</listItem>"
//},
//new TagModel {
//    ButtonContent = "ListItemFirstIndent",
//    Shortcut = "Alt+M",
//    SubShortcut = "F",
//    OpeningTag = "<listItem>",
//    ClosingTag = "</listItem>",
//    TagAs = "<listItem class=\"firstIndent1 fontsize10\">data</listItem>"
//},
//new TagModel {
//    ButtonContent = "ListItemIndent0Depth",
//    Shortcut = "Alt+M",
//    SubShortcut = "D",
//    OpeningTag = "<listItem>",
//    ClosingTag = "</listItem>",
//    TagAs = "<listItem class=\"indent0 fontsize10 depth0\">data</listItem>"
//},
//new TagModel {
//    ButtonContent = "ListItemIndent0",
//    Shortcut = "Alt+M",
//    SubShortcut = "I",
//    OpeningTag = "<listItem>",
//    ClosingTag = "</listItem>",
//    TagAs = "<listItem class=\"indent0 fontsize10\">data</listItem>"
//},
//new TagModel {
//    ButtonContent = "ListItemIndentUp",
//    Shortcut = "Alt+M",
//    SubShortcut = "U",
//    OpeningTag = "<listItem>",
//    ClosingTag = "</listItem>",
//    TagAs = "<listItem class=\"indentUp2 firstIndent-1 fontsize10\">data</listItem>"
//},
//new TagModel {
//    ButtonContent = "ListItem",
//    Shortcut = "Alt+M",
//    SubShortcut = "M",
//    OpeningTag = "<listItem>",
//    ClosingTag = "</listItem>",
//    TagAs = "<listItem>data</listItem>"
//},
//new TagModel {
//    ButtonContent = "longTitle",
//    Shortcut = "Shift+O",
//    OpeningTag = "<longTitle>",
//    ClosingTag = "</longTitle>",
//    TagAs = "<longTitle>data</longTitle>"
//},
//new TagModel {
//    ButtonContent = "MoStretchy{",
//    Shortcut = "Shift+M",
//    SubShortcut = "L",
//    OpeningTag = "<mo>",
//    ClosingTag = "</mo>",
//    TagAs = "<mo xmlns=\"http://www.w3.org/1998/Math/MathML\" stretchy=\"true\">{</mo>"
//},
//new TagModel {
//    ButtonContent = "MoStretchy}",
//    Shortcut = "Shift+M",
//    SubShortcut = "R",
//    OpeningTag = "<mo>",
//    ClosingTag = "</mo>",
//    TagAs = "<mo xmlns=\"http://www.w3.org/1998/Math/MathML\" stretchy=\"true\">}</mo>"
//},
//new TagModel {
//    ButtonContent = "mathml",
//    Shortcut = "Shift+M",
//    SubShortcut = "M",
//    OpeningTag = "<mo>",
//    ClosingTag = "</mo>",
//    TagAs = "<mo></mo>"
//},
//new TagModel {
//    ButtonContent = "Mo",
//    Shortcut = "Shift+M",
//    SubShortcut = "O",
//    OpeningTag = "<mo>",
//    ClosingTag = "</mo>",
//    TagAs = "<mo>data</mo>"
//},
//new TagModel {
//    ButtonContent = "NotationBoldSmallcaps",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "B",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"bold smallCaps\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationCenteredItalic",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "X",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"centered italic\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationCenteredSmallcaps",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "Z",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"centered smallCaps\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationCentered",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "C",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"centered\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationIndent",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "F",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"firstIndent0 fontsize10\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationItalic",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "T",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"italic\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationleftAlign",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "L",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"leftAlign\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationRightAlign",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "R",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"rightAlign\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationSmallcapsLeftAlign",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "A",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"smallCaps leftAlign\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationSmallcapsRighttAlign",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "D",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"smallCaps rightAlign\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationSmallcaps",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "S",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation class=\"smallCaps\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationLanguageSmallcaps",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "W",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation xml:lang=\"en\" class=\"smallCaps\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "NotationLanguage",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "E",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation xml:lang=\"en\">data</notation>"
//},
//new TagModel {
//    ButtonContent = "notation",
//    Shortcut = "Ctrl+K",
//    SubShortcut = "K",
//    OpeningTag = "<notation>",
//    ClosingTag = "</notation>",
//    TagAs = "<notation>data</notation>"
//},
//new TagModel {
//    ButtonContent = "NoteCentered",
//    Shortcut = "Alt+N",
//    SubShortcut = "C",
//    OpeningTag = "<note class=\"centered\">",
//    ClosingTag = "</note>",
//    TagAs = "<note class=\"centered\">data</note>"
//},
//new TagModel {
//    ButtonContent = "NoteClass",
//    Shortcut = "Alt+N",
//    SubShortcut = "F",
//    OpeningTag = "<note class=\"firstIndent1 fontsize10\">",
//    ClosingTag = "</note>",
//    TagAs = "<note class=\"firstIndent1 fontsize10\">data</note>"
//},
//new TagModel {
//    ButtonContent = "NoteCenterEven",
//    Shortcut = "Alt+N",
//    SubShortcut = "V",
//    OpeningTag = "<note role=\"centerRunningHead\" class=\"evenPage\">",
//    ClosingTag = "</note>",
//    TagAs = "<note role=\"centerRunningHead\" class=\"evenPage\">data</note>"
//},
//new TagModel {
//    ButtonContent = "NoteCenterOdd",
//    Shortcut = "Alt+N",
//    SubShortcut = "B",
//    OpeningTag = "<note role=\"centerRunningHead\" class=\"oddPage\">",
//    ClosingTag = "</note>",
//    TagAs = "<note role=\"centerRunningHead\" class=\"oddPage\">data</note>"
//},
//new TagModel {
//    ButtonContent = "NoteRole",
//    Shortcut = "Alt+N",
//    SubShortcut = "P",
//    OpeningTag = "<note role=\"propertyStatement\">",
//    ClosingTag = "</note>",
//    TagAs = "<note role=\"propertyStatement\">data</note>"
//},
//new TagModel {
//    ButtonContent = "NoteTopic",
//    Shortcut = "Alt+N",
//    SubShortcut = "M",
//    OpeningTag = "<note topic=\"miscellaneous\">",
//    ClosingTag = "</note>",
//    TagAs = "<note topic=\"miscellaneous\">data</note>"
//},
//new TagModel {
//    ButtonContent = "NoteEndnote",
//    Shortcut = "Alt+N",
//    SubShortcut = "E",
//    OpeningTag = "<note type=\"endnote\" class=\"firstIndent1 fontsize8\">",
//    ClosingTag = "</note>",
//    TagAs = "<note type=\"endnote\" class=\"firstIndent1 fontsize8\">data</note>"
//},
//new TagModel {
//    ButtonContent = "note",
//    Shortcut = "Alt+N",
//    SubShortcut = "N",
//    OpeningTag = "<note>",
//    ClosingTag = "</note>",
//    TagAs = "<note>data</note>"
//},
//new TagModel {
//    ButtonContent = "NotesTopic",
//    Shortcut = "Shift+J",
//    SubShortcut = "V",
//    OpeningTag = "<notes topic=\"vetoOverride\">",
//    ClosingTag = "</notes>",
//    TagAs = "<notes topic=\"vetoOverride\">data</notes>"
//},
//new TagModel {
//    ButtonContent = "NotesEndnote",
//    Shortcut = "Shift+J",
//    SubShortcut = "E",
//    OpeningTag = "<notes type=\"endnote\">",
//    ClosingTag = "</notes>",
//    TagAs = "<notes type=\"endnote\">data</notes>"
//},
//new TagModel {
//    ButtonContent = "Notes",
//    Shortcut = "Shift+J",
//    SubShortcut = "J",
//    OpeningTag = "<notes>",
//    ClosingTag = "</notes>",
//    TagAs = "<notes>data</notes>"
//},
//new TagModel {
//    ButtonContent = "NumValue",
//    Shortcut = "Ctrl+N",
//    OpeningTag = "<num>",
//    ClosingTag = "</num>",
//    TagAs = "<num value=\" \">data</num>"
//},
//new TagModel {
//    ButtonContent = "OfficialTitleCenteredScp",
//    Shortcut = "Ctrl+O",
//    SubShortcut = "X",
//    OpeningTag = "<officialTitle>",
//    ClosingTag = "</officialTitle>",
//    TagAs = "<officialTitle class=\"centered smallCaps\">data</officialTitle>"
//},
//new TagModel {
//    ButtonContent = "OfficialTitleCentered",
//    Shortcut = "Ctrl+O",
//    SubShortcut = "C",
//    OpeningTag = "<officialTitle>",
//    ClosingTag = "</officialTitle>",
//    TagAs = "<officialTitle class=\"centered\">data</officialTitle>"
//},
//new TagModel {
//    ButtonContent = "OfficialTitleSmallC",
//    Shortcut = "Ctrl+O",
//    SubShortcut = "S",
//    OpeningTag = "<officialTitle>",
//    ClosingTag = "</officialTitle>",
//    TagAs = "<officialTitle class=\"smallCaps\">data</officialTitle>"
//},
//new TagModel {
//    ButtonContent = "officialTitle",
//    Shortcut = "Ctrl+O",
//    SubShortcut = "O",
//    OpeningTag = "<officialTitle>",
//    ClosingTag = "</officialTitle>",
//    TagAs = "<officialTitle>data</officialTitle>"
//},
//new TagModel {
//    ButtonContent = "ParaCenteredFontsize",
//    Shortcut = "Shift+Q",
//    SubShortcut = "G",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"centered fontsize8\">data</p>"
//},
//new TagModel {
//    ButtonContent = "ParaCenteredFontLarger",
//    Shortcut = "Shift+Q",
//    SubShortcut = "L",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"centered\" style=\"font-size:larger;\">data</p>"
//},
//new TagModel {
//    ButtonContent = "ParaCenteredFontNormal",
//    Shortcut = "Shift+Q",
//    SubShortcut = "N",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"centered\" style=\"font-size:normal;\">data</p>"
//},
//new TagModel {
//    ButtonContent = "ParaCenteredFontSmaller",
//    Shortcut = "Shift+Q",
//    SubShortcut = "X",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"centered\" style=\"font-size:smaller;\">data</p>"
//},
//new TagModel {
//    ButtonContent = "ParaCentered",
//    Shortcut = "Shift+Q",
//    SubShortcut = "C",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"centered\">data</p>"
//},
//new TagModel {
//    ButtonContent = "Para First Indent",
//    Shortcut = "Shift+Q",
//    SubShortcut = "F",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"firstIndent1 fontsize8\">data</p>"
//},
//new TagModel {
//    ButtonContent = "ParaIndent0",
//    Shortcut = "Shift+Q",
//    SubShortcut = "I",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"indent0 fontsize10\">data</p>"
//},new TagModel {
//    ButtonContent = "Para First Indent",
//    Shortcut = "Shift+Q",
//    SubShortcut = "T",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"indent1 fontsize10\">data</p>"
//},
//new TagModel {
//    ButtonContent = "ParaSmallcaps",
//    Shortcut = "Shift+Q",
//    SubShortcut = "S",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p class=\"smallCaps\">data</p>"
//},
//new TagModel {
//    ButtonContent = "Normal Para",
//    Shortcut = "Shift+Q",
//    SubShortcut = "Q",
//    OpeningTag = "<p>",
//    ClosingTag = "</p>",
//    TagAs = "<p>data</p>"
//},
//new TagModel {
//    ButtonContent = "PageIdentifier",
//    Shortcut = "Alt+J",
//    SubShortcut = "I",
//    OpeningTag = "<page identifier=\"/us/stat//\">",
//    ClosingTag = "</page>",
//    TagAs = "<page identifier=\"/us/stat//\">data</page>"
//},
//new TagModel {
//    ButtonContent = "page",
//    Shortcut = "Alt+J",
//    SubShortcut = "J",
//    OpeningTag = "<page>",
//    ClosingTag = "</page>",
//    TagAs = "<page>data</page>"
//},
//new TagModel {
//    ButtonContent = "ParagraphFirstIndent",
//    Shortcut = "Alt+P",
//    SubShortcut = "F",
//    OpeningTag = "<paragraph>",
//    ClosingTag = "</paragraph>",
//    TagAs = "<paragraph class=\"firstIndent1 fontsize10\">data</paragraph>"
//},
//new TagModel {
//    ButtonContent = "ParagraphIndent0",
//    Shortcut = "Alt+P",
//    SubShortcut = "I",
//    OpeningTag = "<paragraph>",
//    ClosingTag = "</paragraph>",
//    TagAs = "<paragraph class=\"indent0 fontsize10\">data</paragraph>"
//},
//new TagModel {
//    ButtonContent = "paragraph",
//    Shortcut = "Alt+P",
//    SubShortcut = "P",
//    OpeningTag = "<paragraph>",
//    ClosingTag = "</paragraph>",
//    TagAs = "<paragraph class=\"indent1 fontsize10\">data</paragraph>"
//},
//new TagModel {
//    ButtonContent = "ParagraphIndentUp",
//    Shortcut = "Alt+P",
//    SubShortcut = "U",
//    OpeningTag = "<paragraph>",
//    ClosingTag = "</paragraph>",
//    TagAs = "<paragraph class=\"indentUp1 fontsize10\">data</paragraph>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocAgreement",
//    Shortcut = "Alt+8",
//    SubShortcut = "A",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"agreement\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocConvention",
//    Shortcut = "Alt+8",
//    SubShortcut = "C",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"convention\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocDeclaration",
//    Shortcut = "Alt+8",
//    SubShortcut = "D",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"declaration\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocMemorandum",
//    Shortcut = "Alt+8",
//    SubShortcut = "M",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"memorandum\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocProclamation",
//    Shortcut = "Alt+8",
//    SubShortcut = "P",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"proclamation\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocProtocol",
//    Shortcut = "Alt+8",
//    SubShortcut = "O",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"protocol\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocTreaty",
//    Shortcut = "Alt+8",
//    SubShortcut = "T",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc role=\"treaty\">data</presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "presidentialDoc",
//    Shortcut = "Alt+8",
//    SubShortcut = "R",
//    OpeningTag = "<presidentialDoc>",
//    ClosingTag = "</presidentialDoc>",
//    TagAs = "<presidentialDoc></presidentialDoc>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocsAgreement",
//    Shortcut = "Alt+9",
//    SubShortcut = "A",
//    OpeningTag = "<presidentialDocs>",
//    ClosingTag = "</presidentialDocs>",
//    TagAs = "<presidentialDocs role=\"agreement\">data</presidentialDocs>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocsProclamation",
//    Shortcut = "Alt+9",
//    SubShortcut = "P",
//    OpeningTag = "<presidentialDocs>",
//    ClosingTag = "</presidentialDocs>",
//    TagAs = "<presidentialDocs role=\"proclamations\">data</presidentialDocs>"
//},
//new TagModel {
//    ButtonContent = "PresidentialDocsTreaties",
//    Shortcut = "Alt+9",
//    SubShortcut = "T",
//    OpeningTag = "<presidentialDocs>",
//    ClosingTag = "</presidentialDocs>",
//    TagAs = "<presidentialDocs role=\"treaties\">data</presidentialDocs>"
//},
//new TagModel {
//    ButtonContent = "presidentialDocs",
//    Shortcut = "Alt+9",
//    SubShortcut = "R",
//    OpeningTag = "<presidentialDocs>",
//    ClosingTag = "</presidentialDocs>",
//    TagAs = "<presidentialDocs></presidentialDocs>"
//},
//new TagModel {
//    ButtonContent = "recital",
//    Shortcut = "Shift+Z",
//    SubShortcut = "I",
//    OpeningTag = "<recital>",
//    ClosingTag = "</recital>",
//    TagAs = "<recital class=\"indent1 firstIndent-1 fontsize10\">data</recital>"
//},
//new TagModel {
//    ButtonContent = "RecitalIndentUp",
//    Shortcut = "Shift+Z",
//    SubShortcut = "U",
//    OpeningTag = "<recital>",
//    ClosingTag = "</recital>",
//    TagAs = "<recital class=\"indentUp0 firstIndent1 fontsize10\">data</recital>"
//},
//new TagModel {
//    ButtonContent = "RefBillHr",
//    Shortcut = "Alt+R",
//    SubShortcut = "H",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/bill//hr/\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefCFR",
//    Shortcut = "Alt+R",
//    SubShortcut = "C",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/cfr//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefDCC",
//    Shortcut = "Alt+R",
//    SubShortcut = "D",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/dcc//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefFR",
//    Shortcut = "Alt+R",
//    SubShortcut = "F",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/fr//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefIRC",
//    Shortcut = "Alt+R",
//    SubShortcut = "I",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/irc//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefPL",
//    Shortcut = "Alt+R",
//    SubShortcut = "P",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/pl//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefRS",
//    Shortcut = "Alt+R",
//    SubShortcut = "R",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/rs//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefSTAT",
//    Shortcut = "Alt+R",
//    SubShortcut = "S",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/stat//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefUSC",
//    Shortcut = "Alt+R",
//    SubShortcut = "U",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/usc//\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "RefBillHjres",
//    Shortcut = "Alt+R",
//    SubShortcut = "B",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref href=\"/us/bill//hjres/\">data</ref>"
//},
//new TagModel {
//    ButtonContent = "ref",
//    Shortcut = "Alt+R",
//    SubShortcut = "O",
//    OpeningTag = "<ref>",
//    ClosingTag = "</ref>",
//    TagAs = "<ref>data</ref>"
//},
//new TagModel {
//    ButtonContent = "resolvingClause",
//    Shortcut = "Ctrl+P",
//    SubShortcut = "I",
//    OpeningTag = "<resolvingClause>",
//    ClosingTag = "</resolvingClause>",
//    TagAs = "<resolvingClause class=\"indent0 firstIndent0 fontsize10\">data</resolvingClause>"
//},
//new TagModel {
//    ButtonContent = "ResolvingClauseInline",
//    Shortcut = "Ctrl+P",
//    SubShortcut = "L",
//    OpeningTag = "<resolvingClause>",
//    ClosingTag = "</resolvingClause>",
//    TagAs = "<resolvingClause class=\"inline\">data</resolvingClause>"
//},
//new TagModel {
//    ButtonContent = "SectionCentered",
//    Shortcut = "Alt+S",
//    SubShortcut = "C",
//    OpeningTag = "<section>",
//    ClosingTag = "</section>",
//    TagAs = "<section class=\"centered\">data</section>"
//},
//new TagModel {
//    ButtonContent = "SectionFirstIndent",
//    Shortcut = "Alt+S",
//    SubShortcut = "F",
//    OpeningTag = "<section>",
//    ClosingTag = "</section>",
//    TagAs = "<section class=\"firstIndent1 fontsize10\">data</section>"
//},
//new TagModel {
//    ButtonContent = "SectionIndent0",
//    Shortcut = "Alt+S",
//    SubShortcut = "I",
//    OpeningTag = "<section>",
//    ClosingTag = "</section>",
//    TagAs = "<section class=\"indent0 fontsize10\">data</section>"
//},
//new TagModel {
//    ButtonContent = "SectionIndentUp",
//    Shortcut = "Alt+S",
//    SubShortcut = "U",
//    OpeningTag = "<section>",
//    ClosingTag = "</section>",
//    TagAs = "<section class=\"indentUp1 firstIndent1 fontsize10\">data</section>"
//},
//new TagModel {
//    ButtonContent = "section",
//    Shortcut = "Alt+S",
//    SubShortcut = "S",
//    OpeningTag = "<section>",
//    ClosingTag = "</section>",
//    TagAs = "<section>data</section>"
//},
//new TagModel {
//    ButtonContent = "ShortTitleAct",
//    Shortcut = "Ctrl+E",
//    SubShortcut = "A",
//    OpeningTag = "<shortTitle>",
//    ClosingTag = "</shortTitle>",
//    TagAs = "<shortTitle role=\"act\">data</shortTitle>"
//},
//new TagModel {
//    ButtonContent = "ShortTitleSubtitle",
//    Shortcut = "Ctrl+E",
//    SubShortcut = "S",
//    OpeningTag = "<shortTitle>",
//    ClosingTag = "</shortTitle>",
//    TagAs = "<shortTitle role=\"subtitle\">data</shortTitle>"
//},
//new TagModel {
//    ButtonContent = "ShortTitleTitle",
//    Shortcut = "Ctrl+E",
//    SubShortcut = "T",
//    OpeningTag = "<shortTitle>",
//    ClosingTag = "</shortTitle>",
//    TagAs = "<shortTitle role=\"title\">data</shortTitle>"
//},
//new TagModel {
//    ButtonContent = "shortTitle",
//    Shortcut = "Ctrl+E",
//    SubShortcut = "E",
//    OpeningTag = "<shortTitle>",
//    ClosingTag = "</shortTitle>",
//    TagAs = "<shortTitle>role|data</shortTitle>"
//},
//new TagModel {
//    ButtonContent = "SidenoteLeftMargin",
//    Shortcut = "Alt+Z",
//    SubShortcut = "L",
//    OpeningTag = "<sidenote>",
//    ClosingTag = "</sidenote>",
//    TagAs = "<sidenote renderingPosition=\"leftMargin\">data</sidenote>"
//},
//new TagModel {
//    ButtonContent = "SidenoteRightMargin",
//    Shortcut = "Alt+Z",
//    SubShortcut = "R",
//    OpeningTag = "<sidenote>",
//    ClosingTag = "</sidenote>",
//    TagAs = "<sidenote renderingPosition=\"rightMargin\">data</sidenote>"
//},
//new TagModel {
//    ButtonContent = "sidenote",
//    Shortcut = "Alt+Z",
//    SubShortcut = "Z",
//    OpeningTag = "<sidenote>",
//    ClosingTag = "</sidenote>",
//    TagAs = "<sidenote>data</sidenote>"
//},
//new TagModel {
//    ButtonContent = "SignatureCenteredBOld",
//    Shortcut = "Shift+A",
//    SubShortcut = "B",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature class=\"centered bold\">data</signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureCentered",
//    Shortcut = "Shift+A",
//    SubShortcut = "C",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature class=\"centered\">data</signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureFontsize",
//    Shortcut = "Shift+A",
//    SubShortcut = "F",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature class=\"fontsize8\">data</signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureInline",
//    Shortcut = "Shift+A",
//    SubShortcut = "L",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature class=\"inline\">data</signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureRightAlign",
//    Shortcut = "Shift+A",
//    SubShortcut = "A",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature class=\"rightAlign\">data</signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureSmallcapsCent",
//    Shortcut = "Shift+A",
//    SubShortcut = "S",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature class=\"smallCaps centered\">data</signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureName",
//    Shortcut = "Shift+A",
//    SubShortcut = "N",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature><name>data</name></signature>"
//},
//new TagModel {
//    ButtonContent = "SignatureRole",
//    Shortcut = "Shift+A",
//    SubShortcut = "R",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature><role>data</role></signature>"
//},
//new TagModel {
//    ButtonContent = "signature",
//    Shortcut = "Shift+A",
//    SubShortcut = "O",
//    OpeningTag = "<signature>",
//    ClosingTag = "</signature>",
//    TagAs = "<signature>data</signature>"
//},
//new TagModel {
//    ButtonContent = "SubscriptAttrib",
//    Shortcut = "Shift+U",
//    SubShortcut = "X",
//    OpeningTag = "<sub xmlns=\"http://schemas.gpo.gov/xml/uslm\">",
//    ClosingTag = "</sub>",
//    TagAs = "<sub xmlns=\"http://schemas.gpo.gov/xml/uslm\">data</sub>"
//},
//new TagModel {
//    ButtonContent = "Subscripted text",
//    Shortcut = "Shift+U",
//    SubShortcut = "U",
//    OpeningTag = "<sub>",
//    ClosingTag = "</sub>",
//    TagAs = "<sub>data</sub>"
//},
//new TagModel {
//    ButtonContent = "SubClauseCentered",
//    Shortcut = "Alt+B",
//    SubShortcut = "C",
//    OpeningTag = "<subclause>",
//    ClosingTag = "</subclause>",
//    TagAs = "<subclause class=\"centered\">data</subclause>"
//},
//new TagModel {
//    ButtonContent = "SubClauseFirstIndent",
//    Shortcut = "Alt+B",
//    SubShortcut = "F",
//    OpeningTag = "<subclause>",
//    ClosingTag = "</subclause>",
//    TagAs = "<subclause class=\"firstIndent1 fontsize10\">data</subclause>"
//},
//new TagModel {
//    ButtonContent = "SubClauseIndent0",
//    Shortcut = "Alt+B",
//    SubShortcut = "I",
//    OpeningTag = "<subclause>",
//    ClosingTag = "</subclause>",
//    TagAs = "<subclause class=\"indent1 fontsize10\">data</subclause>"
//},
//new TagModel {
//    ButtonContent = "subclause",
//    Shortcut = "Alt+B",
//    SubShortcut = "I4",
//    OpeningTag = "<subclause>",
//    ClosingTag = "</subclause>",
//    TagAs = "<subclause class=\"indent4 fontsize10\">data</subclause>"
//},
//new TagModel {
//    ButtonContent = "SubClauseIndentUp",
//    Shortcut = "Alt+B",
//    SubShortcut = "U",
//    OpeningTag = "<subclause>",
//    ClosingTag = "</subclause>",
//    TagAs = "<subclause class=\"indentUp1 fontsize10\">data</subclause>"
//},
//new TagModel {
//    ButtonContent = "subclause-inline",
//    Shortcut = "Alt+B",
//    SubShortcut = "L",
//    OpeningTag = "<subclause>",
//    ClosingTag = "</subclause>",
//    TagAs = "<subclause class=\"inline\">data</subclause>"
//},
//new TagModel {
//    ButtonContent = "SubheadingBoldCentered",
//    Shortcut = "Shift+D",
//    SubShortcut = "B",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"bold centered\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingCentered",
//    Shortcut = "Shift+D",
//    SubShortcut = "C",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"centered\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingIndent",
//    Shortcut = "Shift+D",
//    SubShortcut = "F",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"firstIndent-1 fontsize10\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingInline",
//    Shortcut = "Shift+D",
//    SubShortcut = "L",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"inline\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingItalicCentered",
//    Shortcut = "Shift+D",
//    SubShortcut = "I",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"italic centered\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingItalic",
//    Shortcut = "Shift+D",
//    SubShortcut = "T",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"italic\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingSmallcapsCentered",
//    Shortcut = "Shift+D",
//    SubShortcut = "D",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"smallCaps centered\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "SubheadingSmallcaps",
//    Shortcut = "Shift+D",
//    SubShortcut = "S",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading class=\"smallCaps\">data</subheading>"
//},
//new TagModel {
//    ButtonContent = "Subheading",
//    Shortcut = "Shift+D",
//    SubShortcut = "D",
//    OpeningTag = "<subheading>",
//    ClosingTag = "</subheading>",
//    TagAs = "<subheading>data</subheading>"
//},
//new TagModel {
//    ButtonContent = "subitem",
//    Shortcut = "Alt+6",
//    SubShortcut = "I",
//    OpeningTag = "<subitem>",
//    ClosingTag = "</subitem>",
//    TagAs = "<subitem class=\"indent4 fontsize10\">data</subitem>"
//},
//new TagModel {
//    ButtonContent = "subitem-inline",
//    Shortcut = "Alt+6",
//    SubShortcut = "L",
//    OpeningTag = "<subitem>",
//    ClosingTag = "</subitem>",
//    TagAs = "<subitem class=\"inline\">data</subitem>"
//},
//new TagModel {
//    ButtonContent = "SubParagraphFirstIndent",
//    Shortcut = "Shift+B",
//    SubShortcut = "F",
//    OpeningTag = "<subparagraph>",
//    ClosingTag = "</subparagraph>",
//    TagAs = "<subparagraph class=\"firstIndent1 fontsize10\">data</subparagraph>"
//},
//new TagModel {
//    ButtonContent = "SubParagraphIndent0",
//    Shortcut = "Shift+B",
//    SubShortcut = "I",
//    OpeningTag = "<subparagraph>",
//    ClosingTag = "</subparagraph>",
//    TagAs = "<subparagraph class=\"indent0 fontsize10\">data</subparagraph>"
//},
//new TagModel {
//    ButtonContent = "subparagraph",
//    Shortcut = "Shift+B",
//    SubShortcut = "I2",
//    OpeningTag = "<subparagraph>",
//    ClosingTag = "</subparagraph>",
//    TagAs = "<subparagraph class=\"indent2 fontsize10\">data</subparagraph>"
//},
//new TagModel {
//    ButtonContent = "SubParagraphIndentUp",
//    Shortcut = "Shift+B",
//    SubShortcut = "U",
//    OpeningTag = "<subparagraph>",
//    ClosingTag = "</subparagraph>",
//    TagAs = "<subparagraph class=\"indentUp1 fontsize10\">data</subparagraph>"
//},
//new TagModel {
//    ButtonContent = "subparagraph-inline",
//    Shortcut = "Shift+B",
//    SubShortcut = "L",
//    OpeningTag = "<subparagraph>",
//    ClosingTag = "</subparagraph>",
//    TagAs = "<subparagraph class=\"inline\">data</subparagraph>"
//},
//new TagModel {
//    ButtonContent = "SubSectionCentered",
//    Shortcut = "Shift+S",
//    SubShortcut = "C",
//    OpeningTag = "<subsection>",
//    ClosingTag = "</subsection>",
//    TagAs = "<subsection class=\"centered\">data</subsection>"
//},
//new TagModel {
//    ButtonContent = "SubSectionFirstIndent",
//    Shortcut = "Shift+S",
//    SubShortcut = "F",
//    OpeningTag = "<subsection>",
//    ClosingTag = "</subsection>",
//    TagAs = "<subsection class=\"firstIndent1 fontsize10\">data</subsection>"
//},
//new TagModel {
//    ButtonContent = "subsection",
//    Shortcut = "Shift+S",
//    SubShortcut = "I",
//    OpeningTag = "<subsection>",
//    ClosingTag = "</subsection>",
//    TagAs = "<subsection class=\"indent0 fontsize10\">data</subsection>"
//},
//new TagModel {
//    ButtonContent = "SubSectionIndentUp",
//    Shortcut = "Shift+S",
//    SubShortcut = "U",
//    OpeningTag = "<subsection>",
//    ClosingTag = "</subsection>",
//    TagAs = "<subsection class=\"indentUp1 fontsize10\">data</subsection>"
//},
//new TagModel {
//    ButtonContent = "subsection-inline",
//    Shortcut = "Shift+S",
//    SubShortcut = "L",
//    OpeningTag = "<subsection>",
//    ClosingTag = "</subsection>",
//    TagAs = "<subsection class=\"inline\">data</subsection>"
//},
//new TagModel {
//    ButtonContent = "SubSectionDefinitions",
//    Shortcut = "Shift+S",
//    SubShortcut = "D",
//    OpeningTag = "<subsection>",
//    ClosingTag = "</subsection>",
//    TagAs = "<subsection role=\"definitions\" class=\"fontsize10\">data</subsection>"
//},
//new TagModel {
//    ButtonContent = "subsubitem",
//    Shortcut = "Alt+7",
//    SubShortcut = "I",
//    OpeningTag = "<subsubitem>",
//    ClosingTag = "</subsubitem>",
//    TagAs = "<subsubitem class=\"indent5 fontsize10\">data</subsubitem>"
//},
//new TagModel {
//    ButtonContent = "subsubitem-inline",
//    Shortcut = "Alt+7",
//    SubShortcut = "L",
//    OpeningTag = "<subsubitem>",
//    ClosingTag = "</subsubitem>",
//    TagAs = "<subsubitem class=\"inline\">data</subsubitem>"
//},
//new TagModel {
//    ButtonContent = "SuperscriptAttrib",
//    Shortcut = "Shift+C",
//    SubShortcut = "X",
//    OpeningTag = "<sup xmlns=\"http://schemas.gpo.gov/xml/uslm\">",
//    ClosingTag = "</sup>",
//    TagAs = "<sup xmlns=\"http://schemas.gpo.gov/xml/uslm\">data</sup>"
//},
//new TagModel {
//    ButtonContent = "Superscripted text",
//    Shortcut = "Shift+C",
//    SubShortcut = "C",
//    OpeningTag = "<sup>",
//    ClosingTag = "</sup>",
//    TagAs = "<sup>data</sup>"
//},
//new TagModel {
//    ButtonContent = "title",
//    Shortcut = "Shift+Y",
//    OpeningTag = "<title>",
//    ClosingTag = "</title>",
//    TagAs = "<title>data</title>"
//}

//};

            #endregion


            //string addedTagsFile = string.Concat(AppDomain.CurrentDomain.BaseDirectory, @"\USLMCodingTags.txt");
            //if (System.IO.File.Exists(addedTagsFile))
            //{
            //    using (StreamReader sr = new StreamReader(addedTagsFile))
            //    {
            //        string line = sr.ReadLine();
            //        while (line != null)
            //        {
            //            if (line.Contains("ElementName") == false)
            //            {
            //                string[] subs = line.Split('\t');

            //                TagCollection.Add(new TagModel
            //                {
            //                    ButtonContent = subs[0],
            //                    OpeningTag = subs[1],
            //                    TagAs = subs[2],
            //                    Example = subs[2],
            //                    Description = "A " + subs[0]
            //                });
            //            }


            //            //Read the next line
            //            line = sr.ReadLine();
            //        }

            //    }
            //}




        }

        #region Dialog Functions
        /// <summary>
        /// Display an error message
        /// </summary>
        /// <param name="ex">Your exception</param>
        /// <param name="message">Title text. Typically, put here your method name</param>
        public static void ErrorMessage(Exception ex)
        {
            try
            {
                StackTrace stackTrace = new StackTrace(ex);
                System.Reflection.MethodBase method = stackTrace.GetFrame(stackTrace.FrameCount - 1).GetMethod();
                string titleText = method.Name;

                MessageBox.Show(string.Format(ex.Message + "\n\n" + ex.StackTrace + "\n\n{0}", "Please screenshot and send procedures on how this error occured. Thank you."), titleText, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex2)
            {
                ErrorMessage(ex2);
            }
        }

        /// <summary>
        /// Displays an information messagebox
        /// </summary>
        /// <param name="message">Text</param>
        /// <param name="title">Title text</param>
        public static void InformationMessage(string message, string title)
        {
            try
            {
                MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex2)
            {
                ErrorMessage(ex2);
            }
        }

        /// <summary>
        /// Displays a warning messagebox
        /// </summary>
        /// <param name="message">Text</param>
        /// <param name="title">Title text</param>
        public static void WarningMessage(string message, string title)
        {
            try
            {
                MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex2)
            {
                ErrorMessage(ex2);
            }
        }
        /// <summary>
        /// Displays a warning messagebox
        /// </summary>
        /// <param name="message">Text</param>
        /// <param name="title">Title text</param>
        public static void WarningMessage(string message)
        {
            try
            {
                WarningMessage(message, "Warning");
            }
            catch (Exception ex2)
            {
                ErrorMessage(ex2);
            }
        }

        /// <summary>
        /// Displays a yes/no/cancel messagebox. Returns a MessageBoxResult. Either true or false.
        /// </summary>
        /// <param name="message">Text to ask</param>
        /// <returns>MessageBoxResult result. Either true or false.</returns>
        public static MessageBoxResult YesNoCancelDialog(string message)
        {
            MessageBoxResult res = MessageBoxResult.None;

            try
            {
                res = MessageBox.Show(message, "Confirmation", MessageBoxButton.YesNoCancel, MessageBoxImage.Information);
            }
            catch (Exception ex2)
            {
                ErrorMessage(ex2);
            }

            return res;
        }
        #endregion

        #region Shared functions
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Open the file chooser and return the selected files
        /// </summary>
        /// <returns></returns>
        public List<string> GetFilePaths(string DisplayName, string ExtensionList, string Title)
        {
            List<string> pathList = null;

            try
            {
                Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog dialog = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog
                {
                    Title = Title,
                    Multiselect = true
                };

                dialog.Filters.Add(new Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogFilter(DisplayName, ExtensionList));

                if (dialog.ShowDialog() != Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
                {
                    return null;
                }

                pathList = dialog.FileNames.ToList();
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }

            return pathList;
        }
        /// <summary>
        /// Open the file chooser and return the selected file or folder
        /// </summary>
        /// <returns></returns>
        public string GetFilePath(string DisplayName, string ExtensionList, string Title)
        {
            string path = null;

            try
            {
                Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog dialog = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog
                {
                    Title = Title,
                };

                dialog.Filters.Add(new Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogFilter(DisplayName, ExtensionList));

                if (dialog.ShowDialog() != Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
                {
                    return null;
                }

                path = dialog.FileName;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }

            return path;
        }
        /// <summary>
        /// Open the folder chooser and return the selected paths
        /// </summary>
        /// <param name="IsMultiSelect">Default is false. True = Select 2 or more files</param>
        /// <returns></returns>
        public IEnumerable<string> GetFolderPaths(string Title)
        {
            IEnumerable<string> path = null;

            try
            {
                CommonOpenFileDialog folderSelectorDialog = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    AllowNonFileSystemItems = false,
                    Multiselect = true,
                    Title = Title
                };

                if (folderSelectorDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    path = folderSelectorDialog.FileNames;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }

            return path;
        }

        /// <summary>
        /// Open the folder chooser and return the path
        /// </summary>
        /// <param name="IsMultiSelect">Default is false. True = Select 2 or more files</param>
        /// <returns></returns>
        public string GetFolderPath(string Title, bool isMultiSelect = false)
        {
            string path = null;

            try
            {
                CommonOpenFileDialog folderSelectorDialog = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    AllowNonFileSystemItems = false,
                    Multiselect = isMultiSelect,
                    Title = Title
                };

                if (folderSelectorDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    path = folderSelectorDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }

            return path;
        }
        /// <summary>
        /// Get the column
        /// </summary>
        /// <param name="columnNumber"></param>
        /// <returns></returns>
        public string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = string.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (dividend - modulo) / 26;
            }

            return columnName;
        }

        /// <summary>
        /// Open the documentation file
        /// </summary>
        public void ShowDocumentation()
        {
            try
            {
                Process.Start(@"Assets\.docx");
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }
        }


        #endregion
    }
}
