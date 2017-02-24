======================================
Scripting on DoubleTime: A Cheat Sheet
======================================

Objects & Layers
================

.. rst-class:: low
.. todo:: It would be nice if we can set up a Pygments language for OSB scripting.


Objects
-------

.. code-block:: c

    Sprite, <layer>, <origin>, "<filepath>", <x>, <y>

Where:

    - **<layer>**: The :term:`layer` you want your sprite to appear on.
    - **<origin>**: The place on the image the (x,y) position will be based on.
    - **<filepath>**: The filename of the image you want.
    - **<x>**, **<y>**: The (x,y) coordinates of where you want to sprite to appear.

Layers
------
The four possible layers you can use are:

    - **Background**
    - **Fail**
    - **Pass**
    - **Foreground**

Origin
------
There are nine possible origin points of an image:

    - **TopLeft**
    - **TopCentre**
    - **TopRight**
    - **CentreLeft**
    - **Centre**
    - **CentreRight**
    - **BottomLeft**
    - **BottomCentre**
    - **BottomRight**

Important Numbers
-----------------
Here are some coordinate related numbers that are good to know:

    - Increasing X values move rightwards. Increasing Y values move downwards.
    - The viewport range for a 4:3 storyboard is **0-640** for X and **0-480** for Y.
    - The viewport range for a 16:9 storyboard is **-107-747** for X and **0-480** for Y.
    - The center of the screen is **(320,240)**.

And some timing-related ones:

    - Every minute is **60000ms**. A command occuring at 02:34:960 does **NOT** occur on 234960, but rather 154960 (120000 + 34960).

Basic Commands
==============

.. code-block:: c
    :caption: The basic format of every storyboard command:

    _<command>,<easing>,<start_time>,<end_time>,<additional_params>

A :term:`command` modifies a property of a sprite from a ``<start_time>`` to an ``<end_time>`` in *ms*. To change the rate of interpolation, specify a value in :term:`easing`. For the specific properties to modify from ``<start_time>`` to ``<end_time>``, refer to the table below. Remember that the actual command does not contain the ``<>`` brackets; they're just there for ease of reference.


.. csv-table:: Commands
   :header: "Command", "Property Change", "Additional Parameters","Notes"
   :widths: auto
   :delim: ;

   F;Opacity;``<start_opacity>,<end_opacity>``;Range is only from 0-1
   M;Position;``<start_x>,<start_y>,<end_x>,<end_y>``;Refer to Important Numbers for bounds
   MX;X Position;``<start_x>,<end_x>``;
   MY;Y Position;``<start_y>,<end_y>``;
   S;Scale;``<start_scale>,<end_scale>``;Minimum is 0,1 is 100% scale (default)
   V;Scale X / Scale Y;``<start_scale_x>,<start_scale_y>,<end_scale_x>,<end_scale_y>``;Same as scale
   R;Rotation;``<start_rotation>,<end_rotation>``;Uses radians and not degrees
   C;Color;``<start_r>,<start_g>,<start_b>,<end_r>,<end_g>,<end_b>``;Uses RGB from 0-255

.. warning:: Remember that **M** and **MX/MY** and **S** and **V** are like oil to water with each other: they can't be mixed together, or else unintended effects may happen.

Additional Commands
===================

.. code-block:: c
    :caption: The basic format for a Parameter command.

    _P,<easing>,<start_time>,<end_time>,<parameter_id>

A parameter command will apply a special property to a sprite during ``<start_time>`` to ``<end_time>``. ``<easing>`` has no actual effect here.

.. csv-table:: Parameter Commands
   :header: "Parameter ID", "Property"
   :widths: auto

   "H", "Flip Horizontal"
   "V", "Flip Vertical"
   "A", "Additive Blending"

Audio
-----
.. code-block:: c
    :caption: An audio object.

    Sample,<time>,<layer>,"<filepath>",<volume>

Where:

    - **<time>**: When you want the audio sample to play.
    - **<layer>**: The :term:`layer` you want your audio to appear on (only relevant for **Passing** and **Failing**).
    - **<filepath>**: The filename of the image you want.
    - **<volume>**: 0-100. (100 default)

.. note:: Storyboarded audio samples are not affected by the HT, DT, or NC mods.


Compound Commands
=================

Loops
-----

.. code-block:: c
    :caption: The basic format of every loop command:

    _L,<start_time>,<iterations>
    __<commands_go_here>

A loop command will execute the commands inside the loop beginning at ``<start_time>``, and will repeat for ``<iterations>``. The length of the iterations is determined by the latest ``<end_time>`` from the inner commands.

.. warning:: A common pitfall beginner storyboarders fall for is having the loop's inner commands NOT begin from 0, and instead start from the time they want, such as from 7693. However, the times applied in the inner commands *add onto* the loop's ``<start_time>``. Basically, consider the commands from within as **relative** to ``<start_time>``.

Trigger Loops
-------------

.. code-block:: c
    :caption: The basic format of every trigger condition command:

    _T,<trigger_type>,<start_time>,<end_time>
    __<commands_go_here>

When ``<trigger_type>`` is fulfilled during ``<start_time>`` to ``<end_time>``, the trigger loop block will execute.

All valid trigger conditions:

    - HitSound[SampleSet][AdditionsSampleSet][Addition][CustomSampleSet]
        - Each argument is optional.
        - **[SampleSet]** / **[AdditionsSampleSet]**: ``All``, ``Normal``, ``Soft``, or ``Drum``.
        - **[Addition]**: ``Whistle``, ``Finish``, or ``Clap``
        - **[CustomSampleSet]**: ``0`` for default, any number otherwise for that custom sample override
    - Passing
        - Transition to Passing
    - Failing
        - Trasition to Failing


.. warning:: As with the loop command, the times for the inner commands are **relative** to ``<start_time>`` for the trigger condition.

Shorthand Commands
==================

Same Command, Same Duration, In Sequence
----------------------------------------
.. code-block:: c
    :caption: Same command, same duration, in sequence

    _<command>,<easing>,<start_time_1>,<end_time_1>,<params_1>,<params_2>,..<params_n>


Start and End Values are the Same
---------------------------------
.. code-block:: c
    :caption: Start and End Values are the Same

    _<command>,<easing>,<start_time>,<end_time>,<start_params>

Start and End Times are the Same
--------------------------------
.. code-block:: c
    :caption: Start and End Times are the Same

    _<command>,<easing>,<start_time>,,<params>
