﻿using System.Numerics;

namespace CgfConverter.Renderers.Gltf;

public partial class GltfRendererCommon
{
    /*
     * https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#coordinate-system-and-units
     * glTF uses a right-handed coordinate system.
     * glTF defines +Y as up, +Z as forward, and -X as right.
     * the front of a glTF asset faces +Z.
     *
     * https://docs.cryengine.com/display/CEPROG/Math
     * CRYENGINE uses a right-handed coordinate system
     * where positive X-axis points to the right, positive Y-axis away from the viewer and positive Z-axis points up.
     * In the context of characters this means that positive X is right, positive Y is forward, and positive Z is up.
     *
     *         glTF cryengine
     * Right     -X        +X
     * Up        +Y        +Z
     * Forward   +Z        +Y
     */
    
    //*
    private static Vector3 SwapAxesForPosition(Vector3 val) => new(-val.X, val.Z, val.Y);
    private static Vector3 SwapAxesForScale(Vector3 val) => new(val.X, val.Z, val.Y);

    private static Quaternion SwapAxesForAnimations(Quaternion val) => new(-val.X, val.Z, val.Y, val.W);
    
    private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Y, val.W, val.Z, val.X);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.X, val.Y, val.W, -val.Z);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.X, val.W, val.Y, -val.Z);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.Y, val.X, val.Z, -val.W);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.Y, val.X, val.W, -val.Z);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.Y, val.Z, val.X, -val.W);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.Y, val.Z, val.W, -val.X);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.Y, val.W, val.X, -val.Z);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.Y, val.W, val.Z, -val.X);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.W, val.X, val.Y, -val.Z);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.W, val.Y, val.X, -val.Z);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(-val.W, val.Y, val.Z, -val.X);
    
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.X, val.Z, val.Y, -val.W);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.X, val.Z, val.W, -val.Y);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.X, val.W, val.Z, -val.Y);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Z, val.X, val.Y, -val.W);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Z, val.X, val.W, -val.Y);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Z, val.Y, val.X, -val.W);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Z, val.Y, val.W, -val.X);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Z, val.W, val.X, -val.Y);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.Z, val.W, val.Y, -val.X);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.W, val.X, val.Z, -val.Y);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.W, val.Z, val.X, -val.Y);
    // private static Quaternion SwapAxesForLayout(Quaternion val) => new(val.W, val.Z, val.Y, -val.X);

    // M':   swapped matrix
    // T:    swap matrix = new Matrix4x4(-1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1)
    // T^-1: inverse of swap matrix (= T, for this specific configuration)
    // M' = T @ M @ T^-1 = <what's below>
    private static Matrix4x4 SwapAxes(Matrix4x4 val) => new(
        val.M11, -val.M13, -val.M12, -val.M14,
        -val.M31, val.M33, val.M32, val.M34,
        -val.M21, val.M23, val.M22, val.M24,
        -val.M41, val.M43, val.M42, val.M44);
    
    /*/

    private static Vector3 SwapAxes(Vector3 x) => x;
    private static Quaternion SwapAxes(Quaternion x) => x;
    private static Matrix4x4 SwapAxes(Matrix4x4 x) => x;
    //*/
}