using System;

namespace Godot
{
    /// <summary>
    /// Extension methods for tweens.
    /// </summary>
    public static class TweenExtensions
    {
        /// <inheritdoc cref="Tween.TweenCallback"/>
        public static CallbackTweener TweenCallback(this Tween tween, Action action)
        {
            return tween.TweenCallback(Callable.From(action));
        }

        /// <inheritdoc cref="Tween.TweenMethod"/>
        public static MethodTweener TweenMethod<[MustBeVariant] T>(this Tween tween, Func<T, T> method, T from, T to, double duration)
        {
            return tween.TweenMethod(Callable.From(method), Variant.From(from), Variant.From(to), duration);
        }

    }
}
