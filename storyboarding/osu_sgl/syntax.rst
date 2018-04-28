==============
osu!SGL Syntax
==============

  :caption: Introduction!

Welcome
=======
.. todo:: Basic commands


Initializing an element
-----------------------

 .. code-block:: c
  :linenos:
  :caption: An example of declaring an (element) object in SGL
  :name: Declaration

  var sidetail = new Sprite("SB/sidetail.png");

  First, ``var`` declares that the line you are declaring a new *var*iable and ``sidetail`` is a ``name`` of the variable. After equals sign, ``new`` notes that you are initiating new object. You are now telling computer to make a small area in the computer memory (RAM) to make space for a variable called ``sidetail``! Lastly ``("SB/sidetail.png");`` will let program know that where the elements are located. In this case, the picture of sidetail.png is inside of the folder called SB (a very typical case).

  .. note:: You only need to declare var once per name.

  You can also define more about the element!


Initializing an element (in more detailed way)
-----------------------

.. code-block:: c
  :linenos:
  :caption: An example of declaring an (element) object in SGL in more detailed way
  :name: Declaration

  var sidetail = new Sprite("SB/sidetail.png", Background, Centre);

  This is very much the same thing as one example above, however you just declared more specific things about the element. Now the ``sidetail`` element is now part of ``background`` group, and pivot & position is now centre of image!

  .. note:: If you did not declare ``Background, Centre``, it is automatically a foreground object with top-left pivot.


Move
----

One of the most basic command out of 5 commands is to ``move`` a sprite.

 .. code-block:: c
  :linenos:
  :caption: An example of move command in SGL
  :name: Move

  var sidetail = new Sprite("SB/sidetail.png");
  sidetail.move(1000, 2000, 300, 400, 500, 600);

``move`` command above takes 6 parameters:
- First two being startTime (when it should start in milliseconds), and endTime (when it should finish moving in milliseconds).
- Next two being initial position of x and y. From the example, 300 being initial X-axis and 400 being Y-axis.
- Last two being final position of x and y. At 2000ms, the element should be on 500 on X-axis and 600 on Y-axis (according to sample code above).

