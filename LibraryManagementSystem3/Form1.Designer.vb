<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Title = New Label()
        Author = New Label()
        YearPublished = New Label()
        Genre = New Label()
        txtTitle = New TextBox()
        txtGenre = New TextBox()
        txtYearPublished = New TextBox()
        txtAuthor = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Location = New Point(28, 18)
        Title.Name = "Title"
        Title.Size = New Size(38, 20)
        Title.TabIndex = 0
        Title.Text = "Title"
        ' 
        ' Author
        ' 
        Author.AutoSize = True
        Author.Location = New Point(28, 47)
        Author.Name = "Author"
        Author.Size = New Size(54, 20)
        Author.TabIndex = 1
        Author.Text = "Author"
        ' 
        ' YearPublished
        ' 
        YearPublished.AutoSize = True
        YearPublished.Location = New Point(28, 76)
        YearPublished.Name = "YearPublished"
        YearPublished.Size = New Size(101, 20)
        YearPublished.TabIndex = 2
        YearPublished.Text = "YearPublished"
        ' 
        ' Genre
        ' 
        Genre.AutoSize = True
        Genre.Location = New Point(28, 107)
        Genre.Name = "Genre"
        Genre.Size = New Size(48, 20)
        Genre.TabIndex = 3
        Genre.Text = "Genre"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(151, 11)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(125, 27)
        txtTitle.TabIndex = 4
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(151, 113)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 6
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(151, 80)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(125, 27)
        txtYearPublished.TabIndex = 7
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(151, 47)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(125, 27)
        txtAuthor.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(390, 13)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(390, 48)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(390, 78)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(390, 113)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 182)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(511, 188)
        DataGridView1.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtAuthor)
        Controls.Add(txtYearPublished)
        Controls.Add(txtGenre)
        Controls.Add(txtTitle)
        Controls.Add(Genre)
        Controls.Add(YearPublished)
        Controls.Add(Author)
        Controls.Add(Title)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Author As Label
    Friend WithEvents YearPublished As Label
    Friend WithEvents Genre As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
