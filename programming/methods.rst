=======
Methods
=======

Sneak Peek
==========
By the end of this lesson, you should be able to...

- Understand the concept of methods, their practicality in programming, and the different nature and flow methods create in a program.
- Learn how to utilize parameters inside methods, and understand returning a value.
- Learn about method shorthands and special parameter keywords to better customize your method making skills and flourish!

The Premise
===========
Dance choreography is a beautiful art full of intricate steps, twirls, movements, and timing. When trying to memorize a dance routine, it can be thought up of various steps done in sequence. *Left step, left step, then right step, right step, and jump.* And repeat. If we pretend this to be like our own pseudocode, it can look a little like this:

.. code-block:: csharp
  :linenos:

  StepUp();
  StepUp();
  StepDown();
  StepDown();
  StepLeft();
  StepRight();
  StepLeft();
  StepRight();
  Boogie();
  Acrobatics();
  StartAgain();

Don't worry about the parentheses for now, as it's just there to help differentiate between saying that we're *doing* something than it being a variable. Think a verb versus a noun.

Continuing on, this code block is a bit contrived for a dance routine – *especially* when we think about every little dance step. As the dancer, these steps eventually become muscle memory, and the whole sequence becomes rather memorable to execute. Let's give these steps a catchy name, like the *Konami dance*. But that's obviously not the entire choreography, else we just freestyle and embarrass ourselves. There are other sequences of steps and motions to memorize, and those too have their own individual steps.

.. figure:: img/methods/idols_dancing.gif
   :scale: 100%
   :alt: Idols from Love Live strutting their stuff.

   Unlike this. This is just a looped .gif. A butt-shaking, mesmerizing, looped .gif. What does your head say when it reads "gif" out loud? Like gift? Like jiffy? How spiffy, the thought of it so.

Say that the main segment of the routine starts off with doing the Konami dance twice, then the chicken dance, then the Konami dance again. After mastering the Konami dance enough times, does it *really* become the individual steps to singly memorize, or is it now a cohesive set of steps *grouped* together, to be executed whenever on cue? We look at the code-block again, and if we *didn't* fully master or realize the sequence that is the Konami dance, our routine may have to end up looking like this:

.. code-block:: csharp
  :linenos:

  StepUp();
  StepUp();
  StepDown();
  StepDown();
  StepLeft();
  StepRight();
  StepLeft();
  StepRight();
  Boogie();
  Acrobatics();
  StartAgain();

  StepUp();
  StepUp();
  StepDown();
  StepDown();
  StepLeft();
  StepRight();
  StepLeft();
  StepRight();
  Boogie();
  Acrobatics();
  StartAgain();

  ChickenDance();

  StepUp();
  StepUp();
  StepDown();
  StepDown();
  StepLeft();
  StepRight();
  StepLeft();
  StepRight();
  Boogie();
  Acrobatics();
  StartAgain();

If the previous code-block was convoluted with steps, this one is far worse. The real kicker is the fact that it's the *same* steps again and again, but it's being done as if they're individual dance bouts that aren't realized or grouped as the Konami dance. What's better for all of our sanity is something like this:

.. code-block:: csharp
  :linenos:

  KonamiDance();
  KonamiDance();
  ChickenDance();
  KonamiDance();

With the sequence ``KonamiDance()`` to be the motion that we've practiced and memorized earlier, any instance we're to do such a dance, we know what to do on the spot, without any need to focus on the individual steps. All because it's muscle memory to us.

.. figure:: img/methods/maki.gif
   :scale: 80%
   :alt: Nishikino Maki dancing.

   The real reason why I'm starting off with a dance lesson is so I can post images like this and call it educational.

Back to the Programming World
-----------------------------
In actuality, this little happy episode about dancing and choreography is a lot like the concept of methods. A **method** is a procedure an object can execute, and in that procedure, a sequence of commands can undergo a variety of different behaviors – whether it'd be doing the Konami dance, finding the maximum value in an array, or creating a sprite into a storyboard. Whenever we *call* a method, such as storybrew calling the *Generate* method, we tell the object to carry out a task, which in this case, is generating the effect.

We have, in fact, been using methods to carry out a plethora of tasks in our code already! If you've used the ``Log`` method in trying to debug or verify values in your code, then you've used a method, with the task being to send this message we give to ``Log`` and display it in storybrew's interface. Under the hood, there's a few complex things going on to make that happen, but in the end, the program ends with displaying it all in a pristine logged message for us to see. Just like the Konami dance is that behind-the-scenes set of dance steps we execute, ``Log`` is no different.

.. figure:: img/methods/logs.png
   :scale: 100%
   :alt: A bundle of logs.

   Us programmers are so insecure and unsure about our work that we have to ask this bundle of logs if everything is OK.

Methods don't need to be limited to some set of procedures that don't directly communicate back to us. There are methods where we can give a method some data, and we expect to get data in return. For instance, a popular method in OpenTK's MathHelper library is the method ``DegreesToRadians``. As the name implies, if we pass some degrees value, it'll give us back that same value, expect in radians. This is perfect if we needed to use the Rotate storyboard command, as that handles all its angles in radians.

We'll first talk about how methods are created and used, and also provide practical examples to apply our newfound knowledge.

Creating and Using Methods
==========================

A method must be declared inside the scope of a class. When we consider the philosophy of object-oriented programming, the **class** is essentially a custom object that we add data and behavior into. Often this object then gets called elsewhere in a program, using the data members and methods that we've defined into it. The same applies for storyboarding – each script creates a unique class (or object) that we define data (such as configurables) and behavior (like the ``Generate`` method).

Method Signatures
-----------------

The first component of a method is its signature. The **method signature** is the basic definition of a method. Similar to declaring the variable, we're simply declaring a method into existence. That pretty much means we're declaring the name of the method, the method type, and whether we want this method to accept inputs (like how ``DegreesToRadians`` does). Because it's a component of the class, it's also important for us to provide the **access level** of the method, which is basically whether or not this method is for internal use only or if other objects can use it freely. Let's provide an example of a method signature by providing a rather quick and dirty method here:

.. code-block:: csharp
  :linenos:

  public void LogFriendlyMessage()
  {
      Log("Hello! This is your daily friendly reminder to actually go outside for once.");
      Log("The sun is very concerned about your activity indoors and would like to see your beautiful face.")
      Log("... Just kidding. The sun just wants to burn that pasty skin to a pulp.");
  }

Breaking down the method signature we first begin with the **access level** keyword. The most important ones to consider are whether a method is **public** or **private**. A **public** method is accessible by any object, even different ones that are not of the same class. A **private** method is the opposite – the method would only be accessible to itself, and only itself. For most of your needs in storybrew, it's best to just use the ``public`` keyword and call it a day, as the problems access levels try to solve are not ones seen in beginning programming nor creating effects in storyboarding.

.. note:: Not including the access level for a method signature would automatically make the method **private**. This is the same case when specifying access levels for data members of an object too. This would be a rather harrowing problem if another object wants to use that method. For instance, if the ``Generate`` method had no ``public`` access level, storybrew would be unable to actually render the effect, as it's a foreign object trying to access the ``Generate`` method.

After the access level, we have the **return type** of a method. Some methods, like ``DegreesToRadians``, give information back to us. The data type of that information would belong here. If we aren't planning to return any information to the caller, then we say that the method is **void**, or lacking a return type.

Now we finally reach the method name itself, and if we want to pass any information into the method. This information passing through into the method are known as **method parameters**. Enclosed in the parentheses following the method name, the parameters are defined essentially as variable declarations separated by commas. For ``LogFriendlyMessage``, we don't use any parameters, so we'll only need to have a set of empty parentheses.

The access level, return type, method name, and parameters all compose together as the unique **signature** for a method. That means it's entirely possible to have a method of the same name, but with different return types or parameters. This allows for a method to have more flexibility in different situations, a concept known as **method overloading**.

After the method signature comes the actual content of the method itself. As you can see, it's not unlike the bracketed bits we see in chapters like :ref:`Decision Making <programming_decision_making>` or :ref:`Loops <programming_loops_while_loop>`. We'll discuss the scope and inner contents of these methods as we move into method parameters.

Parameters
----------
While some methods are purely procedural, others act like the cooking system in a modern RPG. You go ahead and pick ingredients, the game checks to see if your recipe is legit, and out comes your successful (?) work of art!

.. figure:: img/methods/cooking_with_link.gif
   :scale: 100%
   :alt: Link cooking in Breath of the Wild.

   If only cooking can be this bouncy and fun! (And just tossing a bunch of ingredients together creates some magical recovery item...)

These ingredients are essentially the inputs for your method, known as the method's **parameters**. These inputs are defined similarly to variable declarations, with a type and variable name to be used and calculated inside the method. Multiple parameters can be used by simply separating each one with a comma. Within the scope of the method, they become bona-fide variables that you can use for whatever calculation you need.

Remember that the method's definition is outside the scope of something like the ``Generate`` method, meaning that variables declared within ``Generate`` absolutely do not exist inside the method definition. If you want to *pass* these values into the method, you'd have to send the values off into the parameters, as if your variables are the ingredients for your cooking show.

Finally, methods can return back to us information that's calculated or concluded based upon the inputs we shove into it. If we shoved a ton of Hylian Mushrooms and Hearty Durians into our cooking pot, we should expect to get a delicious fruits and mushroom platter back. This is the **return value** of the method. We first must declare the return type in the method signature, and from that point, create a ``return`` statement that contains data of the same type. This data will be the item that's getting returned. Any method that has a non-void return type *must* have some way of returning a value.

To get a better picture of using methods, let's take a look at a real-life example of a method with OpenTK's ``DegreesToRadians`` method in the MathHelper library.

Example 1: Degrees to Radians
=============================
Degrees and radians are the most prominent units of measurement for angles. While degrees are generally more intuitive to calculate and estimate with, the storyboard engine's Rotate command only accepts angle measurements in radians. This calls for converting the units. The conversion of degrees to radians is not a particularly tricky one, as it involves multiplying the degree value by ``π  / 180.0`` degrees. This allows the liberty of using degrees, and then converting into radians, in something like:

.. code-block:: csharp
  :linenos:

  // Assuming a sprite has already been declared prior
  // Rotate a sprite from 0 to 45 degrees from 0ms to 10000ms
  int girlYoureAcute = 45;
  sprite.Rotate(0, 10000, 0, girlYoureAcute * (Math.PI / 180.0));

While this solution *does* work, its readability can be dramatically improved. When it comes to stellar programming, a major goal is to strive for ease of reading. This is where we'll introduce OpenTK's ``DegreesToRadians`` method.

.. code-block:: csharp
  :linenos:
  :caption: For a full source, refer to viewing ``opentk/blob/master/Source/OpenTK/Math/MathHelper.cs`` at the `official repo <https://github.com/mono/opentk/blob/master/Source/OpenTK/Math/MathHelper.cs#L244>`_ .
  :lineno-start: 244

  public static double DegreesToRadians(double degrees)
  {
      const double degToRad = System.Math.PI / 180.0;
      return degrees * degToRad;
  }

Let's first break this down by the method signature.
- Because of the ``public`` keyword, ``DegreesToRadians`` has a public access level, allowing any object to use this method.
- Because of the ``static`` keyword, an instance of ``MathHelper`` does not need to be created in order to use ``DegreesToRadians``. For a library with utility methods, this is obviously a necessity.
- Because of the ``double`` keyword, the return type for ``DegreesToRadians`` is the type ``double``. This also means that there **needs** to be a return value whose value is also a ``double``.
- ``DegreesToRadians`` is the name of the method. Oh snap!
- The method takes in one parameter, a type ``double`` named ``degrees``.

From then, the ``degToRad`` ratio is calculated (set as ``const`` because this value will *never* change), and then, the final value ``degrees * degToRad``, gets returned back to where the method was called. This means that our code-block earlier ends up looking like this when ``DegreesToRadians`` is used instead:

.. code-block:: csharp
  :linenos:

  // Assuming a sprite has already been declared prior
  // Rotate a sprite from 0 to 45 degrees from 0ms to 10000ms
  int girlYoureAcute = 45;
  sprite.Rotate(0, 10000, 0, MathHelper.DegreesToRadians(girlYoureAcute));

While the character length between the two are identical, the advantage this change of code makes is that the method name, ``DegreesToRadians`` literally tells the reader what's going on. It then means that we should trust the method to give us back the radians equivalent of ``girlYoureAcute`` to be rotated.

That value, ``girlYoureAcute``  gets assigned into the parameter value of ``degrees``. The variables that are passed into the parameters of a method are known as **arguments**. This is how a method can sort of *communicate* with your main part of code. By specifying the right set of parameters, and then using your variables as arguments, methods can be a quick shortcut into performing elaborate behavior for your objects while also helping make your code more readable and easier to work with.

Methods are incredibly important with coding, so let's work with another example.

Example 2: The Distance Formula
===============================

Other Remarks
=============

Expression Body Definitions
---------------------------

.. attention:: Roslyn only.

Special Parameter Keywords
--------------------------

Passing by Reference
~~~~~~~~~~~~~~~~~~~~

Params
~~~~~~

Example 2: Mirrored Coordinates
===============================
