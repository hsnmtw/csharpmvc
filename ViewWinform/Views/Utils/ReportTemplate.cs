using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace MVCWinform.Reporting {
    class ReportTemplate {
        
        public Font Font { get; set; }
        public Brush Brush { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public List<string> Body { get; set; }
        public PrintDocument PrintDocument { get; set; }

        public ReportTemplate(PrintDocument pd){
            this.PrintDocument = pd;
            this.PrintDocument.PrintPage += PrintDocumentPrintPage;
            this.Body = new List<string>();
            this.Brush = Brushes.Black;
            this.Font = new Font("Consolas", 12, FontStyle.Regular);
        }


        private int line;
        private int page = 1;
        private void PrintDocumentPrintPage(object sender, PrintPageEventArgs e) {
            Graphics g = e.Graphics;
            int x = 1, y = 1;
            double pages = 1+(Body.Count *20 / (e.MarginBounds.Bottom-30));
            g.DrawString(Header, Font, Brush, new Point(10, 10));

            g.DrawLine(new Pen(this.Brush), new Point(10, 1090), new Point(800,1090));
            g.DrawString($"Page: {page} / {pages}", Font, Brush, new Point(10, 1100));
            g.DrawString(Footer, Font, Brush, new Point(10, 1140));

            for (int i=line;i<this.Body.Count;i++) {
                //string line = this.Body[i];
                y = 30 + 20 * (x++);
                if (y >= e.MarginBounds.Bottom) {
                    e.HasMorePages = true;
                    line = i;
                    page++;
                    return;
                } else {
                    e.HasMorePages = false;
                }
                g.DrawString(this.Body[i], Font, Brush, new Point(10, y));
            }

            
        }
    }
}
