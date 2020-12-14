using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table table = new Table();

            table.HorizontalAlign = HorizontalAlign.Center;

            table.Width = new Unit("50%");

            table.CssClass = "tableBG";

            //Header
            TableHeaderRow hRow = new TableHeaderRow();

            TableHeaderCell hCell;
            hCell = new TableHeaderCell();

            Label hLabel1 = new Label();
            hLabel1.Text = "Row 1";

            hCell.Controls.Add(hLabel1);

            hRow.Cells.Add(hCell);
            //1==================================
            hCell = new TableHeaderCell();
            hCell.Controls.Add(new Label { Text = "Row 2" });
            hRow.Cells.Add(hCell);
            //2==================================
            hCell = new TableHeaderCell();
            hCell.Controls.Add(new Label { Text = "Row 3" });
            hRow.Cells.Add(hCell);

            table.Rows.Add(hRow);

            //body
            TableRow row;
            TableCell cell;

            ////First line

            row = new TableRow();
            cell = new TableCell();
            cell.CssClass = "tableCell-1";
            cell.Controls.Add(new Label { Text = "hello" });
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.CssClass = "tableCell-2";
            cell.Controls.Add(new Button { Text = "Tik" });
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.CssClass = "tableCell-3";
            cell.Controls.Add(new Label { Text = "image" });
            row.Cells.Add(cell);

            table.Rows.Add(row);

            ////Second line
            row = new TableRow();
            cell = new TableCell();
            cell.CssClass = "tableCell-5";
            cell.ColumnSpan = 2;
            cell.Controls.Add(new Button { Text = "Tik" });
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.CssClass = "tableCell-4";
            cell.Controls.Add(new Label { Text = "hello" });
            row.Cells.Add(cell);

            table.Rows.Add(row);
            //body

            //footer
            TableFooterRow frow = new TableFooterRow();

            TableCell fcell = new TableCell();
            fcell.ColumnSpan = 3;
            fcell.Controls.Add(new Label { Text = "welcome to the club buddy" });

            frow.Cells.Add(fcell);

            table.Rows.Add(frow);

            PlaceHolder1.Controls.Add(table);
            //footer
        }
    }
}