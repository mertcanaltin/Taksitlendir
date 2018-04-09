<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FiyatTextBox = New System.Windows.Forms.TextBox()
        Me.KDVTextBox = New System.Windows.Forms.TextBox()
        Me.KDVliFiyatTextBox = New System.Windows.Forms.TextBox()
        Me.TaksitlerListBox = New System.Windows.Forms.ListBox()
        Me.TaksitlendirButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TaksitSayisiTextBox = New System.Windows.Forms.TextBox()
        Me.ToplamOdenenLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün Fiyatı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KDV Oranı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KDV'li Fiyat:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Taksitler"
        '
        'FiyatTextBox
        '
        Me.FiyatTextBox.Location = New System.Drawing.Point(83, 19)
        Me.FiyatTextBox.Name = "FiyatTextBox"
        Me.FiyatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FiyatTextBox.TabIndex = 4
        '
        'KDVTextBox
        '
        Me.KDVTextBox.Location = New System.Drawing.Point(120, 45)
        Me.KDVTextBox.Name = "KDVTextBox"
        Me.KDVTextBox.Size = New System.Drawing.Size(63, 20)
        Me.KDVTextBox.TabIndex = 5
        '
        'KDVliFiyatTextBox
        '
        Me.KDVliFiyatTextBox.Location = New System.Drawing.Point(83, 71)
        Me.KDVliFiyatTextBox.Name = "KDVliFiyatTextBox"
        Me.KDVliFiyatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KDVliFiyatTextBox.TabIndex = 6
        '
        'TaksitlerListBox
        '
        Me.TaksitlerListBox.FormattingEnabled = True
        Me.TaksitlerListBox.Location = New System.Drawing.Point(25, 148)
        Me.TaksitlerListBox.Name = "TaksitlerListBox"
        Me.TaksitlerListBox.Size = New System.Drawing.Size(158, 147)
        Me.TaksitlerListBox.TabIndex = 7
        '
        'TaksitlendirButton
        '
        Me.TaksitlendirButton.Location = New System.Drawing.Point(25, 314)
        Me.TaksitlendirButton.Name = "TaksitlendirButton"
        Me.TaksitlendirButton.Size = New System.Drawing.Size(158, 23)
        Me.TaksitlendirButton.TabIndex = 8
        Me.TaksitlendirButton.Text = "Taksitlendir"
        Me.TaksitlendirButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Taksit Sayısı:"
        '
        'TaksitSayisiTextBox
        '
        Me.TaksitSayisiTextBox.Location = New System.Drawing.Point(97, 97)
        Me.TaksitSayisiTextBox.Name = "TaksitSayisiTextBox"
        Me.TaksitSayisiTextBox.Size = New System.Drawing.Size(86, 20)
        Me.TaksitSayisiTextBox.TabIndex = 10
        '
        'ToplamOdenenLabel
        '
        Me.ToplamOdenenLabel.AutoSize = True
        Me.ToplamOdenenLabel.Location = New System.Drawing.Point(144, 298)
        Me.ToplamOdenenLabel.Name = "ToplamOdenenLabel"
        Me.ToplamOdenenLabel.Size = New System.Drawing.Size(13, 13)
        Me.ToplamOdenenLabel.TabIndex = 11
        Me.ToplamOdenenLabel.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 371)
        Me.Controls.Add(Me.ToplamOdenenLabel)
        Me.Controls.Add(Me.TaksitSayisiTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TaksitlendirButton)
        Me.Controls.Add(Me.TaksitlerListBox)
        Me.Controls.Add(Me.KDVliFiyatTextBox)
        Me.Controls.Add(Me.KDVTextBox)
        Me.Controls.Add(Me.FiyatTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FiyatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KDVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KDVliFiyatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaksitlerListBox As System.Windows.Forms.ListBox
    Friend WithEvents TaksitlendirButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TaksitSayisiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToplamOdenenLabel As System.Windows.Forms.Label

End Class
