using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Document
    {
        private IDocumentConverter _pdfConverter = new PDFConverter();
        private IDocumentConverter _excelConverter = new ExcelConverter();

        public Document(IDocumentConverter pdfConverter, IDocumentConverter excelConverter)
        {
            _pdfConverter = pdfConverter;
            _excelConverter = excelConverter;
        }

        public void ConvertDocumentToPDF(int documentId)
        {
            this._pdfConverter.Converter(documentId);
        }

        public void ConvertDocumentToExcel(int documentId)
        {
            this._excelConverter.Converter(documentId);
        }
    }
}
