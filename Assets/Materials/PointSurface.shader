Shader "Graph/Point Surface"
{
    Properties
    {
        _Smoothness("Smoothness", Range(0,1)) = 0.5
    }


    SubShader
    { 
        
        //Tags { "RenderType"="Opaque" }
        //LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface ConfigureSurface Standard fullforwardshadows
        #pragma target 3.0

        struct Input {
            float3 worldPos;
        };

        void ConfigureSurface(Input input, inout SurfaceOutputStandard surface)
        {
            surface.Albedo = input.worldPos * 0.5 + 0.5;
            surface.Smoothness = _Smoothness;

        }

        ENDCG
    }
    FallBack "Diffuse"
}
