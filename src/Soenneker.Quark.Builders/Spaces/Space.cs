namespace Soenneker.Quark;

[TailwindModifiers(typeof(SpaceBuilder))]
public static partial class Space
{
    /// <summary>
    /// Fluent step for `XReverse` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static SpaceBuilder XReverse => new(SpaceEnum.XReverse);

    /// <summary>
    /// Fluent step for `YReverse` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static SpaceBuilder YReverse => new(SpaceEnum.YReverse);

    public static class X
    {
        /// <summary>
        /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is0 => new(SpaceEnum.X0);

        /// <summary>
        /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is1 => new(SpaceEnum.X1);

        /// <summary>
        /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is2 => new(SpaceEnum.X2);

        /// <summary>
        /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is3 => new(SpaceEnum.X3);

        /// <summary>
        /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is4 => new(SpaceEnum.X4);

        /// <summary>
        /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is5 => new(SpaceEnum.X5);

        /// <summary>
        /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is6 => new(SpaceEnum.X6);

        /// <summary>
        /// Spacing/sizing scale step `7` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 7` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is7 => new(SpaceEnum.X7);

        /// <summary>
        /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is8 => new(SpaceEnum.X8);

        /// <summary>
        /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
        /// </summary>
        /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
        public static SpaceBuilder Token(string value) => new($"space-x-{value}");
    }

    public static class Y
    {
        /// <summary>
        /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is0 => new(SpaceEnum.Y0);

        /// <summary>
        /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is1 => new(SpaceEnum.Y1);

        /// <summary>
        /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is2 => new(SpaceEnum.Y2);

        /// <summary>
        /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is3 => new(SpaceEnum.Y3);

        /// <summary>
        /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is4 => new(SpaceEnum.Y4);

        /// <summary>
        /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is5 => new(SpaceEnum.Y5);

        /// <summary>
        /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is6 => new(SpaceEnum.Y6);

        /// <summary>
        /// Spacing/sizing scale step `7` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 7` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is7 => new(SpaceEnum.Y7);

        /// <summary>
        /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
        /// </summary>
        public static SpaceBuilder Is8 => new(SpaceEnum.Y8);

        /// <summary>
        /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
        /// </summary>
        /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
        public static SpaceBuilder Token(string value) => new($"space-y-{value}");
    }
}
