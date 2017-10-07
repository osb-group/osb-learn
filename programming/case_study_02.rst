========================================
Case Study 02: Creating Reusable Effects
========================================

A Little Planning Goes a Long Way
=================================
If you've began working with creating your own custom scripted effects, they may look a lot like :ref:`the first case study <case_study_01_tutorial_mode>` or `the Jigoku sample script <https://github.com/Damnae/storybrew/blob/368261a339f3a8e84079241a2f0798fd93962e0f/scripts/Jigoku.cs>`_. While these effects can certainly stand on their own, there are some notable weaknesses when going through with this approach:

- **The code is full of hard, concrete values.** These constant, hard values, while easier in the short term, may end up being hazardous in the future. For instance, consider the hard values used for timing. What if the timing of the map changes, and the offset is no longer accurate? When changing each offset to their correct value, can you be absolutely certain that you've changed each and every one?
- **The code is bloated, lengthy, and relatively difficult to navigate through.** The second law of thermodynamics says that as time marches forward, so does the entropy (or chaos) in the environment. Code is liable to that, especially when there's only one centralized script. Having to continuously scroll in and out, weave through different methods, and diagnose different bugs because methods somehow are fighting against each other are incredibly frustrating ventures that drain time away from actually developing the storyboard.
- **The code is not friendly for reusability.** A script at maximum reusability is a lot like the bundled scripts that come with storybrew. They can immediately function regardless of what project is being developed by being very "plug-and-play" – just change a few configurables and voila! – an awesome effect. A centralized, single script requires a lot more refactoring and restructuring to achieve that same effect for another project. This goes hand in hand with the code having too many hard values that only work best for that specific project.

**The goal of this case study is to help promote creating effects that are more reusable, modular, and easier to experiment and develop.** Working towards this goal is not very difficult at all – in fact, storybrew's structure *encourages* this sort of behavior to foster. Thus, we'll create a more epic storyboard consisting of only a few differently configured effects.

The Map
-------
As with any guide, you'd need to have the reference map to learn from. We'll be using the `yuki. <https://new.ppy.sh/beatmaps/artists/4>`_ song **Be Your Light**.

**Download the reference map by** `clicking this link <https://drive.google.com/file/d/0Bz8tmyefLbRTY0dYVWhDVWd0blk/view?usp=sharing>`_.

If everything imported successfully, you should be greeted with an empty beatmap created by *osb.moe*. With a smooth and cool background, there should be an SB folder with the following contents:

- pixel.png
- arrow.png
- circle.png
- ring.png
- pill.png
- mask.png
- mask-cross.png

As with the first case study, let's set up a game plan of how we want to use these sprites, and the sort of effects we want to use numerous times throughout our storyboard.

Our Goals
---------
For the sake of brevity, let's storyboard roughly the first 30 seconds of this song. Listening to those first 30 seconds, we can split the song up into three, clear sections that will be our *scenes* for the storyboard. Those sections are:

- The first 10 seconds with the chiptune beats.
- The wub-beats and sampled voice starting from 12 seconds.
- The second section of that from 22 seconds to 33 seconds.

Our goal is to create effects that are reusable throughout all three scenes while at the same time creating a really convincing and awesome storyboard. Based on the images we have in our storyboarding folder, we can allocate them into their own special effects. For this tutorial, we'll be using the images for these deeds:

- **pixel.png**, **mask.png**, and **mask-cross.png** would be good as background and foreground overlays, so we can create a general background effect to put as a colored backdrop throughout our three scenes.
- **circle.png** and **ring.png** belong hand-in-hand, so let's create an effect that utilizes both.
- **pill.png** is a particle that might look good in conjunction with waves, so let's create an effect taking advantage of that.
- **arrow.png** can be simple moving particles as their direction is denoted by, which therefore we can use storybrew's built-in Particles effect.

Thus, the sections will be split up as this:

- **Background**. We're going to begin with creating the background effect to get an idea about effect reusability and how flexible you can make a singular effect work in storybrew.
- **Particles**. We'll then insert the bundled Particles effect to begin spicing up the storyboard like a slow, appetizing simmering.
- **CirclePulse**. We'll then create the circle and ring effect by having them pulsate to the beat of the song.
- **Wave**. Finally, we'll create the most elaborate, but flashy effect using ``pill.png`` by designing a sinusoidal wave effect with shockingly cool results.

.. attention:: This case study assumes you've gotten comfortable with all the content up to this point. If any programming concept seems challenging to understand, refer back to the previous chapters and see the examples. Programming is an iterative thing -- we'll be using concepts from if conditions, loops, and even methods!
