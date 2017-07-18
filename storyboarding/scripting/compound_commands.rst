=================
Compound Commands
=================

Sequence Break
==============

.. _storyboarding_scripting_compound_commands_loop:

Loop
====
.. Storyboard loops
.. Remember that the numbers are based off 0!

Trigger
=======
.. Originally called trigger-loops lol

There is one mechanic within storyboarding that will allow you to create some sort of interactive effect with what is happening during gameplay: Triggers.
Triggers can catch certain events and execute basic commands on your sprite in response.

.. note:: Triggers are the most complex command currently provided by the storyboarding API and unfortunately they are accordingly buggy.
There is a whole batch of weird behaviour attached to the use of triggers that will mainly be covered at the end of this chapter in order to not distract from the core concepts of triggers.

Syntax
------
Like every other command, a trigger is always attached to a sprite or animation.

Triggers consist of merely 4 elements:
    - command-character
    - trigger condition
    - time window
    - trigger group (optional)

After the trigger command you have to list the commands that are to be executed when the trigger condition occurs.

.. code-block:: python
  :linenos:
  :caption: An example of using a simple trigger.
  :name: TriggerSyntax

  Sprite,Background,Centre,"sb\aobachibisticks1.png",192.625,140
   F,0,23500,,0
   S,0,23500,,0.2
   T,HitSoundSoft,0,105330
    F,0,0,,1
    F,0,110,,0

*T* is they character marking the triggercommand.
*HitSoundSoft* is the trigger condition. You will learn about the different kinds of trigger conditions in the next chapter.
*0,105330* marks start- and endtime of the trigger. There is no limit to how often a trigger can be executed within the specified timeframe.

The Fade commands after the trigger command are indented by one additional whitespace or underscore to mark them as belonging to the trigger.
It is very important to notice that the time values specified for these commands are **relative** to the time when the trigger starts executing.
Example: If the trigger condition is met at 23918 the sprite will change to 100% opacity at 23918 and fade out at 24028.
This behaviour assures that there a trigger can be executed multiple times.

Trigger Conditions
------------------
Triggering a trigger is very similar to triggering a trap:
It will snap once someone steps into it.
It is not *that* simple though. Our traps have different tastes and they are picky to different degrees.
Let's check how we can satisfy the taste of each of our traps.

Hitsounds
~~~~~~~~~
The first big chunk of possible trigger conditions consists of hitsounds. Every time a note is hit, a hitsound will be played. But Hitsound does not equal Hitsound:
There are as many possible different triggers for hitsounds in a map as hitsounds available.

How do we specify the hitsound we want to have our trap snap on?

This is easy. The naming for the according trigger follows a simple naming scheme as shown in the following table:

.. rst-class:: table table-sm table-hover table-striped
.. csv-table:: Hitsound Trigger Conditions
   :header: "Condition Type", "Name of Sampleset", "Additional", "Number of Sampleset", "Triggername"
   :widths: auto

   "Hitsound", "Soft", "Whistle", "1", "HitsoundSoftWhistle1"
   "Hitsound", "Drum", "", "", "HitsoundDrum"
   "Hitsound", "", "Clap", "", "HitsoundClap"
   "Hitsound", "", "", "4", "Hitsound4"
   "Hitsound", "Normal", "", "2", "HitsoundNormal4"
   "Hitsound", "", "Finish", "0", "HitsoundFinish0"

   The columns are very easy to understand when you are familiar with hitsounding. Aside from the prefix "Hitsound" you can individually add or leave out a specification of your hitsound.
   If you don't know what any of these mean, consider reading `a guide on hitsounding <https://osu.ppy.sh/s/224758#refrole>`_.

 .. warning:: While the naming of the triggers suggests that it checks which hitsound is played, this is actually not the case!
    Changing the sampleset of a note via the per-note quickaccess on the top left of the editor(Shift+Q/W/E/R) or via Sample Import will be ignored for the sake of evaluating triggers.
    You **always** have to change your samplesets via inherited timing sections if you want your Hitsound triggers to work correctly.

Change of Gamestate
~~~~~~~~~~~~~~~~~~~


Example
-------


Trigger Groups
--------------

Pitfalls
--------

Interaction with commands outside of the trigger
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Interaction with other triggers
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
