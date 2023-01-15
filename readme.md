<h2>Overview</h2>
<p>This code is a simple Windows Forms application that allows the user to perform basic arithmetic operations (addition, subtraction, multiplication, and division) on two numbers. The user can enter the numbers in the `textBox1` and `textBox2`, and then click on one of the four buttons (`button1`, `button2`, `button3`, `button4`) to perform the corresponding operation. The result is then displayed in the `textBox3`.</p>
<h2>Code Structure</h2>
<p>The code consists of a single form, `Form1`, which contains the following elements:</p>
<ul>
<li>Two text boxes, `textBox1` and `textBox2`, where the user can enter the numbers to be used in the calculations</li>
<li>A third text box, `textBox3`, where the result of the calculation is displayed</li>
<li>Four buttons, `button1`, `button2`, `button3`, `button4`, corresponding to the four arithmetic operations (addition, subtraction, multiplication, and division)</li>
</ul>
<p>The form also contains two event handlers:</p>

<ul>
<li>`button1_Click`: This is the event handler for the addition button. It gets the values from the two text boxes, performs the addition operation, and then displays the result in the third text box.</li>
<li>`button2_Click`, `button3_Click`, `button4_Click`: These are event handlers for the subtraction, multiplication and division button. They work in the same way as button1_Click.</li>
</ul>
<h2>Running the code</h2>
<p>To run the code, you will need the following:</p>
<ul>
<li>Visual Studio or any other IDE that can run C# Windows forms application</li>
<li>.NET Framework 4.8 or higher</li>
</ul>
<p>Once you have the above requirements, you can open the code in your IDE, and then click on the "Start" button to run the application. The form will appear, and you can enter the numbers in the text boxes and then click on the buttons to perform the calculations.</p>
<h2>Additional Considerations</h2>
<p>The code assumes that the user will always enter valid numbers in the text boxes. If the user enters non-numeric characters, the code will throw an exception and the application will crash.</p>
<p>The code doesn't handle the scenario when the text boxes are empty, in that case it will consider the value as 0 and it will not be added to the total.</p>
<h2>Author</h2>
<p>This code was written by David Dgebuadze as a college assignment.</p>
<h2>Conclusion</h2>
<p>This code provides a simple example of how to create a basic Windows Forms application in C#, and how to use the various controls and event handlers to create a user interface that allows the user to perform basic arithmetic operations. It can be used as a starting point for more complex projects, or as a learning tool for those who are new to C# and the .NET Framework.</p>
