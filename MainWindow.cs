using System;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine am = new AddMedicine
            {
                MdiParent = this
            };
            am.Show();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProvider ap = new AddProvider 
            { 
                MdiParent = this 
            };
            ap.Show();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditMedicine em = new EditMedicine
            {
                MdiParent = this
            };
            em.Show();
        }

        private void providerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditProvider ep = new EditProvider
            {
                MdiParent = this
            };
            ep.Show();
        }

        private void medicineToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteMedicine dm = new DeleteMedicine
            {
                MdiParent = this
            };
            dm.Show();
        }

        private void providerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteProvider dp = new DeleteProvider
            {
                MdiParent = this
            };
            dp.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow sw = new SearchWindow
            {
                MdiParent = this
            };
            sw.Show();
        }

        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSale @as = new AddSale
            {
                MdiParent = this
            };
            @as.Show();
        }

        private void списаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWriteoff aw = new AddWriteoff
            {
                MdiParent = this
            };
            aw.Show();
        }

        private void продажаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditSale es = new EditSale 
            {
                MdiParent = this 
            };
            es.Show();
        }

        private void списаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditWriteoff ew = new EditWriteoff 
            { 
                MdiParent = this 
            };
            ew.Show();
        }

        private void продажаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteSale ds = new DeleteSale 
            { 
                MdiParent = this 
            };
            ds.Show();
        }

        private void списаниеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteWriteoff dw = new DeleteWriteoff 
            { 
                MdiParent = this 
            };
            dw.Show();
        }

        private void расчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPay ap = new AddPay 
            {
                MdiParent = this
            };
            ap.Show();
        }

        private void прибыльToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome ai = new AddIncome 
            { 
                MdiParent = this 
            };
            ai.Show();
        }

        private void расчётToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditPay ep = new EditPay 
            {
                MdiParent = this 
            };
            ep.Show();
        }

        private void прибыльToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditIncome ei = new EditIncome 
            { 
                MdiParent = this 
            };
            ei.Show();
        }

        private void расчётToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeletePay dp = new DeletePay 
            { 
                MdiParent = this 
            };
            dp.Show();
        }

        private void прибыльToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteIncome di = new DeleteIncome 
            { 
                MdiParent = this 
            };
            di.Show();
        }
    }
}
