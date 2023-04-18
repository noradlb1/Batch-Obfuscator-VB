Namespace BatchIDE
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.checkBox3 = New System.Windows.Forms.CheckBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textBox1.BackColor = System.Drawing.Color.Gray
			Me.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.textBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox1.ForeColor = System.Drawing.Color.White
			Me.textBox1.Location = New System.Drawing.Point(9, 12)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(652, 445)
			Me.textBox1.TabIndex = 0
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.ForeColor = System.Drawing.Color.Black
			Me.checkBox1.Location = New System.Drawing.Point(16, 19)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(205, 25)
			Me.checkBox1.TabIndex = 1
			Me.checkBox1.Text = "Use Base64 Obfuscation"
			Me.checkBox1.UseVisualStyleBackColor = True
			' 
			' checkBox2
			' 
			Me.checkBox2.AutoSize = True
			Me.checkBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox2.ForeColor = System.Drawing.Color.Black
			Me.checkBox2.Location = New System.Drawing.Point(16, 40)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(222, 25)
			Me.checkBox2.TabIndex = 2
			Me.checkBox2.Text = "Use Junk Data Obfuscation"
			Me.checkBox2.UseVisualStyleBackColor = True
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.BackColor = System.Drawing.Color.White
			Me.button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.Black
			Me.button1.Location = New System.Drawing.Point(809, 479)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(145, 40)
			Me.button1.TabIndex = 3
			Me.button1.Text = "Compile"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' textBox2
			' 
			Me.textBox2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textBox2.BackColor = System.Drawing.SystemColors.ControlLight
			Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox2.ForeColor = System.Drawing.Color.Black
			Me.textBox2.Location = New System.Drawing.Point(101, 487)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(702, 26)
			Me.textBox2.TabIndex = 6
			' 
			' label1
			' 
			Me.label1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.Black
			Me.label1.Location = New System.Drawing.Point(16, 489)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(86, 21)
			Me.label1.TabIndex = 7
			Me.label1.Text = "File Name:"
			' 
			' checkBox3
			' 
			Me.checkBox3.AutoSize = True
			Me.checkBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox3.ForeColor = System.Drawing.Color.Black
			Me.checkBox3.Location = New System.Drawing.Point(16, 61)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(142, 25)
			Me.checkBox3.TabIndex = 9
			Me.checkBox3.Text = "Compile C# File"
			Me.checkBox3.UseVisualStyleBackColor = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Controls.Add(Me.checkBox3)
			Me.groupBox1.Controls.Add(Me.checkBox2)
			Me.groupBox1.Location = New System.Drawing.Point(676, 7)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(278, 450)
			Me.groupBox1.TabIndex = 10
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Settings"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.SystemColors.ControlDark
			Me.ClientSize = New System.Drawing.Size(975, 547)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.textBox2)
			Me.Controls.Add(Me.label1)
			Me.MinimumSize = New System.Drawing.Size(991, 583)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Batchfuscator"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textBox1 As System.Windows.Forms.TextBox
		Private checkBox1 As System.Windows.Forms.CheckBox
		Private checkBox2 As System.Windows.Forms.CheckBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private textBox2 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private checkBox3 As System.Windows.Forms.CheckBox
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace

