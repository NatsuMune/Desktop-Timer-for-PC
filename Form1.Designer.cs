partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Label lblPhase;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnSkip;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        
        this.lblTime = new System.Windows.Forms.Label();
        this.lblPhase = new System.Windows.Forms.Label();
        this.btnStart = new System.Windows.Forms.Button();
        this.btnReset = new System.Windows.Forms.Button();
        this.btnSkip = new System.Windows.Forms.Button();

        this.Controls.Add(this.lblTime);
        this.Controls.Add(this.lblPhase);
        this.Controls.Add(this.btnStart);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.btnSkip);
    }
} 