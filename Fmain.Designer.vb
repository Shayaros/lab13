<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        tbx1min = New TextBox()
        tbx1max = New TextBox()
        tbdx1 = New TextBox()
        tbx2min = New TextBox()
        tbx2max = New TextBox()
        tbdx2 = New TextBox()
        gv = New DataGridView()
        btnCalc = New Button()
        btnClear = New Button()
        btnExit = New Button()
        CType(gv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbx1min
        ' 
        tbx1min.Location = New Point(685, 72)
        tbx1min.Name = "tbx1min"
        tbx1min.Size = New Size(113, 23)
        tbx1min.TabIndex = 0
        ' 
        ' tbx1max
        ' 
        tbx1max.Location = New Point(804, 72)
        tbx1max.Name = "tbx1max"
        tbx1max.Size = New Size(113, 23)
        tbx1max.TabIndex = 1
        ' 
        ' tbdx1
        ' 
        tbdx1.Location = New Point(685, 114)
        tbdx1.Name = "tbdx1"
        tbdx1.Size = New Size(113, 23)
        tbdx1.TabIndex = 2
        ' 
        ' tbx2min
        ' 
        tbx2min.Location = New Point(685, 152)
        tbx2min.Name = "tbx2min"
        tbx2min.Size = New Size(113, 23)
        tbx2min.TabIndex = 3
        ' 
        ' tbx2max
        ' 
        tbx2max.Location = New Point(804, 152)
        tbx2max.Name = "tbx2max"
        tbx2max.Size = New Size(113, 23)
        tbx2max.TabIndex = 4
        ' 
        ' tbdx2
        ' 
        tbdx2.Location = New Point(804, 114)
        tbdx2.Name = "tbdx2"
        tbdx2.Size = New Size(113, 23)
        tbdx2.TabIndex = 5
        ' 
        ' gv
        ' 
        gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gv.Location = New Point(490, 181)
        gv.Name = "gv"
        gv.Size = New Size(646, 289)
        gv.TabIndex = 6
        ' 
        ' btnCalc
        ' 
        btnCalc.Location = New Point(609, 487)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(121, 81)
        btnCalc.TabIndex = 7
        btnCalc.Text = "Розрахувати"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(766, 487)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(121, 81)
        btnClear.TabIndex = 8
        btnClear.Text = "Очистити"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(927, 487)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(121, 81)
        btnExit.TabIndex = 9
        btnExit.Text = "Вийти"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Fmain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1359, 761)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalc)
        Controls.Add(gv)
        Controls.Add(tbdx2)
        Controls.Add(tbx2max)
        Controls.Add(tbx2min)
        Controls.Add(tbdx1)
        Controls.Add(tbx1max)
        Controls.Add(tbx1min)
        Name = "Fmain"
        Text = "Form1"
        CType(gv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbx1min As TextBox
    Friend WithEvents tbx1max As TextBox
    Friend WithEvents tbdx1 As TextBox
    Friend WithEvents tbx2min As TextBox
    Friend WithEvents tbx2max As TextBox
    Friend WithEvents tbdx2 As TextBox
    Friend WithEvents gv As DataGridView
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
