using System.Text.RegularExpressions;
using PdfSharp.Pdf;
using PdfSharp;
using TheArtOfDev.HtmlRenderer.Core.Entities;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace Year2_Lab1
{
    class Printer
    {
        public static void TakeReceipt(Receipt receipt)
        {
            var item = new DataBase().GetItem(receipt.itemid);
            var client = new DataBase().GetClient(receipt.clientid);

            string fileContent = File.ReadAllText("lb1.html");
            fileContent = Regex.Replace(fileContent, "'id'", receipt.id.ToString());
            fileContent = Regex.Replace(fileContent, "'name'", client.name.ToString());
            fileContent = Regex.Replace(fileContent, "'surname'", client.surname.ToString());
            fileContent = Regex.Replace(fileContent, "'adress'", client.adress.ToString());
            fileContent = Regex.Replace(fileContent, "'docnum'", client.docnum.ToString());
            fileContent = Regex.Replace(fileContent, "'doctype'", client.doctype.ToString());
            fileContent = Regex.Replace(fileContent, "'type'", item.material_id.ToString());
            fileContent = Regex.Replace(fileContent, "'title'", item.title.ToString());
            fileContent = Regex.Replace(fileContent, "'condition'", item.condition.ToString());
            fileContent = Regex.Replace(fileContent, "'pledget'", item.pledget.ToString());
            fileContent = Regex.Replace(fileContent, "'startdate'", receipt.startdate.ToString());
            fileContent = Regex.Replace(fileContent, "'finishdate'", receipt.finishdate.ToString());
            fileContent = Regex.Replace(fileContent, "'sum'", receipt.sum.ToString());
            PdfDocument pdf = PdfGenerator.GeneratePdf(fileContent, PageSize.A4);
            pdf.Save("document.pdf");
        }
    }
}
