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
The days of the week are a universal time system with one big constant – that there are only seven days of the week: nothing more and nothing less. Initially presented, if we wanted to present the days of the week as a string or an integer...

.. code-block:: csharp
  :linenos:

  string dayOfTheWeek = "Tuesday";
  int dayOfTheWeek = 2; // Tuesday

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
                if (thankGodIts == Weekday.Friday)
                {
                    Log("Party!");
                }
            }
        }
    }

Enumerators provide concise ways of expressing these constants while also forcing constraints yet being very readable at the same time. While a rose by any other name smells just as sweet, it's not very intuitive reading it as an integer of the value ``1``. Let the enumerators take care of that underlying value while on the surface you can cleanly classify it as a rose. If you know that a variable will only need to store a very limited set of values, consider creating an enumeration type to make management of that variable far, far easier when storyboarding.

.. hint:: Be sure to pay attention to the **scoping** of enumeration types as you work with this. Enumerators are custom variable types, and don't directly belong in things like the ``Generate`` method. More will be explained to you as you go through this section, but just keep especially in mind *where* you're placing your declaration of an enumerator.

Creating Enumerators
--------------------
Enumerators are customized data types of their own. Like how the primitive data types ``int`` and ``float`` are their own entities we can declare variables for, enumeration types are *our own* types that we can declare variables *of* that type. Just as we can have multiple ``int``, ``string``, and ``float`` variables, we can have multiple instances of our enumeration types. However, to properly declare a custom type, it must be done outside the scope of the storybrew script's class we're working with. This is because the contents in our effect, such as ``SampleEffect``, is its own object, and an object like that isn't able to create a custom enumeration type. Once the compiler enters ``SampleEffect`` territory, it's totally dedicated to making the components for that object, not for making new types or anything.

Otherwise, creating a new enumeration type is very similar to :ref:`creating a new array or list <programming_arrays_and_lists_intiializing_arrays>`. Tell the program that you plan to make an enumerator with ``enum``, give your type a name (as per :ref:`proper variable name rules <programming_variables_and_types_naming>`), then create your bracketed collection of constants that will be your enumeration type.

As such:

.. code-block:: csharp
  :linenos:
  :emphasize-lines: 4

  namespace StorybrewScripts
  {
      // A mon is a feudal Japanese emblem representing a proud family clan.
      public enum MonDesign { Kikkomon, Oda, Toyotomi, Tokugawa, Minamoto, Taira, Chiba, Date, Ryukyu, Itsukishima };

      public class MonDisplay : StoryboardObjectGenerator
      {
            public override void Generate()
            {
                // Code here
            }
      }
  }

By default, the underlying type for enumerators are ``int``, with each constant an incremented integral starting from ``0``. That means that the constant ``Kikkomon`` will begin at ``0``, with ``Oda`` being 1, all the way to ``Itsukishima`` being ``9``. It is possible to change the underlying type of each element, such as using a ``byte`` instead. Changing the underlying type can be done by adding a colon and then specifying your type after the enumeration type name, as shown:

.. code-block:: csharp
  :linenos:

  public enum MonDesign : byte { Kikkomon, Oda, Toyotomi, Tokugawa, Minamoto, Taira, Chiba, Date, Ryukyu, Itsukishima };

Only integral-based types like ``int``, ``byte``, ``short``, and ``long`` are acceptable, with the exception of ``char``. However, the difference in memory that each type creates is incredibly minimal, and for the purpose of storyboarding, it's negligible enough to not worry. Just treat it as trivia. Everyone loves trivia.

.. figure:: img/enumeration/soy-sauce.png
   :scale: 100%
   :alt: Kikkoman soy sauce.

   Not to be confused with Kikkoman soy sauce, which has its own proud, Japanese mon emblem at the center. Did you know that the Mitsubishi logo is also styled after the Japanese mon?

It is also possible to assign different values to each constant in the enumeration type. Computed values are also possible. Observe:

.. code-block:: csharp
  :linenos:

  public enum SpiritAnimal {
      Dragon = 14,
      Fox = 36,
      KimKardashian = 40,
      Hifumi = KimKardashian + 29
  }

.. note:: You may have noticed that this code example doesn't end in a semicolon, while the previous examples do. The semicolon is optional, but it helps in a general convention with one-liners to end in a semicolon as opposed to a multi-lined instance. So if you need to use multiple lines for your enumerator types, feel free to exclude the semicolon as well.

Using Enumerators
-----------------
Enumerators are really easy to utilize in your code. Calling any constant for whatever nefarious deeds you have in mind require you to write the enumeration type name, a ``.``, then the constant name. This allows you to do things like assigning enumeration constants into your variables or checking for equality, such as:

.. code-block:: csharp
  :linenos:

  var theMaster = MonDesign.Oda;
  var theSuccessor = MonDesign.Toyotomi;
  var theShogun = MonDesign.Tokugawa;

  if (theShogun == MonDesign.Tokugawa)
    Log("Constructing the Tokugawa shogunate.");

.. figure:: img/enumeration/tokugawa.jpg
   :scale: 80%
   :alt: Tokugawa Ieyasu.

   I\'m here to chuck samurai and sip on green tea, and I\'m all out of green tea.

This is pretty much the basic extents that can be done with enumerators. The rest of this chapter will cover a few miscellaneous uses that enumerators are good for, and a few examples that demonstrate why enumerators are useful in the first place.

Casting
-------
Because enumeration types' underlying values are integral based, it is possible to convert between integers and back by :ref:`typecasting <programming_variables_and_types_casting>`. This allows for useful possibilities such as cleanly converting your enumeration type into a filename, or randomly selecting enumeration values.

.. code-block:: csharp
  :linenos:

  var monImage = GetMapsetBitmap(SourcePath + "/" + Convert.ToString( (int)myMonDesign ) + ".png");
  var randomMon = (MonDesign) Random(0, 10);

.. warning:: As seen in the previous example, it *is* possible to assign variables beyond the range of the amount of constants there are in an enumeration type, such as giving ``randomMon`` a value of ``42`` typecasted to ``MonDesign``. This is **not** encouraged though. While there will not be any syntax errors, the expectation of an enum is that it should hold the constant values given to it. Look at it a week later, and you'll forget that you're a cheeky bastard assigning the value of ``42`` into your variable. It's a recipe for disaster.

System.Enum Methods
-------------------
Because all enumeration types are derived from the ``enum`` type (``System.Enum`` to be more exact), we can take advantage of Enum methods for any enumerator we create. This allows us to take apart components of our ``enum`` into its names or the values they represent. As they return lists, it's easy to iterate through using something like ``foreach`` loop:

.. code-block:: csharp
  :linenos:
  :emphasize-lines: 17,23

  namespace StorybrewScripts
  {
      public enum Rupee
      {
          Green =  1,
          Blue = 5,
          Red = 20,
          Purple = 50,
          Silver = 100,
          Gold = 300
      }

      public class HollaHollaGetDolla : StoryboardObjectGenerator
      {
            public override void Generate()
            {
                foreach (int i in Enum.GetValues(typeof(Rupee)))
                {
                    if(i > 50)
                        Log("Get rich quick with a rupee valued at " + i.ToString());
                }

                foreach (string rupeeName in Enum.GetNames(typeof(Rupee)))
                {
                    Log("Get jiggy with the fine color of " + rupeeName);
                }
            }
      }
  }

You can also take advantage of the fact that ``Enum.GetValues(typeof(Rupee))`` is inherently a list, so you can get its length and work dynamically from there. The following example is a bit more advanced, but it basically generates a whole list containing every enumeration type in ``MonDesign``. It requires the ``System.Linq`` library to use as well.

.. code-block:: csharp
  :linenos:

  var monMax = Enum.GetNames(typeof(MonDesign)).Length;
  var mons = Enumerable.Range(0,monMax).Select(i => (MonDesign)i).ToList();

.. figure:: img/enumeration/tokugawa.jpg
    :scale: 80%
    :alt: Tokugawa Ieyasu.

    Having united all of Japan under a new era of prosperity, Tokugawa now gets to drown in mad all-natural, forests of concubines.

Flags
-----
Enumeration types are also incredibly useful to store if whether attributes have been met or not. These are known as **flags**. You may be familiar hearing the term *flag* if you play any RPG-like or visual novel. For example, killing off the bandits in that cave over there could *raise* a flag with the nearby village, thereby you completing their silly side quest. Some choices you make could *raise* a flag that will force you into that girl's route, such as staying with a girl to listen to their back story more.

.. figure:: img/enumeration/michiru.png
    :scale: 80%
    :alt: Matsushima Michiru.

    Yes, yes, very good... Fall into the trance of the great blonde fake tsundere Michiru and take this route... Yes...

Enumerators work with flags in a slightly contrived way, as inherently it is still an enumeration type. It is easier to simply show an example and explain its components.

.. code-block:: csharp
  :linenos:
  :emphasize-lines: 3, 17, 18

  namespace StorybrewScripts
  {
      [Flags]
      public enum BurgerMenuOrder
      {
          None = 0x0,
          Hamburger = 0x1,
          Cheeseburger = 0x2,
          Fries = 0x4,
          SoftDrink = 0x8,
      }

      public class MyFastFoodExperience : StoryboardObjectGenerator
      {
            public override void Generate()
            {
                BurgerMenuOrder hifumiOrder = BurgerMenuOrder.Hamburger | BurgerMenuOrder.Fries;
                BurgerMenuOrder aobaOrder = BurgerMenuOrder.Cheeseburger | BurgerMenuOrder.Fries | BurgerMenuOrder.SoftDrink;

                Log("Hifumi ordered: " + hifumiOrder.ToString());
                Log("Aoba ordered: " + aobaOrder.ToString());
            }
      }
  }

Good Practices
--------------
