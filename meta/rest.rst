========
Template
========

..
  Comment. This won't be seen when compiling the document.

Overview
========
This page acts as a good example of using reST, along with some common format constructs that you can use elsewhere. Think of it like a cheatsheet.

A Chapter on Sectioning
=======================
This is the start of a chapter, which is like a big section. You can talk about the main idea here. For instance, we can talk about the cute and shy Hifumi Takimoto.

Sub-Section
-----------
Uses h2 headings and is used for a sub-section. If the chapter consists of numerous sections, use this to help break it down further. Note that we're using a different heading to help denote that this is a different kind of section. reST has that kind of foresight.

Even More of a Minor Section
~~~~~~~~~~~~~~~~~~~~~~~~~~~~
As if that isn't enough, here's a smaller section. Smaller bits of content are appropriate here.

Getting Ridiculous Here...
..........................
This will be the smallest title possible, but I don't think we'd really want to use this one.

.. note:: Be sure to keep an eye out in being consistent with the characters. The levels used are going to be "=, -, ~, ." from biggest to smallest. Also note that your headings' characters need to match the length of the line!

In Summary
----------
We hope that this helped demonstrate the hierarchy of sections!

.. _directives:

Special Formatting Nougats
==========================

Images
------
An image example:

.. image:: img/hifumi_cg.jpg
   :scale: 25%
   :alt: Preview text in case I can't view it!
   :align: right

A figure example:

.. figure:: img/hifumi_cg.jpg
   :scale: 40%
   :alt: Alt text!

   This is the figure caption. The indentation lets reST realize that this is attached to the image. You should use these instead of direct images when wanting to demonstrate a visual example. There must be a blank line after the figure.

Tables
------
Various table directives are possible too. Here we'll show two kinds of tables: the default reST table and CSV tables.

.. table:: La Soleil Employees
   :widths: auto

   =============== ========
      Employee       Role
   =============== ========
   Kashou Mindauki Owner
   Chocola         Waitress
   Vanilla         Waitress
   =============== ========

But sometimes this formatting is inconvenient to type. So here's a CSV table. For more details, refer to `here <http://docutils.sourceforge.net/docs/ref/rst/directives.html#id4>`_.

.. csv-table:: OSB Staff
   :header: "Username", "Server Role"
   :widths: auto

   "BetaStar", "Founder"
   "Exile-", "Founder"
   "Starrodkirby86", "Mentor"
   "Damnae", "Mentor"
   "Naxess", "Mentor"

Cross-Referencing
-----------------
You can cross reference text as well. It works similarly to a GOTO, where you simply label the section you want to redirect, and then refer it like this: :ref:`directives`.

You can also refer to other documents, such as this example to refer back to the overview page. :doc:`overview`.

For more details, refer to `this link <http://www.sphinx-doc.org/en/1.5.1/markup/inline.html#ref-role>`_.

Block-Quotes
------------

Indented text makes a difference.
  Such as this!

But other block-quotes do exist using directives.

.. epigraph::
  "Mouse can every thing."

  -- Angelsim

.. highlights::
  In summary, this stinks!

..
  We can also incorporate mathematical formulas. However, if you want to build this in your local computer, you'll need to install LaTeX.

  .. math::

     \tf[T] $\forall x \exists y \ (y \ is \ prime) \land x < y$

Code Samples
------------
Example of a code-block using C#.

.. warning:: A lot of this code is full of maximum fun!

.. code-block:: csharp
  :linenos:
  :caption: Calculates an interpolated color between ``Color4 a`` and ``Color4 b``.
  :name: ColorLerp

  public Color4 ColorLerp(Color4 a, Color4 b, float blend)
  {
      var vectorColorA = new Vector3(a.R,a.G,a.B);
      var vectorColorB = new Vector3(b.R,b.G,b.B);
      var v = Vector3.Lerp(vectorColorA,vectorColorB,blend);
      return new Color4(v.X,v.Y,v.Z,255);
  }

This example demonstrates highlighting a certain line, and also demonstrates starting a line number from a specific spot. (But the specific line is non-relative to the lineno-start value!)

.. code-block:: csharp
  :linenos:
  :caption: Finds the Manhattan distance (distance in full tiles) from one space to another.
  :name: Manhattan Distance
  :lineno-start: 46
  :emphasize-lines: 2

  public static int manhattanDistance(Coord a, Coord b) {
		return Math.Abs(b.x - a.x) + Math.Abs (b.y - a.y);
	}

This example demonstrates Python highlighting.

.. code-block:: python
  :linenos:
  :caption: A* search algorithm in Python.
  :name: Priority Queue search

  def search(n):

  	def isTooHeavy(cs):
  		cs >= success.moves

  	x = int(n)
  	pq = PriorityQueue()
  	pq.push( PelletState(x), 0 )
  	visited = []
  	success = PelletState(1, 99999999)

  	while pq._queue:
  		currentState = pq.pop()
  		# print( str(currentState.moves) )
  		if not (currentState in visited) and currentState.moves <= success.moves:
  			visited.append(currentState)
  			if currentState.pellets == 1:
  				return currentState
  				# success = currentState if currentState.moves < success.moves else success
  			else:
  				if not isTooHeavy(currentState.moves+1):
  					if not currentState.addFlag:
  						pq.push( currentState.AddOne(), currentState.moves+1 )
  					if currentState.pellets % 2 == 0:
  						pq.push( currentState.DivideGroup(), currentState.moves+1  )
  					pq.push( currentState.RemoveOne(), currentState.moves+1 )

  	return success
