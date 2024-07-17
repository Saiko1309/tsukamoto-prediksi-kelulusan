<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRapor1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRapor2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRapor3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRapor4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRapor5 = New System.Windows.Forms.TextBox()
        Me.btnPrediksi = New System.Windows.Forms.Button()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtRapor1
        '
        Me.txtRapor1.Location = New System.Drawing.Point(23, 44)
        Me.txtRapor1.Name = "txtRapor1"
        Me.txtRapor1.Size = New System.Drawing.Size(100, 20)
        Me.txtRapor1.TabIndex = 0
        Me.txtRapor1.Text = "70"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rapor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rapor2"
        '
        'txtRapor2
        '
        Me.txtRapor2.Location = New System.Drawing.Point(142, 44)
        Me.txtRapor2.Name = "txtRapor2"
        Me.txtRapor2.Size = New System.Drawing.Size(100, 20)
        Me.txtRapor2.TabIndex = 2
        Me.txtRapor2.Text = "70"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rapor3"
        '
        'txtRapor3
        '
        Me.txtRapor3.Location = New System.Drawing.Point(259, 44)
        Me.txtRapor3.Name = "txtRapor3"
        Me.txtRapor3.Size = New System.Drawing.Size(100, 20)
        Me.txtRapor3.TabIndex = 4
        Me.txtRapor3.Text = "70"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rapor4"
        '
        'txtRapor4
        '
        Me.txtRapor4.Location = New System.Drawing.Point(375, 44)
        Me.txtRapor4.Name = "txtRapor4"
        Me.txtRapor4.Size = New System.Drawing.Size(100, 20)
        Me.txtRapor4.TabIndex = 6
        Me.txtRapor4.Text = "70"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(491, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rapor5"
        '
        'txtRapor5
        '
        Me.txtRapor5.Location = New System.Drawing.Point(491, 44)
        Me.txtRapor5.Name = "txtRapor5"
        Me.txtRapor5.Size = New System.Drawing.Size(100, 20)
        Me.txtRapor5.TabIndex = 8
        Me.txtRapor5.Text = "70"
        '
        'btnPrediksi
        '
        Me.btnPrediksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrediksi.Location = New System.Drawing.Point(26, 106)
        Me.btnPrediksi.Name = "btnPrediksi"
        Me.btnPrediksi.Size = New System.Drawing.Size(565, 54)
        Me.btnPrediksi.TabIndex = 10
        Me.btnPrediksi.Text = "PREDIKSI KELULUSAN"
        Me.btnPrediksi.UseVisualStyleBackColor = True
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(38, 201)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(41, 13)
        Me.lblHasil.TabIndex = 11
        Me.lblHasil.Text = "HASIL:"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 308)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnPrediksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRapor5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRapor4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRapor3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRapor2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRapor1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PREDIKSI KELULUSAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRapor1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRapor2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRapor3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRapor4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRapor5 As System.Windows.Forms.TextBox
    Friend WithEvents btnPrediksi As System.Windows.Forms.Button
    Friend WithEvents lblHasil As System.Windows.Forms.Label

End Class
