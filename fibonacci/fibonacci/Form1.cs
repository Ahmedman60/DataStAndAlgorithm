using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Fibonacci
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIndex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRecursive;
		private System.Windows.Forms.TextBox txtRecursive;
		private System.Windows.Forms.TextBox txtIterative;
		private System.Windows.Forms.Button btnIterative;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.txtRecursive = new System.Windows.Forms.TextBox();
            this.txtIterative = new System.Windows.Forms.TextBox();
            this.btnIterative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1  ,  1  ,  2  ,  3  ,  5  ,  8  ,  13  ,...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.Location = new System.Drawing.Point(91, 73);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(73, 30);
            this.txtIndex.TabIndex = 1;
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Index";
            // 
            // btnRecursive
            // 
            this.btnRecursive.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursive.Location = new System.Drawing.Point(189, 73);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(126, 31);
            this.btnRecursive.TabIndex = 3;
            this.btnRecursive.Text = "Recursive";
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // txtRecursive
            // 
            this.txtRecursive.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecursive.Location = new System.Drawing.Point(343, 74);
            this.txtRecursive.Name = "txtRecursive";
            this.txtRecursive.Size = new System.Drawing.Size(163, 30);
            this.txtRecursive.TabIndex = 4;
            // 
            // txtIterative
            // 
            this.txtIterative.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIterative.Location = new System.Drawing.Point(343, 138);
            this.txtIterative.Name = "txtIterative";
            this.txtIterative.Size = new System.Drawing.Size(163, 30);
            this.txtIterative.TabIndex = 6;
            // 
            // btnIterative
            // 
            this.btnIterative.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIterative.Location = new System.Drawing.Point(189, 137);
            this.btnIterative.Name = "btnIterative";
            this.btnIterative.Size = new System.Drawing.Size(126, 30);
            this.btnIterative.TabIndex = 5;
            this.btnIterative.Text = "Iterative";
            this.btnIterative.Click += new System.EventHandler(this.btnIterative_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(11, 23);
            this.ClientSize = new System.Drawing.Size(518, 203);
            this.Controls.Add(this.txtIterative);
            this.Controls.Add(this.btnIterative);
            this.Controls.Add(this.txtRecursive);
            this.Controls.Add(this.btnRecursive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Fibonacci Series...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		long Recursive(long N)
		{
			long Fib ;
			if (N == 0 || N == 1)
				Fib = 1 ;
			else
				Fib = Recursive(N - 1) + Recursive(N - 2) ;
			return Fib ;
		}

		long Iterative(long N)
		{
			long Fib = 1 ;
			long Fst = 1 ;
			long Snd = 1 ;
			for (int i = 2 ; i <= N ; i++)
			{
				Fib = Fst + Snd ;
				Fst = Snd ;
				Snd = Fib ;
			}
			return Fib ;
		}
		
		private void btnRecursive_Click(object sender, System.EventArgs e)
		{
			txtRecursive.Text = Recursive(long.Parse(txtIndex.Text)).ToString() ;		
		}

		private void btnIterative_Click(object sender, System.EventArgs e)
		{
			txtIterative.Text = Iterative(long.Parse(txtIndex.Text)).ToString() ;		
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
