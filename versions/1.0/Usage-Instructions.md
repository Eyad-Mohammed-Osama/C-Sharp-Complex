<h1>Usage Instructions</h1>
<p>The <b>complex</b> Class Belongs To The <b>System</b> Namespace,So You Might Want To Add The Following Directive At The Top Of Your Program:</p>

```cs
using System;
```

<p>To Declare A Complex Number You Should Use The Complex Constructor:</p>

```cs
complex a = new complex(_real,_imaginary);
complex b = new complex(_real);
complex c = new complex();
```

<p>Notice That The <b>_real</b> And The <b>_imaginary</b> Parameters Have The Type Double.</p>
<p>The First Example Declares A Complex Number Called <b>a</b> With Both Real And Imaginary Parts.</p>
<p>The Second Example Declares A Complex Number Called <b>b</b> With Only Real Part,The Imaginary Part Is Initialized With The Value <b>0</b>.</p>
<p>The Third Example Declares An Empty Complex Number Called <b>c</b>,This One Is Useful To Store The Value Of Addition Or Multiplication Of Two Complex Number.</p>

<p>You Can Use The <b>real()</b> Method To Get The Value Of The Real Part Of The Declared Complex Number,You Can Also Use The <b>imaginary()</b> Method To Get The Value Of The Imaginary Part Of The Declared Complex Number.</p>

```cs
complex c = new complex(3,4);
Console.WriteLine(c.real()); //Output 3
Console.WriteLine(c.imaginary()); //Output 4
```

<p>Use The <b>norm()</b> Method To Get The Length Of The Complex Number.</p>

```cs 
complex c = new complex(3,4);
Console.WriteLine(c.norm()); //Output 5
```

<p>Use The <b>conjugate()</b> Method To Get The Conjugate Of The Complex Number.</p>
<p>Since <b>conjugate()</b> Returns A <b>complex</b> Object,You Can Use Any Of The Supported Methods With The Returned Value.</p>

```cs
complex c = new complex(3,4);
Console.WriteLine(c.conjugate().real()); //Output 3
Console.WriteLine(c.conjugate().imaginary()); //Output -4
```

<p>The <b>angle()</b> Method Returns The Angle Between The X-Axis And The Straight Line Passing From Point (0,0) And Point(Real_Part,Imaginary_Part) <b>In Radians</b>.</p>

```cs
complex c = new complex(2,2);
Console.WriteLine(c.angle()); //Output 0.785398163397448
```

<p>If You Ever Wanted To Find The Power Of A Complex Number,Just Use The <b>pow()</b> Method.</p>
<p>Since <b>pow()</b> Returns A <b>complex</b> Object,You Can Use Any Of The Supported Methods With The Returned Value.</p>

```cs
complex c = new complex(3,4);

//let's find the value of this complex number to the power 2
Console.WriteLine(c.pow(2).real()); //Output -7
Console.WriteLine(c.pow(2).imaginary()); //Output 24

//let's find the value of this complex number to the power 3
Console.WriteLine(c.pow(3).real()); //Output -117
Console.WriteLine(c.pow(3).imaginary()); //Output 44
```

<p>This DLL Supports The Four Basic Operations,Addition,Subtraction,Multiplication,Division.</p>

```cs
complex a = new complex(1,3); //Declaring And Initializing The Complex Number (a)
complex b = new complex(2,4); //Declaring And Initializing The Complex Number (b)
complex c = a + b; //Store The Value Of (a+b) Inside The Complex Number (c)
Console.WriteLine(c.real()); //Output 3
Console.WriteLine(c.imaginary()); //Output 7
```

<h2>A Full Example</h2>

```cs
using System;

namespace EntryPoint {
  class Entry {
    public static void Main(string[] args) {
      complex a = new complex(3,4);
      
      Console.WriteLine("The Complex Number Is: 3+4i");
      Console.WriteLine("The Real Part Of The Complex Number Is: {0}", a.real());
      Console.WriteLine("The Imaginary Part Of The Complex Number Is: {0}", a.imaginary());
      Console.WriteLine("The Norm Of The Complex Number Is: {0}", a.norm());
      Console.WriteLine("The Phase Angle Of The Complex Number Is: {0}", a.angle());
      Console.WriteLine("The Square Of This Number Is: {0}+{1}i", a.pow(2).real(), a.pow(2).imaginary());
      Console.WriteLine("--------------------------------------------------------------");
      Console.WriteLine("Conjugate:");
      Console.WriteLine("The Conjugate Of The Complex Number Is: 3-4i");
      Console.WriteLine("The Real Part Of The Conjugate Of The Complex Number Is: {0}", a.conjugate().real());
      Console.WriteLine("The Imaginary Part Of The Conjugate Of The Complex Number Is: {0}", a.conjugate().imaginary());
      Console.WriteLine("The Norm Of The Conjugate Of The Complex Number Is: {0}", a.conjugate().norm());
      Console.WriteLine("The Phase Angle Of The Conjugate Of The Complex Number Is: {0}", a.conjugate().angle());
      Console.WriteLine("--------------------------------------------------------------");
      
      complex b = new complex(-1,2);
      
      complex c = a + b;
      complex d = a - b;
      complex e = a * b;
      complex f = a / b;
      
      Console.WriteLine("(3+4i) + (-1+2i) = {0} + ({1})i", c.real(), c.imaginary());
      Console.WriteLine("(3+4i) - (-1+2i) = {0} + ({1})i", d.real(), d.imaginary());
      Console.WriteLine("(3+4i) * (-1+2i) = {0} + ({1})i", e.real(), e.imaginary());
      Console.WriteLine("(3+4i) / (-1+2i) = {0} + ({1})i", f.real(), f.imaginary());
      
      Console.ReadKey();
    }
  }
}
```
