
using System.Threading.Tasks;

namespace USML_Special_Modification.Processes
{
    internal interface ISpecialAutoTagging
    {
        Task<string> AutoTaggingScan(string documentText);
        Task<string> AutoTaggingScan(string documentText, string volumeNumber);
    }
}
