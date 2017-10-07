.. _glossary:

========
Glossary
========

This is the glossary containing all the most relevant terms in the documentation. If you need to look up something, this page may not be a bad idea to brandish out that Ctrl+F shortcut!

.. rst-class:: low
.. todo:: Proofread and check for any formatting issues. Fill in remaining blank definitions. Improve existing ones.

.. glossary::

    storyboard
        A customized, background animation for a beatmap. Storyboards can be designed in a variety of ways, but often utilize a variety of effects and visualizations to enhance the player's gameplay experience. The centralized focus for osb.moe.

    object
        The collective term for sprites, animations, and audio samples for a storyboard. The vast majority of storyboards solely use sprites.

    sprite
        An object displayed by a still image. Named just like their computer graphics brethen, or a 2D graphic object. Sprites have various properties that can be manipulated, creating the basics of storyboarding.

    scripting
        The commands that a storyboarder can write to tell osu! what objects to create, where they should appear, and what they should do.

    layer
        A collective group of graphic objects intended to be stacked upon each other, like the spongey layers of a cake. Each layer has its own set of graphical objects that may get overlapped by layers above it, and vice versa.

    origin
        The point on an image where the position is based off of. There are nine different origin points available:

        - TopLeft
        - TopCentre
        - TopRight
        - CentreLeft
        - Centre (default)
        - CentreRight
        - BottomLeft
        - BottomCentre
        - BottomRight

    playfield
        The viewport of the screen where the notes are rendered at. Solely 4:3.

    background
        The lowest priority :term:`layer` in storyboarding. Objects in other layers will always appear in front of this.

    fail
        A :term:`layer` that only displays when the player enters fail state. A player enters the fail state when:

        - During playtime, they do not hit a Geki! (i.e. perfect 300) on their last combo in Standard. In Taiko, if the player missed the last note. In osu!catch, if the user failed the previous break.
        - During break time, if the lifebar is below half. In Taiko, if the user performs underneath the expected quota to pass.
        - During the outro, if there were breaks, if over half the breaks were fails.

    pass
        A :term:`layer` that only displays when the player enters the passing state. A player enters this state when:

        - By default in the beginning of the map.
        - During playtime, they hit a Geki! (i.e. perfect 300) on their last combo in Standard. In Taiko, if the player hits the last note. In osu!catch, if the user passes the previous break.
        - During break time, if the lifebar is at least half. In Taiko, if the user performs at least the expected quota to pass.
        - During the outro, if there were breaks, if over half the breaks were passes.

    foreground
        The highest priroity :term:`layer` in storyboarding. Has priority over the other storyboarding layers.

    z-order
        The ordering of overlapping between two-dimensional objects, similar to layers. While not actually used in storyboarding, it is important to consider its nature, as layering is virtually identical to this concept.

    command
        What you want a sprite to do. Applying commands to a sprite may change its properties, such as its position, opacity, scale, and color.

    animation
        An object that uses a series of images instead of a static sprite. Otherwise identical to a :term:`sprite`.

    easing
        A mathematical function that adjusts the rate at which an :term:`object` tweens in a command. Applying an easing other than the default motion makes the velocity non-constant, and often enhances the final command's effect as a whole.

    fade
        ``sprite.fade(easing, startTime, endTime, start_fadeValue, end_fadeValue);`` Fades the sprite. Range of 0 ~ 1 integer is used to represent faint ~ distinct respectively during defined start and end times.

    move
        ``sprite.move(easing, startTime, endTime, startX_position, startY_position, endX_position, endY_position);`` Moves the sprite in the field. Sprite is moved between defined start and end times, and move starting point (x, y) and end point (x, y).

    move x
        ``sprite.moveX(easing, startTime, endTime, startX_position, endX_position);`` Controls movement of x-axis independantly from y-axis. Although this function can be used simultaneously with move y varient, this function can not be used in conjunction with "sprite.move" varient.

    move y
        ``sprite.moveY(easing, startTime, endTime, startY_position, endY_position);`` Controls movement of y-axis independantly from x-axis. Although this function can be used simultaneously with move x varient, this function can not be used in conjunction with "sprite.move" varient.

    scale
        ``sprite.scale(easing, startTime, endTime, start_scaleValue, end_scaleValue);`` Changes size of sprite in both axis. 1 is original size and sizes are changed during defined start and end times.

    vector scale
        ``sprite.scaleVec(easing, startTime, endTime, startX_axis, startY_axis, endX_axis, endY_axis);`` Controls size of sprite by controling two axis (x and y) independantly. (Refer to scale x and scale y)

    scale x
        Scales sprite horizontally (left and rige). [startX_axis] and [endX_axis]

    scale y
        Scales sprite vertically (up and down). [startY_axis] and [endY_axis]

    rotate
        ``sprite.rotate(easing, startTime, endTime, start_radValue, end_radValue);``
        Rotates the sprite. Uses radians. Turns the sprite during defined start and end times. 0 radians is original angle.

    color
    colour
        Insert text here.

    parameter
        Insert text here.

    additive
    additive blending
        Insert text here.

    compound commands
        Commands that actually consist of multiple basic commands. Executing a compound command usually implies there'll be a sequence of commands that a sprite will undergo.

    loop (storyboard) : loop command
        Insert text here.

    trigger loop
    trigger
        Insert text here.

    sample
        An object that plays an audio clip at a certain point and volume.

    Design Editor
        The built-in Storyboard Editor inside the map editor for osu!. Allows mouse-based manipulation of commands alongside the convenience of timeline navigation and immediate previewing, all because it's built into osu! already.

    osu!SGL
    SGL
        A programming lanugage originally developed by MoonShade. Created to ease and allow the possibility for storyboarding using programming paradigms and functionality. Compiled SGL code renders an exported .OSB file to be copy and pasted into osu!'s editor. While no longer officially supported, the language remains a relatively easier means to jump into storyboard programming.

    storybrew
        An osu! storyboard editor developed by Damnae. Its biggest strength is that it lets the developer see changes to code and sprites immediately upon saving. Composition is composed of modular, customizable effects made in the C# programming language. Currently the most powerful storyboard development experience out there.

    osbpy
        A development library developed by Wafu that allows osu! storyboard generation via Python. Due to its relatively easier learning curve, creating storyboards in this medium is relatively convenient, especially with naturally fast and rapid development the Python language allows.

    particle
        Tiny sprite. Mostly used in various types of advanced effects.

    spectrum
        Also known as audio spectrum, volume spectrum, and audio volume graph. Type of an effect where few or more sprites are scaled to represent particular audio frequency range for each sprite.

    variable
        A variable is used to store a value in code with representative defined name.

        - int - Able to store a number value.
        - float - Able to store a bigger value than integer.
        - double - Able to store bigger values than float.
        - char - Able to store character value.
        - bool - Able to store true/false value.
        - string - Able to store more than single character.

    comment
        Mostly serves purpose as a note for programmers while coding.

    bug
        When programs do not behave how it is suppose to, we say there is a/are "bug(s)" in the code.

    debugging
        Debugging is a stage of programming when code does not run properly or as intended. Programmers try to find these errors (bugs) and fix them.

    conditional
    if-condition
        Checks whether the condition is true. If true, it runs part of the command

    loop (programming) : loop
        A sequence of instructions that are continually repeated until a certain condition is reached. Loops are used very often to run a set of statements a desired number of times, and various forms of loops are available to achieve this.

    method
        Lines of code can be grouped into a set and the set can be called using
        specifically defined name of the set.

    function
        This term is used interchangeably with "method." However, "method" is preferred more for object programming rather than "function."

    array (programming) : array
    list (programming) : list
        A data structure that holds a collection of objects together, usually intended to make access to each one of the objects more streamlined and easier for the programmer.

    Osu! Storyboarder Banquet
        A community of storyboarders founded by Exile- and BetaStar. The goals for the server are not only to help promote storyboarding to many osu! players, but also to help others learn and improve their own storyboards. Some also believe that the server's true intention is to be a shrine worshipping the great deity Hifumi.

    BetaBot
        The automated bot that runs in :term:`Osu! Storyboarder Banquet`'s Discord server. Is often nicknamed as Hifumi. Contains the cutest twintails his momma BetaStar can find.

    Hifumi
    Hifumi Takimoto
    滝本ひふみ
        A character designer at Eagle Jump, the fictional game development company from Doga Kobo's *New Game!*. She is actually a goddess and is immediately SS best #1 tier girl. Words cannot sufficiently describe how succulently brilliant our goddess is, but most certainly she is the affectionate mascot for :term:`Osu! Storyboarder Banquet`. Her shyness exudes cuteness, and her beauty mark is a crown over those ill-suited three-dimensional women who cannot compare.
