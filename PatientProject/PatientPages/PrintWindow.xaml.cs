using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Xps;

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PrintWindow.xaml
    /// </summary>
    public partial class PrintWindow : Window
    {
        private FixedDocumentSequence _document;


        public PrintWindow(FixedDocumentSequence document)

        {

            //--------< Initialize with document >------------

            //*open window with document as parameter or argument



            //--< set_preview >--

            _document = document;

            //--</ set_preview >--



            InitializeComponent();



            //< set visible >

            PreviewD.Document = document;

            //</ set visible >

            //--------</ Initialize with document >------------

        }
        private void BtnPrint_Click(object sender, RoutedEventArgs e)

        {

            Print_Document();



        }

        public void Print_Document()

        {

            //----------------< Print_Document() >-----------------------

            //----< Get_Print_Dialog_and_Printer >----

            PrintDialog printDialog = new PrintDialog();

            printDialog.PrintQueue = LocalPrintServer.GetDefaultPrintQueue();

            printDialog.PrintTicket = printDialog.PrintQueue.DefaultPrintTicket;

            //----</ Get_Print_Dialog_and_Printer >----



            //*set the default page orientation based on the desired output.

            printDialog.PrintTicket.PageOrientation = PageOrientation.Landscape;

            printDialog.PrintTicket.PageScalingFactor = 90;

            printDialog.PrintTicket.PageMediaSize = new PageMediaSize(PageMediaSizeName.ISOA4);

            //printDialog.PrintableAreaHeight ; //*get

            //printDialog.PrintableAreaWidth;   //get

            //printDialog.PrintDocument.

            printDialog.PrintTicket.PageBorderless = PageBorderless.None;



            if (printDialog.ShowDialog() == true)

            {

                //----< print >----   

                // set the print ticket for the document sequence and write it to the printer.

                _document.PrintTicket = printDialog.PrintTicket;



                //-< send_document_to_printer >-

                XpsDocumentWriter writer = PrintQueue.CreateXpsDocumentWriter(printDialog.PrintQueue);

                writer.WriteAsync(_document, printDialog.PrintTicket);

                //-</ send_document_to_printer >-

                //----</ print >----   
            }

            //----------------</ Print_Document() >-----------------------

        }
    }
}
