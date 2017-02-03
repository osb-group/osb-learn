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
        Insert text here.

    origin
        Insert text here.

    background
        The lowest priority layer in storyboarding. Objects in other layers will always appear in front of this.

    failing
        A layer that only displays when the player enters fail state. A player enters the fail state when:

        - During playtime, they do not hit a Geki! (i.e. perfect 300) on their last combo in Standard. In Taiko, if the player missed the last note. In osu!catch, if the user failed the previous break.
        - During break time, if the lifebar is below half. In Taiko, if the user performs underneath the expected quota to pass.
        - During the outro, if there were breaks, if over half the breaks were fails.

    passing
        A layer that only displays when the player enters the passing state. A player enters this state when:

        - By default in the beginning of the map.
        - During playtime, they hit a Geki! (i.e. perfect 300) on their last combo in Standard. In Taiko, if the player hits the last note. In osu!catch, if the user passes the previous break.
        - During break time, if the lifebar is at least half. In Taiko, if the user performs at least the expected quota to pass.
        - During the outro, if there were breaks, if over half the breaks were passes.

    foreground
        The highest priroity layer in storyboarding. Has priority over the other storyboarding layers.

    z-order
        Insert text here.

    command
        Insert text here.

    animation
        Insert text here.

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
        Insert text here.

    loop (storyboard) : loop command
        Insert text here.

    trigger loop
    trigger
        Insert text here.

    sample
        Insert text here.

    Design Editor
        Insert text here.

    osu!SGL
    SGL
        Insert text here.

    storybrew
        Insert text here.

    osbpy
        Insert text here.

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
