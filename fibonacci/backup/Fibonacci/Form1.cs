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
			this.label1.Location = new System.Drawing.Point(64, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "1  ,  1  ,  2  ,  3  ,  5  ,  8  ,  13  ,...";
			// 
			// txtIndex
			// 
			this.txtIndex.Location = new System.Drawing.Point(60, 54);
			this.txtIndex.Name = "txtIndex";
			this.txtIndex.Size = new System.Drawing.Size(32, 20);
			this.txtIndex.TabIndex = 1;
			this.txtIndex.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Index";
			// 
			// btnRecursive
			// 
			this.btnRecursive.Location = new System.Drawing.Point(110, 53);
			this.btnRecursive.Name = "btnRecursive";
			this.btnRecursive.TabIndex = 3;
			this.btnRecursive.Text = "Recursive";
			this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
			// 
			// txtRecursive
			// 
			this.txtRecursive.Location = new System.Drawing.Point(193, 54);
			this.txtRecursive.Name = "txtRecursive";
			this.txtRecursive.Size = new System.Drawing.Size(87, 20);
			this.txtRecursive.TabIndex = 4;
			this.txtRecursive.Text = "";
			// 
			// txtIterative
			// 
			this.txtIterative.Location = new System.Drawing.Point(193, 97);
			this.txtIterative.Name = "txtIterative";
			this.txtIterative.Size = new System.Drawing.Size(87, 20);
			this.txtIterative.TabIndex = 6;
			this.txtIterative.Text = "";
			// 
			// btnIterative
			// 
			this.btnIterative.Location = new System.Drawing.Point(112, 96);
			this.btnIterative.Name = "btnIterative";
			this.btnIterative.TabIndex = 5;
			this.btnIterative.Text = "Iterative";
			this.btnIterative.Click += new System.EventHandler(this.btnIterative_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 142);
			this.Controls.Add(this.txtIterative);
			this.Controls.Add(this.btnIterative);
			this.Controls.Add(this.txtRecursive);
			this.Controls.Add(this.btnRecursive);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIndex);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Fibonacci Series...";
			this.ResumeLayout(false);

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
	}
}
