===========
Enumeration
===========

Sneak Peek
==========
By the end of this lesson, you should be able to...

- Learn how to create enumeration types and use them in your program.
- When to use enumerators over integers, strings, or other situations.

Enumerators
===========
The days of the week are a universal time system with one big constant – that there are only seven days of the week, nothing more and nothing less. Initially presented, if we wanted to present the days of the week as a string or an integer...

.. code-block:: csharp
  :linenos:

  string dayOfTheWeek = "Monday";
  int dayOfTheWeek = 1; // Monday

Maybe things seem fine and dandy. However, this is susceptible to unintended inputs. We could try to guarantee writing ``"Monday"``, but then there could be strings to not check for, like, ``"monday"``, ``"月曜日"``, or ``"My Super Sweet Quinceanera"``. Having to account for these other inputs when there are clearly only seven days of the week is a bit of an inconvenience.

.. figure:: img/enumeration/arthur_dent.jpg
   :scale: 80%
   :alt: Arthur Dent.

   This must be Thursday. I never could get the hang of Thursdays.

Enter the enumeration type. An **enumerator** defines a set of named constants that a variable can be assigned with. An ``enum`` is declared outside of a class, and then can be utilized from within. Using storybrew and going with the days of the week example:

.. code-block:: csharp
  :linenos:
  :emphasize-lines: 3, 8, 9

  namespace StorybrewScripts
  {
        public enum Weekday { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        public class SampleEffect : StoryboardObjectGenerator
        {
            public override void Generate()
            {
                Weekday thankGodIts = Weekday.Friday;
                if(thankGodIts == Weekday.Friday)
                {
                    Log("Party!");
                }
            }
        }
    }

Enumerators provide concise ways of expressing these constants while also forcing constraints yet being very readable at the same time.

.. rst-class:: medium
.. todo:: Finish off writing this section.

Creating Enumerators
--------------------

Using Enumerators
-----------------

Good Practices
--------------
