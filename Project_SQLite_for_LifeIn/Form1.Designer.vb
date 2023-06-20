<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnInsert = New Button()
        DG1 = New DataGridView()
        btnShow = New Button()
        txtGenre = New TextBox()
        txtPublication = New TextBox()
        txtISBN = New TextBox()
        txtTitle = New TextBox()
        lblinsert = New Label()
        lblTitle = New Label()
        lbliSBN = New Label()
        lblGenre = New Label()
        lblPublication = New Label()
        txtAuthor = New TextBox()
        lblAuthor = New Label()
        CType(DG1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnInsert
        ' 
        btnInsert.BackColor = SystemColors.ActiveCaption
        btnInsert.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnInsert.ForeColor = Color.Red
        btnInsert.Location = New Point(144, 376)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(181, 50)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' DG1
        ' 
        DG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DG1.Location = New Point(447, 25)
        DG1.Name = "DG1"
        DG1.RowHeadersWidth = 51
        DG1.RowTemplate.Height = 29
        DG1.Size = New Size(966, 334)
        DG1.TabIndex = 1
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = SystemColors.HotTrack
        btnShow.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnShow.ForeColor = Color.Red
        btnShow.Location = New Point(849, 376)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(181, 50)
        btnShow.TabIndex = 2
        btnShow.Text = "Show Books"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(144, 245)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(181, 27)
        txtGenre.TabIndex = 4
        ' 
        ' txtPublication
        ' 
        txtPublication.Location = New Point(144, 310)
        txtPublication.Name = "txtPublication"
        txtPublication.Size = New Size(181, 27)
        txtPublication.TabIndex = 5
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(144, 192)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(181, 27)
        txtISBN.TabIndex = 6
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(144, 96)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(181, 27)
        txtTitle.TabIndex = 7
        ' 
        ' lblinsert
        ' 
        lblinsert.AutoSize = True
        lblinsert.Location = New Point(145, 11)
        lblinsert.Name = "lblinsert"
        lblinsert.Size = New Size(86, 20)
        lblinsert.TabIndex = 9
        lblinsert.Text = "Insert Book:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(97, 99)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(41, 20)
        lblTitle.TabIndex = 11
        lblTitle.Text = "Title:"
        ' 
        ' lbliSBN
        ' 
        lbliSBN.AutoSize = True
        lbliSBN.Location = New Point(94, 195)
        lbliSBN.Name = "lbliSBN"
        lbliSBN.Size = New Size(44, 20)
        lbliSBN.TabIndex = 12
        lbliSBN.Text = "ISBN:"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(87, 248)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(51, 20)
        lblGenre.TabIndex = 13
        lblGenre.Text = "Genre:"
        ' 
        ' lblPublication
        ' 
        lblPublication.AutoSize = True
        lblPublication.Location = New Point(55, 313)
        lblPublication.Name = "lblPublication"
        lblPublication.Size = New Size(86, 20)
        lblPublication.TabIndex = 14
        lblPublication.Text = "Publication:"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(144, 142)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(181, 27)
        txtAuthor.TabIndex = 15
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Location = New Point(80, 145)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(57, 20)
        lblAuthor.TabIndex = 16
        lblAuthor.Text = "Author:"
        ' 
        ' frmPrincipale
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1447, 522)
        Controls.Add(lblAuthor)
        Controls.Add(txtAuthor)
        Controls.Add(lblPublication)
        Controls.Add(lblGenre)
        Controls.Add(lbliSBN)
        Controls.Add(lblTitle)
        Controls.Add(lblinsert)
        Controls.Add(txtTitle)
        Controls.Add(txtISBN)
        Controls.Add(txtPublication)
        Controls.Add(txtGenre)
        Controls.Add(btnShow)
        Controls.Add(DG1)
        Controls.Add(btnInsert)
        Name = "frmPrincipale"
        Text = "BookShop"
        CType(DG1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtPublication As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblinsert As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lbliSBN As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblPublication As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
End Class
