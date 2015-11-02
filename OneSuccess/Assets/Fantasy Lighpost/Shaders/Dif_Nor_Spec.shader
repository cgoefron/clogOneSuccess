
Shader "Victory-Games/Dif-Nor-Spec"{
Properties {
	_Color ("Diffuse Color", Color) = (1,1,1,1)
	_MainTex ("Diffuse Map (RGB)", 2D) = "white" {}	
	_SpecColor ("Specular Color", Color) = (0.5, 0.5, 0.5, 0)
	_Shininess ("Shininess", Range (0.01, 1)) = 0.078125
	_SpecMap ("Specular Map (RGB)", 2D) = "white" {}
	_BumpMap ("Normalmap", 2D) = "bump" {}
}

SubShader {
	Tags {"Queue"="AlphaTest" "IgnoreProjector"="True" "RenderType"="TransparentCutout"}
	LOD 400
	
	
CGPROGRAM
#pragma surface surf BlinnPhong alphatest:_Cutoff

sampler2D _MainTex;
sampler2D _BumpMap;
fixed4 _Color;
half _Shininess;
sampler2D _SpecMap;

struct Input {
	float2 uv_MainTex;
	float2 uv_SpecMap;
	float2 uv_BumpMap;
};

void surf (Input IN, inout SurfaceOutput o) {
	fixed4 tex = tex2D(_MainTex, IN.uv_MainTex);
	fixed4 spec = tex2D(_SpecMap, IN.uv_SpecMap);
	_SpecColor = _SpecColor*spec;
	o.Albedo = tex.rgb * _Color.rgb;
	o.Gloss = spec.r;
	o.Alpha = _Color.a;
	o.Specular = _Shininess;
	o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
}
ENDCG
}

FallBack "Specular"
}