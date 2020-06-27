using System;
using System.Windows.Forms;
using TranslationService;

namespace EnglisgTranslatorWindowsForms2
{
    public partial class Form1 : Form
    {
        private readonly Translator _translator;
        public Form1()
        {
            InitializeComponent();
            _translator = new Translator();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            var result = _translator.Translate(txtSrc.Text);

            txtDestLang.Text = result.Result;
            lblCorection.Text = result.CorrectedResult;
        }
                
        private void lblCorection_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                txtSrc.Text = Globals.combindedString;
                lblCorection.Text = null;
                Globals.test = 0;
            }
        }
    }    
}
