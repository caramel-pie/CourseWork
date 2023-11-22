﻿using System.Text.RegularExpressions;
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

            string fileContent = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <style></style>
</head>
<body>
    <main>
        <h1>Receipt: 'id'</h1>
        <h2>Client's info:</h2>
        <div>
            <p>Name: 'name'</p>
            <p>Surname: 'surname'</p>
            <p>Adress: 'adress'</p>
            <p>Document type: 'doctype'</p>
            <p>Document number: 'docnum'</p>
        </div>
        <h2>Item's info:</h2>
        <div>
            <p>Type: 'type'</p>
            <p>Title: 'title'</p>
            <p>Condition: 'condition'</p>
            <p>Pledget: 'pledget'</p>
        </div>
        <h2>Details:</h2>
        <div>
            <p>Delivery date: 'startdate'</p>
            <p>Return date: 'finishdate'</p>
            <p>Sum: 'sum'</p>
        </div>
    </main>
</body>
</html>";
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
