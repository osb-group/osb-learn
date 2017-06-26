========================================
Optimization Practices for Storyboarding
========================================

.. attention:: This chapter is a work-in-progress. You can help improve it by bugging the author, Starrodkirby86.

The Ranking Criteria: From Elite Beat Agents to Particle Visualizer
===================================================================
- Talk about how ranking criteria has changed standards over time
- Talk about the new ranking criteria and its standards
- Following these principles in optimizing a storyboard

When storyboards were first introduced into osu!, they were intended to be in the same style as seen in the background animations of the Ouendan and Elite Beat Agents games: basic slideshows of images, simplistic pass/fail visuals, and a narrative from start to finish. And yet, as osu! continuously grew, more tools became available for development, and innovators stepped up the plate to push the boundaries of storyboarding far more than its original intentions.

.. figure:: img/optimization/inspiration.gif
   :scale: 100%
   :alt: You're The Inspiration visuals in EBA.

   We went from this... (Storyboard is Elite Beat Agents' `You're The Inspiration <https://osu.ppy.sh/s/4365>`_).

.. figure:: img/optimization/nightbird.gif
  :scale: 100%
  :alt: Damnae's Far East Nightbird.

  To this. By golly. (Storyboard is `Damnae's Far East Nightbird <https://osb.moe/showcase/sb/90/>`_).

In this sense, the concerns for storyboards have shifted greatly as well. What initially were concerns about `strobing and a multitude of large images being loaded at one time <https://osu.ppy.sh/wiki/Ranking_Criteria#storyboarding>`_, have now shifted into ones that simply push osu!'s game engine with a sea of sprites coordinating together into something utterly unreal.

.. figure:: img/optimization/world.gif
  :scale: 100%
  :alt: EXECUTION.

  Wrecking computer and game performance, to a beatmap near you! (Storyboard is `Exile-'s world.execute(me) <https://osb.moe/showcase/sb/1/>`_).

As of the last revised date for this article, new efforts in promoting optimization practices to create well-performing storyboards in an era of particle generation have been brought up `here <https://osu.ppy.sh/forum/t/559005>`_.

SB Load
=======
- SB Load will no longer be a metric for ranking criteria
- More accurate guidelines that SB Load can help suggest to you are good though
    - Hidden objects, partially off-screen, obstructed, etc.

Performance Optimization
========================
- Too many particles/sprites at one time
- Too many commands in a short period of time
- Sprites are rendered for too long in a map (this adds up)
    - OSB uses variables (upon loading the map)
    - the OSB file has to make inefficient runs converting a variable into
    - commands, however it does save space

- storybrew renders sprites more efficiently than osu! does, so playtesting needs to be done on osu!
    - Example: Command count
    - Too many commands, osu! may not read every command

File Size Optimiazation
=======================
- Beatmaps have a 30mb limit, or a 100mb for marathons
- Large storyboards often take time loading on osu!, etc.
- Often, a storyboard past 10MB etc is going to begin demonstrating performance drawbacks
- A good storyboarder should ensure that they don't needlessly waste filesize

Performance & File Size Solutions
=================================
Solutions:
- Use less sprites
- Interpolate less
    - Keyframes in Storybrew
- Use storyboarded loops
- Despawn sprites after they're used
- Sprite pools
    - Drawback: Slightly worse performance (a longer rendered sprite)
- yf_bmp's storyboard optimizer


Coding Optimization
===================
- While coding for storyboarding has standard practices, the biggest differences are that...
    - You are not necessarily writing maintainable code
        - Though reusasble effects can help for producing future storyboards
    - Major optimization practices are not as important with storyboarding
        - Often in production-level software engineering, some optimizations include minute things such as memory management or
        very specific algorithms that solve certain problems
            - You *may* not need this, especially if they take far more time to implement than necessary

- These concerns are more founded when you're scaling upwards and are using many commands
- When making an effect, you may consider
    - What is a good working solution for the effect?
    - What can I do to improve it or make it more reusable?

- Nested For-loops
    - Big O
- Infinite loops
    - While / Do-while loops
    - Be careful about making confusing booleans that seem like they may not end

Less Algorithm, More Code Quirks
These practices should not necessarily be used unless your code is already considerably slow, and the bottlenecks such as O() algorithms may have been taken care of. Likely for storyboarding cases they are not important, but for knowledge's sake. <3

- For loops > Foreach loops
- StringBuilder > String for concatenation
- LINQ Queries
    - LINQ queries are efficient code but because they work on an IEnmuerable extensive interface, they may be slower
    - If it's too slow, you may want to opt for a better way of reorganizing a list you're managing to a smaller list or algorithm
    - Or it may be possible to simply implement some searches yourself, for better or worse
    - There is no need to use LINQ queries for small or trivial numeric operations
