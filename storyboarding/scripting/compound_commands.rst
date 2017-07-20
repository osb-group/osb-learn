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

.. code-block:: c
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

The columns are very easy to understand when you are familiar with hitsounding. Aside from the prefix "Hitsound" you can individually add or leave out a specification of your hitsound to get the exact hitsound or combination of hitsounds you want.
If you don't know what any of these mean, consider reading `a guide on hitsounding <https://osu.ppy.sh/s/224758#refrole>`_.

 .. warning:: While the naming of the triggers suggests that it checks which hitsound is played, this is actually not the case!
    Changing the sampleset of a note via the per-note quickaccess on the top left of the editor(Shift+Q/W/E/R) or via Sample Import will be ignored for the sake of evaluating triggers.
    You **always** have to change your samplesets via inherited timing sections if you want your Hitsound triggers to work correctly.

.. note:: You might have noticed that there is no option to catch a hitnormal alone. This is very annoying when you want to catch hitnormals along with other notes that actually have finishers.
  It can be worked around by changing the sampleset for these notes so you can use ``Hitsound5`` or something like that but it requires a lot of manual effort nonetheless.
  If you wonder why this is the case, the answer is that hitnormals work for everyone differently. Currently there is the option to configure the option ``LayeredHitSounds`` in your ``Skin.ini`` to 0 causing hitnormals no longer be played on notes that have additionals.
  As this is a setting determined by the user in most cases, there is no way to get a consistent experience for all players without the already mentioned workaround anyway.

Change of Gamestate
~~~~~~~~~~~~~~~~~~~
.. it is safe to say that Passing/Failing triggers literally don't work in CtB and Mania

Example
-------
Aoba wants to play the Taiko drum! She is very inexperienced but maybe you can help her out?

.. image:: img/aobaTaiko.png
  :scale: 20%
  :alt: Full of optimism: Aoba
  :align: left

.. image:: img/drum.png
  :scale: 20%
  :alt:  ...and the Taiko drum!
  :align: right

If you aren't familiar with Taiko mapping, no problem, we got that covered in a few words.
There are 2 types of notes in Taiko, Don (red) and Kat (blue). If it has a whistle and/or clap hitsound attached it is a Kat, otherwise it is a Don note.

We can make Aoba hit the drum by catching the respective trigger conditions:
These would be ``HitsoundWhistle`` and ``HitsoundClap`` for Kat.
For Don we have to create a workaround and give each note a separate Hitsoundset because we can't react to the hitnormal without reacting to the additionals as well.
So let's say we put Hitsoundset 4 for each Don, meaning we have to catch ``Hitsound4``.

To make this as simple as possible in terms of example, we'll introduce 2 more versions of Aoba in which she is using one or the other drumstick to hit the Taiko.
We will also put one of her pigtails into a differentsprite so that we can display the drumsticks in front of the drum but her hair behind it.

.. image:: img/aobaTaikoIdle.png
  :scale: 20%
  :alt: Full of optimism: Aoba
  :align: left






Trigger Groups
--------------

Pitfalls
--------

Interaction with commands outside of the trigger
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Interaction with other triggers
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Supported hitobjects
~~~~~~~~~~~~~~~~~~~~
