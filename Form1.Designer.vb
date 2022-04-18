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
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BMIresult = New System.Windows.Forms.Label()
        Me.resultBox = New System.Windows.Forms.TextBox()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(120, 102)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 23)
        Me.txtBox1.TabIndex = 0
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(120, 157)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(100, 23)
        Me.txtBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Height (cm) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Weight (kg) :"
        '
        'BMIresult
        '
        Me.BMIresult.AutoSize = True
        Me.BMIresult.Location = New System.Drawing.Point(60, 237)
        Me.BMIresult.Name = "BMIresult"
        Me.BMIresult.Size = New System.Drawing.Size(39, 15)
        Me.BMIresult.TabIndex = 4
        Me.BMIresult.Text = "BMI ="
        '
        'resultBox
        '
        Me.resultBox.BackColor = System.Drawing.Color.Yellow
        Me.resultBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.resultBox.Location = New System.Drawing.Point(120, 234)
        Me.resultBox.Name = "resultBox"
        Me.resultBox.Size = New System.Drawing.Size(100, 23)
        Me.resultBox.TabIndex = 5
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(85, 281)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(135, 23)
        Me.btnResult.TabIndex = 6
        Me.btnResult.Text = "Calculate"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 337)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.resultBox)
        Me.Controls.Add(Me.BMIresult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Name = "Form1"
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BMIresult As Label
    Friend WithEvents resultBox As TextBox
    Friend WithEvents btnResult As Button
End Class
