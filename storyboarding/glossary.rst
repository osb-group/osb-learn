.. _glossary:

========
Glossary
========

This is the glossary containing all the most relevant terms in the documentation. If you need to look up something, this page may not be a bad idea to brandish out that Ctrl+F shortcut!

.. note:: This glossary is still a work-in-progress. There are a plethora of words that probably need defining right now.

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
        The viewport of the screen where the storyboard is visible. In the past, as osu! was solely 4:3, the playfield was 640x480, with the center point being (320,240), but with widescreen support, the dimensions have been upgraded to 854x480. As such, the left boundary ends roughly around -107 on the x-axis, while the right edge hits roughly 747.

    background
        The lowest priority :term:`layer` in storyboarding. Objects in other layers will always appear in front of this.

    failing
        A :term:`layer` that only displays when the player enters fail state. A player enters the fail state when:

        - During playtime, they do not hit a Geki! (i.e. perfect 300) on their last combo in Standard. In Taiko, if the player missed the last note. In osu!catch, if the user failed the previous break.
        - During break time, if the lifebar is below half. In Taiko, if the user performs underneath the expected quota to pass.
        - During the outro, if there were breaks, if over half the breaks were fails.

    passing
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
        Insert text here.

    move
    move x
    move y
        Insert text here.

    scale
        Insert text here.

    vector scale
    scale x
    scale y
        Insert text here.

    rotate
        Insert text here.

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
        Insert text here.

    spectrum
        Insert text here.

    variable
        Insert text here.

    comment
        Insert text here.

    bug
        Insert text here.

    debugging
        Insert text here.

    conditional
    if-condition
        Insert text here.

    loop (programming) : loop
        Insert text here.

    method
    function
        Insert text here.

    array (programming) : array
    list (programming) : list
        Insert text here.

    Osu! Storyboarder Banquet
        A community of storyboarders founded by Exile- and BetaStar. The goals for the server are not only to help promote storyboarding to many osu! players, but also to help others learn and improve their own storyboards. Some also believe that the server's true intention is to be a shrine worshipping the great deity Hifumi.

    BetaBot
        The automated bot that runs in :term:`Osu! Storyboarder Banquet`'s Discord server. Is often nicknamed as Hifumi. Contains the cutest twintails his momma BetaStar can find.

    Hifumi Takimoto : Hifumi
    滝本ひふみ
        A character designer at Eagle Jump, the fictional game development company from Doga Kobo's *New Game!*. She is actually a goddess and is immediately SS best #1 tier girl. Words cannot sufficiently describe how succulently brilliant our goddess is, but most certainly she is the affectionate mascot for :term:`Osu! Storyboarder Banquet`. Her shyness exudes cuteness, and her beauty mark is a crown over those ill-suited three-dimensional women who cannot compare.
