#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


struct VirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct InvokerActionInvoker0
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		method->invoker_method(methodPtr, method, obj, NULL, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1 p1)
	{
		void* params[1] = { &p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2>
struct InvokerActionInvoker2;
template <typename T1, typename T2>
struct InvokerActionInvoker2<T1*, T2>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2 p2)
	{
		void* params[2] = { p1, &p2 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Action`1<Dreamteck.Splines.SplineUser>
struct Action_1_tA84280AD46ADE7CBEF377175550A3B4E31E5031C;
// System.Threading.AsyncLocal`1<System.Globalization.CultureInfo>
struct AsyncLocal_1_t1D3339EA4C8650D2DEDDF9553E5C932B3DC2CCFD;
// System.Collections.Generic.List`1<System.Int32[]>
struct List_1_tDEC4119E22EFA9DBE2F6B6C4F3ACD2FD0849215C;
// System.Collections.Generic.List`1<System.Double>
struct List_1_t495F03F47D827883530F951D563C0BB7340E5995;
// System.Collections.Generic.List`1<UnityEngine.RaycastHit>
struct List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9;
// System.Collections.Generic.Queue`1<System.Object>
struct Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5;
// System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>
struct Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371;
// System.Boolean[]
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4;
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Double[]
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// UnityEngine.RaycastHit[]
struct RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8;
// Dreamteck.Splines.SplinePoint[]
struct SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C;
// Dreamteck.Splines.SplineSample[]
struct SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE;
// Dreamteck.Splines.SplineTrigger[]
struct SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262;
// Dreamteck.Splines.SplineUser[]
struct SplineUserU5BU5D_tB38D10588EB2B223CCBA9DD16A1A2B604BFA95BA;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// Dreamteck.Splines.TriggerGroup[]
struct TriggerGroupU5BU5D_t121FB5C03AB60759F4EDD2BFB2B5A68EDC5963E7;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// UnityEngine.Vector4[]
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD;
// Dreamteck.Splines.SplineComputer/NodeLink[]
struct NodeLinkU5BU5D_t4D1B23DA0183E9D150F8141EA4BDA3D18E5F6B00;
// Dreamteck.Splines.SplineThreading/EmptyHandler[]
struct EmptyHandlerU5BU5D_tF3FD15E0BD0260EE82AC2B56F33BEFC9DEE098DB;
// Dreamteck.Splines.SplineThreading/ThreadDef[]
struct ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606;
// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// Dreamteck.Splines.ColorModifier
struct ColorModifier_t40BA57E95327C68D64F1B4263B957DFEDF278496;
// System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// Dreamteck.Splines.EmptySplineHandler
struct EmptySplineHandler_tEE7C57BF02E506288CD17C4318BA3D989D45E11C;
// System.Threading.ExecutionContext
struct ExecutionContext_t9D6EDFD92F0B2D391751963E2D77A8B03CB81710;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Security.Principal.IPrincipal
struct IPrincipal_tE7AF5096287F6C3472585E124CB38FF2A51EAB5F;
// System.Threading.InternalThread
struct InternalThread_tF40B7BFCBD60C82BD8475A22FF5186CA10293687;
// System.LocalDataStoreHolder
struct LocalDataStoreHolder_t789DD474AE5141213C2105CE57830ECFC2D3C03F;
// System.LocalDataStoreMgr
struct LocalDataStoreMgr_t205F1783D5CC2B148E829B5882E5406FF9A3AC1E;
// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4;
// UnityEngine.MeshCollider
struct MeshCollider_tB525E4DDE383252364ED0BDD32CF2B53914EE455;
// UnityEngine.MeshFilter
struct MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5;
// Dreamteck.Splines.MeshGenerator
struct MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E;
// UnityEngine.MeshRenderer
struct MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.MulticastDelegate
struct MulticastDelegate_t;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// Dreamteck.Splines.OffsetModifier
struct OffsetModifier_t8BCE246A4761CC52429FF9D6AB4C0948C7619115;
// System.Threading.ParameterizedThreadStart
struct ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9;
// Dreamteck.Splines.RotationModifier
struct RotationModifier_tB0B59CD933696DE13AA179E69338EF3139D88ACE;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// Dreamteck.Splines.SampleCollection
struct SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82;
// Dreamteck.Splines.SizeModifier
struct SizeModifier_t0F348800C415E2CFA793AACD7C4451E7E47C1B1B;
// Dreamteck.Splines.Spline
struct Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B;
// Dreamteck.Splines.SplineComputer
struct SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22;
// Dreamteck.Splines.SplineSample
struct SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE;
// Dreamteck.Splines.SplineTrigger
struct SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD;
// Dreamteck.Splines.SplineUser
struct SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA;
// System.String
struct String_t;
// Dreamteck.Splines.SurfaceGenerator
struct SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A;
// Dreamteck.TS_Bounds
struct TS_Bounds_t9C9BF7DE41731FC6FD6A7931ECEB5E4C0069C497;
// Dreamteck.TS_Mesh
struct TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F;
// System.Threading.Thread
struct Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// Dreamteck.Splines.TriggerGroup
struct TriggerGroup_tF128CA84FCAE0CB4549FC7141431DEA981C2D43E;
// Dreamteck.Splines.TubeGenerator
struct TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46;
// UnityEngine.Events.UnityEvent
struct UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// Dreamteck.Splines.WaveformGenerator
struct WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3;
// Dreamteck.Splines.SplineThreading/EmptyHandler
struct EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE;
// Dreamteck.Splines.SplineThreading/ThreadDef
struct ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203;
// Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler
struct BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF;
// Dreamteck.Splines.SplineThreading/ThreadDef/Worker
struct Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87;

IL2CPP_EXTERN_C RuntimeClass* Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t495F03F47D827883530F951D563C0BB7340E5995_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ThreadInterruptedException_t5F777BF218B009092789F6DA0013E4DC3A0987CC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral1E60ED2E7B21CE7BABE99A45D5D0998B513D58F1;
IL2CPP_EXTERN_C String_t* _stringLiteral2EB6E2A95D5C3E11CE312FE16B937D8DB184DBE5;
IL2CPP_EXTERN_C String_t* _stringLiteral4CFC5ABA1C919D113FC5E9034608A0133787E620;
IL2CPP_EXTERN_C String_t* _stringLiteral88EB21CA5454C0DC11F3E2DCF04D902104818319;
IL2CPP_EXTERN_C String_t* _stringLiteralC8030254E2A044716BE5C6218DC805EFA9F40947;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralEB5F7E205563AF268B2398339D6BC44920D66CE0;
IL2CPP_EXTERN_C const RuntimeMethod* ArrayUtility_Add_TisThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_m7AA2A015A47078C2BBC1C12D7F87B749CCF6EC7E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Queue_1_Dequeue_mC90913E91A7B06DCAE75B561DB0D1366461A2903_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Queue_1_Enqueue_m03169B6B661DD5BE1E05AF38EC0787E4E8A47208_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Queue_1__ctor_mB77C6E0D45FF98C70022A1A4274DC0DF66CF6AEB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Queue_1_get_Count_m2624F89E4009D9F306525357B93267F2E9A18060_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SplineThreading_Quitting_mFABFBD154A784EB6DC8B2C1B169AA79DF1AFC5B3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SplineThreading_RunThread_mDF557DB8E00DDD010B6A00B1EB167CEF016734DB_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8;
struct SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C;
struct SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE;
struct SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262;
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
struct ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<System.Double>
struct List_1_t495F03F47D827883530F951D563C0BB7340E5995  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<UnityEngine.RaycastHit>
struct List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.Queue`1<System.Object>
struct Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5  : public RuntimeObject
{
	// T[] System.Collections.Generic.Queue`1::_array
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____array_0;
	// System.Int32 System.Collections.Generic.Queue`1::_head
	int32_t ____head_1;
	// System.Int32 System.Collections.Generic.Queue`1::_tail
	int32_t ____tail_2;
	// System.Int32 System.Collections.Generic.Queue`1::_size
	int32_t ____size_3;
	// System.Int32 System.Collections.Generic.Queue`1::_version
	int32_t ____version_4;
	// System.Object System.Collections.Generic.Queue`1::_syncRoot
	RuntimeObject* ____syncRoot_5;
};

// System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>
struct Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371  : public RuntimeObject
{
	// T[] System.Collections.Generic.Queue`1::_array
	EmptyHandlerU5BU5D_tF3FD15E0BD0260EE82AC2B56F33BEFC9DEE098DB* ____array_0;
	// System.Int32 System.Collections.Generic.Queue`1::_head
	int32_t ____head_1;
	// System.Int32 System.Collections.Generic.Queue`1::_tail
	int32_t ____tail_2;
	// System.Int32 System.Collections.Generic.Queue`1::_size
	int32_t ____size_3;
	// System.Int32 System.Collections.Generic.Queue`1::_version
	int32_t ____version_4;
	// System.Object System.Collections.Generic.Queue`1::_syncRoot
	RuntimeObject* ____syncRoot_5;
};

// System.Runtime.ConstrainedExecution.CriticalFinalizerObject
struct CriticalFinalizerObject_t1DCAB623CAEA6529A96F5F3EDE3C7048A6E313C9  : public RuntimeObject
{
};

// Dreamteck.Splines.SampleCollection
struct SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82  : public RuntimeObject
{
	// Dreamteck.Splines.SplineSample[] Dreamteck.Splines.SampleCollection::samples
	SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* ___samples_0;
	// System.Int32[] Dreamteck.Splines.SampleCollection::optimizedIndices
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___optimizedIndices_1;
	// Dreamteck.Splines.SplineComputer/SampleMode Dreamteck.Splines.SampleCollection::sampleMode
	int32_t ___sampleMode_2;
	// Dreamteck.Splines.SplineSample Dreamteck.Splines.SampleCollection::_workSample
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ____workSample_3;
	// System.Double Dreamteck.Splines.SampleCollection::clipFrom
	double ___clipFrom_4;
	// System.Double Dreamteck.Splines.SampleCollection::clipTo
	double ___clipTo_5;
	// System.Boolean Dreamteck.Splines.SampleCollection::loopSamples
	bool ___loopSamples_6;
};

// Dreamteck.Splines.Spline
struct Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B  : public RuntimeObject
{
	// Dreamteck.Splines.SplinePoint[] Dreamteck.Splines.Spline::points
	SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* ___points_0;
	// System.Boolean Dreamteck.Splines.Spline::closed
	bool ___closed_1;
	// Dreamteck.Splines.Spline/Type Dreamteck.Splines.Spline::type
	int32_t ___type_2;
	// System.Boolean Dreamteck.Splines.Spline::linearAverageDirection
	bool ___linearAverageDirection_3;
	// UnityEngine.AnimationCurve Dreamteck.Splines.Spline::customValueInterpolation
	AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* ___customValueInterpolation_4;
	// UnityEngine.AnimationCurve Dreamteck.Splines.Spline::customNormalInterpolation
	AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* ___customNormalInterpolation_5;
	// System.Int32 Dreamteck.Splines.Spline::sampleRate
	int32_t ___sampleRate_6;
};

// Dreamteck.Splines.SplineThreading
struct SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// Dreamteck.TS_Mesh
struct TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F  : public RuntimeObject
{
	// UnityEngine.Vector3[] Dreamteck.TS_Mesh::vertices
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___vertices_0;
	// UnityEngine.Vector3[] Dreamteck.TS_Mesh::normals
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___normals_1;
	// UnityEngine.Vector4[] Dreamteck.TS_Mesh::tangents
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___tangents_2;
	// UnityEngine.Color[] Dreamteck.TS_Mesh::colors
	ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* ___colors_3;
	// UnityEngine.Vector2[] Dreamteck.TS_Mesh::uv
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uv_4;
	// UnityEngine.Vector2[] Dreamteck.TS_Mesh::uv2
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uv2_5;
	// UnityEngine.Vector2[] Dreamteck.TS_Mesh::uv3
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uv3_6;
	// UnityEngine.Vector2[] Dreamteck.TS_Mesh::uv4
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uv4_7;
	// System.Int32[] Dreamteck.TS_Mesh::triangles
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___triangles_8;
	// System.Collections.Generic.List`1<System.Int32[]> Dreamteck.TS_Mesh::subMeshes
	List_1_tDEC4119E22EFA9DBE2F6B6C4F3ACD2FD0849215C* ___subMeshes_9;
	// Dreamteck.TS_Bounds Dreamteck.TS_Mesh::bounds
	TS_Bounds_t9C9BF7DE41731FC6FD6A7931ECEB5E4C0069C497* ___bounds_10;
	// UnityEngine.Rendering.IndexFormat Dreamteck.TS_Mesh::indexFormat
	int32_t ___indexFormat_11;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) Dreamteck.TS_Mesh::hasUpdate
	bool ___hasUpdate_12;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// Dreamteck.Splines.SplineThreading/ThreadDef
struct ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203  : public RuntimeObject
{
	// System.Threading.ParameterizedThreadStart Dreamteck.Splines.SplineThreading/ThreadDef::start
	ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9* ___start_0;
	// System.Threading.Thread Dreamteck.Splines.SplineThreading/ThreadDef::thread
	Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* ___thread_1;
	// Dreamteck.Splines.SplineThreading/ThreadDef/Worker Dreamteck.Splines.SplineThreading/ThreadDef::worker
	Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* ___worker_2;
};

// Dreamteck.Splines.SplineThreading/ThreadDef/Worker
struct Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87  : public RuntimeObject
{
	// System.Boolean Dreamteck.Splines.SplineThreading/ThreadDef/Worker::computing
	bool ___computing_0;
	// System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler> Dreamteck.Splines.SplineThreading/ThreadDef/Worker::instructions
	Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* ___instructions_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// System.Double
struct Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F 
{
	// System.Double System.Double::m_value
	double ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// UnityEngine.LayerMask
struct LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB 
{
	// System.Int32 UnityEngine.LayerMask::m_Mask
	int32_t ___m_Mask_0;
};

// UnityEngine.Mathf
struct Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682 
{
	union
	{
		struct
		{
		};
		uint8_t Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682__padding[1];
	};
};

// UnityEngine.Matrix4x4
struct Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 
{
	// System.Single UnityEngine.Matrix4x4::m00
	float ___m00_0;
	// System.Single UnityEngine.Matrix4x4::m10
	float ___m10_1;
	// System.Single UnityEngine.Matrix4x4::m20
	float ___m20_2;
	// System.Single UnityEngine.Matrix4x4::m30
	float ___m30_3;
	// System.Single UnityEngine.Matrix4x4::m01
	float ___m01_4;
	// System.Single UnityEngine.Matrix4x4::m11
	float ___m11_5;
	// System.Single UnityEngine.Matrix4x4::m21
	float ___m21_6;
	// System.Single UnityEngine.Matrix4x4::m31
	float ___m31_7;
	// System.Single UnityEngine.Matrix4x4::m02
	float ___m02_8;
	// System.Single UnityEngine.Matrix4x4::m12
	float ___m12_9;
	// System.Single UnityEngine.Matrix4x4::m22
	float ___m22_10;
	// System.Single UnityEngine.Matrix4x4::m32
	float ___m32_11;
	// System.Single UnityEngine.Matrix4x4::m03
	float ___m03_12;
	// System.Single UnityEngine.Matrix4x4::m13
	float ___m13_13;
	// System.Single UnityEngine.Matrix4x4::m23
	float ___m23_14;
	// System.Single UnityEngine.Matrix4x4::m33
	float ___m33_15;
};

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 
{
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// System.Threading.Thread
struct Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F  : public CriticalFinalizerObject_t1DCAB623CAEA6529A96F5F3EDE3C7048A6E313C9
{
	// System.Threading.InternalThread System.Threading.Thread::internal_thread
	InternalThread_tF40B7BFCBD60C82BD8475A22FF5186CA10293687* ___internal_thread_6;
	// System.Object System.Threading.Thread::m_ThreadStartArg
	RuntimeObject* ___m_ThreadStartArg_7;
	// System.Object System.Threading.Thread::pending_exception
	RuntimeObject* ___pending_exception_8;
	// System.MulticastDelegate System.Threading.Thread::m_Delegate
	MulticastDelegate_t* ___m_Delegate_10;
	// System.Threading.ExecutionContext System.Threading.Thread::m_ExecutionContext
	ExecutionContext_t9D6EDFD92F0B2D391751963E2D77A8B03CB81710* ___m_ExecutionContext_11;
	// System.Boolean System.Threading.Thread::m_ExecutionContextBelongsToOuterScope
	bool ___m_ExecutionContextBelongsToOuterScope_12;
	// System.Security.Principal.IPrincipal System.Threading.Thread::principal
	RuntimeObject* ___principal_13;
	// System.Int32 System.Threading.Thread::principal_version
	int32_t ___principal_version_14;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 
{
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354  : public RuntimeObject
{
	// System.IntPtr UnityEngine.AnimationCurve::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.RaycastHit
struct RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 
{
	// UnityEngine.Vector3 UnityEngine.RaycastHit::m_Point
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Point_0;
	// UnityEngine.Vector3 UnityEngine.RaycastHit::m_Normal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Normal_1;
	// System.UInt32 UnityEngine.RaycastHit::m_FaceID
	uint32_t ___m_FaceID_2;
	// System.Single UnityEngine.RaycastHit::m_Distance
	float ___m_Distance_3;
	// UnityEngine.Vector2 UnityEngine.RaycastHit::m_UV
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_UV_4;
	// System.Int32 UnityEngine.RaycastHit::m_Collider
	int32_t ___m_Collider_5;
};

// Dreamteck.Splines.SplinePoint
struct SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB 
{
	// Dreamteck.Splines.SplinePoint/Type Dreamteck.Splines.SplinePoint::_type
	int32_t ____type_0;
	// UnityEngine.Vector3 Dreamteck.Splines.SplinePoint::position
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_1;
	// UnityEngine.Color Dreamteck.Splines.SplinePoint::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_2;
	// UnityEngine.Vector3 Dreamteck.Splines.SplinePoint::normal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___normal_3;
	// System.Single Dreamteck.Splines.SplinePoint::size
	float ___size_4;
	// UnityEngine.Vector3 Dreamteck.Splines.SplinePoint::tangent
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___tangent_5;
	// UnityEngine.Vector3 Dreamteck.Splines.SplinePoint::tangent2
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___tangent2_6;
};

// Dreamteck.Splines.SplineSample
struct SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE  : public RuntimeObject
{
	// UnityEngine.Vector3 Dreamteck.Splines.SplineSample::position
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_0;
	// UnityEngine.Vector3 Dreamteck.Splines.SplineSample::up
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___up_1;
	// UnityEngine.Vector3 Dreamteck.Splines.SplineSample::forward
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forward_2;
	// UnityEngine.Color Dreamteck.Splines.SplineSample::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_3;
	// System.Single Dreamteck.Splines.SplineSample::size
	float ___size_4;
	// System.Double Dreamteck.Splines.SplineSample::percent
	double ___percent_5;
};

// Dreamteck.Splines.SplineTrigger
struct SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD  : public RuntimeObject
{
	// System.String Dreamteck.Splines.SplineTrigger::name
	String_t* ___name_0;
	// Dreamteck.Splines.SplineTrigger/Type Dreamteck.Splines.SplineTrigger::type
	int32_t ___type_1;
	// System.Boolean Dreamteck.Splines.SplineTrigger::workOnce
	bool ___workOnce_2;
	// System.Boolean Dreamteck.Splines.SplineTrigger::worked
	bool ___worked_3;
	// System.Double Dreamteck.Splines.SplineTrigger::position
	double ___position_4;
	// System.Boolean Dreamteck.Splines.SplineTrigger::enabled
	bool ___enabled_5;
	// UnityEngine.Color Dreamteck.Splines.SplineTrigger::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_6;
	// UnityEngine.Events.UnityEvent Dreamteck.Splines.SplineTrigger::onCross
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* ___onCross_7;
	// System.Action`1<Dreamteck.Splines.SplineUser> Dreamteck.Splines.SplineTrigger::onUserCross
	Action_1_tA84280AD46ADE7CBEF377175550A3B4E31E5031C* ___onUserCross_8;
};

// Dreamteck.Splines.TriggerGroup
struct TriggerGroup_tF128CA84FCAE0CB4549FC7141431DEA981C2D43E  : public RuntimeObject
{
	// System.Boolean Dreamteck.Splines.TriggerGroup::enabled
	bool ___enabled_0;
	// System.String Dreamteck.Splines.TriggerGroup::name
	String_t* ___name_1;
	// UnityEngine.Color Dreamteck.Splines.TriggerGroup::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_2;
	// Dreamteck.Splines.SplineTrigger[] Dreamteck.Splines.TriggerGroup::triggers
	SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* ___triggers_3;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07  : public MulticastDelegate_t
{
};

// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// System.Threading.ParameterizedThreadStart
struct ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9  : public MulticastDelegate_t
{
};

// System.Threading.ThreadInterruptedException
struct ThreadInterruptedException_t5F777BF218B009092789F6DA0013E4DC3A0987CC  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// Dreamteck.Splines.SplineThreading/EmptyHandler
struct EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE  : public MulticastDelegate_t
{
};

// Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler
struct BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF  : public MulticastDelegate_t
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// Dreamteck.Splines.SplineComputer
struct SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.Boolean Dreamteck.Splines.SplineComputer::multithreaded
	bool ___multithreaded_4;
	// System.Boolean Dreamteck.Splines.SplineComputer::rebuildOnAwake
	bool ___rebuildOnAwake_5;
	// Dreamteck.Splines.SplineComputer/UpdateMode Dreamteck.Splines.SplineComputer::updateMode
	int32_t ___updateMode_6;
	// Dreamteck.Splines.TriggerGroup[] Dreamteck.Splines.SplineComputer::triggerGroups
	TriggerGroupU5BU5D_t121FB5C03AB60759F4EDD2BFB2B5A68EDC5963E7* ___triggerGroups_7;
	// Dreamteck.Splines.Spline Dreamteck.Splines.SplineComputer::spline
	Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* ___spline_8;
	// Dreamteck.Splines.SplineSample[] Dreamteck.Splines.SplineComputer::_rawSamples
	SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* ____rawSamples_9;
	// Dreamteck.Splines.SplineSample[] Dreamteck.Splines.SplineComputer::_transformedSamples
	SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* ____transformedSamples_10;
	// Dreamteck.Splines.SampleCollection Dreamteck.Splines.SplineComputer::sampleCollection
	SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* ___sampleCollection_11;
	// System.Double[] Dreamteck.Splines.SplineComputer::originalSamplePercents
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___originalSamplePercents_12;
	// System.Boolean[] Dreamteck.Splines.SplineComputer::sampleFlter
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___sampleFlter_13;
	// System.Int32 Dreamteck.Splines.SplineComputer::_sampleCount
	int32_t ____sampleCount_14;
	// System.Boolean Dreamteck.Splines.SplineComputer::_is2D
	bool ____is2D_15;
	// System.Boolean Dreamteck.Splines.SplineComputer::hasSamples
	bool ___hasSamples_16;
	// System.Boolean[] Dreamteck.Splines.SplineComputer::pointsDirty
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___pointsDirty_17;
	// System.Single Dreamteck.Splines.SplineComputer::_optimizeAngleThreshold
	float ____optimizeAngleThreshold_18;
	// Dreamteck.Splines.SplineComputer/Space Dreamteck.Splines.SplineComputer::_space
	int32_t ____space_19;
	// Dreamteck.Splines.SplineComputer/SampleMode Dreamteck.Splines.SplineComputer::_sampleMode
	int32_t ____sampleMode_20;
	// Dreamteck.Splines.SplineUser[] Dreamteck.Splines.SplineComputer::_subscribers
	SplineUserU5BU5D_tB38D10588EB2B223CCBA9DD16A1A2B604BFA95BA* ____subscribers_21;
	// Dreamteck.Splines.SplineComputer/NodeLink[] Dreamteck.Splines.SplineComputer::nodes
	NodeLinkU5BU5D_t4D1B23DA0183E9D150F8141EA4BDA3D18E5F6B00* ___nodes_22;
	// System.Boolean Dreamteck.Splines.SplineComputer::_rebuildPending
	bool ____rebuildPending_23;
	// System.Boolean Dreamteck.Splines.SplineComputer::_trsCached
	bool ____trsCached_24;
	// UnityEngine.Transform Dreamteck.Splines.SplineComputer::_trs
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trs_25;
	// UnityEngine.Matrix4x4 Dreamteck.Splines.SplineComputer::_transformMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ____transformMatrix_26;
	// UnityEngine.Matrix4x4 Dreamteck.Splines.SplineComputer::_inverseTransformMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ____inverseTransformMatrix_27;
	// System.Boolean Dreamteck.Splines.SplineComputer::_queueResample
	bool ____queueResample_28;
	// System.Boolean Dreamteck.Splines.SplineComputer::_queueRebuild
	bool ____queueRebuild_29;
	// UnityEngine.Vector3 Dreamteck.Splines.SplineComputer::_lastPosition
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____lastPosition_30;
	// UnityEngine.Vector3 Dreamteck.Splines.SplineComputer::_lastScale
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____lastScale_31;
	// System.Boolean Dreamteck.Splines.SplineComputer::_uniformScale
	bool ____uniformScale_32;
	// UnityEngine.Quaternion Dreamteck.Splines.SplineComputer::_lastRotation
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ____lastRotation_33;
	// Dreamteck.Splines.EmptySplineHandler Dreamteck.Splines.SplineComputer::onRebuild
	EmptySplineHandler_tEE7C57BF02E506288CD17C4318BA3D989D45E11C* ___onRebuild_34;
};

// Dreamteck.Splines.SplineUser
struct SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Dreamteck.Splines.SplineUser/UpdateMethod Dreamteck.Splines.SplineUser::updateMethod
	int32_t ___updateMethod_4;
	// Dreamteck.Splines.SplineComputer Dreamteck.Splines.SplineUser::_spline
	SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* ____spline_5;
	// System.Boolean Dreamteck.Splines.SplineUser::_autoUpdate
	bool ____autoUpdate_6;
	// Dreamteck.Splines.RotationModifier Dreamteck.Splines.SplineUser::_rotationModifier
	RotationModifier_tB0B59CD933696DE13AA179E69338EF3139D88ACE* ____rotationModifier_7;
	// Dreamteck.Splines.OffsetModifier Dreamteck.Splines.SplineUser::_offsetModifier
	OffsetModifier_t8BCE246A4761CC52429FF9D6AB4C0948C7619115* ____offsetModifier_8;
	// Dreamteck.Splines.ColorModifier Dreamteck.Splines.SplineUser::_colorModifier
	ColorModifier_t40BA57E95327C68D64F1B4263B957DFEDF278496* ____colorModifier_9;
	// Dreamteck.Splines.SizeModifier Dreamteck.Splines.SplineUser::_sizeModifier
	SizeModifier_t0F348800C415E2CFA793AACD7C4451E7E47C1B1B* ____sizeModifier_10;
	// Dreamteck.Splines.SampleCollection Dreamteck.Splines.SplineUser::sampleCollection
	SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* ___sampleCollection_11;
	// Dreamteck.Splines.SplineSample Dreamteck.Splines.SplineUser::clipFromSample
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___clipFromSample_12;
	// Dreamteck.Splines.SplineSample Dreamteck.Splines.SplineUser::clipToSample
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___clipToSample_13;
	// System.Boolean Dreamteck.Splines.SplineUser::_loopSamples
	bool ____loopSamples_14;
	// System.Double Dreamteck.Splines.SplineUser::_clipFrom
	double ____clipFrom_15;
	// System.Double Dreamteck.Splines.SplineUser::_clipTo
	double ____clipTo_16;
	// System.Single Dreamteck.Splines.SplineUser::animClipFrom
	float ___animClipFrom_17;
	// System.Single Dreamteck.Splines.SplineUser::animClipTo
	float ___animClipTo_18;
	// System.Boolean Dreamteck.Splines.SplineUser::rebuild
	bool ___rebuild_19;
	// System.Boolean Dreamteck.Splines.SplineUser::getSamples
	bool ___getSamples_20;
	// System.Boolean Dreamteck.Splines.SplineUser::postBuild
	bool ___postBuild_21;
	// UnityEngine.Transform Dreamteck.Splines.SplineUser::_trs
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trs_22;
	// System.Boolean Dreamteck.Splines.SplineUser::_hasTransform
	bool ____hasTransform_23;
	// System.Int32 Dreamteck.Splines.SplineUser::_sampleCount
	int32_t ____sampleCount_24;
	// System.Int32 Dreamteck.Splines.SplineUser::startSampleIndex
	int32_t ___startSampleIndex_25;
	// Dreamteck.Splines.SplineSample Dreamteck.Splines.SplineUser::evalResult
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___evalResult_26;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) Dreamteck.Splines.SplineUser::multithreaded
	bool ___multithreaded_27;
	// System.Boolean Dreamteck.Splines.SplineUser::buildOnAwake
	bool ___buildOnAwake_28;
	// System.Boolean Dreamteck.Splines.SplineUser::buildOnEnable
	bool ___buildOnEnable_29;
	// Dreamteck.Splines.EmptySplineHandler Dreamteck.Splines.SplineUser::onPostBuild
	EmptySplineHandler_tEE7C57BF02E506288CD17C4318BA3D989D45E11C* ___onPostBuild_30;
	// System.Boolean Dreamteck.Splines.SplineUser::_isUpdated
	bool ____isUpdated_31;
};

// Dreamteck.Splines.MeshGenerator
struct MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E  : public SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA
{
	// System.Boolean Dreamteck.Splines.MeshGenerator::_baked
	bool ____baked_33;
	// System.Boolean Dreamteck.Splines.MeshGenerator::_markDynamic
	bool ____markDynamic_34;
	// System.Single Dreamteck.Splines.MeshGenerator::_size
	float ____size_35;
	// UnityEngine.Color Dreamteck.Splines.MeshGenerator::_color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ____color_36;
	// UnityEngine.Vector3 Dreamteck.Splines.MeshGenerator::_offset
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____offset_37;
	// Dreamteck.Splines.MeshGenerator/NormalMethod Dreamteck.Splines.MeshGenerator::_normalMethod
	int32_t ____normalMethod_38;
	// System.Boolean Dreamteck.Splines.MeshGenerator::_calculateTangents
	bool ____calculateTangents_39;
	// System.Boolean Dreamteck.Splines.MeshGenerator::_useSplineSize
	bool ____useSplineSize_40;
	// System.Boolean Dreamteck.Splines.MeshGenerator::_useSplineColor
	bool ____useSplineColor_41;
	// System.Single Dreamteck.Splines.MeshGenerator::_rotation
	float ____rotation_42;
	// System.Boolean Dreamteck.Splines.MeshGenerator::_flipFaces
	bool ____flipFaces_43;
	// System.Boolean Dreamteck.Splines.MeshGenerator::_doubleSided
	bool ____doubleSided_44;
	// Dreamteck.Splines.MeshGenerator/UVMode Dreamteck.Splines.MeshGenerator::_uvMode
	int32_t ____uvMode_45;
	// UnityEngine.Vector2 Dreamteck.Splines.MeshGenerator::_uvScale
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ____uvScale_46;
	// UnityEngine.Vector2 Dreamteck.Splines.MeshGenerator::_uvOffset
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ____uvOffset_47;
	// System.Single Dreamteck.Splines.MeshGenerator::_uvRotation
	float ____uvRotation_48;
	// UnityEngine.Rendering.IndexFormat Dreamteck.Splines.MeshGenerator::_meshIndexFormat
	int32_t ____meshIndexFormat_49;
	// UnityEngine.MeshCollider Dreamteck.Splines.MeshGenerator::meshCollider
	MeshCollider_tB525E4DDE383252364ED0BDD32CF2B53914EE455* ___meshCollider_50;
	// UnityEngine.MeshFilter Dreamteck.Splines.MeshGenerator::filter
	MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* ___filter_51;
	// UnityEngine.MeshRenderer Dreamteck.Splines.MeshGenerator::meshRenderer
	MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE* ___meshRenderer_52;
	// Dreamteck.TS_Mesh Dreamteck.Splines.MeshGenerator::tsMesh
	TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* ___tsMesh_53;
	// UnityEngine.Mesh Dreamteck.Splines.MeshGenerator::mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___mesh_54;
	// System.Single Dreamteck.Splines.MeshGenerator::colliderUpdateRate
	float ___colliderUpdateRate_55;
	// System.Boolean Dreamteck.Splines.MeshGenerator::updateCollider
	bool ___updateCollider_56;
	// System.Single Dreamteck.Splines.MeshGenerator::lastUpdateTime
	float ___lastUpdateTime_57;
	// System.Single Dreamteck.Splines.MeshGenerator::vDist
	float ___vDist_58;
};

// Dreamteck.Splines.SurfaceGenerator
struct SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A  : public MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E
{
	// System.Single Dreamteck.Splines.SurfaceGenerator::_expand
	float ____expand_60;
	// System.Single Dreamteck.Splines.SurfaceGenerator::_extrude
	float ____extrude_61;
	// UnityEngine.Vector2 Dreamteck.Splines.SurfaceGenerator::_sideUvScale
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ____sideUvScale_62;
	// UnityEngine.Vector2 Dreamteck.Splines.SurfaceGenerator::_sideUvOffset
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ____sideUvOffset_63;
	// Dreamteck.Splines.SplineComputer Dreamteck.Splines.SurfaceGenerator::_extrudeSpline
	SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* ____extrudeSpline_64;
	// UnityEngine.Vector3 Dreamteck.Splines.SurfaceGenerator::_extrudeOffset
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____extrudeOffset_65;
	// Dreamteck.Splines.SplineSample[] Dreamteck.Splines.SurfaceGenerator::extrudeResults
	SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* ___extrudeResults_66;
	// UnityEngine.Vector3[] Dreamteck.Splines.SurfaceGenerator::identityVertices
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___identityVertices_67;
	// UnityEngine.Vector3[] Dreamteck.Splines.SurfaceGenerator::identityNormals
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___identityNormals_68;
	// UnityEngine.Vector2[] Dreamteck.Splines.SurfaceGenerator::projectedVerts
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___projectedVerts_69;
	// System.Int32[] Dreamteck.Splines.SurfaceGenerator::surfaceTris
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___surfaceTris_70;
	// System.Int32[] Dreamteck.Splines.SurfaceGenerator::wallTris
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___wallTris_71;
	// System.Double Dreamteck.Splines.SurfaceGenerator::_extrudeFrom
	double ____extrudeFrom_72;
	// System.Double Dreamteck.Splines.SurfaceGenerator::_extrudeTo
	double ____extrudeTo_73;
	// System.Boolean Dreamteck.Splines.SurfaceGenerator::_uniformUvs
	bool ____uniformUvs_74;
	// UnityEngine.Vector3 Dreamteck.Splines.SurfaceGenerator::_trsRight
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____trsRight_75;
	// UnityEngine.Vector3 Dreamteck.Splines.SurfaceGenerator::_trsUp
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____trsUp_76;
	// UnityEngine.Vector3 Dreamteck.Splines.SurfaceGenerator::_trsForward
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ____trsForward_77;
};

// Dreamteck.Splines.TubeGenerator
struct TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46  : public MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E
{
	// System.Int32 Dreamteck.Splines.TubeGenerator::_sides
	int32_t ____sides_60;
	// System.Int32 Dreamteck.Splines.TubeGenerator::_roundCapLatitude
	int32_t ____roundCapLatitude_61;
	// Dreamteck.Splines.TubeGenerator/CapMethod Dreamteck.Splines.TubeGenerator::_capMode
	int32_t ____capMode_62;
	// System.Single Dreamteck.Splines.TubeGenerator::_revolve
	float ____revolve_63;
	// System.Single Dreamteck.Splines.TubeGenerator::_capUVScale
	float ____capUVScale_64;
	// System.Single Dreamteck.Splines.TubeGenerator::_uvTwist
	float ____uvTwist_65;
	// System.Int32 Dreamteck.Splines.TubeGenerator::bodyVertexCount
	int32_t ___bodyVertexCount_66;
	// System.Int32 Dreamteck.Splines.TubeGenerator::bodyTrisCount
	int32_t ___bodyTrisCount_67;
	// System.Int32 Dreamteck.Splines.TubeGenerator::capVertexCount
	int32_t ___capVertexCount_68;
	// System.Int32 Dreamteck.Splines.TubeGenerator::capTrisCount
	int32_t ___capTrisCount_69;
};

// Dreamteck.Splines.WaveformGenerator
struct WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3  : public MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E
{
	// Dreamteck.Splines.WaveformGenerator/Axis Dreamteck.Splines.WaveformGenerator::_axis
	int32_t ____axis_60;
	// System.Boolean Dreamteck.Splines.WaveformGenerator::_symmetry
	bool ____symmetry_61;
	// Dreamteck.Splines.WaveformGenerator/UVWrapMode Dreamteck.Splines.WaveformGenerator::_uvWrapMode
	int32_t ____uvWrapMode_62;
	// System.Int32 Dreamteck.Splines.WaveformGenerator::_slices
	int32_t ____slices_63;
};

// System.Collections.Generic.List`1<System.Double>
struct List_1_t495F03F47D827883530F951D563C0BB7340E5995_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Double>

// System.Collections.Generic.List`1<UnityEngine.RaycastHit>
struct List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.RaycastHit>

// System.Collections.Generic.Queue`1<System.Object>

// System.Collections.Generic.Queue`1<System.Object>

// System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>

// System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>

// Dreamteck.Splines.SampleCollection

// Dreamteck.Splines.SampleCollection

// Dreamteck.Splines.Spline
struct Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields
{
	// UnityEngine.Vector3[] Dreamteck.Splines.Spline::catPoints
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___catPoints_7;
};

// Dreamteck.Splines.Spline

// Dreamteck.Splines.SplineThreading
struct SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields
{
	// Dreamteck.Splines.SplineThreading/ThreadDef[] Dreamteck.Splines.SplineThreading::threads
	ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* ___threads_0;
	// System.Object Dreamteck.Splines.SplineThreading::locker
	RuntimeObject* ___locker_1;
};

// Dreamteck.Splines.SplineThreading

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// Dreamteck.TS_Mesh

// Dreamteck.TS_Mesh

// Dreamteck.Splines.SplineThreading/ThreadDef

// Dreamteck.Splines.SplineThreading/ThreadDef

// Dreamteck.Splines.SplineThreading/ThreadDef/Worker

// Dreamteck.Splines.SplineThreading/ThreadDef/Worker

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// UnityEngine.Color

// UnityEngine.Color

// System.Double

// System.Double

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// UnityEngine.LayerMask

// UnityEngine.LayerMask

// UnityEngine.Mathf
struct Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682_StaticFields
{
	// System.Single UnityEngine.Mathf::Epsilon
	float ___Epsilon_0;
};

// UnityEngine.Mathf

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields
{
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___identityQuaternion_4;
};

// UnityEngine.Quaternion

// System.Single

// System.Single

// System.Threading.Thread
struct Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F_StaticFields
{
	// System.LocalDataStoreMgr System.Threading.Thread::s_LocalDataStoreMgr
	LocalDataStoreMgr_t205F1783D5CC2B148E829B5882E5406FF9A3AC1E* ___s_LocalDataStoreMgr_0;
	// System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> System.Threading.Thread::s_asyncLocalCurrentCulture
	AsyncLocal_1_t1D3339EA4C8650D2DEDDF9553E5C932B3DC2CCFD* ___s_asyncLocalCurrentCulture_4;
	// System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> System.Threading.Thread::s_asyncLocalCurrentUICulture
	AsyncLocal_1_t1D3339EA4C8650D2DEDDF9553E5C932B3DC2CCFD* ___s_asyncLocalCurrentUICulture_5;
};

// System.Threading.Thread
struct Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F_ThreadStaticFields
{
	// System.LocalDataStoreHolder System.Threading.Thread::s_LocalDataStore
	LocalDataStoreHolder_t789DD474AE5141213C2105CE57830ECFC2D3C03F* ___s_LocalDataStore_1;
	// System.Globalization.CultureInfo System.Threading.Thread::m_CurrentCulture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___m_CurrentCulture_2;
	// System.Globalization.CultureInfo System.Threading.Thread::m_CurrentUICulture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___m_CurrentUICulture_3;
	// System.Threading.Thread System.Threading.Thread::current_thread
	Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* ___current_thread_9;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector2

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// UnityEngine.Vector3

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_StaticFields
{
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___negativeInfinityVector_8;
};

// UnityEngine.Vector4

// System.Void

// System.Void

// UnityEngine.AnimationCurve

// UnityEngine.AnimationCurve

// System.Delegate

// System.Delegate

// System.Exception
struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};

// System.Exception

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};

// UnityEngine.Object

// UnityEngine.RaycastHit

// UnityEngine.RaycastHit

// Dreamteck.Splines.SplinePoint

// Dreamteck.Splines.SplinePoint

// Dreamteck.Splines.SplineSample

// Dreamteck.Splines.SplineSample

// Dreamteck.Splines.SplineTrigger

// Dreamteck.Splines.SplineTrigger

// Dreamteck.Splines.TriggerGroup

// Dreamteck.Splines.TriggerGroup

// UnityEngine.Mesh

// UnityEngine.Mesh

// System.Action

// System.Action

// System.AsyncCallback

// System.AsyncCallback

// System.Threading.ParameterizedThreadStart

// System.Threading.ParameterizedThreadStart

// System.Threading.ThreadInterruptedException

// System.Threading.ThreadInterruptedException

// UnityEngine.Transform

// UnityEngine.Transform

// Dreamteck.Splines.SplineThreading/EmptyHandler

// Dreamteck.Splines.SplineThreading/EmptyHandler

// Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler

// Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler

// Dreamteck.Splines.SplineComputer

// Dreamteck.Splines.SplineComputer

// Dreamteck.Splines.SplineUser

// Dreamteck.Splines.SplineUser

// Dreamteck.Splines.MeshGenerator
struct MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_StaticFields
{
	// UnityEngine.Vector2 Dreamteck.Splines.MeshGenerator::uvs
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___uvs_59;
};

// Dreamteck.Splines.MeshGenerator

// Dreamteck.Splines.SurfaceGenerator

// Dreamteck.Splines.SurfaceGenerator

// Dreamteck.Splines.TubeGenerator

// Dreamteck.Splines.TubeGenerator

// Dreamteck.Splines.WaveformGenerator

// Dreamteck.Splines.WaveformGenerator
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Dreamteck.Splines.SplineSample[]
struct SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE  : public RuntimeArray
{
	ALIGN_FIELD (8) SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* m_Items[1];

	inline SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 m_Items[1];

	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 value)
	{
		m_Items[index] = value;
	}
};
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 m_Items[1];

	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389  : public RuntimeArray
{
	ALIGN_FIELD (8) Color_tD001788D726C3A7F1379BEED0260B9591F440C1F m_Items[1];

	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		m_Items[index] = value;
	}
};
// Dreamteck.Splines.SplinePoint[]
struct SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C  : public RuntimeArray
{
	ALIGN_FIELD (8) SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB m_Items[1];

	inline SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.RaycastHit[]
struct RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8  : public RuntimeArray
{
	ALIGN_FIELD (8) RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 m_Items[1];

	inline RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 value)
	{
		m_Items[index] = value;
	}
};
// System.Double[]
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE  : public RuntimeArray
{
	ALIGN_FIELD (8) double m_Items[1];

	inline double GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline double* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, double value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline double GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline double* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, double value)
	{
		m_Items[index] = value;
	}
};
// Dreamteck.Splines.SplineThreading/ThreadDef[]
struct ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606  : public RuntimeArray
{
	ALIGN_FIELD (8) ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* m_Items[1];

	inline ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// Dreamteck.Splines.SplineTrigger[]
struct SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262  : public RuntimeArray
{
	ALIGN_FIELD (8) SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* m_Items[1];

	inline SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Void System.Collections.Generic.List`1<UnityEngine.RaycastHit>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC_gshared (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Double>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34_gshared (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Double>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_gshared_inline (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, double ___0_item, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.RaycastHit>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_gshared_inline (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 ___0_item, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.RaycastHit>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797_gshared (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<System.Double>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3_gshared (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.ArrayUtility::Add<System.Object>(T[]&,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArrayUtility_Add_TisRuntimeObject_mB96A4F23F8AABE7E3B695FC122614D7D37BF68D8_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918** ___0_array, RuntimeObject* ___1_item, const RuntimeMethod* method) ;
// T System.Collections.Generic.Queue`1<System.Object>::Dequeue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Queue_1_Dequeue_m86B243DF9EC238316EC3D27DF3E0AB8DB0987E84_gshared (Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.Queue`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Queue_1_get_Count_m1768ADA9855B7CDA14C9C42E098A287F1A39C3A2_gshared_inline (Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Queue`1<System.Object>::Enqueue(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Queue_1_Enqueue_m5CB8CF3906F1289F92036F0973EC5BE3450402EF_gshared (Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Queue`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Queue_1__ctor_m6E2A5A8173E0CC524496D5155C737DF8FD10D0EB_gshared (Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5* __this, const RuntimeMethod* method) ;

// System.Boolean UnityEngine.Vector2::op_Inequality(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector2_op_Inequality_mBEA93B5A0E954FEFB863DC61CB209119980EC713_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_lhs, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_rhs, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineComputer::Unsubscribe(Dreamteck.Splines.SplineUser)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineComputer_Unsubscribe_mEF0F485A661990220EB3EFCC192FD013240AEA4B (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* ___0_input, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineComputer::Subscribe(Dreamteck.Splines.SplineUser)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineComputer_Subscribe_m3385A4EA7E695FE8C60B97BE9C41E5FBCF53C046 (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* ___0_input, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Vector3::op_Inequality(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_Awake_m01397118A8B7F582739A549E42020A7D3ED78D1D (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::set_name(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Transform Dreamteck.Splines.SplineUser::get_trs()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_right()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_right_mC6DC057C23313802E2186A9E0DB760D795A758A4 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_up()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_up_mE47A9D9D96422224DD0539AA5524DA5440145BB2 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_forward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_forward_mFCFACF7165FDAB21E80E384C494DF278386CEE2F (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// Dreamteck.Splines.SplineComputer Dreamteck.Splines.SplineUser::get_spline()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.Splines.SplineComputer::get_pointCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SplineComputer_get_pointCount_m1387B94E0BA0994DEC199453682EF3E96E067AE8 (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::BuildMesh()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_BuildMesh_m4236C36A669B18C4515D7C463126F87D18E38464 (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SurfaceGenerator::Generate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_Generate_mB26ABD9C1DDE7E17782F2CCD35C8046852D3832E (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Transform::get_hasChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Transform_get_hasChanged_m570B3328E80AA338FF074A5C208500E98E440795 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.Splines.SplineUser::get_sampleCount()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) ;
// System.Boolean Dreamteck.Splines.SplineComputer::get_isClosed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SplineComputer_get_isClosed_m8DACA32E64742FC87F16C9083E7CAFD38F0BB8E4 (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineComputer::Evaluate(Dreamteck.Splines.SplineSample[]&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineComputer_Evaluate_m0604AAED91A8749A57556277B116F53BCBBBCE24 (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** ___0_results, double ___1_from, double ___2_to, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Implicit(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Implicit_m93896EF7D68FA113C42D3FE2BC6F661FC7EF514A (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_exists, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SurfaceGenerator::GetProjectedVertices(System.Int32,UnityEngine.Vector3&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_GetProjectedVertices_mA692776555C25658180719FDCFBDFE3E5A367200 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, int32_t ___0_count, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_center, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___2_normal, const RuntimeMethod* method) ;
// System.Boolean Dreamteck.Splines.SurfaceGenerator::IsClockwise(UnityEngine.Vector2[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SurfaceGenerator_IsClockwise_m58C6F229185719546E19E1E9D7E96A2919E203AD (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0_points2D, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SurfaceGenerator::GenerateSurfaceTris(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_GenerateSurfaceTris_mE36CA2D87838FBB86CF86C5AA03EC6EB4AE5AA66 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, bool ___0_flip, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.MeshGenerator::get_offset()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineUser::GetSample(System.Int32,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56 (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, int32_t ___0_index, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_target, const RuntimeMethod* method) ;
// UnityEngine.Color Dreamteck.Splines.MeshGenerator::get_color()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::op_Multiply(UnityEngine.Color,UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::InverseLerp(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline (float ___0_a, float ___1_b, float ___2_value, const RuntimeMethod* method) ;
// UnityEngine.Vector2 Dreamteck.Splines.MeshGenerator::get_uvScale()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 Dreamteck.Splines.MeshGenerator::get_uvOffset()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SplineSample::get_right()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_UnaryNegation(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SurfaceGenerator::GetIdentityVerts(UnityEngine.Vector3,UnityEngine.Vector3,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_GetIdentityVerts_mC7BDC4CD1E53A036F51168922F9C444A93DBD36A (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_center, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_normal, bool ___2_clockwise, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SplineUser::TransformOffset(Dreamteck.Splines.SplineSample,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineUser_TransformOffset_mD969E92E60072227A903E72D6952507B4B7B5E3E (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_sample, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_localOffset, const RuntimeMethod* method) ;
// UnityEngine.Quaternion Dreamteck.Splines.SplineSample::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 SplineSample_get_rotation_m4C55C2F2CA674E9A0D4ABCFE7A8B080FD0540CE4 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Quaternion::op_Multiply(UnityEngine.Quaternion,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C (Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_rotation, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_point, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___0_x, float ___1_y, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::Distance(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.Splines.SurfaceGenerator::WriteTris(System.Int32[]&,System.Int32[]&,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___0_tris, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___1_target, int32_t ___2_vertexOffset, int32_t ___3_trisOffset, bool ___4_flip, const RuntimeMethod* method) ;
// System.Int32[] Dreamteck.MeshUtility::GeneratePlaneTriangles(System.Int32[]&,System.Int32,System.Int32,System.Boolean,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* MeshUtility_GeneratePlaneTriangles_m7627A2B6F10209B80C86839A8E52EC35DC8DE957 (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___0_triangles, int32_t ___1_x, int32_t ___2_z, bool ___3_flip, int32_t ___4_startTriangleIndex, int32_t ___5_startVertex, bool ___6_reallocateArray, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Subtraction(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// System.Void Dreamteck.MeshUtility::Triangulate(UnityEngine.Vector2[],System.Int32[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshUtility_Triangulate_m5316CBBF25C2F7EA4149EAC9F5F25F677AB0935B (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0_points, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___1_output, const RuntimeMethod* method) ;
// System.Void Dreamteck.MeshUtility::FlipTriangles(System.Int32[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshUtility_FlipTriangles_mD8B1519FBF6273A03EEF1B375429E777ABB1CCF4 (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___0_triangles, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::LookRotation(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_LookRotation_mDB2CCA75B8E1AB98104F2A6E1A1EA57D0D1298D7 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_forward, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::Inverse(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_Inverse_mD9C060AC626A7B406F4984AC98F8358DC89EF512 (Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_rotation, const RuntimeMethod* method) ;
// Dreamteck.Splines.SplineSample Dreamteck.Splines.SplineUser::GetSampleRaw(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111 (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::Normalize()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Division(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline (const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::LookRotation(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_forward, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_upwards, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_right()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Project(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Project_m85DF3CB297EC5E1A17BD6266FF65E86AB7372C9B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_vector, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_onNormal, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::get_magnitude()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::Dot(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::get_one()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_zero_m32506C40EC2EE7D5D4410BF40D3EE683A3D5F32C_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_forward()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline (const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator__ctor_mC01695CDAB2865B65DC8307E3B9841B0B1B81182 (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.SplineUser::get_span()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SplineUser_get_span_m4E81282006AD4AC500D4B5B9448A415025BFEE8E (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_Reset_mB799CBB956E944F2D210D091F77D75CE92206F32 (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Boolean Dreamteck.Splines.TubeGenerator::get_useCap()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TubeGenerator_get_useCap_mBDFC07A2B79C4E3164BF845DCE00D3B1D7EFC802 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.Splines.TubeGenerator::get_sides()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.TubeGenerator::Generate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_Generate_m9FC76BE48568FC8E34F0867761439F16DC436371 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.TubeGenerator::GenerateFlatCaps()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_GenerateFlatCaps_mA78CF75F3E7C237BCBEDC144D60C98BA3D533A2C (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.TubeGenerator::GenerateRoundCaps()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_GenerateRoundCaps_m795F04EEA7FC62AB6089F68EB307B57122EB1326 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::ResetUVDistance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_ResetUVDistance_mD94F210D5CA48404969149B0883D1A98ED29021E (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.MeshGenerator::GetBaseSize(Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float MeshGenerator_GetBaseSize_m25D28E870FB60C746299133A0C8DE62F1B07256F (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_sample, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(System.Single,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline (float ___0_d, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_a, const RuntimeMethod* method) ;
// Dreamteck.Splines.MeshGenerator/UVMode Dreamteck.Splines.MeshGenerator::get_uvMode()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t MeshGenerator_get_uvMode_m069663A59CCF805CF43951424B6CE3CE106AE889_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::AddUVDistance(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_AddUVDistance_m4E91426033AE6AEB6AFEDA97AFCBB588B98EA72A (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, int32_t ___0_sampleIndex, const RuntimeMethod* method) ;
// UnityEngine.Color Dreamteck.Splines.MeshGenerator::GetBaseColor(Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F MeshGenerator_GetBaseColor_m0668E5049FD711975D9B6E34E4E0CA81028AFDD8 (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_sample, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.MeshGenerator::get_rotation()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float MeshGenerator_get_rotation_mB779241C82CC9BB0235F09AA0D249EE1B87CE122_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::AngleAxis(System.Single,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80 (float ___0_angle, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_axis, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.MeshGenerator::get_size()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::CalculateUVs(System.Double,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_CalculateUVs_mAF89F2DF16327AE09658FCCADE4E03B046BDC230 (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, double ___0_percent, float ___1_u, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Multiply(UnityEngine.Vector2,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_a, float ___1_d, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.MeshGenerator::get_uvRotation()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float MeshGenerator_get_uvRotation_m38AD623D63FEDB94A5DFEEF63F3352AC5E707964_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::get_right()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_right_m99043ED6B3D5AEA5033313FE3DA9571F39D1B280_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Addition(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Addition_m8136742CE6EE33BA4EB81C5F584678455917D2AE_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_a, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Subtraction(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_a, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_v, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_v, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Normalize(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Normalize_mEF8349CC39674236CFC694189AFD36E31F89AC8F_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.TubeGenerator::get_capUVScale()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float TubeGenerator_get_capUVScale_mEF333A82CE736CDF2EA7B378B85C5440AEDF6B81_inline (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.SplineComputer::CalculateLength(System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SplineComputer_CalculateLength_m73A79AF80927451FF66285B220F11A5F40AC630E (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, double ___0_from, double ___1_to, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.SplineUser::get_clipFrom()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double SplineUser_get_clipFrom_m699C755D0B41B89666EEAF9BC216338150573B13_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.SplineUser::get_clipTo()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double SplineUser_get_clipTo_m8887A1FBDE58D63C6681E3E70783345CE4C6AAFD_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::op_Multiply(UnityEngine.Quaternion,UnityEngine.Quaternion)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_op_Multiply_mCB375FCCC12A2EC8F9EB824A1BFB4453B58C2012_inline (Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_lhs, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rhs, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_normalized()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.WaveformGenerator::Generate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_Generate_m6C3F9AAD82374B4F77E60C67E476AC292B54BADF (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::Build()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_Build_m68DE60DDB0027B95BA65CA6A8B4D02658BB6528A (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.MeshGenerator::LateRun()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshGenerator_LateRun_mC06A5F11D453D5E4CA19E1D8B27C4B0383A587A7 (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SplineComputer::get_position()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineComputer_get_position_mD2F6425281CB9AFF55B9A81B5433F4454793D725_inline (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SplineComputer::TransformDirection(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineComputer_TransformDirection_m7F943932EB9A36F3655B4F4F64498190CD512056 (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_direction, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SplineComputer::InverseTransformPoint(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineComputer_InverseTransformPoint_mB227D68C60B30DB16D9B1B5C22D0593B918536BB (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_point, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SplineComputer::TransformPoint(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineComputer_TransformPoint_mDD08FFAEF020CCCA355C9E83DD0D741DF5A5EFCB (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_point, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Cross(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Lerp(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.Splines.SampleCollection::get_Count()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineSample::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.DMath::FloorInt(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556 (double ___0_a, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.DMath::CeilInt(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t DMath_CeilInt_m92CA33A9E6B959B6A1EF0CE1BF001C27983C34F8 (double ___0_a, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SampleCollection::GetSamplingValues(System.Double,System.Int32&,System.Double&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, int32_t* ___1_sampleIndex, double* ___2_lerp, const RuntimeMethod* method) ;
// System.Double Dreamteck.DMath::Lerp(System.Double,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30 (double ___0_a, double ___1_b, double ___2_t, const RuntimeMethod* method) ;
// System.Double Dreamteck.DMath::InverseLerp(System.Double,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double DMath_InverseLerp_mA44B700EA1DD0378E63AA498B5D91C76B8DBD60A (double ___0_a, double ___1_b, double ___2_t, const RuntimeMethod* method) ;
// System.Boolean Dreamteck.Splines.SampleCollection::get_hasSamples()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SampleCollection::Evaluate(System.Double,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_Evaluate_mE67F0879D5C0755347AA1C1D7D2D08B22B3044A1 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_result, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,Dreamteck.Splines.SplineSample,System.Double,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_Lerp_mB500F377220064E5FD7A760E312BAA168A6A7820 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_a, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_b, double ___2_t, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___3_target, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineSample::CopyFrom(Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_CopyFrom_mB1BB345F571264DD4BA0290C34F20C13615F58FE (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_input, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::FormatFromTo(System.Double&,System.Double&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764 (double* ___0_from, double* ___1_to, bool ___2_preventInvert, const RuntimeMethod* method) ;
// Dreamteck.Splines.SplineSample Dreamteck.Splines.SampleCollection::Evaluate(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* SampleCollection_Evaluate_mD98A6D806C880D45EF1713A095E70B921B730051 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.SampleCollection::EvaluatePosition(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.SampleCollection::Travel(System.Double,System.Single,Dreamteck.Splines.Spline/Direction,System.Single&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SampleCollection_Travel_mC74ADC8BD2E55C17FF9E5EAC0622217977AF0637 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_start, float ___1_distance, int32_t ___2_direction, float* ___3_moved, double ___4_clipFrom, double ___5_clipTo, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineSample::.ctor(Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample__ctor_m6BB75B83D92E2D0698FBDECDCDAB9E200DB9541E (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_input, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::get_sqrMagnitude()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::Min(System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.LinearAlgebraUtility::ProjectOnLine(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 LinearAlgebraUtility_ProjectOnLine_mEC026A5EC230133DF5B0D6C5DCFAB043236D81F6 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_fromPoint, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_toPoint, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_project, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::Max(System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,Dreamteck.Splines.SplineSample,System.Single,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_a, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_b, float ___2_t, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___3_target, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.SampleCollection::GetSamplePercent(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, int32_t ___0_sampleIndex, const RuntimeMethod* method) ;
// System.Single Dreamteck.LinearAlgebraUtility::InverseLerp(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float LinearAlgebraUtility_InverseLerp_mF97B35AB1DDDB6785E9E96EAF24768DF07A321F8 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_value, const RuntimeMethod* method) ;
// System.Int32 Dreamteck.Splines.Spline::get_iterations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) ;
// System.Double Dreamteck.DMath::Clamp01(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E (double ___0_a, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.Splines.Spline::EvaluatePosition(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_percent, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.Spline::get_moveStep()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) ;
// System.Double Dreamteck.DMath::Move(System.Double,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA (double ___0_current, double ___1_target, double ___2_amount, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::RoundToInt(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_RoundToInt_m60F8B66CF27F1FA75AA219342BD184B75771EB4B_inline (float ___0_f, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.Spline::GetClosestPoint(System.Int32,UnityEngine.Vector3,System.Double,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_GetClosestPoint_mF5C6AB0488DCE8AB8DDEC400D85555CCF15780C5 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_iterations, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_point, double ___2_start, double ___3_end, int32_t ___4_slices, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.LayerMask::op_Implicit(UnityEngine.LayerMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t LayerMask_op_Implicit_m7F5A5B9D079281AC445ED39DEE1FCFA9D795810D (LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB ___0_mask, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Physics::Linecast(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Physics_Linecast_m399C6C11AD7ECE11241A37C08BAB4D97CF3CB925 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_start, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_end, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* ___2_hitInfo, int32_t ___3_layerMask, int32_t ___4_queryTriggerInteraction, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.RaycastHit::get_point()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 RaycastHit_get_point_m02B764612562AFE0F998CC7CFB2EEDE41BA47F39 (RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.RaycastHit>::.ctor()
inline void List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9*, const RuntimeMethod*))List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Double>::.ctor()
inline void List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34 (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t495F03F47D827883530F951D563C0BB7340E5995*, const RuntimeMethod*))List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34_gshared)(__this, method);
}
// UnityEngine.RaycastHit[] UnityEngine.Physics::RaycastAll(UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Int32,UnityEngine.QueryTriggerInteraction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* Physics_RaycastAll_m8B7FB8419A65BEE78927D0EE84916E8DBE7ECD34 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_origin, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_direction, float ___2_maxDistance, int32_t ___3_layerMask, int32_t ___4_queryTriggerInteraction, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Double>::Add(T)
inline void List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_inline (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, double ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t495F03F47D827883530F951D563C0BB7340E5995*, double, const RuntimeMethod*))List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_gshared_inline)(__this, ___0_item, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.RaycastHit>::Add(T)
inline void List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_inline (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9*, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5, const RuntimeMethod*))List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_gshared_inline)(__this, ___0_item, method);
}
// T[] System.Collections.Generic.List`1<UnityEngine.RaycastHit>::ToArray()
inline RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797 (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, const RuntimeMethod* method)
{
	return ((  RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* (*) (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9*, const RuntimeMethod*))List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797_gshared)(__this, method);
}
// T[] System.Collections.Generic.List`1<System.Double>::ToArray()
inline DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3 (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, const RuntimeMethod* method)
{
	return ((  DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* (*) (List_1_t495F03F47D827883530F951D563C0BB7340E5995*, const RuntimeMethod*))List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3_gshared)(__this, method);
}
// System.Void Dreamteck.Splines.Spline::EvaluatePosition(UnityEngine.Vector3&,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_EvaluatePosition_m7312161C2C2CF4DA1EDBEFD4F0B3E65FB54707CD (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_percent, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::Evaluate(Dreamteck.Splines.SplineSample,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_result, double ___1_percent, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.Spline::GetPointPercent(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_GetPointPercent_mD3E8CF895C8F0C0A4DE9AB262479A25B3253F9E5 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_pointIndex, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::Clamp(System.Int32,System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline (int32_t ___0_value, int32_t ___1_min, int32_t ___2_max, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.AnimationCurve::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimationCurve_get_length_m259A67BB0870D3A153F6FEDBB06CB0D24089CD81 (AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimationCurve::Evaluate(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationCurve_Evaluate_m50B857043DE251A186032ADBCBB4CEF817F4EE3C (AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* __this, float ___0_time, const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::Lerp(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline (float ___0_a, float ___1_b, float ___2_t, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::Lerp(UnityEngine.Color,UnityEngine.Color,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_Lerp_mE79F87889843ECDC188E4CB5B5E1F1B2256E5EBE_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, float ___2_t, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Slerp(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::EvaluateTangent(UnityEngine.Vector3&,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_EvaluateTangent_m2FCD441A9260957B50B1668103D6F2AB22B31B44 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_percent, const RuntimeMethod* method) ;
// System.Double Dreamteck.DMath::Clamp(System.Double,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double DMath_Clamp_m5FF4D892D00AB10A164C167334755F3232981EFD (double ___0_a, double ___1_min, double ___2_max, const RuntimeMethod* method) ;
// Dreamteck.Splines.SplineSample Dreamteck.Splines.Spline::Evaluate(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* Spline_Evaluate_m7E6845261066AD52B8EB7367C904584C8AE5BFB6 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_percent, const RuntimeMethod* method) ;
// System.Single Dreamteck.Splines.Spline::CalculateLength(System.Double,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Spline_CalculateLength_m787BB23CD4D7E8E9A11DC60F88A2C0E88768DE77 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_from, double ___1_to, double ___2_resolution, const RuntimeMethod* method) ;
// System.Double Dreamteck.Splines.Spline::Travel(System.Double,System.Single,System.Single&,Dreamteck.Splines.Spline/Direction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_Travel_m3E26056E9A6ED0565DEC43E6E1FD5782BADF4176 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_start, float ___1_distance, float* ___2_moved, int32_t ___3_direction, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::GetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetPoint_mB32C7A254C40F490575EF91597EA99BC71C84A91 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_percent, int32_t ___2_pointIndex, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::GetTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetTangent_mF6E73EC157647B30D942CD7DA04345E88C43F688 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_percent, int32_t ___2_pointIndex, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::Break(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Break_mCCDEB091443D97798A4690BFA5409010ADDD74EF (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_at, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2 (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::set_type(Dreamteck.Splines.SplinePoint/Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SetTangentPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SetTangent2Position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SetTangent2Position_m5B8AF2AF551EA75864610CC9031A15E16CA6C709 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::GetCatPoints(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::CatmullRomGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_CatmullRomGetPoint_m1AC3943C3EF3392C689F1967625BE4CF7D8BD62B (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::BezierGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_BezierGetPoint_mF488DEAF2BFFE1C6457729D545B3C37FC0D6CF39 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::BSPGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_BSPGetPoint_mBB1EAF649CE9594188EBBA68994A6629952BCD2A (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_time, int32_t ___2_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::LinearGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_LinearGetPoint_m5082CFCA1CE9ED30A2C987BBCAC8D06DFB6C0CB0 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::GetCatmullRomTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetCatmullRomTangent_mC2E20E825154CD11CBB31543984660B55EE7773F (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_direction, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::BezierGetTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_BezierGetTangent_mA55EB1C827D49D884D96225A1C464ED30F6CF95C (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.Spline::LinearGetTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_LinearGetTangent_mB82558C318EAFAE8C5DE036AB7A580B049AF824C (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) ;
// Dreamteck.Splines.SplinePoint/Type Dreamteck.Splines.SplinePoint::get_type()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SmoothMirrorTangent2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::GetInterpolatedTangents(Dreamteck.Splines.SplinePoint,Dreamteck.Splines.SplinePoint,System.Single,UnityEngine.Vector3&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_GetInterpolatedTangents_mB11DCA5F98C4C5F5137968CAC801095756BAF2C1 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___0_a, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___1_b, float ___2_t, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___3_t1, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___4_t2, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Color::op_Inequality(UnityEngine.Color,UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Color_op_Inequality_mF1C733BA10E60B086AB950A71143678AE76C4D92_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_lhs, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_rhs, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SetPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SetPosition_m1F2299CBE14258E1A15D14E4DB5548FC012EB8E3 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SmoothFreeTangent2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SmoothMirrorTangent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothMirrorTangent_m6629C39EF35EED097AE1515B67CEA4F07585CB4F (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::SmoothFreeTangent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothFreeTangent_mC66202A3720F69113A60B5D62C20B91452BADB09 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_white()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline (const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m718BF2D1D560533D5B1F0E5D5C47D01C2D7774D0 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_p, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m34BE52F582225E64066CA0C9AF666C3DE6FFE281 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_p, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_t, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_mF4465401AF66C3C44EF1F4824249192284BB3440 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_tan, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_nor, float ___3_s, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___4_col, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m7DCDA279715CF65AAA5E41C7CFCAC1A2086B53FF (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_tan, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_tan2, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___3_nor, float ___4_s, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___5_col, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplinePoint::.ctor(Dreamteck.Splines.SplinePoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m952EEFB42104ED263F2287EA03F341B65FE850F3 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___0_source, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Vector3::op_Equality(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_back()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_back_mCA5A84170E8DE5CE38C0551B4CCAD647BF215E57_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dreamteck.DMath::LerpVector3(UnityEngine.Vector3,UnityEngine.Vector3,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 DMath_LerpVector3_mD7444DF6760CA16627233C2A87F392094595DF26 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, double ___2_t, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef__ctor_m4DEBDB384AE201A2DF410F046853B5A3CBC4EF66 (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Restart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Restart_m5D2F9CCAD3B5731A3B61DF4D2E73E812463F1E2C (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.ArrayUtility::Add<Dreamteck.Splines.SplineThreading/ThreadDef>(T[]&,T)
inline void ArrayUtility_Add_TisThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_m7AA2A015A47078C2BBC1C12D7F87B749CCF6EC7E (ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606** ___0_array, ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* ___1_item, const RuntimeMethod* method)
{
	((  void (*) (ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606**, ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203*, const RuntimeMethod*))ArrayUtility_Add_TisRuntimeObject_mB96A4F23F8AABE7E3B695FC122614D7D37BF68D8_gshared)(___0_array, ___1_item, method);
}
// System.Void System.Action::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Void UnityEngine.Application::add_quitting(System.Action)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Application_add_quitting_m5767AC63F23ABFD5BC3D60710906643BA536CCC5 (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___0_value, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading::Stop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_Stop_m9E741FD702CC4F2D1475284BB9BA63AB8C798494 (const RuntimeMethod* method) ;
// System.Void System.Threading.Thread::Sleep(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread_Sleep_m71DE163765BF465EC4A0163F2ED4D43143094549 (int32_t ___0_millisecondsTimeout, const RuntimeMethod* method) ;
// System.Void System.Threading.Monitor::Exit(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA (RuntimeObject* ___0_obj, const RuntimeMethod* method) ;
// System.Void System.Threading.Monitor::Enter(System.Object,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149 (RuntimeObject* ___0_obj, bool* ___1_lockTaken, const RuntimeMethod* method) ;
// T System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>::Dequeue()
inline EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* Queue_1_Dequeue_mC90913E91A7B06DCAE75B561DB0D1366461A2903 (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* __this, const RuntimeMethod* method)
{
	return ((  EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* (*) (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371*, const RuntimeMethod*))Queue_1_Dequeue_m86B243DF9EC238316EC3D27DF3E0AB8DB0987E84_gshared)(__this, method);
}
// System.Void Dreamteck.Splines.SplineThreading/EmptyHandler::Invoke()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_inline (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>::get_Count()
inline int32_t Queue_1_get_Count_m2624F89E4009D9F306525357B93267F2E9A18060_inline (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371*, const RuntimeMethod*))Queue_1_get_Count_m1768ADA9855B7CDA14C9C42E098A287F1A39C3A2_gshared_inline)(__this, method);
}
// System.Boolean System.String::op_Inequality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Inequality_m8C940F3CFC42866709D7CA931B3D77B4BE94BCB6 (String_t* ___0_a, String_t* ___1_b, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___0_str0, String_t* ___1_str1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Boolean Dreamteck.Splines.SplineThreading/ThreadDef::get_isAlive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ThreadDef_get_isAlive_mB0B5DE1368BFCE2ABFAA588ED42955217A4549A2 (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) ;
// System.Boolean Dreamteck.Splines.SplineThreading/ThreadDef::get_computing()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ThreadDef_get_computing_mFDC15BD2D22DCBC6EEAA9E1A87B8B1880D841CCD (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Queue(Dreamteck.Splines.SplineThreading/EmptyHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Queue_mC4874F604D1DC69A41F1FF0AAE9ED29BEB1A7935 (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* ___0_handler, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Interrupt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Interrupt_m13ED736535FD5A887AD7730B3C670073F693C82C (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Abort()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Abort_m3AE7C07F359AD6F99DE321E1186E22F7D4F112AC (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) ;
// System.Boolean System.Threading.Thread::get_IsAlive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Thread_get_IsAlive_m87922B882A526D780570799F497EEB4C99F005DF (Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* __this, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef/Worker::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Worker__ctor_m24E0DEC6ED9146413DC7AEEF3AF2F41E8DBC16A6 (Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* __this, const RuntimeMethod* method) ;
// System.Void System.Threading.ParameterizedThreadStart::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ParameterizedThreadStart__ctor_m31EA734851CB478E822BAB7E1B479CA4FDBF2718 (ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>::Enqueue(T)
inline void Queue_1_Enqueue_m03169B6B661DD5BE1E05AF38EC0787E4E8A47208 (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* __this, EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371*, EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE*, const RuntimeMethod*))Queue_1_Enqueue_m5CB8CF3906F1289F92036F0973EC5BE3450402EF_gshared)(__this, ___0_item, method);
}
// System.Void System.Threading.Thread::Interrupt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread_Interrupt_mDBD6FD816042E18A5B33E6EDCE1168B324DEAD7E (Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* __this, const RuntimeMethod* method) ;
// System.Void System.Threading.Thread::.ctor(System.Threading.ParameterizedThreadStart)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread__ctor_m7319B115C7E11770EEEC7F1D4A01A50E29550700 (Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* __this, ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9* ___0_start, const RuntimeMethod* method) ;
// System.Void System.Threading.Thread::Start(System.Object)
IL2CPP_EXTERN_C IL2CPP_NO_INLINE IL2CPP_METHOD_ATTR void Thread_Start_m64E3F27883C3CCCE7209F5D2BD268A33D4C71566 (Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* __this, RuntimeObject* ___0_parameter, const RuntimeMethod* method) ;
// System.Void System.Threading.Thread::Abort()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread_Abort_mB956BACF405EFC38C6A3D0B93142E4CEDD64D941 (Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Queue`1<Dreamteck.Splines.SplineThreading/EmptyHandler>::.ctor()
inline void Queue_1__ctor_mB77C6E0D45FF98C70022A1A4274DC0DF66CF6AEB (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* __this, const RuntimeMethod* method)
{
	((  void (*) (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371*, const RuntimeMethod*))Queue_1__ctor_m6E2A5A8173E0CC524496D5155C737DF8FD10D0EB_gshared)(__this, method);
}
// System.Boolean Dreamteck.Splines.SplineTrigger::Check(System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SplineTrigger_Check_m7B0807E1819E15937AA4DD856CFD7AF0A250288B (SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* __this, double ___0_previousPercent, double ___1_currentPercent, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineTrigger::Invoke(Dreamteck.Splines.SplineUser)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineTrigger_Invoke_m6B1D9EEDE84BEC94544D18FEC705989A238744B4 (SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* __this, SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* ___0_user, const RuntimeMethod* method) ;
// System.Void Dreamteck.Splines.SplineTrigger::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineTrigger_Reset_m995F2E4883C1BC9F03F60ECDB80ACC9E38117249 (SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Vector2::op_Equality(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector2_op_Equality_m6F2E069A50E787D131261E5CB25FC9E03F95B5E1_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_lhs, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_rhs, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___0_x, float ___1_y, float ___2_z, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::Clamp01(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___0_value, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::Magnitude(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_vector, const RuntimeMethod* method) ;
// System.Void UnityEngine.Quaternion::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Quaternion__ctor_m868FD60AA65DD5A8AC0C5DEB0608381A8D85FCD8_inline (Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* __this, float ___0_x, float ___1_y, float ___2_z, float ___3_w, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Color::op_Equality(UnityEngine.Color,UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Color_op_Equality_mB2BDC39B0B367BA15AA8DF22F8CB0D02D20BDC71_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_lhs, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_rhs, const RuntimeMethod* method) ;
// UnityEngine.Vector4 UnityEngine.Color::op_Implicit(UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 Color_op_Implicit_m9B3228DAFA8DC57A75DE00CBBF13ED4F1E7B01FF_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_c, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Vector4::op_Equality(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector4_op_Equality_mCEA0E5F229F4AE8C55152F7A8F84345F24F52DC6_inline (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___0_lhs, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_rhs, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* __this, float ___0_x, float ___1_y, float ___2_z, float ___3_w, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Single Dreamteck.Splines.SurfaceGenerator::get_expand()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SurfaceGenerator_get_expand_m7A50241A1A1F13EB1854A3F10F00E1F8AF6A53CA (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _expand; }
		float L_0 = __this->____expand_60;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_expand(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_expand_m588CF9965BD7E2FDD2A2706D100C476FDB908C26 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, float ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _expand)
		float L_0 = ___0_value;
		float L_1 = __this->____expand_60;
		if ((((float)L_0) == ((float)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _expand = value;
		float L_2 = ___0_value;
		__this->____expand_60 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Single Dreamteck.Splines.SurfaceGenerator::get_extrude()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SurfaceGenerator_get_extrude_m27407583EE4F11A0F7B0F802C91D952A1862753F (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _extrude; }
		float L_0 = __this->____extrude_61;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_extrude(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_extrude_mF8222745920EB233A3DD8B3C41811F0F607FA384 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, float ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _extrude)
		float L_0 = ___0_value;
		float L_1 = __this->____extrude_61;
		if ((((float)L_0) == ((float)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _extrude = value;
		float L_2 = ___0_value;
		__this->____extrude_61 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Double Dreamteck.Splines.SurfaceGenerator::get_extrudeClipFrom()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SurfaceGenerator_get_extrudeClipFrom_mA4B11B72A92EE88527827D0F4B0F53B2EC038758 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _extrudeFrom; }
		double L_0 = __this->____extrudeFrom_72;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_extrudeClipFrom(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_extrudeClipFrom_mE0819061A7AB87E8C43264D0E4D2EF4A20EF9129 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, double ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _extrudeFrom)
		double L_0 = ___0_value;
		double L_1 = __this->____extrudeFrom_72;
		if ((((double)L_0) == ((double)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _extrudeFrom = value;
		double L_2 = ___0_value;
		__this->____extrudeFrom_72 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Double Dreamteck.Splines.SurfaceGenerator::get_extrudeClipTo()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SurfaceGenerator_get_extrudeClipTo_mEC46AF0A54E7244FCFA6352CE511A47FF2E20084 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _extrudeTo; }
		double L_0 = __this->____extrudeTo_73;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_extrudeClipTo(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_extrudeClipTo_m59BC1C2C7A5BEA09F1AA08F717E2E35E8D03AF1D (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, double ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _extrudeTo)
		double L_0 = ___0_value;
		double L_1 = __this->____extrudeTo_73;
		if ((((double)L_0) == ((double)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _extrudeTo = value;
		double L_2 = ___0_value;
		__this->____extrudeTo_73 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// UnityEngine.Vector2 Dreamteck.Splines.SurfaceGenerator::get_sideUvScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 SurfaceGenerator_get_sideUvScale_m949F2F0EFCFD1BF1B1A0D6BE593AC96945EB9D15 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _sideUvScale; }
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = __this->____sideUvScale_62;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_sideUvScale(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_sideUvScale_mC56D5E4157D183D6423D23D37F8D14770D0EE8A4 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _sideUvScale)
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = __this->____sideUvScale_62;
		bool L_2;
		L_2 = Vector2_op_Inequality_mBEA93B5A0E954FEFB863DC61CB209119980EC713_inline(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_001c;
		}
	}
	{
		// _sideUvScale = value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_3 = ___0_value;
		__this->____sideUvScale_62 = L_3;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
		return;
	}

IL_001c:
	{
		// else _sideUvScale = value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4 = ___0_value;
		__this->____sideUvScale_62 = L_4;
		// }
		return;
	}
}
// UnityEngine.Vector2 Dreamteck.Splines.SurfaceGenerator::get_sideUvOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 SurfaceGenerator_get_sideUvOffset_mC50E2A3F072CB59E96BBC32C4020DAEEE931CE65 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _sideUvOffset; }
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = __this->____sideUvOffset_63;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_sideUvOffset(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_sideUvOffset_mD4A0B66B2B67D8654A64446775E67CAD282469BB (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _sideUvOffset)
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = __this->____sideUvOffset_63;
		bool L_2;
		L_2 = Vector2_op_Inequality_mBEA93B5A0E954FEFB863DC61CB209119980EC713_inline(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_001c;
		}
	}
	{
		// _sideUvOffset = value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_3 = ___0_value;
		__this->____sideUvOffset_63 = L_3;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
		return;
	}

IL_001c:
	{
		// else _sideUvOffset = value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4 = ___0_value;
		__this->____sideUvOffset_63 = L_4;
		// }
		return;
	}
}
// Dreamteck.Splines.SplineComputer Dreamteck.Splines.SurfaceGenerator::get_extrudeSpline()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* SurfaceGenerator_get_extrudeSpline_m0E0EAA7D7C8AB9A7BAB1F302796F35B3AF0F753B (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _extrudeSpline; }
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_0 = __this->____extrudeSpline_64;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_extrudeSpline(Dreamteck.Splines.SplineComputer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_extrudeSpline_m8C193D9792212D60B2F8F0D1568DD7FD4C21CD1A (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (value != _extrudeSpline)
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_0 = ___0_value;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_1 = __this->____extrudeSpline_64;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_004a;
		}
	}
	{
		// if (_extrudeSpline != null)
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_3 = __this->____extrudeSpline_64;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_3, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_4)
		{
			goto IL_0028;
		}
	}
	{
		// _extrudeSpline.Unsubscribe(this);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_5 = __this->____extrudeSpline_64;
		NullCheck(L_5);
		SplineComputer_Unsubscribe_mEF0F485A661990220EB3EFCC192FD013240AEA4B(L_5, __this, NULL);
	}

IL_0028:
	{
		// _extrudeSpline = value;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_6 = ___0_value;
		__this->____extrudeSpline_64 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____extrudeSpline_64), (void*)L_6);
		// if (value != null)
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_7 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_8;
		L_8 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_7, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_8)
		{
			goto IL_0044;
		}
	}
	{
		// _extrudeSpline.Subscribe(this);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_9 = __this->____extrudeSpline_64;
		NullCheck(L_9);
		SplineComputer_Subscribe_m3385A4EA7E695FE8C60B97BE9C41E5FBCF53C046(L_9, __this, NULL);
	}

IL_0044:
	{
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_004a:
	{
		// }
		return;
	}
}
// UnityEngine.Vector3 Dreamteck.Splines.SurfaceGenerator::get_extrudeOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SurfaceGenerator_get_extrudeOffset_m1C5022FC315745B15C77092C7CF230E5184D666F (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _extrudeOffset; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->____extrudeOffset_65;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_extrudeOffset(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_extrudeOffset_mCF08BE27BF75C05BDD40007D26F6BB690E2E18FA (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) 
{
	{
		// if(value != _extrudeOffset)
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_value;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->____extrudeOffset_65;
		bool L_2;
		L_2 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		// _extrudeOffset = value;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_value;
		__this->____extrudeOffset_65 = L_3;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_001b:
	{
		// }
		return;
	}
}
// System.Boolean Dreamteck.Splines.SurfaceGenerator::get_uniformUvs()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SurfaceGenerator_get_uniformUvs_m93FE4F3240B516BF4F1A883B5772682CB276CCD6 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uniformUvs; }
		bool L_0 = __this->____uniformUvs_74;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::set_uniformUvs(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_set_uniformUvs_m3AE7E014B31E4323165A79EA733C1E5230AA96C0 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _uniformUvs)
		bool L_0 = ___0_value;
		bool L_1 = __this->____uniformUvs_74;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _uniformUvs = value;
		bool L_2 = ___0_value;
		__this->____uniformUvs_74 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_Awake_m410EBF59D1B6B43A22604D81D222933A25397E15 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1E60ED2E7B21CE7BABE99A45D5D0998B513D58F1);
		s_Il2CppMethodInitialized = true;
	}
	{
		// base.Awake();
		MeshGenerator_Awake_m01397118A8B7F582739A549E42020A7D3ED78D1D(__this, NULL);
		// mesh.name = "surface";
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_0 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___mesh_54;
		NullCheck(L_0);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_0, _stringLiteral1E60ED2E7B21CE7BABE99A45D5D0998B513D58F1, NULL);
		// _trsRight = trs.right;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1;
		L_1 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_1);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Transform_get_right_mC6DC057C23313802E2186A9E0DB760D795A758A4(L_1, NULL);
		__this->____trsRight_75 = L_2;
		// _trsUp = trs.up;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_3;
		L_3 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Transform_get_up_mE47A9D9D96422224DD0539AA5524DA5440145BB2(L_3, NULL);
		__this->____trsUp_76 = L_4;
		// _trsForward = trs.forward;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_5;
		L_5 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Transform_get_forward_mFCFACF7165FDAB21E80E384C494DF278386CEE2F(L_5, NULL);
		__this->____trsForward_77 = L_6;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::BuildMesh()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_BuildMesh_mD0AE4709C1BD974EA466E45F06FAFC38134283B8 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// if (spline.pointCount == 0) return;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_0;
		L_0 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = SplineComputer_get_pointCount_m1387B94E0BA0994DEC199453682EF3E96E067AE8(L_0, NULL);
		if (L_1)
		{
			goto IL_000e;
		}
	}
	{
		// if (spline.pointCount == 0) return;
		return;
	}

IL_000e:
	{
		// base.BuildMesh();
		MeshGenerator_BuildMesh_m4236C36A669B18C4515D7C463126F87D18E38464(__this, NULL);
		// Generate();
		SurfaceGenerator_Generate_mB26ABD9C1DDE7E17782F2CCD35C8046852D3832E(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::LateUpdate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_LateUpdate_mB673A622421461458BB34A016ABA4F1EFC7E1867 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	{
		// if (multithreaded && trs.hasChanged)
		bool L_0 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___multithreaded_27;
		il2cpp_codegen_memory_barrier();
		if (!L_0)
		{
			goto IL_004a;
		}
	}
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1;
		L_1 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_1);
		bool L_2;
		L_2 = Transform_get_hasChanged_m570B3328E80AA338FF074A5C208500E98E440795(L_1, NULL);
		if (!L_2)
		{
			goto IL_004a;
		}
	}
	{
		// _trsRight = trs.right;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_3;
		L_3 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Transform_get_right_mC6DC057C23313802E2186A9E0DB760D795A758A4(L_3, NULL);
		__this->____trsRight_75 = L_4;
		// _trsUp = trs.up;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_5;
		L_5 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Transform_get_up_mE47A9D9D96422224DD0539AA5524DA5440145BB2(L_5, NULL);
		__this->____trsUp_76 = L_6;
		// _trsForward = trs.forward;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_7;
		L_7 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_7);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Transform_get_forward_mFCFACF7165FDAB21E80E384C494DF278386CEE2F(L_7, NULL);
		__this->____trsForward_77 = L_8;
	}

IL_004a:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::Generate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_Generate_mB26ABD9C1DDE7E17782F2CCD35C8046852D3832E (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_5;
	memset((&V_5), 0, sizeof(V_5));
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	int32_t V_9 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_10;
	memset((&V_10), 0, sizeof(V_10));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_11;
	memset((&V_11), 0, sizeof(V_11));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_12;
	memset((&V_12), 0, sizeof(V_12));
	int32_t V_13 = 0;
	int32_t V_14 = 0;
	int32_t V_15 = 0;
	int32_t V_16 = 0;
	int32_t V_17 = 0;
	float V_18 = 0.0f;
	int32_t V_19 = 0;
	int32_t V_20 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_21;
	memset((&V_21), 0, sizeof(V_21));
	int32_t V_22 = 0;
	int32_t V_23 = 0;
	int32_t V_24 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_25;
	memset((&V_25), 0, sizeof(V_25));
	int32_t V_26 = 0;
	int32_t V_27 = 0;
	int32_t V_28 = 0;
	int32_t V_29 = 0;
	int32_t V_30 = 0;
	int32_t G_B11_0 = 0;
	int32_t G_B14_0 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B51_0;
	memset((&G_B51_0), 0, sizeof(G_B51_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B51_1 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B50_0;
	memset((&G_B50_0), 0, sizeof(G_B50_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B50_1 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B52_0;
	memset((&G_B52_0), 0, sizeof(G_B52_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B52_1;
	memset((&G_B52_1), 0, sizeof(G_B52_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B52_2 = NULL;
	int32_t G_B82_0 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B82_1 = NULL;
	int32_t G_B81_0 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B81_1 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B83_0;
	memset((&G_B83_0), 0, sizeof(G_B83_0));
	int32_t G_B83_1 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B83_2 = NULL;
	{
		// if (!multithreaded)
		bool L_0 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___multithreaded_27;
		il2cpp_codegen_memory_barrier();
		if (L_0)
		{
			goto IL_003d;
		}
	}
	{
		// _trsRight = trs.right;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1;
		L_1 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_1);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Transform_get_right_mC6DC057C23313802E2186A9E0DB760D795A758A4(L_1, NULL);
		__this->____trsRight_75 = L_2;
		// _trsUp = trs.up;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_3;
		L_3 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Transform_get_up_mE47A9D9D96422224DD0539AA5524DA5440145BB2(L_3, NULL);
		__this->____trsUp_76 = L_4;
		// _trsForward = trs.forward;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_5;
		L_5 = SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline(__this, NULL);
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Transform_get_forward_mFCFACF7165FDAB21E80E384C494DF278386CEE2F(L_5, NULL);
		__this->____trsForward_77 = L_6;
	}

IL_003d:
	{
		// int surfaceVertexCount = sampleCount;
		int32_t L_7;
		L_7 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		V_0 = L_7;
		// if (spline.isClosed) surfaceVertexCount--;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_8;
		L_8 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		NullCheck(L_8);
		bool L_9;
		L_9 = SplineComputer_get_isClosed_m8DACA32E64742FC87F16C9083E7CAFD38F0BB8E4(L_8, NULL);
		if (!L_9)
		{
			goto IL_0055;
		}
	}
	{
		// if (spline.isClosed) surfaceVertexCount--;
		int32_t L_10 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_10, 1));
	}

IL_0055:
	{
		// int vertexCount = surfaceVertexCount;
		int32_t L_11 = V_0;
		V_1 = L_11;
		// if (_extrudeSpline != null)
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_12 = __this->____extrudeSpline_64;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_13;
		L_13 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_12, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_13)
		{
			goto IL_0084;
		}
	}
	{
		// _extrudeSpline.Evaluate(ref extrudeResults, _extrudeFrom, _extrudeTo);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_14 = __this->____extrudeSpline_64;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_15 = (&__this->___extrudeResults_66);
		double L_16 = __this->____extrudeFrom_72;
		double L_17 = __this->____extrudeTo_73;
		NullCheck(L_14);
		SplineComputer_Evaluate_m0604AAED91A8749A57556277B116F53BCBBBCE24(L_14, L_15, L_16, L_17, NULL);
		goto IL_0099;
	}

IL_0084:
	{
		// } else if(extrudeResults.Length > 0)
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_18 = __this->___extrudeResults_66;
		NullCheck(L_18);
		if (!(((RuntimeArray*)L_18)->max_length))
		{
			goto IL_0099;
		}
	}
	{
		// extrudeResults = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_19 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___extrudeResults_66 = L_19;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___extrudeResults_66), (void*)L_19);
	}

IL_0099:
	{
		// bool pathExtrude = _extrudeSpline && extrudeResults.Length > 0;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_20 = __this->____extrudeSpline_64;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_21;
		L_21 = Object_op_Implicit_m93896EF7D68FA113C42D3FE2BC6F661FC7EF514A(L_20, NULL);
		if (!L_21)
		{
			goto IL_00b2;
		}
	}
	{
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_22 = __this->___extrudeResults_66;
		NullCheck(L_22);
		G_B11_0 = ((!(((uint32_t)(((RuntimeArray*)L_22)->max_length)) <= ((uint32_t)0)))? 1 : 0);
		goto IL_00b3;
	}

IL_00b2:
	{
		G_B11_0 = 0;
	}

IL_00b3:
	{
		V_2 = (bool)G_B11_0;
		// bool simpleExtrude = !pathExtrude && _extrude != 0f;
		bool L_23 = V_2;
		if (L_23)
		{
			goto IL_00c9;
		}
	}
	{
		float L_24 = __this->____extrude_61;
		G_B14_0 = ((((int32_t)((((float)L_24) == ((float)(0.0f)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_00ca;
	}

IL_00c9:
	{
		G_B14_0 = 0;
	}

IL_00ca:
	{
		V_3 = (bool)G_B14_0;
		// if (pathExtrude)
		bool L_25 = V_2;
		if (!L_25)
		{
			goto IL_00e6;
		}
	}
	{
		// vertexCount *= 2;
		int32_t L_26 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_multiply(L_26, 2));
		// vertexCount += sampleCount * extrudeResults.Length;
		int32_t L_27 = V_1;
		int32_t L_28;
		L_28 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_29 = __this->___extrudeResults_66;
		NullCheck(L_29);
		V_1 = ((int32_t)il2cpp_codegen_add(L_27, ((int32_t)il2cpp_codegen_multiply(L_28, ((int32_t)(((RuntimeArray*)L_29)->max_length))))));
		goto IL_00f1;
	}

IL_00e6:
	{
		// else if (simpleExtrude)
		bool L_30 = V_3;
		if (!L_30)
		{
			goto IL_00f1;
		}
	}
	{
		// vertexCount *= 4;
		int32_t L_31 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_multiply(L_31, 4));
		// vertexCount += 2;
		int32_t L_32 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_32, 2));
	}

IL_00f1:
	{
		// GetProjectedVertices(surfaceVertexCount, out center, out normal);
		int32_t L_33 = V_0;
		SurfaceGenerator_GetProjectedVertices_mA692776555C25658180719FDCFBDFE3E5A367200(__this, L_33, (&V_4), (&V_5), NULL);
		// bool clockwise = IsClockwise(projectedVerts);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_34 = __this->___projectedVerts_69;
		bool L_35;
		L_35 = SurfaceGenerator_IsClockwise_m58C6F229185719546E19E1E9D7E96A2919E203AD(__this, L_34, NULL);
		V_6 = L_35;
		// bool flipCap = false;
		V_7 = (bool)0;
		// bool flipSide = false;
		V_8 = (bool)0;
		// if (!clockwise) flipSide = !flipSide;
		bool L_36 = V_6;
		if (L_36)
		{
			goto IL_011b;
		}
	}
	{
		// if (!clockwise) flipSide = !flipSide;
		bool L_37 = V_8;
		V_8 = (bool)((((int32_t)L_37) == ((int32_t)0))? 1 : 0);
	}

IL_011b:
	{
		// if (simpleExtrude && _extrude < 0f)
		bool L_38 = V_3;
		if (!L_38)
		{
			goto IL_0139;
		}
	}
	{
		float L_39 = __this->____extrude_61;
		if ((!(((float)L_39) < ((float)(0.0f)))))
		{
			goto IL_0139;
		}
	}
	{
		// flipCap = !flipCap;
		bool L_40 = V_7;
		V_7 = (bool)((((int32_t)L_40) == ((int32_t)0))? 1 : 0);
		// flipSide = !flipSide;
		bool L_41 = V_8;
		V_8 = (bool)((((int32_t)L_41) == ((int32_t)0))? 1 : 0);
	}

IL_0139:
	{
		// GenerateSurfaceTris(flipCap);
		bool L_42 = V_7;
		SurfaceGenerator_GenerateSurfaceTris_mE36CA2D87838FBB86CF86C5AA03EC6EB4AE5AA66(__this, L_42, NULL);
		// int totalTrisCount = surfaceTris.Length;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_43 = __this->___surfaceTris_70;
		NullCheck(L_43);
		V_9 = ((int32_t)(((RuntimeArray*)L_43)->max_length));
		// if (simpleExtrude)
		bool L_44 = V_3;
		if (!L_44)
		{
			goto IL_0167;
		}
	}
	{
		// totalTrisCount *= 2;
		int32_t L_45 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_multiply(L_45, 2));
		// totalTrisCount += 2 * sampleCount * 2 * 3;
		int32_t L_46 = V_9;
		int32_t L_47;
		L_47 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		V_9 = ((int32_t)il2cpp_codegen_add(L_46, ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(2, L_47)), 2)), 3))));
		goto IL_0185;
	}

IL_0167:
	{
		// totalTrisCount *= 2;
		int32_t L_48 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_multiply(L_48, 2));
		// totalTrisCount += extrudeResults .Length * sampleCount * 2 * 3;
		int32_t L_49 = V_9;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_50 = __this->___extrudeResults_66;
		NullCheck(L_50);
		int32_t L_51;
		L_51 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		V_9 = ((int32_t)il2cpp_codegen_add(L_49, ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)(((RuntimeArray*)L_50)->max_length)), L_51)), 2)), 3))));
	}

IL_0185:
	{
		// AllocateMesh(vertexCount, totalTrisCount);
		int32_t L_52 = V_1;
		int32_t L_53 = V_9;
		VirtualActionInvoker2< int32_t, int32_t >::Invoke(24 /* System.Void Dreamteck.Splines.MeshGenerator::AllocateMesh(System.Int32,System.Int32) */, __this, L_52, L_53);
		// Vector3 off = _trsRight * offset.x + _trsUp * offset.y + _trsForward * offset.z;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54 = __this->____trsRight_75;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55;
		L_55 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_56 = L_55.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57;
		L_57 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_54, L_56, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58 = __this->____trsUp_76;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59;
		L_59 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_60 = L_59.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_61;
		L_61 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_58, L_60, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_62;
		L_62 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_57, L_61, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_63 = __this->____trsForward_77;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_64;
		L_64 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_65 = L_64.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_66;
		L_66 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_63, L_65, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_67;
		L_67 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_62, L_66, NULL);
		V_10 = L_67;
		// for (int i = 0; i < surfaceVertexCount; i++)
		V_13 = 0;
		goto IL_025e;
	}

IL_01e1:
	{
		// GetSample(i, evalResult);
		int32_t L_68 = V_13;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_69 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, L_68, L_69, NULL);
		// tsMesh.vertices[i] = evalResult.position + off;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_70 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_70);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_71 = L_70->___vertices_0;
		int32_t L_72 = V_13;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_73 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_73);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_74 = L_73->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_75 = V_10;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_76;
		L_76 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_74, L_75, NULL);
		NullCheck(L_71);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_76);
		// tsMesh.normals[i] = evalResult.up;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_77 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_77);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_78 = L_77->___normals_1;
		int32_t L_79 = V_13;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_80 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_80);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81 = L_80->___up_1;
		NullCheck(L_78);
		(L_78)->SetAt(static_cast<il2cpp_array_size_t>(L_79), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_81);
		// tsMesh.colors[i] = evalResult.color * color;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_82 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_82);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_83 = L_82->___colors_3;
		int32_t L_84 = V_13;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_85 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_85);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_86 = L_85->___color_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_87;
		L_87 = MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline(__this, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_88;
		L_88 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_86, L_87, NULL);
		NullCheck(L_83);
		(L_83)->SetAt(static_cast<il2cpp_array_size_t>(L_84), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_88);
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_89 = V_13;
		V_13 = ((int32_t)il2cpp_codegen_add(L_89, 1));
	}

IL_025e:
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_90 = V_13;
		int32_t L_91 = V_0;
		if ((((int32_t)L_90) < ((int32_t)L_91)))
		{
			goto IL_01e1;
		}
	}
	{
		// Vector2 min = projectedVerts[0];
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_92 = __this->___projectedVerts_69;
		NullCheck(L_92);
		int32_t L_93 = 0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_94 = (L_92)->GetAt(static_cast<il2cpp_array_size_t>(L_93));
		V_11 = L_94;
		// Vector2 max = projectedVerts[0];
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_95 = __this->___projectedVerts_69;
		NullCheck(L_95);
		int32_t L_96 = 0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_97 = (L_95)->GetAt(static_cast<il2cpp_array_size_t>(L_96));
		V_12 = L_97;
		// for (int i = 1; i < projectedVerts.Length; i++)
		V_14 = 1;
		goto IL_0360;
	}

IL_028a:
	{
		// if (min.x < projectedVerts[i].x) min.x = projectedVerts[i].x;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_98 = V_11;
		float L_99 = L_98.___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_100 = __this->___projectedVerts_69;
		int32_t L_101 = V_14;
		NullCheck(L_100);
		float L_102 = ((L_100)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_101)))->___x_0;
		if ((!(((float)L_99) < ((float)L_102))))
		{
			goto IL_02be;
		}
	}
	{
		// if (min.x < projectedVerts[i].x) min.x = projectedVerts[i].x;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_103 = __this->___projectedVerts_69;
		int32_t L_104 = V_14;
		NullCheck(L_103);
		float L_105 = ((L_103)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_104)))->___x_0;
		(&V_11)->___x_0 = L_105;
	}

IL_02be:
	{
		// if (min.y < projectedVerts[i].y) min.y = projectedVerts[i].y;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_106 = V_11;
		float L_107 = L_106.___y_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_108 = __this->___projectedVerts_69;
		int32_t L_109 = V_14;
		NullCheck(L_108);
		float L_110 = ((L_108)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_109)))->___y_1;
		if ((!(((float)L_107) < ((float)L_110))))
		{
			goto IL_02f2;
		}
	}
	{
		// if (min.y < projectedVerts[i].y) min.y = projectedVerts[i].y;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_111 = __this->___projectedVerts_69;
		int32_t L_112 = V_14;
		NullCheck(L_111);
		float L_113 = ((L_111)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_112)))->___y_1;
		(&V_11)->___y_1 = L_113;
	}

IL_02f2:
	{
		// if (max.x > projectedVerts[i].x) max.x = projectedVerts[i].x;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_114 = V_12;
		float L_115 = L_114.___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_116 = __this->___projectedVerts_69;
		int32_t L_117 = V_14;
		NullCheck(L_116);
		float L_118 = ((L_116)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_117)))->___x_0;
		if ((!(((float)L_115) > ((float)L_118))))
		{
			goto IL_0326;
		}
	}
	{
		// if (max.x > projectedVerts[i].x) max.x = projectedVerts[i].x;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_119 = __this->___projectedVerts_69;
		int32_t L_120 = V_14;
		NullCheck(L_119);
		float L_121 = ((L_119)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_120)))->___x_0;
		(&V_12)->___x_0 = L_121;
	}

IL_0326:
	{
		// if (max.y > projectedVerts[i].y) max.y = projectedVerts[i].y;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_122 = V_12;
		float L_123 = L_122.___y_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_124 = __this->___projectedVerts_69;
		int32_t L_125 = V_14;
		NullCheck(L_124);
		float L_126 = ((L_124)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_125)))->___y_1;
		if ((!(((float)L_123) > ((float)L_126))))
		{
			goto IL_035a;
		}
	}
	{
		// if (max.y > projectedVerts[i].y) max.y = projectedVerts[i].y;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_127 = __this->___projectedVerts_69;
		int32_t L_128 = V_14;
		NullCheck(L_127);
		float L_129 = ((L_127)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_128)))->___y_1;
		(&V_12)->___y_1 = L_129;
	}

IL_035a:
	{
		// for (int i = 1; i < projectedVerts.Length; i++)
		int32_t L_130 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_add(L_130, 1));
	}

IL_0360:
	{
		// for (int i = 1; i < projectedVerts.Length; i++)
		int32_t L_131 = V_14;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_132 = __this->___projectedVerts_69;
		NullCheck(L_132);
		if ((((int32_t)L_131) < ((int32_t)((int32_t)(((RuntimeArray*)L_132)->max_length)))))
		{
			goto IL_028a;
		}
	}
	{
		// for (int i = 0; i < projectedVerts.Length; i++)
		V_15 = 0;
		goto IL_0455;
	}

IL_0377:
	{
		// tsMesh.uv[i].x = Mathf.InverseLerp(max.x, min.x, projectedVerts[i].x) * uvScale.x - uvScale.x * 0.5f + uvOffset.x + 0.5f;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_133 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_133);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_134 = L_133->___uv_4;
		int32_t L_135 = V_15;
		NullCheck(L_134);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_136 = V_12;
		float L_137 = L_136.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_138 = V_11;
		float L_139 = L_138.___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_140 = __this->___projectedVerts_69;
		int32_t L_141 = V_15;
		NullCheck(L_140);
		float L_142 = ((L_140)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_141)))->___x_0;
		float L_143;
		L_143 = Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline(L_137, L_139, L_142, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_144;
		L_144 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_145 = L_144.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_146;
		L_146 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_147 = L_146.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_148;
		L_148 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_149 = L_148.___x_0;
		((L_134)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_135)))->___x_0 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_143, L_145)), ((float)il2cpp_codegen_multiply(L_147, (0.5f))))), L_149)), (0.5f)));
		// tsMesh.uv[i].y = Mathf.InverseLerp(min.y, max.y, projectedVerts[i].y) * uvScale.y - uvScale.y * 0.5f + uvOffset.y + 0.5f;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_150 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_150);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_151 = L_150->___uv_4;
		int32_t L_152 = V_15;
		NullCheck(L_151);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_153 = V_11;
		float L_154 = L_153.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_155 = V_12;
		float L_156 = L_155.___y_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_157 = __this->___projectedVerts_69;
		int32_t L_158 = V_15;
		NullCheck(L_157);
		float L_159 = ((L_157)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_158)))->___y_1;
		float L_160;
		L_160 = Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline(L_154, L_156, L_159, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_161;
		L_161 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_162 = L_161.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_163;
		L_163 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_164 = L_163.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_165;
		L_165 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_166 = L_165.___y_1;
		((L_151)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_152)))->___y_1 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_160, L_162)), ((float)il2cpp_codegen_multiply(L_164, (0.5f))))), L_166)), (0.5f)));
		// for (int i = 0; i < projectedVerts.Length; i++)
		int32_t L_167 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_167, 1));
	}

IL_0455:
	{
		// for (int i = 0; i < projectedVerts.Length; i++)
		int32_t L_168 = V_15;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_169 = __this->___projectedVerts_69;
		NullCheck(L_169);
		if ((((int32_t)L_168) < ((int32_t)((int32_t)(((RuntimeArray*)L_169)->max_length)))))
		{
			goto IL_0377;
		}
	}
	{
		// if (flipCap)
		bool L_170 = V_7;
		if (!L_170)
		{
			goto IL_049f;
		}
	}
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		V_16 = 0;
		goto IL_049a;
	}

IL_046d:
	{
		// tsMesh.normals[i] *= -1f;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_171 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_171);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_172 = L_171->___normals_1;
		int32_t L_173 = V_16;
		NullCheck(L_172);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_174 = ((L_172)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_173)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_175 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_174);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_176;
		L_176 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_175, (-1.0f), NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_174 = L_176;
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_177 = V_16;
		V_16 = ((int32_t)il2cpp_codegen_add(L_177, 1));
	}

IL_049a:
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_178 = V_16;
		int32_t L_179 = V_0;
		if ((((int32_t)L_178) < ((int32_t)L_179)))
		{
			goto IL_046d;
		}
	}

IL_049f:
	{
		// if (_expand != 0f)
		float L_180 = __this->____expand_60;
		if ((((float)L_180) == ((float)(0.0f))))
		{
			goto IL_0518;
		}
	}
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		V_17 = 0;
		goto IL_0513;
	}

IL_04b1:
	{
		// GetSample(i, evalResult);
		int32_t L_181 = V_17;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_182 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, L_181, L_182, NULL);
		// tsMesh.vertices[i] += (clockwise ? -evalResult.right : evalResult.right) * _expand;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_183 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_183);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_184 = L_183->___vertices_0;
		int32_t L_185 = V_17;
		NullCheck(L_184);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_186 = ((L_184)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_185)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_187 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_186);
		bool L_188 = V_6;
		G_B50_0 = L_187;
		G_B50_1 = L_186;
		if (L_188)
		{
			G_B51_0 = L_187;
			G_B51_1 = L_186;
			goto IL_04e8;
		}
	}
	{
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_189 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_189);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_190;
		L_190 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_189, NULL);
		G_B52_0 = L_190;
		G_B52_1 = G_B50_0;
		G_B52_2 = G_B50_1;
		goto IL_04f8;
	}

IL_04e8:
	{
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_191 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_191);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_192;
		L_192 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_191, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_193;
		L_193 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_192, NULL);
		G_B52_0 = L_193;
		G_B52_1 = G_B51_0;
		G_B52_2 = G_B51_1;
	}

IL_04f8:
	{
		float L_194 = __this->____expand_60;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_195;
		L_195 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(G_B52_0, L_194, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_196;
		L_196 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(G_B52_1, L_195, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)G_B52_2 = L_196;
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_197 = V_17;
		V_17 = ((int32_t)il2cpp_codegen_add(L_197, 1));
	}

IL_0513:
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_198 = V_17;
		int32_t L_199 = V_0;
		if ((((int32_t)L_198) < ((int32_t)L_199)))
		{
			goto IL_04b1;
		}
	}

IL_0518:
	{
		// if (pathExtrude)
		bool L_200 = V_2;
		if (!L_200)
		{
			goto IL_09de;
		}
	}
	{
		// GetIdentityVerts(center, normal, clockwise);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_201 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_202 = V_5;
		bool L_203 = V_6;
		SurfaceGenerator_GetIdentityVerts_mC7BDC4CD1E53A036F51168922F9C444A93DBD36A(__this, L_201, L_202, L_203, NULL);
		// for (int i = 0; i < surfaceVertexCount; i++)
		V_20 = 0;
		goto IL_072c;
	}

IL_0532:
	{
		// Vector3 vertexOffset = TransformOffset(extrudeResults[0], _extrudeOffset);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_204 = __this->___extrudeResults_66;
		NullCheck(L_204);
		int32_t L_205 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_206 = (L_204)->GetAt(static_cast<il2cpp_array_size_t>(L_205));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_207 = __this->____extrudeOffset_65;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_208;
		L_208 = SplineUser_TransformOffset_mD969E92E60072227A903E72D6952507B4B7B5E3E(L_206, L_207, NULL);
		V_21 = L_208;
		// tsMesh.vertices[i + surfaceVertexCount] = extrudeResults[0].position + (extrudeResults[0].rotation * identityVertices[i] + off) + vertexOffset;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_209 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_209);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_210 = L_209->___vertices_0;
		int32_t L_211 = V_20;
		int32_t L_212 = V_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_213 = __this->___extrudeResults_66;
		NullCheck(L_213);
		int32_t L_214 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_215 = (L_213)->GetAt(static_cast<il2cpp_array_size_t>(L_214));
		NullCheck(L_215);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_216 = L_215->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_217 = __this->___extrudeResults_66;
		NullCheck(L_217);
		int32_t L_218 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_219 = (L_217)->GetAt(static_cast<il2cpp_array_size_t>(L_218));
		NullCheck(L_219);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_220;
		L_220 = SplineSample_get_rotation_m4C55C2F2CA674E9A0D4ABCFE7A8B080FD0540CE4(L_219, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_221 = __this->___identityVertices_67;
		int32_t L_222 = V_20;
		NullCheck(L_221);
		int32_t L_223 = L_222;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_224 = (L_221)->GetAt(static_cast<il2cpp_array_size_t>(L_223));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_225;
		L_225 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_220, L_224, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_226 = V_10;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_227;
		L_227 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_225, L_226, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_228;
		L_228 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_216, L_227, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_229 = V_21;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_230;
		L_230 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_228, L_229, NULL);
		NullCheck(L_210);
		(L_210)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_211, L_212))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_230);
		// tsMesh.normals[i + surfaceVertexCount] = -extrudeResults[0].forward;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_231 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_231);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_232 = L_231->___normals_1;
		int32_t L_233 = V_20;
		int32_t L_234 = V_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_235 = __this->___extrudeResults_66;
		NullCheck(L_235);
		int32_t L_236 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_237 = (L_235)->GetAt(static_cast<il2cpp_array_size_t>(L_236));
		NullCheck(L_237);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_238 = L_237->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_239;
		L_239 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_238, NULL);
		NullCheck(L_232);
		(L_232)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_233, L_234))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_239);
		// tsMesh.colors[i + surfaceVertexCount] = tsMesh.colors[i] * extrudeResults[0].color;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_240 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_240);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_241 = L_240->___colors_3;
		int32_t L_242 = V_20;
		int32_t L_243 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_244 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_244);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_245 = L_244->___colors_3;
		int32_t L_246 = V_20;
		NullCheck(L_245);
		int32_t L_247 = L_246;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_248 = (L_245)->GetAt(static_cast<il2cpp_array_size_t>(L_247));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_249 = __this->___extrudeResults_66;
		NullCheck(L_249);
		int32_t L_250 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_251 = (L_249)->GetAt(static_cast<il2cpp_array_size_t>(L_250));
		NullCheck(L_251);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_252 = L_251->___color_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_253;
		L_253 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_248, L_252, NULL);
		NullCheck(L_241);
		(L_241)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_242, L_243))), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_253);
		// tsMesh.uv[i + surfaceVertexCount] = new Vector2(1f - tsMesh.uv[i].x, tsMesh.uv[i].y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_254 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_254);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_255 = L_254->___uv_4;
		int32_t L_256 = V_20;
		int32_t L_257 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_258 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_258);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_259 = L_258->___uv_4;
		int32_t L_260 = V_20;
		NullCheck(L_259);
		float L_261 = ((L_259)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_260)))->___x_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_262 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_262);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_263 = L_262->___uv_4;
		int32_t L_264 = V_20;
		NullCheck(L_263);
		float L_265 = ((L_263)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_264)))->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_266;
		memset((&L_266), 0, sizeof(L_266));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_266), ((float)il2cpp_codegen_subtract((1.0f), L_261)), L_265, /*hidden argument*/NULL);
		NullCheck(L_255);
		(L_255)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_256, L_257))), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_266);
		// vertexOffset = TransformOffset(extrudeResults[extrudeResults.Length - 1], _extrudeOffset);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_267 = __this->___extrudeResults_66;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_268 = __this->___extrudeResults_66;
		NullCheck(L_268);
		NullCheck(L_267);
		int32_t L_269 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_268)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_270 = (L_267)->GetAt(static_cast<il2cpp_array_size_t>(L_269));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_271 = __this->____extrudeOffset_65;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_272;
		L_272 = SplineUser_TransformOffset_mD969E92E60072227A903E72D6952507B4B7B5E3E(L_270, L_271, NULL);
		V_21 = L_272;
		// tsMesh.vertices[i] = extrudeResults[extrudeResults.Length - 1].position + (extrudeResults[extrudeResults.Length - 1].rotation * identityVertices[i] + off) + vertexOffset;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_273 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_273);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_274 = L_273->___vertices_0;
		int32_t L_275 = V_20;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_276 = __this->___extrudeResults_66;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_277 = __this->___extrudeResults_66;
		NullCheck(L_277);
		NullCheck(L_276);
		int32_t L_278 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_277)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_279 = (L_276)->GetAt(static_cast<il2cpp_array_size_t>(L_278));
		NullCheck(L_279);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_280 = L_279->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_281 = __this->___extrudeResults_66;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_282 = __this->___extrudeResults_66;
		NullCheck(L_282);
		NullCheck(L_281);
		int32_t L_283 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_282)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_284 = (L_281)->GetAt(static_cast<il2cpp_array_size_t>(L_283));
		NullCheck(L_284);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_285;
		L_285 = SplineSample_get_rotation_m4C55C2F2CA674E9A0D4ABCFE7A8B080FD0540CE4(L_284, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_286 = __this->___identityVertices_67;
		int32_t L_287 = V_20;
		NullCheck(L_286);
		int32_t L_288 = L_287;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_289 = (L_286)->GetAt(static_cast<il2cpp_array_size_t>(L_288));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_290;
		L_290 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_285, L_289, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_291 = V_10;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_292;
		L_292 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_290, L_291, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_293;
		L_293 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_280, L_292, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_294 = V_21;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_295;
		L_295 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_293, L_294, NULL);
		NullCheck(L_274);
		(L_274)->SetAt(static_cast<il2cpp_array_size_t>(L_275), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_295);
		// tsMesh.normals[i] = extrudeResults[extrudeResults.Length - 1].forward;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_296 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_296);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_297 = L_296->___normals_1;
		int32_t L_298 = V_20;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_299 = __this->___extrudeResults_66;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_300 = __this->___extrudeResults_66;
		NullCheck(L_300);
		NullCheck(L_299);
		int32_t L_301 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_300)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_302 = (L_299)->GetAt(static_cast<il2cpp_array_size_t>(L_301));
		NullCheck(L_302);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_303 = L_302->___forward_2;
		NullCheck(L_297);
		(L_297)->SetAt(static_cast<il2cpp_array_size_t>(L_298), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_303);
		// tsMesh.colors[i] *= extrudeResults[extrudeResults.Length - 1].color;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_304 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_304);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_305 = L_304->___colors_3;
		int32_t L_306 = V_20;
		NullCheck(L_305);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* L_307 = ((L_305)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_306)));
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_308 = (*(Color_tD001788D726C3A7F1379BEED0260B9591F440C1F*)L_307);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_309 = __this->___extrudeResults_66;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_310 = __this->___extrudeResults_66;
		NullCheck(L_310);
		NullCheck(L_309);
		int32_t L_311 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_310)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_312 = (L_309)->GetAt(static_cast<il2cpp_array_size_t>(L_311));
		NullCheck(L_312);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_313 = L_312->___color_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_314;
		L_314 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_308, L_313, NULL);
		*(Color_tD001788D726C3A7F1379BEED0260B9591F440C1F*)L_307 = L_314;
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_315 = V_20;
		V_20 = ((int32_t)il2cpp_codegen_add(L_315, 1));
	}

IL_072c:
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_316 = V_20;
		int32_t L_317 = V_0;
		if ((((int32_t)L_316) < ((int32_t)L_317)))
		{
			goto IL_0532;
		}
	}
	{
		// float totalLength = 0f;
		V_18 = (0.0f);
		// for (int i = 0; i < extrudeResults.Length; i++)
		V_22 = 0;
		goto IL_0956;
	}

IL_0743:
	{
		// if (_uniformUvs && i > 0) totalLength += Vector3.Distance(extrudeResults[i].position, extrudeResults[i - 1].position);
		bool L_318 = __this->____uniformUvs_74;
		if (!L_318)
		{
			goto IL_0778;
		}
	}
	{
		int32_t L_319 = V_22;
		if ((((int32_t)L_319) <= ((int32_t)0)))
		{
			goto IL_0778;
		}
	}
	{
		// if (_uniformUvs && i > 0) totalLength += Vector3.Distance(extrudeResults[i].position, extrudeResults[i - 1].position);
		float L_320 = V_18;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_321 = __this->___extrudeResults_66;
		int32_t L_322 = V_22;
		NullCheck(L_321);
		int32_t L_323 = L_322;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_324 = (L_321)->GetAt(static_cast<il2cpp_array_size_t>(L_323));
		NullCheck(L_324);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_325 = L_324->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_326 = __this->___extrudeResults_66;
		int32_t L_327 = V_22;
		NullCheck(L_326);
		int32_t L_328 = ((int32_t)il2cpp_codegen_subtract(L_327, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_329 = (L_326)->GetAt(static_cast<il2cpp_array_size_t>(L_328));
		NullCheck(L_329);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_330 = L_329->___position_0;
		float L_331;
		L_331 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_325, L_330, NULL);
		V_18 = ((float)il2cpp_codegen_add(L_320, L_331));
	}

IL_0778:
	{
		// int startIndex = surfaceVertexCount * 2 + i * sampleCount;
		int32_t L_332 = V_0;
		int32_t L_333 = V_22;
		int32_t L_334;
		L_334 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		V_23 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_332, 2)), ((int32_t)il2cpp_codegen_multiply(L_333, L_334))));
		// for (int n = 0; n < identityVertices.Length; n++)
		V_24 = 0;
		goto IL_0941;
	}

IL_078f:
	{
		// Vector3 vertexOffset = TransformOffset(extrudeResults[i], _extrudeOffset);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_335 = __this->___extrudeResults_66;
		int32_t L_336 = V_22;
		NullCheck(L_335);
		int32_t L_337 = L_336;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_338 = (L_335)->GetAt(static_cast<il2cpp_array_size_t>(L_337));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_339 = __this->____extrudeOffset_65;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_340;
		L_340 = SplineUser_TransformOffset_mD969E92E60072227A903E72D6952507B4B7B5E3E(L_338, L_339, NULL);
		V_25 = L_340;
		// tsMesh.vertices[startIndex + n] = extrudeResults[i].position + (extrudeResults[i].rotation * identityVertices[n] + off) + vertexOffset;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_341 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_341);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_342 = L_341->___vertices_0;
		int32_t L_343 = V_23;
		int32_t L_344 = V_24;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_345 = __this->___extrudeResults_66;
		int32_t L_346 = V_22;
		NullCheck(L_345);
		int32_t L_347 = L_346;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_348 = (L_345)->GetAt(static_cast<il2cpp_array_size_t>(L_347));
		NullCheck(L_348);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_349 = L_348->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_350 = __this->___extrudeResults_66;
		int32_t L_351 = V_22;
		NullCheck(L_350);
		int32_t L_352 = L_351;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_353 = (L_350)->GetAt(static_cast<il2cpp_array_size_t>(L_352));
		NullCheck(L_353);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_354;
		L_354 = SplineSample_get_rotation_m4C55C2F2CA674E9A0D4ABCFE7A8B080FD0540CE4(L_353, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_355 = __this->___identityVertices_67;
		int32_t L_356 = V_24;
		NullCheck(L_355);
		int32_t L_357 = L_356;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_358 = (L_355)->GetAt(static_cast<il2cpp_array_size_t>(L_357));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_359;
		L_359 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_354, L_358, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_360 = V_10;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_361;
		L_361 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_359, L_360, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_362;
		L_362 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_349, L_361, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_363 = V_25;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_364;
		L_364 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_362, L_363, NULL);
		NullCheck(L_342);
		(L_342)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_343, L_344))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_364);
		// tsMesh.normals[startIndex + n] = extrudeResults[i].rotation * identityNormals[n];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_365 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_365);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_366 = L_365->___normals_1;
		int32_t L_367 = V_23;
		int32_t L_368 = V_24;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_369 = __this->___extrudeResults_66;
		int32_t L_370 = V_22;
		NullCheck(L_369);
		int32_t L_371 = L_370;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_372 = (L_369)->GetAt(static_cast<il2cpp_array_size_t>(L_371));
		NullCheck(L_372);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_373;
		L_373 = SplineSample_get_rotation_m4C55C2F2CA674E9A0D4ABCFE7A8B080FD0540CE4(L_372, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_374 = __this->___identityNormals_68;
		int32_t L_375 = V_24;
		NullCheck(L_374);
		int32_t L_376 = L_375;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_377 = (L_374)->GetAt(static_cast<il2cpp_array_size_t>(L_376));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_378;
		L_378 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_373, L_377, NULL);
		NullCheck(L_366);
		(L_366)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_367, L_368))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_378);
		// if (_uniformUvs) tsMesh.uv[startIndex + n] = new Vector2((float)n / (identityVertices.Length - 1) * _sideUvScale.x + _sideUvOffset.x, totalLength * _sideUvScale.y + _sideUvOffset.y);
		bool L_379 = __this->____uniformUvs_74;
		if (!L_379)
		{
			goto IL_0895;
		}
	}
	{
		// if (_uniformUvs) tsMesh.uv[startIndex + n] = new Vector2((float)n / (identityVertices.Length - 1) * _sideUvScale.x + _sideUvOffset.x, totalLength * _sideUvScale.y + _sideUvOffset.y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_380 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_380);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_381 = L_380->___uv_4;
		int32_t L_382 = V_23;
		int32_t L_383 = V_24;
		int32_t L_384 = V_24;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_385 = __this->___identityVertices_67;
		NullCheck(L_385);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_386 = (&__this->____sideUvScale_62);
		float L_387 = L_386->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_388 = (&__this->____sideUvOffset_63);
		float L_389 = L_388->___x_0;
		float L_390 = V_18;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_391 = (&__this->____sideUvScale_62);
		float L_392 = L_391->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_393 = (&__this->____sideUvOffset_63);
		float L_394 = L_393->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_395;
		memset((&L_395), 0, sizeof(L_395));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_395), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)L_384)/((float)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_385)->max_length)), 1))))), L_387)), L_389)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_390, L_392)), L_394)), /*hidden argument*/NULL);
		NullCheck(L_381);
		(L_381)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_382, L_383))), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_395);
		goto IL_08fd;
	}

IL_0895:
	{
		// else tsMesh.uv[startIndex + n] = new Vector2((float)n / (identityVertices.Length - 1) * _sideUvScale.x + _sideUvOffset.x, (float)i / (extrudeResults.Length - 1) * _sideUvScale.y + _sideUvOffset.y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_396 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_396);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_397 = L_396->___uv_4;
		int32_t L_398 = V_23;
		int32_t L_399 = V_24;
		int32_t L_400 = V_24;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_401 = __this->___identityVertices_67;
		NullCheck(L_401);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_402 = (&__this->____sideUvScale_62);
		float L_403 = L_402->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_404 = (&__this->____sideUvOffset_63);
		float L_405 = L_404->___x_0;
		int32_t L_406 = V_22;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_407 = __this->___extrudeResults_66;
		NullCheck(L_407);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_408 = (&__this->____sideUvScale_62);
		float L_409 = L_408->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_410 = (&__this->____sideUvOffset_63);
		float L_411 = L_410->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_412;
		memset((&L_412), 0, sizeof(L_412));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_412), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)L_400)/((float)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_401)->max_length)), 1))))), L_403)), L_405)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)L_406)/((float)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_407)->max_length)), 1))))), L_409)), L_411)), /*hidden argument*/NULL);
		NullCheck(L_397);
		(L_397)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_398, L_399))), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_412);
	}

IL_08fd:
	{
		// if (clockwise) tsMesh.uv[startIndex + n].x = 1f - tsMesh.uv[startIndex + n].x;
		bool L_413 = V_6;
		if (!L_413)
		{
			goto IL_093b;
		}
	}
	{
		// if (clockwise) tsMesh.uv[startIndex + n].x = 1f - tsMesh.uv[startIndex + n].x;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_414 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_414);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_415 = L_414->___uv_4;
		int32_t L_416 = V_23;
		int32_t L_417 = V_24;
		NullCheck(L_415);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_418 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_418);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_419 = L_418->___uv_4;
		int32_t L_420 = V_23;
		int32_t L_421 = V_24;
		NullCheck(L_419);
		float L_422 = ((L_419)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_420, L_421)))))->___x_0;
		((L_415)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_416, L_417)))))->___x_0 = ((float)il2cpp_codegen_subtract((1.0f), L_422));
	}

IL_093b:
	{
		// for (int n = 0; n < identityVertices.Length; n++)
		int32_t L_423 = V_24;
		V_24 = ((int32_t)il2cpp_codegen_add(L_423, 1));
	}

IL_0941:
	{
		// for (int n = 0; n < identityVertices.Length; n++)
		int32_t L_424 = V_24;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_425 = __this->___identityVertices_67;
		NullCheck(L_425);
		if ((((int32_t)L_424) < ((int32_t)((int32_t)(((RuntimeArray*)L_425)->max_length)))))
		{
			goto IL_078f;
		}
	}
	{
		// for (int i = 0; i < extrudeResults.Length; i++)
		int32_t L_426 = V_22;
		V_22 = ((int32_t)il2cpp_codegen_add(L_426, 1));
	}

IL_0956:
	{
		// for (int i = 0; i < extrudeResults.Length; i++)
		int32_t L_427 = V_22;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_428 = __this->___extrudeResults_66;
		NullCheck(L_428);
		if ((((int32_t)L_427) < ((int32_t)((int32_t)(((RuntimeArray*)L_428)->max_length)))))
		{
			goto IL_0743;
		}
	}
	{
		// int written = WriteTris(ref surfaceTris, ref tsMesh.triangles, 0, 0, false);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_429 = (&__this->___surfaceTris_70);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_430 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_430);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_431 = (&L_430->___triangles_8);
		int32_t L_432;
		L_432 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_429, L_431, 0, 0, (bool)0, NULL);
		V_19 = L_432;
		// written = WriteTris(ref surfaceTris, ref tsMesh.triangles, surfaceVertexCount, written, true);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_433 = (&__this->___surfaceTris_70);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_434 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_434);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_435 = (&L_434->___triangles_8);
		int32_t L_436 = V_0;
		int32_t L_437 = V_19;
		int32_t L_438;
		L_438 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_433, L_435, L_436, L_437, (bool)1, NULL);
		V_19 = L_438;
		// MeshUtility.GeneratePlaneTriangles(ref wallTris, sampleCount - 1, extrudeResults.Length, flipSide, 0, 0, true);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_439 = (&__this->___wallTris_71);
		int32_t L_440;
		L_440 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_441 = __this->___extrudeResults_66;
		NullCheck(L_441);
		bool L_442 = V_8;
		il2cpp_codegen_runtime_class_init_inline(MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_443;
		L_443 = MeshUtility_GeneratePlaneTriangles_m7627A2B6F10209B80C86839A8E52EC35DC8DE957(L_439, ((int32_t)il2cpp_codegen_subtract(L_440, 1)), ((int32_t)(((RuntimeArray*)L_441)->max_length)), L_442, 0, 0, (bool)1, NULL);
		// WriteTris(ref wallTris, ref tsMesh.triangles, surfaceVertexCount * 2, written, false);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_444 = (&__this->___wallTris_71);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_445 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_445);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_446 = (&L_445->___triangles_8);
		int32_t L_447 = V_0;
		int32_t L_448 = V_19;
		int32_t L_449;
		L_449 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_444, L_446, ((int32_t)il2cpp_codegen_multiply(L_447, 2)), L_448, (bool)0, NULL);
		return;
	}

IL_09de:
	{
		// else if (simpleExtrude)
		bool L_450 = V_3;
		if (!L_450)
		{
			goto IL_0e1a;
		}
	}
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		V_27 = 0;
		goto IL_0ae5;
	}

IL_09ec:
	{
		// tsMesh.vertices[i + surfaceVertexCount] = tsMesh.vertices[i];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_451 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_451);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_452 = L_451->___vertices_0;
		int32_t L_453 = V_27;
		int32_t L_454 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_455 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_455);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_456 = L_455->___vertices_0;
		int32_t L_457 = V_27;
		NullCheck(L_456);
		int32_t L_458 = L_457;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_459 = (L_456)->GetAt(static_cast<il2cpp_array_size_t>(L_458));
		NullCheck(L_452);
		(L_452)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_453, L_454))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_459);
		// tsMesh.normals[i + surfaceVertexCount] = -tsMesh.normals[i];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_460 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_460);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_461 = L_460->___normals_1;
		int32_t L_462 = V_27;
		int32_t L_463 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_464 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_464);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_465 = L_464->___normals_1;
		int32_t L_466 = V_27;
		NullCheck(L_465);
		int32_t L_467 = L_466;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_468 = (L_465)->GetAt(static_cast<il2cpp_array_size_t>(L_467));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_469;
		L_469 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_468, NULL);
		NullCheck(L_461);
		(L_461)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_462, L_463))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_469);
		// tsMesh.colors[i + surfaceVertexCount] = tsMesh.colors[i];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_470 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_470);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_471 = L_470->___colors_3;
		int32_t L_472 = V_27;
		int32_t L_473 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_474 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_474);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_475 = L_474->___colors_3;
		int32_t L_476 = V_27;
		NullCheck(L_475);
		int32_t L_477 = L_476;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_478 = (L_475)->GetAt(static_cast<il2cpp_array_size_t>(L_477));
		NullCheck(L_471);
		(L_471)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_472, L_473))), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_478);
		// tsMesh.uv[i + surfaceVertexCount] = new Vector2(1f - tsMesh.uv[i].x, tsMesh.uv[i].y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_479 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_479);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_480 = L_479->___uv_4;
		int32_t L_481 = V_27;
		int32_t L_482 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_483 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_483);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_484 = L_483->___uv_4;
		int32_t L_485 = V_27;
		NullCheck(L_484);
		float L_486 = ((L_484)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_485)))->___x_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_487 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_487);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_488 = L_487->___uv_4;
		int32_t L_489 = V_27;
		NullCheck(L_488);
		float L_490 = ((L_488)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_489)))->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_491;
		memset((&L_491), 0, sizeof(L_491));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_491), ((float)il2cpp_codegen_subtract((1.0f), L_486)), L_490, /*hidden argument*/NULL);
		NullCheck(L_480);
		(L_480)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_481, L_482))), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_491);
		// tsMesh.vertices[i] += normal * _extrude;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_492 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_492);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_493 = L_492->___vertices_0;
		int32_t L_494 = V_27;
		NullCheck(L_493);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_495 = ((L_493)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_494)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_496 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_495);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_497 = V_5;
		float L_498 = __this->____extrude_61;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_499;
		L_499 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_497, L_498, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_500;
		L_500 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_496, L_499, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_495 = L_500;
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_501 = V_27;
		V_27 = ((int32_t)il2cpp_codegen_add(L_501, 1));
	}

IL_0ae5:
	{
		// for (int i = 0; i < surfaceVertexCount; i++)
		int32_t L_502 = V_27;
		int32_t L_503 = V_0;
		if ((((int32_t)L_502) < ((int32_t)L_503)))
		{
			goto IL_09ec;
		}
	}
	{
		// for (int i = 0; i < surfaceVertexCount + 1; i++)
		V_28 = 0;
		goto IL_0d9e;
	}

IL_0af5:
	{
		// int index = i;
		int32_t L_504 = V_28;
		V_29 = L_504;
		// if (i >= surfaceVertexCount) index = i - surfaceVertexCount;
		int32_t L_505 = V_28;
		int32_t L_506 = V_0;
		if ((((int32_t)L_505) < ((int32_t)L_506)))
		{
			goto IL_0b04;
		}
	}
	{
		// if (i >= surfaceVertexCount) index = i - surfaceVertexCount;
		int32_t L_507 = V_28;
		int32_t L_508 = V_0;
		V_29 = ((int32_t)il2cpp_codegen_subtract(L_507, L_508));
	}

IL_0b04:
	{
		// GetSample(index, evalResult);
		int32_t L_509 = V_29;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_510 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, L_509, L_510, NULL);
		// tsMesh.vertices[i + surfaceVertexCount * 2] = tsMesh.vertices[index] - normal * _extrude;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_511 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_511);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_512 = L_511->___vertices_0;
		int32_t L_513 = V_28;
		int32_t L_514 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_515 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_515);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_516 = L_515->___vertices_0;
		int32_t L_517 = V_29;
		NullCheck(L_516);
		int32_t L_518 = L_517;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_519 = (L_516)->GetAt(static_cast<il2cpp_array_size_t>(L_518));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_520 = V_5;
		float L_521 = __this->____extrude_61;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_522;
		L_522 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_520, L_521, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_523;
		L_523 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_519, L_522, NULL);
		NullCheck(L_512);
		(L_512)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_513, ((int32_t)il2cpp_codegen_multiply(L_514, 2))))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_523);
		// tsMesh.normals[i + surfaceVertexCount * 2] = clockwise ? -evalResult.right : evalResult.right;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_524 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_524);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_525 = L_524->___normals_1;
		int32_t L_526 = V_28;
		int32_t L_527 = V_0;
		bool L_528 = V_6;
		G_B81_0 = ((int32_t)il2cpp_codegen_add(L_526, ((int32_t)il2cpp_codegen_multiply(L_527, 2))));
		G_B81_1 = L_525;
		if (L_528)
		{
			G_B82_0 = ((int32_t)il2cpp_codegen_add(L_526, ((int32_t)il2cpp_codegen_multiply(L_527, 2))));
			G_B82_1 = L_525;
			goto IL_0b6e;
		}
	}
	{
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_529 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_529);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_530;
		L_530 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_529, NULL);
		G_B83_0 = L_530;
		G_B83_1 = G_B81_0;
		G_B83_2 = G_B81_1;
		goto IL_0b7e;
	}

IL_0b6e:
	{
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_531 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_531);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_532;
		L_532 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_531, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_533;
		L_533 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_532, NULL);
		G_B83_0 = L_533;
		G_B83_1 = G_B82_0;
		G_B83_2 = G_B82_1;
	}

IL_0b7e:
	{
		NullCheck(G_B83_2);
		(G_B83_2)->SetAt(static_cast<il2cpp_array_size_t>(G_B83_1), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)G_B83_0);
		// tsMesh.colors[i + surfaceVertexCount * 2] = tsMesh.colors[index];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_534 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_534);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_535 = L_534->___colors_3;
		int32_t L_536 = V_28;
		int32_t L_537 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_538 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_538);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_539 = L_538->___colors_3;
		int32_t L_540 = V_29;
		NullCheck(L_539);
		int32_t L_541 = L_540;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_542 = (L_539)->GetAt(static_cast<il2cpp_array_size_t>(L_541));
		NullCheck(L_535);
		(L_535)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_536, ((int32_t)il2cpp_codegen_multiply(L_537, 2))))), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_542);
		// tsMesh.uv[i + surfaceVertexCount * 2] = new Vector2((float)i / (surfaceVertexCount - 1) * _sideUvScale.x + _sideUvOffset.x, 0f + _sideUvOffset.y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_543 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_543);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_544 = L_543->___uv_4;
		int32_t L_545 = V_28;
		int32_t L_546 = V_0;
		int32_t L_547 = V_28;
		int32_t L_548 = V_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_549 = (&__this->____sideUvScale_62);
		float L_550 = L_549->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_551 = (&__this->____sideUvOffset_63);
		float L_552 = L_551->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_553 = (&__this->____sideUvOffset_63);
		float L_554 = L_553->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_555;
		memset((&L_555), 0, sizeof(L_555));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_555), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)L_547)/((float)((int32_t)il2cpp_codegen_subtract(L_548, 1))))), L_550)), L_552)), ((float)il2cpp_codegen_add((0.0f), L_554)), /*hidden argument*/NULL);
		NullCheck(L_544);
		(L_544)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_545, ((int32_t)il2cpp_codegen_multiply(L_546, 2))))), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_555);
		// if (clockwise) tsMesh.uv[i + surfaceVertexCount * 2].x = 1f - tsMesh.uv[i + surfaceVertexCount * 2].x;
		bool L_556 = V_6;
		if (!L_556)
		{
			goto IL_0c37;
		}
	}
	{
		// if (clockwise) tsMesh.uv[i + surfaceVertexCount * 2].x = 1f - tsMesh.uv[i + surfaceVertexCount * 2].x;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_557 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_557);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_558 = L_557->___uv_4;
		int32_t L_559 = V_28;
		int32_t L_560 = V_0;
		NullCheck(L_558);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_561 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_561);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_562 = L_561->___uv_4;
		int32_t L_563 = V_28;
		int32_t L_564 = V_0;
		NullCheck(L_562);
		float L_565 = ((L_562)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_563, ((int32_t)il2cpp_codegen_multiply(L_564, 2)))))))->___x_0;
		((L_558)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_559, ((int32_t)il2cpp_codegen_multiply(L_560, 2)))))))->___x_0 = ((float)il2cpp_codegen_subtract((1.0f), L_565));
	}

IL_0c37:
	{
		// int offsetIndex = i + surfaceVertexCount * 3 + 1;
		int32_t L_566 = V_28;
		int32_t L_567 = V_0;
		V_30 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_566, ((int32_t)il2cpp_codegen_multiply(L_567, 3)))), 1));
		// tsMesh.vertices[offsetIndex] = tsMesh.vertices[index];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_568 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_568);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_569 = L_568->___vertices_0;
		int32_t L_570 = V_30;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_571 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_571);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_572 = L_571->___vertices_0;
		int32_t L_573 = V_29;
		NullCheck(L_572);
		int32_t L_574 = L_573;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_575 = (L_572)->GetAt(static_cast<il2cpp_array_size_t>(L_574));
		NullCheck(L_569);
		(L_569)->SetAt(static_cast<il2cpp_array_size_t>(L_570), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_575);
		// tsMesh.normals[offsetIndex] = tsMesh.normals[i + surfaceVertexCount * 2];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_576 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_576);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_577 = L_576->___normals_1;
		int32_t L_578 = V_30;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_579 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_579);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_580 = L_579->___normals_1;
		int32_t L_581 = V_28;
		int32_t L_582 = V_0;
		NullCheck(L_580);
		int32_t L_583 = ((int32_t)il2cpp_codegen_add(L_581, ((int32_t)il2cpp_codegen_multiply(L_582, 2))));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_584 = (L_580)->GetAt(static_cast<il2cpp_array_size_t>(L_583));
		NullCheck(L_577);
		(L_577)->SetAt(static_cast<il2cpp_array_size_t>(L_578), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_584);
		// tsMesh.colors[offsetIndex] = tsMesh.colors[index];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_585 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_585);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_586 = L_585->___colors_3;
		int32_t L_587 = V_30;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_588 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_588);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_589 = L_588->___colors_3;
		int32_t L_590 = V_29;
		NullCheck(L_589);
		int32_t L_591 = L_590;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_592 = (L_589)->GetAt(static_cast<il2cpp_array_size_t>(L_591));
		NullCheck(L_586);
		(L_586)->SetAt(static_cast<il2cpp_array_size_t>(L_587), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_592);
		// if (_uniformUvs) tsMesh.uv[offsetIndex] = new Vector2((float)i / surfaceVertexCount * _sideUvScale.x + _sideUvOffset.x, _extrude * _sideUvScale.y + _sideUvOffset.y);
		bool L_593 = __this->____uniformUvs_74;
		if (!L_593)
		{
			goto IL_0d0e;
		}
	}
	{
		// if (_uniformUvs) tsMesh.uv[offsetIndex] = new Vector2((float)i / surfaceVertexCount * _sideUvScale.x + _sideUvOffset.x, _extrude * _sideUvScale.y + _sideUvOffset.y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_594 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_594);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_595 = L_594->___uv_4;
		int32_t L_596 = V_30;
		int32_t L_597 = V_28;
		int32_t L_598 = V_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_599 = (&__this->____sideUvScale_62);
		float L_600 = L_599->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_601 = (&__this->____sideUvOffset_63);
		float L_602 = L_601->___x_0;
		float L_603 = __this->____extrude_61;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_604 = (&__this->____sideUvScale_62);
		float L_605 = L_604->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_606 = (&__this->____sideUvOffset_63);
		float L_607 = L_606->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_608;
		memset((&L_608), 0, sizeof(L_608));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_608), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)L_597)/((float)L_598))), L_600)), L_602)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_603, L_605)), L_607)), /*hidden argument*/NULL);
		NullCheck(L_595);
		(L_595)->SetAt(static_cast<il2cpp_array_size_t>(L_596), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_608);
		goto IL_0d60;
	}

IL_0d0e:
	{
		// else tsMesh.uv[offsetIndex] = new Vector2((float)i / surfaceVertexCount * _sideUvScale.x + _sideUvOffset.x, 1f * _sideUvScale.y + _sideUvOffset.y);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_609 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_609);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_610 = L_609->___uv_4;
		int32_t L_611 = V_30;
		int32_t L_612 = V_28;
		int32_t L_613 = V_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_614 = (&__this->____sideUvScale_62);
		float L_615 = L_614->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_616 = (&__this->____sideUvOffset_63);
		float L_617 = L_616->___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_618 = (&__this->____sideUvScale_62);
		float L_619 = L_618->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_620 = (&__this->____sideUvOffset_63);
		float L_621 = L_620->___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_622;
		memset((&L_622), 0, sizeof(L_622));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_622), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)L_612)/((float)L_613))), L_615)), L_617)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply((1.0f), L_619)), L_621)), /*hidden argument*/NULL);
		NullCheck(L_610);
		(L_610)->SetAt(static_cast<il2cpp_array_size_t>(L_611), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_622);
	}

IL_0d60:
	{
		// if (clockwise) tsMesh.uv[offsetIndex].x = 1f - tsMesh.uv[offsetIndex].x;
		bool L_623 = V_6;
		if (!L_623)
		{
			goto IL_0d98;
		}
	}
	{
		// if (clockwise) tsMesh.uv[offsetIndex].x = 1f - tsMesh.uv[offsetIndex].x;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_624 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_624);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_625 = L_624->___uv_4;
		int32_t L_626 = V_30;
		NullCheck(L_625);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_627 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_627);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_628 = L_627->___uv_4;
		int32_t L_629 = V_30;
		NullCheck(L_628);
		float L_630 = ((L_628)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_629)))->___x_0;
		((L_625)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_626)))->___x_0 = ((float)il2cpp_codegen_subtract((1.0f), L_630));
	}

IL_0d98:
	{
		// for (int i = 0; i < surfaceVertexCount + 1; i++)
		int32_t L_631 = V_28;
		V_28 = ((int32_t)il2cpp_codegen_add(L_631, 1));
	}

IL_0d9e:
	{
		// for (int i = 0; i < surfaceVertexCount + 1; i++)
		int32_t L_632 = V_28;
		int32_t L_633 = V_0;
		if ((((int32_t)L_632) < ((int32_t)((int32_t)il2cpp_codegen_add(L_633, 1)))))
		{
			goto IL_0af5;
		}
	}
	{
		// int written = WriteTris(ref surfaceTris, ref tsMesh.triangles, 0, 0, false);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_634 = (&__this->___surfaceTris_70);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_635 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_635);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_636 = (&L_635->___triangles_8);
		int32_t L_637;
		L_637 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_634, L_636, 0, 0, (bool)0, NULL);
		V_26 = L_637;
		// written = WriteTris(ref surfaceTris, ref tsMesh.triangles, surfaceVertexCount, written, true);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_638 = (&__this->___surfaceTris_70);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_639 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_639);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_640 = (&L_639->___triangles_8);
		int32_t L_641 = V_0;
		int32_t L_642 = V_26;
		int32_t L_643;
		L_643 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_638, L_640, L_641, L_642, (bool)1, NULL);
		V_26 = L_643;
		// MeshUtility.GeneratePlaneTriangles(ref wallTris, sampleCount - 1, 2, flipSide, 0, 0, true);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_644 = (&__this->___wallTris_71);
		int32_t L_645;
		L_645 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		bool L_646 = V_8;
		il2cpp_codegen_runtime_class_init_inline(MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_647;
		L_647 = MeshUtility_GeneratePlaneTriangles_m7627A2B6F10209B80C86839A8E52EC35DC8DE957(L_644, ((int32_t)il2cpp_codegen_subtract(L_645, 1)), 2, L_646, 0, 0, (bool)1, NULL);
		// WriteTris(ref wallTris, ref tsMesh.triangles, surfaceVertexCount * 2, written, false);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_648 = (&__this->___wallTris_71);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_649 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_649);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_650 = (&L_649->___triangles_8);
		int32_t L_651 = V_0;
		int32_t L_652 = V_26;
		int32_t L_653;
		L_653 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_648, L_650, ((int32_t)il2cpp_codegen_multiply(L_651, 2)), L_652, (bool)0, NULL);
		return;
	}

IL_0e1a:
	{
		// WriteTris(ref surfaceTris, ref tsMesh.triangles, 0, 0, false);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_654 = (&__this->___surfaceTris_70);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_655 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_655);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_656 = (&L_655->___triangles_8);
		int32_t L_657;
		L_657 = SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058(__this, L_654, L_656, 0, 0, (bool)0, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::GenerateSurfaceTris(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_GenerateSurfaceTris_mE36CA2D87838FBB86CF86C5AA03EC6EB4AE5AA66 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, bool ___0_flip, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MeshUtility.Triangulate(projectedVerts, ref surfaceTris);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_0 = __this->___projectedVerts_69;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_1 = (&__this->___surfaceTris_70);
		il2cpp_codegen_runtime_class_init_inline(MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		MeshUtility_Triangulate_m5316CBBF25C2F7EA4149EAC9F5F25F677AB0935B(L_0, L_1, NULL);
		// if (flip) MeshUtility.FlipTriangles(ref surfaceTris);
		bool L_2 = ___0_flip;
		if (!L_2)
		{
			goto IL_001f;
		}
	}
	{
		// if (flip) MeshUtility.FlipTriangles(ref surfaceTris);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_3 = (&__this->___surfaceTris_70);
		il2cpp_codegen_runtime_class_init_inline(MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		MeshUtility_FlipTriangles_mD8B1519FBF6273A03EEF1B375429E777ABB1CCF4(L_3, NULL);
	}

IL_001f:
	{
		// }
		return;
	}
}
// System.Int32 Dreamteck.Splines.SurfaceGenerator::WriteTris(System.Int32[]&,System.Int32[]&,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SurfaceGenerator_WriteTris_m3D5B2293A4020845D2CF1A0DAB049D5FD49FF058 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___0_tris, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___1_target, int32_t ___2_vertexOffset, int32_t ___3_trisOffset, bool ___4_flip, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// for (int i = trisOffset; i < trisOffset + tris.Length; i += 3)
		int32_t L_0 = ___3_trisOffset;
		V_0 = L_0;
		goto IL_006d;
	}

IL_0005:
	{
		// if (flip)
		bool L_1 = ___4_flip;
		if (!L_1)
		{
			goto IL_003a;
		}
	}
	{
		// target[i] = tris[i + 2 - trisOffset] + vertexOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_2 = ___1_target;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_2);
		int32_t L_4 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_5 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_5);
		int32_t L_7 = V_0;
		int32_t L_8 = ___3_trisOffset;
		NullCheck(L_6);
		int32_t L_9 = ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_7, 2)), L_8));
		int32_t L_10 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		int32_t L_11 = ___2_vertexOffset;
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(L_4), (int32_t)((int32_t)il2cpp_codegen_add(L_10, L_11)));
		// target[i + 1] = tris[i + 1 - trisOffset] + vertexOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_12 = ___1_target;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_13 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_12);
		int32_t L_14 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_15 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_16 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_15);
		int32_t L_17 = V_0;
		int32_t L_18 = ___3_trisOffset;
		NullCheck(L_16);
		int32_t L_19 = ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_17, 1)), L_18));
		int32_t L_20 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		int32_t L_21 = ___2_vertexOffset;
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_14, 1))), (int32_t)((int32_t)il2cpp_codegen_add(L_20, L_21)));
		// target[i + 2] = tris[i - trisOffset] + vertexOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_22 = ___1_target;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_23 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_22);
		int32_t L_24 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_25 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_26 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_25);
		int32_t L_27 = V_0;
		int32_t L_28 = ___3_trisOffset;
		NullCheck(L_26);
		int32_t L_29 = ((int32_t)il2cpp_codegen_subtract(L_27, L_28));
		int32_t L_30 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_29));
		int32_t L_31 = ___2_vertexOffset;
		NullCheck(L_23);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_24, 2))), (int32_t)((int32_t)il2cpp_codegen_add(L_30, L_31)));
		goto IL_0069;
	}

IL_003a:
	{
		// target[i] = tris[i - trisOffset] + vertexOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_32 = ___1_target;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_33 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_32);
		int32_t L_34 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_35 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_36 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_35);
		int32_t L_37 = V_0;
		int32_t L_38 = ___3_trisOffset;
		NullCheck(L_36);
		int32_t L_39 = ((int32_t)il2cpp_codegen_subtract(L_37, L_38));
		int32_t L_40 = (L_36)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		int32_t L_41 = ___2_vertexOffset;
		NullCheck(L_33);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(L_34), (int32_t)((int32_t)il2cpp_codegen_add(L_40, L_41)));
		// target[i + 1] = tris[i + 1 - trisOffset] + vertexOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_42 = ___1_target;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_43 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_42);
		int32_t L_44 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_45 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_46 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_45);
		int32_t L_47 = V_0;
		int32_t L_48 = ___3_trisOffset;
		NullCheck(L_46);
		int32_t L_49 = ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_47, 1)), L_48));
		int32_t L_50 = (L_46)->GetAt(static_cast<il2cpp_array_size_t>(L_49));
		int32_t L_51 = ___2_vertexOffset;
		NullCheck(L_43);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_44, 1))), (int32_t)((int32_t)il2cpp_codegen_add(L_50, L_51)));
		// target[i + 2] = tris[i + 2 - trisOffset] + vertexOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_52 = ___1_target;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_53 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_52);
		int32_t L_54 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_55 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_56 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_55);
		int32_t L_57 = V_0;
		int32_t L_58 = ___3_trisOffset;
		NullCheck(L_56);
		int32_t L_59 = ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_57, 2)), L_58));
		int32_t L_60 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_59));
		int32_t L_61 = ___2_vertexOffset;
		NullCheck(L_53);
		(L_53)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_54, 2))), (int32_t)((int32_t)il2cpp_codegen_add(L_60, L_61)));
	}

IL_0069:
	{
		// for (int i = trisOffset; i < trisOffset + tris.Length; i += 3)
		int32_t L_62 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_62, 3));
	}

IL_006d:
	{
		// for (int i = trisOffset; i < trisOffset + tris.Length; i += 3)
		int32_t L_63 = V_0;
		int32_t L_64 = ___3_trisOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_65 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_66 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_65);
		NullCheck(L_66);
		if ((((int32_t)L_63) < ((int32_t)((int32_t)il2cpp_codegen_add(L_64, ((int32_t)(((RuntimeArray*)L_66)->max_length)))))))
		{
			goto IL_0005;
		}
	}
	{
		// return trisOffset + tris.Length;
		int32_t L_67 = ___3_trisOffset;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_68 = ___0_tris;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_69 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_68);
		NullCheck(L_69);
		return ((int32_t)il2cpp_codegen_add(L_67, ((int32_t)(((RuntimeArray*)L_69)->max_length))));
	}
}
// System.Boolean Dreamteck.Splines.SurfaceGenerator::IsClockwise(UnityEngine.Vector2[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SurfaceGenerator_IsClockwise_m58C6F229185719546E19E1E9D7E96A2919E203AD (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0_points2D, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_2;
	memset((&V_2), 0, sizeof(V_2));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_3;
	memset((&V_3), 0, sizeof(V_3));
	{
		// float sum = 0f;
		V_0 = (0.0f);
		// for (int i = 1; i < points2D.Length; i++)
		V_1 = 1;
		goto IL_0042;
	}

IL_000a:
	{
		// Vector2 v1 = points2D[i];
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_0 = ___0_points2D;
		int32_t L_1 = V_1;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_2 = L_3;
		// Vector2 v2 = points2D[(i + 1) % points2D.Length];
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_4 = ___0_points2D;
		int32_t L_5 = V_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_6 = ___0_points2D;
		NullCheck(L_6);
		NullCheck(L_4);
		int32_t L_7 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_5, 1))%((int32_t)(((RuntimeArray*)L_6)->max_length))));
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_8 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// sum += (v2.x - v1.x) * (v2.y + v1.y);
		float L_9 = V_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_10 = V_3;
		float L_11 = L_10.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_12 = V_2;
		float L_13 = L_12.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_14 = V_3;
		float L_15 = L_14.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_16 = V_2;
		float L_17 = L_16.___y_1;
		V_0 = ((float)il2cpp_codegen_add(L_9, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_11, L_13)), ((float)il2cpp_codegen_add(L_15, L_17))))));
		// for (int i = 1; i < points2D.Length; i++)
		int32_t L_18 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_0042:
	{
		// for (int i = 1; i < points2D.Length; i++)
		int32_t L_19 = V_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_20 = ___0_points2D;
		NullCheck(L_20);
		if ((((int32_t)L_19) < ((int32_t)((int32_t)(((RuntimeArray*)L_20)->max_length)))))
		{
			goto IL_000a;
		}
	}
	{
		// sum += (points2D[0].x - points2D[points2D.Length - 1].x) * (points2D[0].y + points2D[points2D.Length - 1].y);
		float L_21 = V_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_22 = ___0_points2D;
		NullCheck(L_22);
		float L_23 = ((L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_24 = ___0_points2D;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_25 = ___0_points2D;
		NullCheck(L_25);
		NullCheck(L_24);
		float L_26 = ((L_24)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_25)->max_length)), 1)))))->___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_27 = ___0_points2D;
		NullCheck(L_27);
		float L_28 = ((L_27)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___y_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_29 = ___0_points2D;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_30 = ___0_points2D;
		NullCheck(L_30);
		NullCheck(L_29);
		float L_31 = ((L_29)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_30)->max_length)), 1)))))->___y_1;
		V_0 = ((float)il2cpp_codegen_add(L_21, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_23, L_26)), ((float)il2cpp_codegen_add(L_28, L_31))))));
		// return sum <= 0f;
		float L_32 = V_0;
		return (bool)((((int32_t)((!(((float)L_32) <= ((float)(0.0f))))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::GetIdentityVerts(UnityEngine.Vector3,UnityEngine.Vector3,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_GetIdentityVerts_mC7BDC4CD1E53A036F51168922F9C444A93DBD36A (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_center, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_normal, bool ___2_clockwise, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B5_0;
	memset((&G_B5_0), 0, sizeof(G_B5_0));
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 G_B5_1;
	memset((&G_B5_1), 0, sizeof(G_B5_1));
	int32_t G_B5_2 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B5_3 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B4_0;
	memset((&G_B4_0), 0, sizeof(G_B4_0));
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 G_B4_1;
	memset((&G_B4_1), 0, sizeof(G_B4_1));
	int32_t G_B4_2 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B4_3 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B6_0;
	memset((&G_B6_0), 0, sizeof(G_B6_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B6_1;
	memset((&G_B6_1), 0, sizeof(G_B6_1));
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 G_B6_2;
	memset((&G_B6_2), 0, sizeof(G_B6_2));
	int32_t G_B6_3 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B6_4 = NULL;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 G_B8_0;
	memset((&G_B8_0), 0, sizeof(G_B8_0));
	int32_t G_B8_1 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B8_2 = NULL;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 G_B7_0;
	memset((&G_B7_0), 0, sizeof(G_B7_0));
	int32_t G_B7_1 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B7_2 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B9_0;
	memset((&G_B9_0), 0, sizeof(G_B9_0));
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 G_B9_1;
	memset((&G_B9_1), 0, sizeof(G_B9_1));
	int32_t G_B9_2 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B9_3 = NULL;
	{
		// Quaternion vertsRotation = Quaternion.Inverse(Quaternion.LookRotation(normal));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___1_normal;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1;
		L_1 = Quaternion_LookRotation_mDB2CCA75B8E1AB98104F2A6E1A1EA57D0D1298D7(L_0, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_2;
		L_2 = Quaternion_Inverse_mD9C060AC626A7B406F4984AC98F8358DC89EF512(L_1, NULL);
		V_0 = L_2;
		// if (identityVertices.Length != sampleCount)
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_3 = __this->___identityVertices_67;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length))) == ((int32_t)L_4)))
		{
			goto IL_003e;
		}
	}
	{
		// identityVertices = new Vector3[sampleCount];
		int32_t L_5;
		L_5 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_6 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_5);
		__this->___identityVertices_67 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___identityVertices_67), (void*)L_6);
		// identityNormals = new Vector3[sampleCount];
		int32_t L_7;
		L_7 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_8 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_7);
		__this->___identityNormals_68 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___identityNormals_68), (void*)L_8);
	}

IL_003e:
	{
		// for (int i = 0; i < sampleCount; i++)
		V_1 = 0;
		goto IL_00d3;
	}

IL_0045:
	{
		// identityVertices[i] = vertsRotation * (GetSampleRaw(i).position - center + (clockwise ? -GetSampleRaw(i).right : GetSampleRaw(i).right) * _expand);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_9 = __this->___identityVertices_67;
		int32_t L_10 = V_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_11 = V_0;
		int32_t L_12 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_13;
		L_13 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_12, NULL);
		NullCheck(L_13);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14 = L_13->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = ___0_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_14, L_15, NULL);
		bool L_17 = ___2_clockwise;
		G_B4_0 = L_16;
		G_B4_1 = L_11;
		G_B4_2 = L_10;
		G_B4_3 = L_9;
		if (L_17)
		{
			G_B5_0 = L_16;
			G_B5_1 = L_11;
			G_B5_2 = L_10;
			G_B5_3 = L_9;
			goto IL_0070;
		}
	}
	{
		int32_t L_18 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_19;
		L_19 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_18, NULL);
		NullCheck(L_19);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_19, NULL);
		G_B6_0 = L_20;
		G_B6_1 = G_B4_0;
		G_B6_2 = G_B4_1;
		G_B6_3 = G_B4_2;
		G_B6_4 = G_B4_3;
		goto IL_0081;
	}

IL_0070:
	{
		int32_t L_21 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_22;
		L_22 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_21, NULL);
		NullCheck(L_22);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		L_23 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_22, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_23, NULL);
		G_B6_0 = L_24;
		G_B6_1 = G_B5_0;
		G_B6_2 = G_B5_1;
		G_B6_3 = G_B5_2;
		G_B6_4 = G_B5_3;
	}

IL_0081:
	{
		float L_25 = __this->____expand_60;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(G_B6_0, L_25, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(G_B6_1, L_26, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(G_B6_2, L_27, NULL);
		NullCheck(G_B6_4);
		(G_B6_4)->SetAt(static_cast<il2cpp_array_size_t>(G_B6_3), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_28);
		// identityNormals[i] = vertsRotation * (clockwise ? -GetSampleRaw(i).right : GetSampleRaw(i).right);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = __this->___identityNormals_68;
		int32_t L_30 = V_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_31 = V_0;
		bool L_32 = ___2_clockwise;
		G_B7_0 = L_31;
		G_B7_1 = L_30;
		G_B7_2 = L_29;
		if (L_32)
		{
			G_B8_0 = L_31;
			G_B8_1 = L_30;
			G_B8_2 = L_29;
			goto IL_00b4;
		}
	}
	{
		int32_t L_33 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_34;
		L_34 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_33, NULL);
		NullCheck(L_34);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35;
		L_35 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_34, NULL);
		G_B9_0 = L_35;
		G_B9_1 = G_B7_0;
		G_B9_2 = G_B7_1;
		G_B9_3 = G_B7_2;
		goto IL_00c5;
	}

IL_00b4:
	{
		int32_t L_36 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_37;
		L_37 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_36, NULL);
		NullCheck(L_37);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38;
		L_38 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_37, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39;
		L_39 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_38, NULL);
		G_B9_0 = L_39;
		G_B9_1 = G_B8_0;
		G_B9_2 = G_B8_1;
		G_B9_3 = G_B8_2;
	}

IL_00c5:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40;
		L_40 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(G_B9_1, G_B9_0, NULL);
		NullCheck(G_B9_3);
		(G_B9_3)->SetAt(static_cast<il2cpp_array_size_t>(G_B9_2), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_40);
		// for (int i = 0; i < sampleCount; i++)
		int32_t L_41 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_41, 1));
	}

IL_00d3:
	{
		// for (int i = 0; i < sampleCount; i++)
		int32_t L_42 = V_1;
		int32_t L_43;
		L_43 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		if ((((int32_t)L_42) < ((int32_t)L_43)))
		{
			goto IL_0045;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::GetProjectedVertices(System.Int32,UnityEngine.Vector3&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator_GetProjectedVertices_mA692776555C25658180719FDCFBDFE3E5A367200 (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, int32_t ___0_count, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_center, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___2_normal, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	float V_5 = 0.0f;
	float V_6 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_7;
	memset((&V_7), 0, sizeof(V_7));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B8_0;
	memset((&G_B8_0), 0, sizeof(G_B8_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B7_0;
	memset((&G_B7_0), 0, sizeof(G_B7_0));
	{
		// center = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_0 = ___1_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_0 = L_1;
		// normal = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_2 = ___2_normal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_2 = L_3;
		// Vector3 off = _trsRight * offset.x + _trsUp * offset.y + _trsForward * offset.z;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = __this->____trsRight_75;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5;
		L_5 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_6 = L_5.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_4, L_6, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = __this->____trsUp_76;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_10 = L_9.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11;
		L_11 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_8, L_10, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_7, L_11, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = __this->____trsForward_77;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_15 = L_14.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_13, L_15, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17;
		L_17 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_12, L_16, NULL);
		V_0 = L_17;
		// for (int i = 0; i < count; i++)
		V_3 = 0;
		goto IL_00ab;
	}

IL_0067:
	{
		// center += GetSampleRaw(i).position + off;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_18 = ___1_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_19 = ___1_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_19);
		int32_t L_21 = V_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_22;
		L_22 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_21, NULL);
		NullCheck(L_22);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = L_22->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_23, L_24, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_20, L_25, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_18 = L_26;
		// normal += GetSampleRaw(i).up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_27 = ___2_normal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_28 = ___2_normal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_28);
		int32_t L_30 = V_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_31;
		L_31 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_30, NULL);
		NullCheck(L_31);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32 = L_31->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33;
		L_33 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_29, L_32, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_27 = L_33;
		// for (int i = 0; i < count; i++)
		int32_t L_34 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_00ab:
	{
		// for (int i = 0; i < count; i++)
		int32_t L_35 = V_3;
		int32_t L_36 = ___0_count;
		if ((((int32_t)L_35) < ((int32_t)L_36)))
		{
			goto IL_0067;
		}
	}
	{
		// normal.Normalize();
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_37 = ___2_normal;
		Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline(L_37, NULL);
		// center /= count;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_38 = ___1_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_39 = ___1_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_39);
		int32_t L_41 = ___0_count;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42;
		L_42 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_40, ((float)L_41), NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_38 = L_42;
		// Quaternion rot = Quaternion.LookRotation(normal, Vector3.up);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_43 = ___2_normal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_43);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45;
		L_45 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_46;
		L_46 = Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307(L_44, L_45, NULL);
		// Vector3 up = rot * Vector3.up;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_47 = L_46;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_48;
		L_48 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49;
		L_49 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_47, L_48, NULL);
		V_1 = L_49;
		// Vector3 right = rot * Vector3.right;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50;
		L_50 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51;
		L_51 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_47, L_50, NULL);
		V_2 = L_51;
		// if (projectedVerts.Length != count) projectedVerts = new Vector2[count];
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_52 = __this->___projectedVerts_69;
		NullCheck(L_52);
		int32_t L_53 = ___0_count;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_52)->max_length))) == ((int32_t)L_53)))
		{
			goto IL_0106;
		}
	}
	{
		// if (projectedVerts.Length != count) projectedVerts = new Vector2[count];
		int32_t L_54 = ___0_count;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_55 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)L_54);
		__this->___projectedVerts_69 = L_55;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___projectedVerts_69), (void*)L_55);
	}

IL_0106:
	{
		// for (int i = 0; i < count; i++)
		V_4 = 0;
		goto IL_01ad;
	}

IL_010e:
	{
		// Vector3 point = GetSampleRaw(i).position + off - center;
		int32_t L_56 = V_4;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_57;
		L_57 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_56, NULL);
		NullCheck(L_57);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58 = L_57->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_60;
		L_60 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_58, L_59, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_61 = ___1_center;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_62 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_61);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_63;
		L_63 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_60, L_62, NULL);
		// float projectionPointX = Vector3.Project(point, right).magnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_64 = L_63;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_66;
		L_66 = Vector3_Project_m85DF3CB297EC5E1A17BD6266FF65E86AB7372C9B_inline(L_64, L_65, NULL);
		V_7 = L_66;
		float L_67;
		L_67 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_7), NULL);
		V_5 = L_67;
		// if (Vector3.Dot(point, right) < 0.0f) projectionPointX *= -1f;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68 = L_64;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69 = V_2;
		float L_70;
		L_70 = Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline(L_68, L_69, NULL);
		G_B7_0 = L_68;
		if ((!(((float)L_70) < ((float)(0.0f)))))
		{
			G_B8_0 = L_68;
			goto IL_0156;
		}
	}
	{
		// if (Vector3.Dot(point, right) < 0.0f) projectionPointX *= -1f;
		float L_71 = V_5;
		V_5 = ((float)il2cpp_codegen_multiply(L_71, (-1.0f)));
		G_B8_0 = G_B7_0;
	}

IL_0156:
	{
		// float projectionPointY = Vector3.Project(point, up).magnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_72 = G_B8_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_73 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_74;
		L_74 = Vector3_Project_m85DF3CB297EC5E1A17BD6266FF65E86AB7372C9B_inline(L_72, L_73, NULL);
		V_7 = L_74;
		float L_75;
		L_75 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_7), NULL);
		V_6 = L_75;
		// if (Vector3.Dot(point, up) < 0.0f) projectionPointY *= -1f;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_76 = V_1;
		float L_77;
		L_77 = Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline(L_72, L_76, NULL);
		if ((!(((float)L_77) < ((float)(0.0f)))))
		{
			goto IL_017f;
		}
	}
	{
		// if (Vector3.Dot(point, up) < 0.0f) projectionPointY *= -1f;
		float L_78 = V_6;
		V_6 = ((float)il2cpp_codegen_multiply(L_78, (-1.0f)));
	}

IL_017f:
	{
		// projectedVerts[i].x = projectionPointX;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_79 = __this->___projectedVerts_69;
		int32_t L_80 = V_4;
		NullCheck(L_79);
		float L_81 = V_5;
		((L_79)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_80)))->___x_0 = L_81;
		// projectedVerts[i].y = projectionPointY;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_82 = __this->___projectedVerts_69;
		int32_t L_83 = V_4;
		NullCheck(L_82);
		float L_84 = V_6;
		((L_82)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_83)))->___y_1 = L_84;
		// for (int i = 0; i < count; i++)
		int32_t L_85 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_85, 1));
	}

IL_01ad:
	{
		// for (int i = 0; i < count; i++)
		int32_t L_86 = V_4;
		int32_t L_87 = ___0_count;
		if ((((int32_t)L_86) < ((int32_t)L_87)))
		{
			goto IL_010e;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SurfaceGenerator::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SurfaceGenerator__ctor_m8D869EE2EC90203B8D2E8D472771AAC66CF4362C (SurfaceGenerator_t801E017F3242D368541922E7CC94DB8BE113F65A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private Vector2 _sideUvScale = Vector2.one;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0;
		L_0 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		__this->____sideUvScale_62 = L_0;
		// private Vector2 _sideUvOffset = Vector2.zero;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1;
		L_1 = Vector2_get_zero_m32506C40EC2EE7D5D4410BF40D3EE683A3D5F32C_inline(NULL);
		__this->____sideUvOffset_63 = L_1;
		// private Vector3 _extrudeOffset = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		__this->____extrudeOffset_65 = L_2;
		// private SplineSample[] extrudeResults = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_3 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___extrudeResults_66 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___extrudeResults_66), (void*)L_3);
		// private Vector3[] identityVertices = new Vector3[0];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___identityVertices_67 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___identityVertices_67), (void*)L_4);
		// private Vector3[] identityNormals = new Vector3[0];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_5 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___identityNormals_68 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___identityNormals_68), (void*)L_5);
		// private Vector2[] projectedVerts = new Vector2[0];
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_6 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___projectedVerts_69 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___projectedVerts_69), (void*)L_6);
		// private int[] surfaceTris = new int[0];
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_7 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___surfaceTris_70 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___surfaceTris_70), (void*)L_7);
		// private int[] wallTris = new int[0];
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_8 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___wallTris_71 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___wallTris_71), (void*)L_8);
		// private double _extrudeTo = 1.0;
		__this->____extrudeTo_73 = (1.0);
		// private Vector3 _trsRight = Vector3.right;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		__this->____trsRight_75 = L_9;
		// private Vector3 _trsUp = Vector3.up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		__this->____trsUp_76 = L_10;
		// private Vector3 _trsForward = Vector3.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11;
		L_11 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		__this->____trsForward_77 = L_11;
		il2cpp_codegen_runtime_class_init_inline(MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		MeshGenerator__ctor_mC01695CDAB2865B65DC8307E3B9841B0B1B81182(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 Dreamteck.Splines.TubeGenerator::get_sides()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _sides; }
		int32_t L_0 = __this->____sides_60;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::set_sides(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_set_sides_m29EA1F7C115B162B692AA4AFE6E872815B99BEC4 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _sides)
		int32_t L_0 = ___0_value;
		int32_t L_1 = __this->____sides_60;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001d;
		}
	}
	{
		// if (value < 3) value = 3;
		int32_t L_2 = ___0_value;
		if ((((int32_t)L_2) >= ((int32_t)3)))
		{
			goto IL_0010;
		}
	}
	{
		// if (value < 3) value = 3;
		___0_value = 3;
	}

IL_0010:
	{
		// _sides = value;
		int32_t L_3 = ___0_value;
		__this->____sides_60 = L_3;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_001d:
	{
		// }
		return;
	}
}
// Dreamteck.Splines.TubeGenerator/CapMethod Dreamteck.Splines.TubeGenerator::get_capMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TubeGenerator_get_capMode_m21F5380CC84CF34AA8E212CA4DB2933A4990D719 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _capMode; }
		int32_t L_0 = __this->____capMode_62;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::set_capMode(Dreamteck.Splines.TubeGenerator/CapMethod)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_set_capMode_m16304C19BC570E0697CC4E639EDE2F8A0EF48BCD (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _capMode)
		int32_t L_0 = ___0_value;
		int32_t L_1 = __this->____capMode_62;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _capMode = value;
		int32_t L_2 = ___0_value;
		__this->____capMode_62 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Int32 Dreamteck.Splines.TubeGenerator::get_roundCapLatitude()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TubeGenerator_get_roundCapLatitude_m7B8B5BC8B54CA83F68F74B9BB6BCD0A92368725B (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _roundCapLatitude; }
		int32_t L_0 = __this->____roundCapLatitude_61;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::set_roundCapLatitude(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_set_roundCapLatitude_m29369996ABCA8FCCCD680C0241DCB6C203F583E6 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value < 1) value = 1;
		int32_t L_0 = ___0_value;
		if ((((int32_t)L_0) >= ((int32_t)1)))
		{
			goto IL_0007;
		}
	}
	{
		// if (value < 1) value = 1;
		___0_value = 1;
	}

IL_0007:
	{
		// if (value != _roundCapLatitude)
		int32_t L_1 = ___0_value;
		int32_t L_2 = __this->____roundCapLatitude_61;
		if ((((int32_t)L_1) == ((int32_t)L_2)))
		{
			goto IL_0026;
		}
	}
	{
		// _roundCapLatitude = value;
		int32_t L_3 = ___0_value;
		__this->____roundCapLatitude_61 = L_3;
		// if(_capMode == CapMethod.Round) Rebuild();
		int32_t L_4 = __this->____capMode_62;
		if ((!(((uint32_t)L_4) == ((uint32_t)2))))
		{
			goto IL_0026;
		}
	}
	{
		// if(_capMode == CapMethod.Round) Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0026:
	{
		// }
		return;
	}
}
// System.Single Dreamteck.Splines.TubeGenerator::get_revolve()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TubeGenerator_get_revolve_mA0E88A6BBFB22394509F6985803FB599F9751CB3 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _revolve; }
		float L_0 = __this->____revolve_63;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::set_revolve(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_set_revolve_mD18A3D17A8E3FA5803CA58E12C62A0D3BB313CD4 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, float ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _revolve)
		float L_0 = ___0_value;
		float L_1 = __this->____revolve_63;
		if ((((float)L_0) == ((float)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _revolve = value;
		float L_2 = ___0_value;
		__this->____revolve_63 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Single Dreamteck.Splines.TubeGenerator::get_capUVScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TubeGenerator_get_capUVScale_mEF333A82CE736CDF2EA7B378B85C5440AEDF6B81 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _capUVScale; }
		float L_0 = __this->____capUVScale_64;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::set_capUVScale(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_set_capUVScale_mBD62A29ED16E9CB8A74126B858B5CA79C79456CC (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, float ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _capUVScale)
		float L_0 = ___0_value;
		float L_1 = __this->____capUVScale_64;
		if ((((float)L_0) == ((float)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _capUVScale = value;
		float L_2 = ___0_value;
		__this->____capUVScale_64 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Single Dreamteck.Splines.TubeGenerator::get_uvTwist()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TubeGenerator_get_uvTwist_mAAB7671A9BBEBBFDBABE6FAF8B4C7AFF18C07478 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uvTwist; }
		float L_0 = __this->____uvTwist_65;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::set_uvTwist(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_set_uvTwist_m3D3BF32BB3C6D5E289617D8629E042365349BDCF (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, float ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _uvTwist)
		float L_0 = ___0_value;
		float L_1 = __this->____uvTwist_65;
		if ((((float)L_0) == ((float)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _uvTwist = value;
		float L_2 = ___0_value;
		__this->____uvTwist_65 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Boolean Dreamteck.Splines.TubeGenerator::get_useCap()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TubeGenerator_get_useCap_mBDFC07A2B79C4E3164BF845DCE00D3B1D7EFC802 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// bool isCapSet = _capMode != CapMethod.None;
		int32_t L_0 = __this->____capMode_62;
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		// if (spline != null) return isCapSet && (!spline.isClosed || span < 1f);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_1;
		L_1 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_1, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_2)
		{
			goto IL_003e;
		}
	}
	{
		// if (spline != null) return isCapSet && (!spline.isClosed || span < 1f);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_003c;
		}
	}
	{
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_4;
		L_4 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		NullCheck(L_4);
		bool L_5;
		L_5 = SplineComputer_get_isClosed_m8DACA32E64742FC87F16C9083E7CAFD38F0BB8E4(L_4, NULL);
		if (!L_5)
		{
			goto IL_003a;
		}
	}
	{
		double L_6;
		L_6 = SplineUser_get_span_m4E81282006AD4AC500D4B5B9448A415025BFEE8E(__this, NULL);
		return (bool)((((double)L_6) < ((double)(1.0)))? 1 : 0);
	}

IL_003a:
	{
		return (bool)1;
	}

IL_003c:
	{
		return (bool)0;
	}

IL_003e:
	{
		// return isCapSet;
		bool L_7 = V_0;
		return L_7;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_Reset_mE187F2BF0B4A21795E4CAD5331E2BA83FB95C16F (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// base.Reset();
		MeshGenerator_Reset_mB799CBB956E944F2D210D091F77D75CE92206F32(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_Awake_m9F10A449AB23C27DE1E49C141C0740978ECFDBF2 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEB5F7E205563AF268B2398339D6BC44920D66CE0);
		s_Il2CppMethodInitialized = true;
	}
	{
		// base.Awake();
		MeshGenerator_Awake_m01397118A8B7F582739A549E42020A7D3ED78D1D(__this, NULL);
		// mesh.name = "tube";
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_0 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___mesh_54;
		NullCheck(L_0);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_0, _stringLiteralEB5F7E205563AF268B2398339D6BC44920D66CE0, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::BuildMesh()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_BuildMesh_m91B4A7DBFEEB2638029EBD1DA852C27FDD4BCC90 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// if (_sides <= 2) return;
		int32_t L_0 = __this->____sides_60;
		if ((((int32_t)L_0) > ((int32_t)2)))
		{
			goto IL_000a;
		}
	}
	{
		// if (_sides <= 2) return;
		return;
	}

IL_000a:
	{
		// base.BuildMesh();
		MeshGenerator_BuildMesh_m4236C36A669B18C4515D7C463126F87D18E38464(__this, NULL);
		// bodyVertexCount = (_sides + 1) * sampleCount;
		int32_t L_1 = __this->____sides_60;
		int32_t L_2;
		L_2 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		__this->___bodyVertexCount_66 = ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_add(L_1, 1)), L_2));
		// CapMethod _capModeFinal = _capMode;
		int32_t L_3 = __this->____capMode_62;
		V_0 = L_3;
		// if (!useCap) _capModeFinal = CapMethod.None;
		bool L_4;
		L_4 = TubeGenerator_get_useCap_mBDFC07A2B79C4E3164BF845DCE00D3B1D7EFC802(__this, NULL);
		if (L_4)
		{
			goto IL_0036;
		}
	}
	{
		// if (!useCap) _capModeFinal = CapMethod.None;
		V_0 = 0;
	}

IL_0036:
	{
		int32_t L_5 = V_0;
		if ((((int32_t)L_5) == ((int32_t)1)))
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_6 = V_0;
		if ((((int32_t)L_6) == ((int32_t)2)))
		{
			goto IL_0050;
		}
	}
	{
		goto IL_0067;
	}

IL_0040:
	{
		// case CapMethod.Flat: capVertexCount = _sides + 1; break;
		int32_t L_7 = __this->____sides_60;
		__this->___capVertexCount_68 = ((int32_t)il2cpp_codegen_add(L_7, 1));
		// case CapMethod.Flat: capVertexCount = _sides + 1; break;
		goto IL_006e;
	}

IL_0050:
	{
		// case CapMethod.Round: capVertexCount = _roundCapLatitude * (sides + 1); break;
		int32_t L_8 = __this->____roundCapLatitude_61;
		int32_t L_9;
		L_9 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		__this->___capVertexCount_68 = ((int32_t)il2cpp_codegen_multiply(L_8, ((int32_t)il2cpp_codegen_add(L_9, 1))));
		// case CapMethod.Round: capVertexCount = _roundCapLatitude * (sides + 1); break;
		goto IL_006e;
	}

IL_0067:
	{
		// default: capVertexCount = 0; break;
		__this->___capVertexCount_68 = 0;
	}

IL_006e:
	{
		// int vertexCount = bodyVertexCount + capVertexCount * 2;
		int32_t L_10 = __this->___bodyVertexCount_66;
		int32_t L_11 = __this->___capVertexCount_68;
		V_1 = ((int32_t)il2cpp_codegen_add(L_10, ((int32_t)il2cpp_codegen_multiply(L_11, 2))));
		// bodyTrisCount = _sides * (sampleCount - 1) * 2 * 3;
		int32_t L_12 = __this->____sides_60;
		int32_t L_13;
		L_13 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		__this->___bodyTrisCount_67 = ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_12, ((int32_t)il2cpp_codegen_subtract(L_13, 1)))), 2)), 3));
		int32_t L_14 = V_0;
		if ((((int32_t)L_14) == ((int32_t)1)))
		{
			goto IL_00a1;
		}
	}
	{
		int32_t L_15 = V_0;
		if ((((int32_t)L_15) == ((int32_t)2)))
		{
			goto IL_00b5;
		}
	}
	{
		goto IL_00cc;
	}

IL_00a1:
	{
		// case CapMethod.Flat: capTrisCount = (_sides - 1) * 3 * 2; break;
		int32_t L_16 = __this->____sides_60;
		__this->___capTrisCount_69 = ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_16, 1)), 3)), 2));
		// case CapMethod.Flat: capTrisCount = (_sides - 1) * 3 * 2; break;
		goto IL_00d3;
	}

IL_00b5:
	{
		// case CapMethod.Round: capTrisCount = _sides * _roundCapLatitude * 6; break;
		int32_t L_17 = __this->____sides_60;
		int32_t L_18 = __this->____roundCapLatitude_61;
		__this->___capTrisCount_69 = ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_17, L_18)), 6));
		// case CapMethod.Round: capTrisCount = _sides * _roundCapLatitude * 6; break;
		goto IL_00d3;
	}

IL_00cc:
	{
		// default: capTrisCount = 0; break;
		__this->___capTrisCount_69 = 0;
	}

IL_00d3:
	{
		// AllocateMesh(vertexCount, bodyTrisCount + capTrisCount * 2);
		int32_t L_19 = V_1;
		int32_t L_20 = __this->___bodyTrisCount_67;
		int32_t L_21 = __this->___capTrisCount_69;
		VirtualActionInvoker2< int32_t, int32_t >::Invoke(24 /* System.Void Dreamteck.Splines.MeshGenerator::AllocateMesh(System.Int32,System.Int32) */, __this, L_19, ((int32_t)il2cpp_codegen_add(L_20, ((int32_t)il2cpp_codegen_multiply(L_21, 2)))));
		// Generate();
		TubeGenerator_Generate_m9FC76BE48568FC8E34F0867761439F16DC436371(__this, NULL);
		int32_t L_22 = V_0;
		if ((((int32_t)L_22) == ((int32_t)1)))
		{
			goto IL_00f8;
		}
	}
	{
		int32_t L_23 = V_0;
		if ((((int32_t)L_23) == ((int32_t)2)))
		{
			goto IL_00ff;
		}
	}
	{
		return;
	}

IL_00f8:
	{
		// case CapMethod.Flat: GenerateFlatCaps(); break;
		TubeGenerator_GenerateFlatCaps_mA78CF75F3E7C237BCBEDC144D60C98BA3D533A2C(__this, NULL);
		// case CapMethod.Flat: GenerateFlatCaps(); break;
		return;
	}

IL_00ff:
	{
		// case CapMethod.Round: GenerateRoundCaps(); break;
		TubeGenerator_GenerateRoundCaps_m795F04EEA7FC62AB6089F68EB307B57122EB1326(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::Generate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_Generate_m9FC76BE48568FC8E34F0867761439F16DC436371 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_3;
	memset((&V_3), 0, sizeof(V_3));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	float V_5 = 0.0f;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_6;
	memset((&V_6), 0, sizeof(V_6));
	int32_t V_7 = 0;
	float V_8 = 0.0f;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_9;
	memset((&V_9), 0, sizeof(V_9));
	{
		// int vertexIndex = 0;
		V_0 = 0;
		// ResetUVDistance();
		MeshGenerator_ResetUVDistance_mD94F210D5CA48404969149B0883D1A98ED29021E(__this, NULL);
		// bool hasOffset = offset != Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		bool L_2;
		L_2 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_0, L_1, NULL);
		V_1 = L_2;
		// for (int i = 0; i < sampleCount; i++)
		V_2 = 0;
		goto IL_0251;
	}

IL_0020:
	{
		// GetSample(i, evalResult);
		int32_t L_3 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, L_3, L_4, NULL);
		// Vector3 center = evalResult.position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_5 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = L_5->___position_0;
		V_3 = L_6;
		// Vector3 right = evalResult.right;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_7);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_7, NULL);
		V_4 = L_8;
		// float resultSize = GetBaseSize(evalResult);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_9 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		float L_10;
		L_10 = MeshGenerator_GetBaseSize_m25D28E870FB60C746299133A0C8DE62F1B07256F(__this, L_9, NULL);
		V_5 = L_10;
		// if (hasOffset)
		bool L_11 = V_1;
		if (!L_11)
		{
			goto IL_00b9;
		}
	}
	{
		// center += (offset.x * resultSize) * right + (offset.y * resultSize) * evalResult.up + (offset.z * resultSize) * evalResult.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13;
		L_13 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_14 = L_13.___x_2;
		float L_15 = V_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17;
		L_17 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_14, L_15)), L_16, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_19 = L_18.___y_3;
		float L_20 = V_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_21 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_21);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = L_21->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		L_23 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_19, L_20)), L_22, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_17, L_23, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_26 = L_25.___z_4;
		float L_27 = V_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_28 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_28);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = L_28->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30;
		L_30 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_26, L_27)), L_29, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_24, L_30, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32;
		L_32 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_12, L_31, NULL);
		V_3 = L_32;
	}

IL_00b9:
	{
		// if (uvMode == UVMode.UniformClamp || uvMode == UVMode.UniformClip)
		int32_t L_33;
		L_33 = MeshGenerator_get_uvMode_m069663A59CCF805CF43951424B6CE3CE106AE889_inline(__this, NULL);
		if ((((int32_t)L_33) == ((int32_t)3)))
		{
			goto IL_00cb;
		}
	}
	{
		int32_t L_34;
		L_34 = MeshGenerator_get_uvMode_m069663A59CCF805CF43951424B6CE3CE106AE889_inline(__this, NULL);
		if ((!(((uint32_t)L_34) == ((uint32_t)1))))
		{
			goto IL_00d2;
		}
	}

IL_00cb:
	{
		// AddUVDistance(i);
		int32_t L_35 = V_2;
		MeshGenerator_AddUVDistance_m4E91426033AE6AEB6AFEDA97AFCBB588B98EA72A(__this, L_35, NULL);
	}

IL_00d2:
	{
		// Color vertexColor = GetBaseColor(evalResult) * color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_36 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_37;
		L_37 = MeshGenerator_GetBaseColor_m0668E5049FD711975D9B6E34E4E0CA81028AFDD8(__this, L_36, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_38;
		L_38 = MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline(__this, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_39;
		L_39 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_37, L_38, NULL);
		V_6 = L_39;
		// for (int n = 0; n < _sides + 1; n++)
		V_7 = 0;
		goto IL_023e;
	}

IL_00f3:
	{
		// float anglePercent = (float)(n) / _sides;
		int32_t L_40 = V_7;
		int32_t L_41 = __this->____sides_60;
		V_8 = ((float)(((float)L_40)/((float)L_41)));
		// Quaternion rot = Quaternion.AngleAxis(_revolve * anglePercent + rotation + 180f, evalResult.forward);
		float L_42 = __this->____revolve_63;
		float L_43 = V_8;
		float L_44;
		L_44 = MeshGenerator_get_rotation_mB779241C82CC9BB0235F09AA0D249EE1B87CE122_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_45 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_45);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46 = L_45->___forward_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_47;
		L_47 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_42, L_43)), L_44)), (180.0f))), L_46, NULL);
		V_9 = L_47;
		// tsMesh.vertices[vertexIndex] = center + rot * right * (size * resultSize * 0.5f);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_48 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_48);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_49 = L_48->___vertices_0;
		int32_t L_50 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51 = V_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_52 = V_9;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54;
		L_54 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_52, L_53, NULL);
		float L_55;
		L_55 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		float L_56 = V_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57;
		L_57 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_54, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_55, L_56)), (0.5f))), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58;
		L_58 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_51, L_57, NULL);
		NullCheck(L_49);
		(L_49)->SetAt(static_cast<il2cpp_array_size_t>(L_50), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_58);
		// CalculateUVs(evalResult.percent, anglePercent);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_59 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_59);
		double L_60 = L_59->___percent_5;
		float L_61 = V_8;
		MeshGenerator_CalculateUVs_mAF89F2DF16327AE09658FCCADE4E03B046BDC230(__this, L_60, L_61, NULL);
		// tsMesh.uv[vertexIndex] = Vector2.one * 0.5f + (Vector2)(Quaternion.AngleAxis(uvRotation + 180f, Vector3.forward) * (Vector2.one * 0.5f - (uvs + Vector2.right * ((float)evalResult.percent * _uvTwist))));
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_62 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_62);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_63 = L_62->___uv_4;
		int32_t L_64 = V_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_65;
		L_65 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_66;
		L_66 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_65, (0.5f), NULL);
		float L_67;
		L_67 = MeshGenerator_get_uvRotation_m38AD623D63FEDB94A5DFEEF63F3352AC5E707964_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68;
		L_68 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_69;
		L_69 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_add(L_67, (180.0f))), L_68, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_70;
		L_70 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_71;
		L_71 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_70, (0.5f), NULL);
		il2cpp_codegen_runtime_class_init_inline(MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_72 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_StaticFields*)il2cpp_codegen_static_fields_for(MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var))->___uvs_59;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_73;
		L_73 = Vector2_get_right_m99043ED6B3D5AEA5033313FE3DA9571F39D1B280_inline(NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_74 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_74);
		double L_75 = L_74->___percent_5;
		float L_76 = __this->____uvTwist_65;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_77;
		L_77 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_73, ((float)il2cpp_codegen_multiply(((float)L_75), L_76)), NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_78;
		L_78 = Vector2_op_Addition_m8136742CE6EE33BA4EB81C5F584678455917D2AE_inline(L_72, L_77, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_79;
		L_79 = Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline(L_71, L_78, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_80;
		L_80 = Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline(L_79, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81;
		L_81 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_69, L_80, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_82;
		L_82 = Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline(L_81, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_83;
		L_83 = Vector2_op_Addition_m8136742CE6EE33BA4EB81C5F584678455917D2AE_inline(L_66, L_82, NULL);
		NullCheck(L_63);
		(L_63)->SetAt(static_cast<il2cpp_array_size_t>(L_64), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_83);
		// tsMesh.normals[vertexIndex] = Vector3.Normalize(tsMesh.vertices[vertexIndex] - center);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_84 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_84);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_85 = L_84->___normals_1;
		int32_t L_86 = V_0;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_87 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_87);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_88 = L_87->___vertices_0;
		int32_t L_89 = V_0;
		NullCheck(L_88);
		int32_t L_90 = L_89;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_91 = (L_88)->GetAt(static_cast<il2cpp_array_size_t>(L_90));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_92 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_93;
		L_93 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_91, L_92, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_94;
		L_94 = Vector3_Normalize_mEF8349CC39674236CFC694189AFD36E31F89AC8F_inline(L_93, NULL);
		NullCheck(L_85);
		(L_85)->SetAt(static_cast<il2cpp_array_size_t>(L_86), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_94);
		// tsMesh.colors[vertexIndex] = vertexColor;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_95 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_95);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_96 = L_95->___colors_3;
		int32_t L_97 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_98 = V_6;
		NullCheck(L_96);
		(L_96)->SetAt(static_cast<il2cpp_array_size_t>(L_97), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_98);
		// vertexIndex++;
		int32_t L_99 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_99, 1));
		// for (int n = 0; n < _sides + 1; n++)
		int32_t L_100 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_100, 1));
	}

IL_023e:
	{
		// for (int n = 0; n < _sides + 1; n++)
		int32_t L_101 = V_7;
		int32_t L_102 = __this->____sides_60;
		if ((((int32_t)L_101) < ((int32_t)((int32_t)il2cpp_codegen_add(L_102, 1)))))
		{
			goto IL_00f3;
		}
	}
	{
		// for (int i = 0; i < sampleCount; i++)
		int32_t L_103 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_103, 1));
	}

IL_0251:
	{
		// for (int i = 0; i < sampleCount; i++)
		int32_t L_104 = V_2;
		int32_t L_105;
		L_105 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		if ((((int32_t)L_104) < ((int32_t)L_105)))
		{
			goto IL_0020;
		}
	}
	{
		// MeshUtility.GeneratePlaneTriangles(ref tsMesh.triangles, _sides, sampleCount, false);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_106 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_106);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_107 = (&L_106->___triangles_8);
		int32_t L_108 = __this->____sides_60;
		int32_t L_109;
		L_109 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_110;
		L_110 = MeshUtility_GeneratePlaneTriangles_m7627A2B6F10209B80C86839A8E52EC35DC8DE957(L_107, L_108, L_109, (bool)0, 0, 0, (bool)0, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::GenerateFlatCaps()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_GenerateFlatCaps_mA78CF75F3E7C237BCBEDC144D60C98BA3D533A2C (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t G_B9_0 = 0;
	{
		// GetSample(0, evalResult);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, 0, L_0, NULL);
		// for (int i = 0; i < _sides+1; i++)
		V_2 = 0;
		goto IL_0101;
	}

IL_0014:
	{
		// int index = bodyVertexCount + i;
		int32_t L_1 = __this->___bodyVertexCount_66;
		int32_t L_2 = V_2;
		V_3 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		// tsMesh.vertices[index] = tsMesh.vertices[i];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_3 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_3);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = L_3->___vertices_0;
		int32_t L_5 = V_3;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_6 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_6);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_7 = L_6->___vertices_0;
		int32_t L_8 = V_2;
		NullCheck(L_7);
		int32_t L_9 = L_8;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		NullCheck(L_4);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(L_5), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_10);
		// tsMesh.normals[index] = -evalResult.forward;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_11 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_11);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_12 = L_11->___normals_1;
		int32_t L_13 = V_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_14 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_14);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = L_14->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_15, NULL);
		NullCheck(L_12);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(L_13), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_16);
		// tsMesh.colors[index] = tsMesh.colors[i];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_17 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_17);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_18 = L_17->___colors_3;
		int32_t L_19 = V_3;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_20 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_20);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_21 = L_20->___colors_3;
		int32_t L_22 = V_2;
		NullCheck(L_21);
		int32_t L_23 = L_22;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_24 = (L_21)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		NullCheck(L_18);
		(L_18)->SetAt(static_cast<il2cpp_array_size_t>(L_19), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_24);
		// tsMesh.uv[index] = Quaternion.AngleAxis(_revolve * (((float)i) / (_sides - 1)), Vector3.forward) * Vector2.right * (0.5f * capUVScale) + Vector3.right * 0.5f + Vector3.up * 0.5f;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_25 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_25);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_26 = L_25->___uv_4;
		int32_t L_27 = V_3;
		float L_28 = __this->____revolve_63;
		int32_t L_29 = V_2;
		int32_t L_30 = __this->____sides_60;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_32;
		L_32 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_multiply(L_28, ((float)(((float)L_29)/((float)((int32_t)il2cpp_codegen_subtract(L_30, 1))))))), L_31, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_33;
		L_33 = Vector2_get_right_m99043ED6B3D5AEA5033313FE3DA9571F39D1B280_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34;
		L_34 = Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline(L_33, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35;
		L_35 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_32, L_34, NULL);
		float L_36;
		L_36 = TubeGenerator_get_capUVScale_mEF333A82CE736CDF2EA7B378B85C5440AEDF6B81_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_35, ((float)il2cpp_codegen_multiply((0.5f), L_36)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38;
		L_38 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39;
		L_39 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_38, (0.5f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40;
		L_40 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_37, L_39, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41;
		L_41 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42;
		L_42 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_41, (0.5f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_43;
		L_43 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_40, L_42, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_44;
		L_44 = Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline(L_43, NULL);
		NullCheck(L_26);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(L_27), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_44);
		// for (int i = 0; i < _sides+1; i++)
		int32_t L_45 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_45, 1));
	}

IL_0101:
	{
		// for (int i = 0; i < _sides+1; i++)
		int32_t L_46 = V_2;
		int32_t L_47 = __this->____sides_60;
		if ((((int32_t)L_46) < ((int32_t)((int32_t)il2cpp_codegen_add(L_47, 1)))))
		{
			goto IL_0014;
		}
	}
	{
		// GetSample(sampleCount - 1, evalResult);
		int32_t L_48;
		L_48 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_49 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, ((int32_t)il2cpp_codegen_subtract(L_48, 1)), L_49, NULL);
		// for (int i = 0; i < _sides + 1; i++)
		V_4 = 0;
		goto IL_0243;
	}

IL_012b:
	{
		// int index = bodyVertexCount + (_sides + 1) + i;
		int32_t L_50 = __this->___bodyVertexCount_66;
		int32_t L_51 = __this->____sides_60;
		int32_t L_52 = V_4;
		V_5 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_50, ((int32_t)il2cpp_codegen_add(L_51, 1)))), L_52));
		// int bodyIndex = bodyVertexCount - (_sides + 1) + i;
		int32_t L_53 = __this->___bodyVertexCount_66;
		int32_t L_54 = __this->____sides_60;
		int32_t L_55 = V_4;
		V_6 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_53, ((int32_t)il2cpp_codegen_add(L_54, 1)))), L_55));
		// tsMesh.vertices[index] = tsMesh.vertices[bodyIndex];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_56 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_56);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_57 = L_56->___vertices_0;
		int32_t L_58 = V_5;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_59 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_59);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_60 = L_59->___vertices_0;
		int32_t L_61 = V_6;
		NullCheck(L_60);
		int32_t L_62 = L_61;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_63 = (L_60)->GetAt(static_cast<il2cpp_array_size_t>(L_62));
		NullCheck(L_57);
		(L_57)->SetAt(static_cast<il2cpp_array_size_t>(L_58), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_63);
		// tsMesh.normals[index] = GetSampleRaw(sampleCount -1).forward;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_64 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_64);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_65 = L_64->___normals_1;
		int32_t L_66 = V_5;
		int32_t L_67;
		L_67 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_68;
		L_68 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, ((int32_t)il2cpp_codegen_subtract(L_67, 1)), NULL);
		NullCheck(L_68);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69 = L_68->___forward_2;
		NullCheck(L_65);
		(L_65)->SetAt(static_cast<il2cpp_array_size_t>(L_66), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_69);
		// tsMesh.colors[index] = tsMesh.colors[bodyIndex];
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_70 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_70);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_71 = L_70->___colors_3;
		int32_t L_72 = V_5;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_73 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_73);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_74 = L_73->___colors_3;
		int32_t L_75 = V_6;
		NullCheck(L_74);
		int32_t L_76 = L_75;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_77 = (L_74)->GetAt(static_cast<il2cpp_array_size_t>(L_76));
		NullCheck(L_71);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_77);
		// tsMesh.uv[index] = Quaternion.AngleAxis(_revolve * ((float)(bodyIndex) / (_sides - 1)), Vector3.forward) * Vector2.right * (0.5f * capUVScale) + Vector3.right * 0.5f + Vector3.up * 0.5f;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_78 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_78);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_79 = L_78->___uv_4;
		int32_t L_80 = V_5;
		float L_81 = __this->____revolve_63;
		int32_t L_82 = V_6;
		int32_t L_83 = __this->____sides_60;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_84;
		L_84 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_85;
		L_85 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_multiply(L_81, ((float)(((float)L_82)/((float)((int32_t)il2cpp_codegen_subtract(L_83, 1))))))), L_84, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_86;
		L_86 = Vector2_get_right_m99043ED6B3D5AEA5033313FE3DA9571F39D1B280_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_87;
		L_87 = Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline(L_86, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_88;
		L_88 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_85, L_87, NULL);
		float L_89;
		L_89 = TubeGenerator_get_capUVScale_mEF333A82CE736CDF2EA7B378B85C5440AEDF6B81_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_90;
		L_90 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_88, ((float)il2cpp_codegen_multiply((0.5f), L_89)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_91;
		L_91 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_92;
		L_92 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_91, (0.5f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_93;
		L_93 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_90, L_92, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_94;
		L_94 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_95;
		L_95 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_94, (0.5f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_96;
		L_96 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_93, L_95, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_97;
		L_97 = Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline(L_96, NULL);
		NullCheck(L_79);
		(L_79)->SetAt(static_cast<il2cpp_array_size_t>(L_80), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_97);
		// for (int i = 0; i < _sides + 1; i++)
		int32_t L_98 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_98, 1));
	}

IL_0243:
	{
		// for (int i = 0; i < _sides + 1; i++)
		int32_t L_99 = V_4;
		int32_t L_100 = __this->____sides_60;
		if ((((int32_t)L_99) < ((int32_t)((int32_t)il2cpp_codegen_add(L_100, 1)))))
		{
			goto IL_012b;
		}
	}
	{
		// int t = bodyTrisCount;
		int32_t L_101 = __this->___bodyTrisCount_67;
		V_0 = L_101;
		// bool fullIntegrity = _revolve == 360f;
		float L_102 = __this->____revolve_63;
		// int finalSides = fullIntegrity ? _sides - 1 : _sides;
		if (((((float)L_102) == ((float)(360.0f)))? 1 : 0))
		{
			goto IL_0270;
		}
	}
	{
		int32_t L_103 = __this->____sides_60;
		G_B9_0 = L_103;
		goto IL_0278;
	}

IL_0270:
	{
		int32_t L_104 = __this->____sides_60;
		G_B9_0 = ((int32_t)il2cpp_codegen_subtract(L_104, 1));
	}

IL_0278:
	{
		V_1 = G_B9_0;
		// for (int i = 0; i < finalSides - 1; i++)
		V_7 = 0;
		goto IL_02d3;
	}

IL_027e:
	{
		// tsMesh.triangles[t++] = i + bodyVertexCount + 2;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_105 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_105);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_106 = L_105->___triangles_8;
		int32_t L_107 = V_0;
		int32_t L_108 = L_107;
		V_0 = ((int32_t)il2cpp_codegen_add(L_108, 1));
		int32_t L_109 = V_7;
		int32_t L_110 = __this->___bodyVertexCount_66;
		NullCheck(L_106);
		(L_106)->SetAt(static_cast<il2cpp_array_size_t>(L_108), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_109, L_110)), 2)));
		// tsMesh.triangles[t++] = i + +bodyVertexCount + 1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_111 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_111);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_112 = L_111->___triangles_8;
		int32_t L_113 = V_0;
		int32_t L_114 = L_113;
		V_0 = ((int32_t)il2cpp_codegen_add(L_114, 1));
		int32_t L_115 = V_7;
		int32_t L_116 = __this->___bodyVertexCount_66;
		NullCheck(L_112);
		(L_112)->SetAt(static_cast<il2cpp_array_size_t>(L_114), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_115, L_116)), 1)));
		// tsMesh.triangles[t++] = bodyVertexCount;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_117 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_117);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_118 = L_117->___triangles_8;
		int32_t L_119 = V_0;
		int32_t L_120 = L_119;
		V_0 = ((int32_t)il2cpp_codegen_add(L_120, 1));
		int32_t L_121 = __this->___bodyVertexCount_66;
		NullCheck(L_118);
		(L_118)->SetAt(static_cast<il2cpp_array_size_t>(L_120), (int32_t)L_121);
		// for (int i = 0; i < finalSides - 1; i++)
		int32_t L_122 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_122, 1));
	}

IL_02d3:
	{
		// for (int i = 0; i < finalSides - 1; i++)
		int32_t L_123 = V_7;
		int32_t L_124 = V_1;
		if ((((int32_t)L_123) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_124, 1)))))
		{
			goto IL_027e;
		}
	}
	{
		// for (int i = 0; i < finalSides - 1; i++)
		V_8 = 0;
		goto IL_034f;
	}

IL_02df:
	{
		// tsMesh.triangles[t++] = bodyVertexCount + (_sides + 1);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_125 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_125);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_126 = L_125->___triangles_8;
		int32_t L_127 = V_0;
		int32_t L_128 = L_127;
		V_0 = ((int32_t)il2cpp_codegen_add(L_128, 1));
		int32_t L_129 = __this->___bodyVertexCount_66;
		int32_t L_130 = __this->____sides_60;
		NullCheck(L_126);
		(L_126)->SetAt(static_cast<il2cpp_array_size_t>(L_128), (int32_t)((int32_t)il2cpp_codegen_add(L_129, ((int32_t)il2cpp_codegen_add(L_130, 1)))));
		// tsMesh.triangles[t++] = i + 1 + bodyVertexCount + (_sides + 1);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_131 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_131);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_132 = L_131->___triangles_8;
		int32_t L_133 = V_0;
		int32_t L_134 = L_133;
		V_0 = ((int32_t)il2cpp_codegen_add(L_134, 1));
		int32_t L_135 = V_8;
		int32_t L_136 = __this->___bodyVertexCount_66;
		int32_t L_137 = __this->____sides_60;
		NullCheck(L_132);
		(L_132)->SetAt(static_cast<il2cpp_array_size_t>(L_134), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_135, 1)), L_136)), ((int32_t)il2cpp_codegen_add(L_137, 1)))));
		// tsMesh.triangles[t++] = i + 2 + bodyVertexCount + (_sides + 1);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_138 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_138);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_139 = L_138->___triangles_8;
		int32_t L_140 = V_0;
		int32_t L_141 = L_140;
		V_0 = ((int32_t)il2cpp_codegen_add(L_141, 1));
		int32_t L_142 = V_8;
		int32_t L_143 = __this->___bodyVertexCount_66;
		int32_t L_144 = __this->____sides_60;
		NullCheck(L_139);
		(L_139)->SetAt(static_cast<il2cpp_array_size_t>(L_141), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_142, 2)), L_143)), ((int32_t)il2cpp_codegen_add(L_144, 1)))));
		// for (int i = 0; i < finalSides - 1; i++)
		int32_t L_145 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_145, 1));
	}

IL_034f:
	{
		// for (int i = 0; i < finalSides - 1; i++)
		int32_t L_146 = V_8;
		int32_t L_147 = V_1;
		if ((((int32_t)L_146) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_147, 1)))))
		{
			goto IL_02df;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::GenerateRoundCaps()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator_GenerateRoundCaps_m795F04EEA7FC62AB6089F68EB307B57122EB1326 (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	float V_2 = 0.0f;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_3;
	memset((&V_3), 0, sizeof(V_3));
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_6;
	memset((&V_6), 0, sizeof(V_6));
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	float V_10 = 0.0f;
	float V_11 = 0.0f;
	int32_t V_12 = 0;
	float V_13 = 0.0f;
	int32_t V_14 = 0;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_15;
	memset((&V_15), 0, sizeof(V_15));
	float V_16 = 0.0f;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_17;
	memset((&V_17), 0, sizeof(V_17));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_18;
	memset((&V_18), 0, sizeof(V_18));
	int32_t V_19 = 0;
	int32_t V_20 = 0;
	int32_t V_21 = 0;
	int32_t V_22 = 0;
	int32_t V_23 = 0;
	float V_24 = 0.0f;
	float V_25 = 0.0f;
	int32_t V_26 = 0;
	float V_27 = 0.0f;
	int32_t V_28 = 0;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_29;
	memset((&V_29), 0, sizeof(V_29));
	float V_30 = 0.0f;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_31;
	memset((&V_31), 0, sizeof(V_31));
	int32_t V_32 = 0;
	int32_t V_33 = 0;
	int32_t V_34 = 0;
	int32_t V_35 = 0;
	{
		// GetSample(0, evalResult);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, 0, L_0, NULL);
		// Vector3 center = evalResult.position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_1);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = L_1->___position_0;
		V_0 = L_2;
		// bool hasOffset = offset != Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		bool L_5;
		L_5 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_3, L_4, NULL);
		V_1 = L_5;
		// float resultSize = GetBaseSize(evalResult);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_6 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		float L_7;
		L_7 = MeshGenerator_GetBaseSize_m25D28E870FB60C746299133A0C8DE62F1B07256F(__this, L_6, NULL);
		V_2 = L_7;
		// if (hasOffset)
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_00a2;
		}
	}
	{
		// center += (offset.x * resultSize) * evalResult.right + (offset.y * resultSize) * evalResult.up + (offset.z * resultSize) * evalResult.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_11 = L_10.___x_2;
		float L_12 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_13 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_13);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_13, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15;
		L_15 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_11, L_12)), L_14, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_17 = L_16.___y_3;
		float L_18 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_19 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_19);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = L_19->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_17, L_18)), L_20, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22;
		L_22 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_15, L_21, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		L_23 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_24 = L_23.___z_4;
		float L_25 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_26 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_26);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27 = L_26->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_24, L_25)), L_27, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_22, L_28, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30;
		L_30 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_9, L_29, NULL);
		V_0 = L_30;
	}

IL_00a2:
	{
		// Quaternion lookRot = Quaternion.LookRotation(-evalResult.forward, evalResult.up);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_31 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_31);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32 = L_31->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33;
		L_33 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_32, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_34 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_34);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = L_34->___up_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_36;
		L_36 = Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307(L_33, L_35, NULL);
		V_3 = L_36;
		// float startV = 0f;
		V_4 = (0.0f);
		// float capLengthPercent = 0f;
		V_5 = (0.0f);
		// switch (uvMode)
		int32_t L_37;
		L_37 = MeshGenerator_get_uvMode_m069663A59CCF805CF43951424B6CE3CE106AE889_inline(__this, NULL);
		V_8 = L_37;
		int32_t L_38 = V_8;
		switch (L_38)
		{
			case 0:
			{
				goto IL_00f5;
			}
			case 1:
			{
				goto IL_0131;
			}
			case 2:
			{
				goto IL_0181;
			}
			case 3:
			{
				goto IL_0162;
			}
		}
	}
	{
		goto IL_01a7;
	}

IL_00f5:
	{
		// case UVMode.Clip: startV = (float)evalResult.percent;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_39 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_39);
		double L_40 = L_39->___percent_5;
		V_4 = ((float)L_40);
		// capLengthPercent = (size * 0.5f) / spline.CalculateLength(); break;
		float L_41;
		L_41 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_42;
		L_42 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		NullCheck(L_42);
		float L_43;
		L_43 = SplineComputer_CalculateLength_m73A79AF80927451FF66285B220F11A5F40AC630E(L_42, (0.0), (1.0), NULL);
		V_5 = ((float)(((float)il2cpp_codegen_multiply(L_41, (0.5f)))/L_43));
		// capLengthPercent = (size * 0.5f) / spline.CalculateLength(); break;
		goto IL_01a7;
	}

IL_0131:
	{
		// startV = spline.CalculateLength(0.0, evalResult.percent);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_44;
		L_44 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_45 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_45);
		double L_46 = L_45->___percent_5;
		NullCheck(L_44);
		float L_47;
		L_47 = SplineComputer_CalculateLength_m73A79AF80927451FF66285B220F11A5F40AC630E(L_44, (0.0), L_46, NULL);
		V_4 = L_47;
		// capLengthPercent = size * 0.5f; break;
		float L_48;
		L_48 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		V_5 = ((float)il2cpp_codegen_multiply(L_48, (0.5f)));
		// capLengthPercent = size * 0.5f; break;
		goto IL_01a7;
	}

IL_0162:
	{
		// startV = 0f;
		V_4 = (0.0f);
		// capLengthPercent = size * 0.5f / (float)span;
		float L_49;
		L_49 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		double L_50;
		L_50 = SplineUser_get_span_m4E81282006AD4AC500D4B5B9448A415025BFEE8E(__this, NULL);
		V_5 = ((float)(((float)il2cpp_codegen_multiply(L_49, (0.5f)))/((float)L_50)));
		// break;
		goto IL_01a7;
	}

IL_0181:
	{
		// case UVMode.Clamp: capLengthPercent = (size * 0.5f) / spline.CalculateLength(clipFrom, clipTo); break;
		float L_51;
		L_51 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_52;
		L_52 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		double L_53;
		L_53 = SplineUser_get_clipFrom_m699C755D0B41B89666EEAF9BC216338150573B13_inline(__this, NULL);
		double L_54;
		L_54 = SplineUser_get_clipTo_m8887A1FBDE58D63C6681E3E70783345CE4C6AAFD_inline(__this, NULL);
		NullCheck(L_52);
		float L_55;
		L_55 = SplineComputer_CalculateLength_m73A79AF80927451FF66285B220F11A5F40AC630E(L_52, L_53, L_54, NULL);
		V_5 = ((float)(((float)il2cpp_codegen_multiply(L_51, (0.5f)))/L_55));
	}

IL_01a7:
	{
		// Color vertexColor = GetBaseColor(evalResult) * color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_56 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_57;
		L_57 = MeshGenerator_GetBaseColor_m0668E5049FD711975D9B6E34E4E0CA81028AFDD8(__this, L_56, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_58;
		L_58 = MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline(__this, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_59;
		L_59 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_57, L_58, NULL);
		V_6 = L_59;
		// for (int lat = 1; lat < _roundCapLatitude+1; lat++)
		V_9 = 1;
		goto IL_0394;
	}

IL_01c8:
	{
		// float latitudePercent = ((float)lat / _roundCapLatitude);
		int32_t L_60 = V_9;
		int32_t L_61 = __this->____roundCapLatitude_61;
		V_10 = ((float)(((float)L_60)/((float)L_61)));
		// float latAngle = 90f * latitudePercent;
		float L_62 = V_10;
		V_11 = ((float)il2cpp_codegen_multiply((90.0f), L_62));
		// for (int lon = 0; lon <= sides; lon++)
		V_12 = 0;
		goto IL_0381;
	}

IL_01e7:
	{
		// float anglePercent = (float)lon / sides;
		int32_t L_63 = V_12;
		int32_t L_64;
		L_64 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_13 = ((float)(((float)L_63)/((float)L_64)));
		// int index = bodyVertexCount + lon + (lat-1) * (sides + 1);
		int32_t L_65 = __this->___bodyVertexCount_66;
		int32_t L_66 = V_12;
		int32_t L_67 = V_9;
		int32_t L_68;
		L_68 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_14 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_65, L_66)), ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_67, 1)), ((int32_t)il2cpp_codegen_add(L_68, 1))))));
		// Quaternion rot = Quaternion.AngleAxis(_revolve * anglePercent + rotation + 180f, -Vector3.forward) * Quaternion.AngleAxis(latAngle, Vector3.up);
		float L_69 = __this->____revolve_63;
		float L_70 = V_13;
		float L_71;
		L_71 = MeshGenerator_get_rotation_mB779241C82CC9BB0235F09AA0D249EE1B87CE122_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_72;
		L_72 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_73;
		L_73 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_72, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_74;
		L_74 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_69, L_70)), L_71)), (180.0f))), L_73, NULL);
		float L_75 = V_11;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_76;
		L_76 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_77;
		L_77 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(L_75, L_76, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_78;
		L_78 = Quaternion_op_Multiply_mCB375FCCC12A2EC8F9EB824A1BFB4453B58C2012_inline(L_74, L_77, NULL);
		V_15 = L_78;
		// tsMesh.vertices[index] = center + lookRot * rot * -Vector3.right * (size * 0.5f * evalResult.size);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_79 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_79);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_80 = L_79->___vertices_0;
		int32_t L_81 = V_14;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82 = V_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_83 = V_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_84 = V_15;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_85;
		L_85 = Quaternion_op_Multiply_mCB375FCCC12A2EC8F9EB824A1BFB4453B58C2012_inline(L_83, L_84, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_86;
		L_86 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_87;
		L_87 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_86, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_88;
		L_88 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_85, L_87, NULL);
		float L_89;
		L_89 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_90 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_90);
		float L_91 = L_90->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_92;
		L_92 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_88, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_89, (0.5f))), L_91)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_93;
		L_93 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_82, L_92, NULL);
		NullCheck(L_80);
		(L_80)->SetAt(static_cast<il2cpp_array_size_t>(L_81), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_93);
		// tsMesh.colors[index] = vertexColor;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_94 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_94);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_95 = L_94->___colors_3;
		int32_t L_96 = V_14;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_97 = V_6;
		NullCheck(L_95);
		(L_95)->SetAt(static_cast<il2cpp_array_size_t>(L_96), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_97);
		// tsMesh.normals[index] = (tsMesh.vertices[index] - center).normalized;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_98 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_98);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_99 = L_98->___normals_1;
		int32_t L_100 = V_14;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_101 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_101);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_102 = L_101->___vertices_0;
		int32_t L_103 = V_14;
		NullCheck(L_102);
		int32_t L_104 = L_103;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_105 = (L_102)->GetAt(static_cast<il2cpp_array_size_t>(L_104));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_106 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_107;
		L_107 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_105, L_106, NULL);
		V_18 = L_107;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_108;
		L_108 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_18), NULL);
		NullCheck(L_99);
		(L_99)->SetAt(static_cast<il2cpp_array_size_t>(L_100), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_108);
		// float baseV = startV + capLengthPercent * latitudePercent;
		float L_109 = V_4;
		float L_110 = V_5;
		float L_111 = V_10;
		V_16 = ((float)il2cpp_codegen_add(L_109, ((float)il2cpp_codegen_multiply(L_110, L_111))));
		// Vector2 baseUV = new Vector2(anglePercent * uvScale.x - baseV * _uvTwist, baseV * uvScale.y) - uvOffset;
		float L_112 = V_13;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_113;
		L_113 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_114 = L_113.___x_0;
		float L_115 = V_16;
		float L_116 = __this->____uvTwist_65;
		float L_117 = V_16;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_118;
		L_118 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_119 = L_118.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_120;
		memset((&L_120), 0, sizeof(L_120));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_120), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_112, L_114)), ((float)il2cpp_codegen_multiply(L_115, L_116)))), ((float)il2cpp_codegen_multiply(L_117, L_119)), /*hidden argument*/NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_121;
		L_121 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_122;
		L_122 = Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline(L_120, L_121, NULL);
		V_17 = L_122;
		// tsMesh.uv[index] = Vector2.one * 0.5f + (Vector2)(Quaternion.AngleAxis(uvRotation + 180f, Vector3.forward) * (Vector2.one * 0.5f - baseUV));
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_123 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_123);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_124 = L_123->___uv_4;
		int32_t L_125 = V_14;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_126;
		L_126 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_127;
		L_127 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_126, (0.5f), NULL);
		float L_128;
		L_128 = MeshGenerator_get_uvRotation_m38AD623D63FEDB94A5DFEEF63F3352AC5E707964_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_129;
		L_129 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_130;
		L_130 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_add(L_128, (180.0f))), L_129, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_131;
		L_131 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_132;
		L_132 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_131, (0.5f), NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_133 = V_17;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_134;
		L_134 = Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline(L_132, L_133, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_135;
		L_135 = Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline(L_134, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_136;
		L_136 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_130, L_135, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_137;
		L_137 = Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline(L_136, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_138;
		L_138 = Vector2_op_Addition_m8136742CE6EE33BA4EB81C5F584678455917D2AE_inline(L_127, L_137, NULL);
		NullCheck(L_124);
		(L_124)->SetAt(static_cast<il2cpp_array_size_t>(L_125), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_138);
		// for (int lon = 0; lon <= sides; lon++)
		int32_t L_139 = V_12;
		V_12 = ((int32_t)il2cpp_codegen_add(L_139, 1));
	}

IL_0381:
	{
		// for (int lon = 0; lon <= sides; lon++)
		int32_t L_140 = V_12;
		int32_t L_141;
		L_141 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		if ((((int32_t)L_140) <= ((int32_t)L_141)))
		{
			goto IL_01e7;
		}
	}
	{
		// for (int lat = 1; lat < _roundCapLatitude+1; lat++)
		int32_t L_142 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_add(L_142, 1));
	}

IL_0394:
	{
		// for (int lat = 1; lat < _roundCapLatitude+1; lat++)
		int32_t L_143 = V_9;
		int32_t L_144 = __this->____roundCapLatitude_61;
		if ((((int32_t)L_143) < ((int32_t)((int32_t)il2cpp_codegen_add(L_144, 1)))))
		{
			goto IL_01c8;
		}
	}
	{
		// int t = bodyTrisCount;
		int32_t L_145 = __this->___bodyTrisCount_67;
		V_7 = L_145;
		// for (int z = -1; z < _roundCapLatitude - 1; z++)
		V_19 = (-1);
		goto IL_0490;
	}

IL_03b3:
	{
		// for (int x = 0; x < sides; x++)
		V_20 = 0;
		goto IL_047d;
	}

IL_03bb:
	{
		// int current = bodyVertexCount + x + z * (sides + 1);
		int32_t L_146 = __this->___bodyVertexCount_66;
		int32_t L_147 = V_20;
		int32_t L_148 = V_19;
		int32_t L_149;
		L_149 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_21 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_146, L_147)), ((int32_t)il2cpp_codegen_multiply(L_148, ((int32_t)il2cpp_codegen_add(L_149, 1))))));
		// int next = current + (sides + 1);
		int32_t L_150 = V_21;
		int32_t L_151;
		L_151 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_22 = ((int32_t)il2cpp_codegen_add(L_150, ((int32_t)il2cpp_codegen_add(L_151, 1))));
		// if (z == -1)
		int32_t L_152 = V_19;
		if ((!(((uint32_t)L_152) == ((uint32_t)(-1)))))
		{
			goto IL_03f3;
		}
	}
	{
		// current = x;
		int32_t L_153 = V_20;
		V_21 = L_153;
		// next = bodyVertexCount + x;
		int32_t L_154 = __this->___bodyVertexCount_66;
		int32_t L_155 = V_20;
		V_22 = ((int32_t)il2cpp_codegen_add(L_154, L_155));
	}

IL_03f3:
	{
		// tsMesh.triangles[t++] = next + 1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_156 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_156);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_157 = L_156->___triangles_8;
		int32_t L_158 = V_7;
		int32_t L_159 = L_158;
		V_7 = ((int32_t)il2cpp_codegen_add(L_159, 1));
		int32_t L_160 = V_22;
		NullCheck(L_157);
		(L_157)->SetAt(static_cast<il2cpp_array_size_t>(L_159), (int32_t)((int32_t)il2cpp_codegen_add(L_160, 1)));
		// tsMesh.triangles[t++] = current + 1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_161 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_161);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_162 = L_161->___triangles_8;
		int32_t L_163 = V_7;
		int32_t L_164 = L_163;
		V_7 = ((int32_t)il2cpp_codegen_add(L_164, 1));
		int32_t L_165 = V_21;
		NullCheck(L_162);
		(L_162)->SetAt(static_cast<il2cpp_array_size_t>(L_164), (int32_t)((int32_t)il2cpp_codegen_add(L_165, 1)));
		// tsMesh.triangles[t++] = current;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_166 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_166);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_167 = L_166->___triangles_8;
		int32_t L_168 = V_7;
		int32_t L_169 = L_168;
		V_7 = ((int32_t)il2cpp_codegen_add(L_169, 1));
		int32_t L_170 = V_21;
		NullCheck(L_167);
		(L_167)->SetAt(static_cast<il2cpp_array_size_t>(L_169), (int32_t)L_170);
		// tsMesh.triangles[t++] = next;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_171 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_171);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_172 = L_171->___triangles_8;
		int32_t L_173 = V_7;
		int32_t L_174 = L_173;
		V_7 = ((int32_t)il2cpp_codegen_add(L_174, 1));
		int32_t L_175 = V_22;
		NullCheck(L_172);
		(L_172)->SetAt(static_cast<il2cpp_array_size_t>(L_174), (int32_t)L_175);
		// tsMesh.triangles[t++] = next + 1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_176 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_176);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_177 = L_176->___triangles_8;
		int32_t L_178 = V_7;
		int32_t L_179 = L_178;
		V_7 = ((int32_t)il2cpp_codegen_add(L_179, 1));
		int32_t L_180 = V_22;
		NullCheck(L_177);
		(L_177)->SetAt(static_cast<il2cpp_array_size_t>(L_179), (int32_t)((int32_t)il2cpp_codegen_add(L_180, 1)));
		// tsMesh.triangles[t++] = current;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_181 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_181);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_182 = L_181->___triangles_8;
		int32_t L_183 = V_7;
		int32_t L_184 = L_183;
		V_7 = ((int32_t)il2cpp_codegen_add(L_184, 1));
		int32_t L_185 = V_21;
		NullCheck(L_182);
		(L_182)->SetAt(static_cast<il2cpp_array_size_t>(L_184), (int32_t)L_185);
		// for (int x = 0; x < sides; x++)
		int32_t L_186 = V_20;
		V_20 = ((int32_t)il2cpp_codegen_add(L_186, 1));
	}

IL_047d:
	{
		// for (int x = 0; x < sides; x++)
		int32_t L_187 = V_20;
		int32_t L_188;
		L_188 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		if ((((int32_t)L_187) < ((int32_t)L_188)))
		{
			goto IL_03bb;
		}
	}
	{
		// for (int z = -1; z < _roundCapLatitude - 1; z++)
		int32_t L_189 = V_19;
		V_19 = ((int32_t)il2cpp_codegen_add(L_189, 1));
	}

IL_0490:
	{
		// for (int z = -1; z < _roundCapLatitude - 1; z++)
		int32_t L_190 = V_19;
		int32_t L_191 = __this->____roundCapLatitude_61;
		if ((((int32_t)L_190) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_191, 1)))))
		{
			goto IL_03b3;
		}
	}
	{
		// GetSample(sampleCount - 1, evalResult);
		int32_t L_192;
		L_192 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_193 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		SplineUser_GetSample_m7480D0F5AC6544AD4D5778D0BC42C6898A83BB56(__this, ((int32_t)il2cpp_codegen_subtract(L_192, 1)), L_193, NULL);
		// center = evalResult.position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_194 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_194);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_195 = L_194->___position_0;
		V_0 = L_195;
		// resultSize = GetBaseSize(evalResult);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_196 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		float L_197;
		L_197 = MeshGenerator_GetBaseSize_m25D28E870FB60C746299133A0C8DE62F1B07256F(__this, L_196, NULL);
		V_2 = L_197;
		// if (hasOffset)
		bool L_198 = V_1;
		if (!L_198)
		{
			goto IL_0537;
		}
	}
	{
		// center += (offset.x * resultSize) * evalResult.right + (offset.y * resultSize) * evalResult.up + (offset.z * resultSize) * evalResult.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_199 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_200;
		L_200 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_201 = L_200.___x_2;
		float L_202 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_203 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_203);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_204;
		L_204 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_203, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_205;
		L_205 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_201, L_202)), L_204, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_206;
		L_206 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_207 = L_206.___y_3;
		float L_208 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_209 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_209);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_210 = L_209->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_211;
		L_211 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_207, L_208)), L_210, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_212;
		L_212 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_205, L_211, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_213;
		L_213 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_214 = L_213.___z_4;
		float L_215 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_216 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_216);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_217 = L_216->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_218;
		L_218 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(L_214, L_215)), L_217, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_219;
		L_219 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_212, L_218, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_220;
		L_220 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_199, L_219, NULL);
		V_0 = L_220;
	}

IL_0537:
	{
		// lookRot = Quaternion.LookRotation(evalResult.forward, evalResult.up);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_221 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_221);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_222 = L_221->___forward_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_223 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_223);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_224 = L_223->___up_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_225;
		L_225 = Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307(L_222, L_224, NULL);
		V_3 = L_225;
		// switch (uvMode)
		int32_t L_226;
		L_226 = MeshGenerator_get_uvMode_m069663A59CCF805CF43951424B6CE3CE106AE889_inline(__this, NULL);
		V_8 = L_226;
		int32_t L_227 = V_8;
		switch (L_227)
		{
			case 0:
			{
				goto IL_0574;
			}
			case 1:
			{
				goto IL_0584;
			}
			case 2:
			{
				goto IL_05a7;
			}
			case 3:
			{
				goto IL_05b0;
			}
		}
	}
	{
		goto IL_05cf;
	}

IL_0574:
	{
		// case UVMode.Clip: startV = (float)evalResult.percent; break;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_228 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_228);
		double L_229 = L_228->___percent_5;
		V_4 = ((float)L_229);
		// case UVMode.Clip: startV = (float)evalResult.percent; break;
		goto IL_05cf;
	}

IL_0584:
	{
		// case UVMode.UniformClip: startV = spline.CalculateLength(0.0, evalResult.percent); break;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_230;
		L_230 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_231 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_231);
		double L_232 = L_231->___percent_5;
		NullCheck(L_230);
		float L_233;
		L_233 = SplineComputer_CalculateLength_m73A79AF80927451FF66285B220F11A5F40AC630E(L_230, (0.0), L_232, NULL);
		V_4 = L_233;
		// case UVMode.UniformClip: startV = spline.CalculateLength(0.0, evalResult.percent); break;
		goto IL_05cf;
	}

IL_05a7:
	{
		// case UVMode.Clamp: startV = 1f; break;
		V_4 = (1.0f);
		// case UVMode.Clamp: startV = 1f; break;
		goto IL_05cf;
	}

IL_05b0:
	{
		// case UVMode.UniformClamp: startV = spline.CalculateLength(); break;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_234;
		L_234 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		NullCheck(L_234);
		float L_235;
		L_235 = SplineComputer_CalculateLength_m73A79AF80927451FF66285B220F11A5F40AC630E(L_234, (0.0), (1.0), NULL);
		V_4 = L_235;
	}

IL_05cf:
	{
		// vertexColor = GetBaseColor(evalResult) * color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_236 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_237;
		L_237 = MeshGenerator_GetBaseColor_m0668E5049FD711975D9B6E34E4E0CA81028AFDD8(__this, L_236, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_238;
		L_238 = MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline(__this, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_239;
		L_239 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_237, L_238, NULL);
		V_6 = L_239;
		// for (int lat = 1; lat < _roundCapLatitude+1; lat++)
		V_23 = 1;
		goto IL_07c6;
	}

IL_05f0:
	{
		// float latitudePercent = ((float)lat / _roundCapLatitude);
		int32_t L_240 = V_23;
		int32_t L_241 = __this->____roundCapLatitude_61;
		V_24 = ((float)(((float)L_240)/((float)L_241)));
		// float latAngle = 90f * latitudePercent;
		float L_242 = V_24;
		V_25 = ((float)il2cpp_codegen_multiply((90.0f), L_242));
		// for (int lon = 0; lon <= sides; lon++)
		V_26 = 0;
		goto IL_07b3;
	}

IL_060f:
	{
		// float anglePercent = (float)lon / sides;
		int32_t L_243 = V_26;
		int32_t L_244;
		L_244 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_27 = ((float)(((float)L_243)/((float)L_244)));
		// int index = bodyVertexCount + capVertexCount + lon + (lat - 1) * (sides + 1);
		int32_t L_245 = __this->___bodyVertexCount_66;
		int32_t L_246 = __this->___capVertexCount_68;
		int32_t L_247 = V_26;
		int32_t L_248 = V_23;
		int32_t L_249;
		L_249 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_28 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_245, L_246)), L_247)), ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_248, 1)), ((int32_t)il2cpp_codegen_add(L_249, 1))))));
		// Quaternion rot = Quaternion.AngleAxis(_revolve * anglePercent + rotation + 180f, Vector3.forward) * Quaternion.AngleAxis(latAngle, -Vector3.up);
		float L_250 = __this->____revolve_63;
		float L_251 = V_27;
		float L_252;
		L_252 = MeshGenerator_get_rotation_mB779241C82CC9BB0235F09AA0D249EE1B87CE122_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_253;
		L_253 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_254;
		L_254 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_250, L_251)), L_252)), (180.0f))), L_253, NULL);
		float L_255 = V_25;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_256;
		L_256 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_257;
		L_257 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_256, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_258;
		L_258 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(L_255, L_257, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_259;
		L_259 = Quaternion_op_Multiply_mCB375FCCC12A2EC8F9EB824A1BFB4453B58C2012_inline(L_254, L_258, NULL);
		V_29 = L_259;
		// tsMesh.vertices[index] = center + lookRot * rot * Vector3.right * size * 0.5f * evalResult.size;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_260 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_260);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_261 = L_260->___vertices_0;
		int32_t L_262 = V_28;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_263 = V_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_264 = V_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_265 = V_29;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_266;
		L_266 = Quaternion_op_Multiply_mCB375FCCC12A2EC8F9EB824A1BFB4453B58C2012_inline(L_264, L_265, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_267;
		L_267 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_268;
		L_268 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_266, L_267, NULL);
		float L_269;
		L_269 = MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_270;
		L_270 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_268, L_269, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_271;
		L_271 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_270, (0.5f), NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_272 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_272);
		float L_273 = L_272->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_274;
		L_274 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_271, L_273, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_275;
		L_275 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_263, L_274, NULL);
		NullCheck(L_261);
		(L_261)->SetAt(static_cast<il2cpp_array_size_t>(L_262), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_275);
		// tsMesh.normals[index] = (tsMesh.vertices[index] - center).normalized;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_276 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_276);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_277 = L_276->___normals_1;
		int32_t L_278 = V_28;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_279 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_279);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_280 = L_279->___vertices_0;
		int32_t L_281 = V_28;
		NullCheck(L_280);
		int32_t L_282 = L_281;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_283 = (L_280)->GetAt(static_cast<il2cpp_array_size_t>(L_282));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_284 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_285;
		L_285 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_283, L_284, NULL);
		V_18 = L_285;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_286;
		L_286 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_18), NULL);
		NullCheck(L_277);
		(L_277)->SetAt(static_cast<il2cpp_array_size_t>(L_278), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_286);
		// tsMesh.colors[index] = vertexColor;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_287 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_287);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_288 = L_287->___colors_3;
		int32_t L_289 = V_28;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_290 = V_6;
		NullCheck(L_288);
		(L_288)->SetAt(static_cast<il2cpp_array_size_t>(L_289), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_290);
		// float baseV = startV + capLengthPercent * latitudePercent;
		float L_291 = V_4;
		float L_292 = V_5;
		float L_293 = V_24;
		V_30 = ((float)il2cpp_codegen_add(L_291, ((float)il2cpp_codegen_multiply(L_292, L_293))));
		// Vector2 baseUV = new Vector2(anglePercent * uvScale.x + baseV * _uvTwist, baseV * uvScale.y) - uvOffset;
		float L_294 = V_27;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_295;
		L_295 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_296 = L_295.___x_0;
		float L_297 = V_30;
		float L_298 = __this->____uvTwist_65;
		float L_299 = V_30;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_300;
		L_300 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_301 = L_300.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_302;
		memset((&L_302), 0, sizeof(L_302));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_302), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_294, L_296)), ((float)il2cpp_codegen_multiply(L_297, L_298)))), ((float)il2cpp_codegen_multiply(L_299, L_301)), /*hidden argument*/NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_303;
		L_303 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_304;
		L_304 = Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline(L_302, L_303, NULL);
		V_31 = L_304;
		// tsMesh.uv[index] = Vector2.one * 0.5f + (Vector2)(Quaternion.AngleAxis(uvRotation + 180f, Vector3.forward) * (Vector2.one * 0.5f - baseUV));
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_305 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_305);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_306 = L_305->___uv_4;
		int32_t L_307 = V_28;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_308;
		L_308 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_309;
		L_309 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_308, (0.5f), NULL);
		float L_310;
		L_310 = MeshGenerator_get_uvRotation_m38AD623D63FEDB94A5DFEEF63F3352AC5E707964_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_311;
		L_311 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_312;
		L_312 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_add(L_310, (180.0f))), L_311, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_313;
		L_313 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_314;
		L_314 = Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline(L_313, (0.5f), NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_315 = V_31;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_316;
		L_316 = Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline(L_314, L_315, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_317;
		L_317 = Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline(L_316, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_318;
		L_318 = Quaternion_op_Multiply_mE1EBA73F9173432B50F8F17CE8190C5A7986FB8C(L_312, L_317, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_319;
		L_319 = Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline(L_318, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_320;
		L_320 = Vector2_op_Addition_m8136742CE6EE33BA4EB81C5F584678455917D2AE_inline(L_309, L_319, NULL);
		NullCheck(L_306);
		(L_306)->SetAt(static_cast<il2cpp_array_size_t>(L_307), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_320);
		// for (int lon = 0; lon <= sides; lon++)
		int32_t L_321 = V_26;
		V_26 = ((int32_t)il2cpp_codegen_add(L_321, 1));
	}

IL_07b3:
	{
		// for (int lon = 0; lon <= sides; lon++)
		int32_t L_322 = V_26;
		int32_t L_323;
		L_323 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		if ((((int32_t)L_322) <= ((int32_t)L_323)))
		{
			goto IL_060f;
		}
	}
	{
		// for (int lat = 1; lat < _roundCapLatitude+1; lat++)
		int32_t L_324 = V_23;
		V_23 = ((int32_t)il2cpp_codegen_add(L_324, 1));
	}

IL_07c6:
	{
		// for (int lat = 1; lat < _roundCapLatitude+1; lat++)
		int32_t L_325 = V_23;
		int32_t L_326 = __this->____roundCapLatitude_61;
		if ((((int32_t)L_325) < ((int32_t)((int32_t)il2cpp_codegen_add(L_326, 1)))))
		{
			goto IL_05f0;
		}
	}
	{
		// for (int z = -1; z < _roundCapLatitude - 1; z++)
		V_32 = (-1);
		goto IL_08d8;
	}

IL_07dd:
	{
		// for (int x = 0; x < sides; x++)
		V_33 = 0;
		goto IL_08c5;
	}

IL_07e5:
	{
		// int current = bodyVertexCount + capVertexCount + x + z * (sides + 1);
		int32_t L_327 = __this->___bodyVertexCount_66;
		int32_t L_328 = __this->___capVertexCount_68;
		int32_t L_329 = V_33;
		int32_t L_330 = V_32;
		int32_t L_331;
		L_331 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_34 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_327, L_328)), L_329)), ((int32_t)il2cpp_codegen_multiply(L_330, ((int32_t)il2cpp_codegen_add(L_331, 1))))));
		// int next = current + (sides + 1);
		int32_t L_332 = V_34;
		int32_t L_333;
		L_333 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		V_35 = ((int32_t)il2cpp_codegen_add(L_332, ((int32_t)il2cpp_codegen_add(L_333, 1))));
		// if (z == -1)
		int32_t L_334 = V_32;
		if ((!(((uint32_t)L_334) == ((uint32_t)(-1)))))
		{
			goto IL_083b;
		}
	}
	{
		// current = bodyVertexCount - (_sides+1) + x;
		int32_t L_335 = __this->___bodyVertexCount_66;
		int32_t L_336 = __this->____sides_60;
		int32_t L_337 = V_33;
		V_34 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_335, ((int32_t)il2cpp_codegen_add(L_336, 1)))), L_337));
		// next = bodyVertexCount + capVertexCount + x;
		int32_t L_338 = __this->___bodyVertexCount_66;
		int32_t L_339 = __this->___capVertexCount_68;
		int32_t L_340 = V_33;
		V_35 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_338, L_339)), L_340));
	}

IL_083b:
	{
		// tsMesh.triangles[t++] = current+1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_341 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_341);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_342 = L_341->___triangles_8;
		int32_t L_343 = V_7;
		int32_t L_344 = L_343;
		V_7 = ((int32_t)il2cpp_codegen_add(L_344, 1));
		int32_t L_345 = V_34;
		NullCheck(L_342);
		(L_342)->SetAt(static_cast<il2cpp_array_size_t>(L_344), (int32_t)((int32_t)il2cpp_codegen_add(L_345, 1)));
		// tsMesh.triangles[t++] = next + 1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_346 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_346);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_347 = L_346->___triangles_8;
		int32_t L_348 = V_7;
		int32_t L_349 = L_348;
		V_7 = ((int32_t)il2cpp_codegen_add(L_349, 1));
		int32_t L_350 = V_35;
		NullCheck(L_347);
		(L_347)->SetAt(static_cast<il2cpp_array_size_t>(L_349), (int32_t)((int32_t)il2cpp_codegen_add(L_350, 1)));
		// tsMesh.triangles[t++] = next;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_351 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_351);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_352 = L_351->___triangles_8;
		int32_t L_353 = V_7;
		int32_t L_354 = L_353;
		V_7 = ((int32_t)il2cpp_codegen_add(L_354, 1));
		int32_t L_355 = V_35;
		NullCheck(L_352);
		(L_352)->SetAt(static_cast<il2cpp_array_size_t>(L_354), (int32_t)L_355);
		// tsMesh.triangles[t++] = next;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_356 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_356);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_357 = L_356->___triangles_8;
		int32_t L_358 = V_7;
		int32_t L_359 = L_358;
		V_7 = ((int32_t)il2cpp_codegen_add(L_359, 1));
		int32_t L_360 = V_35;
		NullCheck(L_357);
		(L_357)->SetAt(static_cast<il2cpp_array_size_t>(L_359), (int32_t)L_360);
		// tsMesh.triangles[t++] = current;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_361 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_361);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_362 = L_361->___triangles_8;
		int32_t L_363 = V_7;
		int32_t L_364 = L_363;
		V_7 = ((int32_t)il2cpp_codegen_add(L_364, 1));
		int32_t L_365 = V_34;
		NullCheck(L_362);
		(L_362)->SetAt(static_cast<il2cpp_array_size_t>(L_364), (int32_t)L_365);
		// tsMesh.triangles[t++] = current + 1;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_366 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_366);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_367 = L_366->___triangles_8;
		int32_t L_368 = V_7;
		int32_t L_369 = L_368;
		V_7 = ((int32_t)il2cpp_codegen_add(L_369, 1));
		int32_t L_370 = V_34;
		NullCheck(L_367);
		(L_367)->SetAt(static_cast<il2cpp_array_size_t>(L_369), (int32_t)((int32_t)il2cpp_codegen_add(L_370, 1)));
		// for (int x = 0; x < sides; x++)
		int32_t L_371 = V_33;
		V_33 = ((int32_t)il2cpp_codegen_add(L_371, 1));
	}

IL_08c5:
	{
		// for (int x = 0; x < sides; x++)
		int32_t L_372 = V_33;
		int32_t L_373;
		L_373 = TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline(__this, NULL);
		if ((((int32_t)L_372) < ((int32_t)L_373)))
		{
			goto IL_07e5;
		}
	}
	{
		// for (int z = -1; z < _roundCapLatitude - 1; z++)
		int32_t L_374 = V_32;
		V_32 = ((int32_t)il2cpp_codegen_add(L_374, 1));
	}

IL_08d8:
	{
		// for (int z = -1; z < _roundCapLatitude - 1; z++)
		int32_t L_375 = V_32;
		int32_t L_376 = __this->____roundCapLatitude_61;
		if ((((int32_t)L_375) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_376, 1)))))
		{
			goto IL_07dd;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TubeGenerator::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TubeGenerator__ctor_mC2C50C841782D91A4B6056FFC5368147C4E1A6DC (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private int _sides = 12;
		__this->____sides_60 = ((int32_t)12);
		// private int _roundCapLatitude = 6;
		__this->____roundCapLatitude_61 = 6;
		// private float _revolve = 360f;
		__this->____revolve_63 = (360.0f);
		// private float _capUVScale = 1f;
		__this->____capUVScale_64 = (1.0f);
		il2cpp_codegen_runtime_class_init_inline(MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		MeshGenerator__ctor_mC01695CDAB2865B65DC8307E3B9841B0B1B81182(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Dreamteck.Splines.WaveformGenerator/Axis Dreamteck.Splines.WaveformGenerator::get_axis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WaveformGenerator_get_axis_m8AAA47B9C6A654E90EBED368924F829D31B6A753 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// get { return _axis; }
		int32_t L_0 = __this->____axis_60;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::set_axis(Dreamteck.Splines.WaveformGenerator/Axis)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_set_axis_mAE6D67ADF685842485E14878B282EFE2B6388B58 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _axis)
		int32_t L_0 = ___0_value;
		int32_t L_1 = __this->____axis_60;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _axis = value;
		int32_t L_2 = ___0_value;
		__this->____axis_60 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Boolean Dreamteck.Splines.WaveformGenerator::get_symmetry()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WaveformGenerator_get_symmetry_m9F50C583986917AEB336329EFD396D5436B7E233 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// get { return _symmetry; }
		bool L_0 = __this->____symmetry_61;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::set_symmetry(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_set_symmetry_mFE58271826F8F092837C7783AF60B61E05AAC796 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _symmetry)
		bool L_0 = ___0_value;
		bool L_1 = __this->____symmetry_61;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _symmetry = value;
		bool L_2 = ___0_value;
		__this->____symmetry_61 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// Dreamteck.Splines.WaveformGenerator/UVWrapMode Dreamteck.Splines.WaveformGenerator::get_uvWrapMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WaveformGenerator_get_uvWrapMode_m63B0783261375F0F4857EC99E7D6C0CE4DA7550C (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uvWrapMode; }
		int32_t L_0 = __this->____uvWrapMode_62;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::set_uvWrapMode(Dreamteck.Splines.WaveformGenerator/UVWrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_set_uvWrapMode_m5626393D9001A30AE7055FC8C09597B71CCD667F (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _uvWrapMode)
		int32_t L_0 = ___0_value;
		int32_t L_1 = __this->____uvWrapMode_62;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0016;
		}
	}
	{
		// _uvWrapMode = value;
		int32_t L_2 = ___0_value;
		__this->____uvWrapMode_62 = L_2;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_0016:
	{
		// }
		return;
	}
}
// System.Int32 Dreamteck.Splines.WaveformGenerator::get_slices()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WaveformGenerator_get_slices_m0897FF5DF517C63E8410E772228C0214B8C4B362 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// get { return _slices; }
		int32_t L_0 = __this->____slices_63;
		return L_0;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::set_slices(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_set_slices_mBAFF1D43E3D7D1A91C40340604478419ABD382C0 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// if (value != _slices)
		int32_t L_0 = ___0_value;
		int32_t L_1 = __this->____slices_63;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001d;
		}
	}
	{
		// if (value < 1) value = 1;
		int32_t L_2 = ___0_value;
		if ((((int32_t)L_2) >= ((int32_t)1)))
		{
			goto IL_0010;
		}
	}
	{
		// if (value < 1) value = 1;
		___0_value = 1;
	}

IL_0010:
	{
		// _slices = value;
		int32_t L_3 = ___0_value;
		__this->____slices_63 = L_3;
		// Rebuild();
		VirtualActionInvoker0::Invoke(12 /* System.Void Dreamteck.Splines.SplineUser::Rebuild() */, __this);
	}

IL_001d:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_Awake_m5E63FEEA6D452BC3DCB1E8DCDBBF103E530D92CB (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC8030254E2A044716BE5C6218DC805EFA9F40947);
		s_Il2CppMethodInitialized = true;
	}
	{
		// base.Awake();
		MeshGenerator_Awake_m01397118A8B7F582739A549E42020A7D3ED78D1D(__this, NULL);
		// mesh.name = "waveform";
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_0 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___mesh_54;
		NullCheck(L_0);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_0, _stringLiteralC8030254E2A044716BE5C6218DC805EFA9F40947, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::BuildMesh()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_BuildMesh_mAEE710C0A7255C1496821FE7E055E2F83D807512 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// base.BuildMesh();
		MeshGenerator_BuildMesh_m4236C36A669B18C4515D7C463126F87D18E38464(__this, NULL);
		// Generate();
		WaveformGenerator_Generate_m6C3F9AAD82374B4F77E60C67E476AC292B54BADF(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::Build()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_Build_m67D3B203720C9CA3769187849B9474168CB6C209 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// base.Build();
		MeshGenerator_Build_m68DE60DDB0027B95BA65CA6A8B4D02658BB6528A(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::LateRun()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_LateRun_m3B1799D7FEE75D7F0615121D38BAB64E6F5E92BD (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	{
		// base.LateRun();
		MeshGenerator_LateRun_mC06A5F11D453D5E4CA19E1D8B27C4B0383A587A7(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::Generate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator_Generate_m6C3F9AAD82374B4F77E60C67E476AC292B54BADF (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	float V_7 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_8;
	memset((&V_8), 0, sizeof(V_8));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_9;
	memset((&V_9), 0, sizeof(V_9));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_10;
	memset((&V_10), 0, sizeof(V_10));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_11;
	memset((&V_11), 0, sizeof(V_11));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_12;
	memset((&V_12), 0, sizeof(V_12));
	float V_13 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_14;
	memset((&V_14), 0, sizeof(V_14));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_15;
	memset((&V_15), 0, sizeof(V_15));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_16;
	memset((&V_16), 0, sizeof(V_16));
	int32_t V_17 = 0;
	float V_18 = 0.0f;
	int32_t V_19 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B14_0 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B13_0 = NULL;
	float G_B15_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B15_1 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B18_0 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B17_0 = NULL;
	float G_B19_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B19_1 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B22_0 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B21_0 = NULL;
	float G_B23_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* G_B23_1 = NULL;
	{
		// int vertexCount = sampleCount * (_slices + 1);
		int32_t L_0;
		L_0 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		int32_t L_1 = __this->____slices_63;
		V_0 = ((int32_t)il2cpp_codegen_multiply(L_0, ((int32_t)il2cpp_codegen_add(L_1, 1))));
		// AllocateMesh(vertexCount, _slices * (sampleCount - 1) * 6);
		int32_t L_2 = V_0;
		int32_t L_3 = __this->____slices_63;
		int32_t L_4;
		L_4 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		VirtualActionInvoker2< int32_t, int32_t >::Invoke(24 /* System.Void Dreamteck.Splines.MeshGenerator::AllocateMesh(System.Int32,System.Int32) */, __this, L_2, ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_3, ((int32_t)il2cpp_codegen_subtract(L_4, 1)))), 6)));
		// int vertIndex = 0;
		V_1 = 0;
		// float avgTop = 0f;
		V_2 = (0.0f);
		// float totalLength = 0f;
		V_3 = (0.0f);
		// Vector3 computerPosition = spline.position;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_5;
		L_5 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = SplineComputer_get_position_mD2F6425281CB9AFF55B9A81B5433F4454793D725_inline(L_5, NULL);
		// Vector3 normal = spline.TransformDirection(Vector3.right);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_7;
		L_7 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		NullCheck(L_7);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = SplineComputer_TransformDirection_m7F943932EB9A36F3655B4F4F64498190CD512056(L_7, L_8, NULL);
		V_4 = L_9;
		// switch (_axis)
		int32_t L_10 = __this->____axis_60;
		V_5 = L_10;
		int32_t L_11 = V_5;
		if ((((int32_t)L_11) == ((int32_t)1)))
		{
			goto IL_0068;
		}
	}
	{
		int32_t L_12 = V_5;
		if ((((int32_t)L_12) == ((int32_t)2)))
		{
			goto IL_007c;
		}
	}
	{
		goto IL_008e;
	}

IL_0068:
	{
		// case Axis.Y: normal = spline.TransformDirection(Vector3.up); break;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_13;
		L_13 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		NullCheck(L_13);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15;
		L_15 = SplineComputer_TransformDirection_m7F943932EB9A36F3655B4F4F64498190CD512056(L_13, L_14, NULL);
		V_4 = L_15;
		// case Axis.Y: normal = spline.TransformDirection(Vector3.up); break;
		goto IL_008e;
	}

IL_007c:
	{
		// case Axis.Z: normal = spline.TransformDirection(Vector3.forward); break;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_16;
		L_16 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17;
		L_17 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		NullCheck(L_16);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = SplineComputer_TransformDirection_m7F943932EB9A36F3655B4F4F64498190CD512056(L_16, L_17, NULL);
		V_4 = L_18;
	}

IL_008e:
	{
		// for (int i = 0; i < sampleCount; i++)
		V_6 = 0;
		goto IL_0476;
	}

IL_0096:
	{
		// evalResult = GetSampleRaw(i);
		int32_t L_19 = V_6;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_20;
		L_20 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, L_19, NULL);
		((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26 = L_20;
		Il2CppCodeGenWriteBarrier((void**)(&((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26), (void*)L_20);
		// float resultSize = GetBaseSize(evalResult);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_21 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		float L_22;
		L_22 = MeshGenerator_GetBaseSize_m25D28E870FB60C746299133A0C8DE62F1B07256F(__this, L_21, NULL);
		V_7 = L_22;
		// Vector3 samplePosition = evalResult.position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_23 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_23);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = L_23->___position_0;
		V_8 = L_24;
		// Vector3 localSamplePosition = spline.InverseTransformPoint(samplePosition);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_25;
		L_25 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = V_8;
		NullCheck(L_25);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = SplineComputer_InverseTransformPoint_mB227D68C60B30DB16D9B1B5C22D0593B918536BB(L_25, L_26, NULL);
		V_9 = L_27;
		// Vector3 bottomPosition = localSamplePosition;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28 = V_9;
		V_10 = L_28;
		// Vector3 sampleDirection = evalResult.forward;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_29 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_29);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30 = L_29->___forward_2;
		V_11 = L_30;
		// Vector3 sampleNormal = evalResult.up;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_31 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_31);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32 = L_31->___up_1;
		V_12 = L_32;
		// float heightPercent = 1f;
		V_13 = (1.0f);
		// if (_uvWrapMode == UVWrapMode.UniformX || _uvWrapMode == UVWrapMode.Uniform)
		int32_t L_33 = __this->____uvWrapMode_62;
		if ((((int32_t)L_33) == ((int32_t)1)))
		{
			goto IL_0105;
		}
	}
	{
		int32_t L_34 = __this->____uvWrapMode_62;
		if ((!(((uint32_t)L_34) == ((uint32_t)3))))
		{
			goto IL_012c;
		}
	}

IL_0105:
	{
		// if (i > 0) totalLength += Vector3.Distance(evalResult.position, GetSampleRaw(i - 1).position);
		int32_t L_35 = V_6;
		if ((((int32_t)L_35) <= ((int32_t)0)))
		{
			goto IL_012c;
		}
	}
	{
		// if (i > 0) totalLength += Vector3.Distance(evalResult.position, GetSampleRaw(i - 1).position);
		float L_36 = V_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_37 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_37);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38 = L_37->___position_0;
		int32_t L_39 = V_6;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_40;
		L_40 = SplineUser_GetSampleRaw_m25510D806BDB5E8055F5F65F9DF2A1AEAF5F8111(__this, ((int32_t)il2cpp_codegen_subtract(L_39, 1)), NULL);
		NullCheck(L_40);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = L_40->___position_0;
		float L_42;
		L_42 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_38, L_41, NULL);
		V_3 = ((float)il2cpp_codegen_add(L_36, L_42));
	}

IL_012c:
	{
		// switch (_axis)
		int32_t L_43 = __this->____axis_60;
		V_5 = L_43;
		int32_t L_44 = V_5;
		switch (L_44)
		{
			case 0:
			{
				goto IL_014c;
			}
			case 1:
			{
				goto IL_0193;
			}
			case 2:
			{
				goto IL_01d7;
			}
		}
	}
	{
		goto IL_0219;
	}

IL_014c:
	{
		// case Axis.X: bottomPosition.x = _symmetry ? -localSamplePosition.x : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.x); avgTop += localSamplePosition.x; break;
		bool L_45 = __this->____symmetry_61;
		G_B13_0 = (&V_10);
		if (L_45)
		{
			G_B14_0 = (&V_10);
			goto IL_015d;
		}
	}
	{
		G_B15_0 = (0.0f);
		G_B15_1 = G_B13_0;
		goto IL_0165;
	}

IL_015d:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46 = V_9;
		float L_47 = L_46.___x_2;
		G_B15_0 = ((-L_47));
		G_B15_1 = G_B14_0;
	}

IL_0165:
	{
		G_B15_1->___x_2 = G_B15_0;
		// case Axis.X: bottomPosition.x = _symmetry ? -localSamplePosition.x : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.x); avgTop += localSamplePosition.x; break;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_48;
		L_48 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_49 = L_48.___y_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50 = V_9;
		float L_51 = L_50.___x_2;
		float L_52;
		L_52 = fabsf(L_51);
		V_13 = ((float)il2cpp_codegen_multiply(L_49, L_52));
		// case Axis.X: bottomPosition.x = _symmetry ? -localSamplePosition.x : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.x); avgTop += localSamplePosition.x; break;
		float L_53 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54 = V_9;
		float L_55 = L_54.___x_2;
		V_2 = ((float)il2cpp_codegen_add(L_53, L_55));
		// case Axis.X: bottomPosition.x = _symmetry ? -localSamplePosition.x : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.x); avgTop += localSamplePosition.x; break;
		goto IL_0219;
	}

IL_0193:
	{
		// case Axis.Y: bottomPosition.y = _symmetry ? -localSamplePosition.y : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.y); avgTop += localSamplePosition.y; break;
		bool L_56 = __this->____symmetry_61;
		G_B17_0 = (&V_10);
		if (L_56)
		{
			G_B18_0 = (&V_10);
			goto IL_01a4;
		}
	}
	{
		G_B19_0 = (0.0f);
		G_B19_1 = G_B17_0;
		goto IL_01ac;
	}

IL_01a4:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57 = V_9;
		float L_58 = L_57.___y_3;
		G_B19_0 = ((-L_58));
		G_B19_1 = G_B18_0;
	}

IL_01ac:
	{
		G_B19_1->___y_3 = G_B19_0;
		// case Axis.Y: bottomPosition.y = _symmetry ? -localSamplePosition.y : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.y); avgTop += localSamplePosition.y; break;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_59;
		L_59 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_60 = L_59.___y_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_61 = V_9;
		float L_62 = L_61.___y_3;
		float L_63;
		L_63 = fabsf(L_62);
		V_13 = ((float)il2cpp_codegen_multiply(L_60, L_63));
		// case Axis.Y: bottomPosition.y = _symmetry ? -localSamplePosition.y : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.y); avgTop += localSamplePosition.y; break;
		float L_64 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65 = V_9;
		float L_66 = L_65.___y_3;
		V_2 = ((float)il2cpp_codegen_add(L_64, L_66));
		// case Axis.Y: bottomPosition.y = _symmetry ? -localSamplePosition.y : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.y); avgTop += localSamplePosition.y; break;
		goto IL_0219;
	}

IL_01d7:
	{
		// case Axis.Z: bottomPosition.z = _symmetry ? -localSamplePosition.z : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.z); avgTop += localSamplePosition.z; break;
		bool L_67 = __this->____symmetry_61;
		G_B21_0 = (&V_10);
		if (L_67)
		{
			G_B22_0 = (&V_10);
			goto IL_01e8;
		}
	}
	{
		G_B23_0 = (0.0f);
		G_B23_1 = G_B21_0;
		goto IL_01f0;
	}

IL_01e8:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68 = V_9;
		float L_69 = L_68.___z_4;
		G_B23_0 = ((-L_69));
		G_B23_1 = G_B22_0;
	}

IL_01f0:
	{
		G_B23_1->___z_4 = G_B23_0;
		// case Axis.Z: bottomPosition.z = _symmetry ? -localSamplePosition.z : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.z); avgTop += localSamplePosition.z; break;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_70;
		L_70 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_71 = L_70.___y_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_72 = V_9;
		float L_73 = L_72.___z_4;
		float L_74;
		L_74 = fabsf(L_73);
		V_13 = ((float)il2cpp_codegen_multiply(L_71, L_74));
		// case Axis.Z: bottomPosition.z = _symmetry ? -localSamplePosition.z : 0f;  heightPercent = uvScale.y * Mathf.Abs(localSamplePosition.z); avgTop += localSamplePosition.z; break;
		float L_75 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_76 = V_9;
		float L_77 = L_76.___z_4;
		V_2 = ((float)il2cpp_codegen_add(L_75, L_77));
	}

IL_0219:
	{
		// bottomPosition = spline.TransformPoint(bottomPosition);
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_78;
		L_78 = SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_79 = V_10;
		NullCheck(L_78);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_80;
		L_80 = SplineComputer_TransformPoint_mDD08FFAEF020CCCA355C9E83DD0D741DF5A5EFCB(L_78, L_79, NULL);
		V_10 = L_80;
		// Vector3 right = Vector3.Cross(normal, sampleDirection).normalized;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82 = V_11;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_83;
		L_83 = Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline(L_81, L_82, NULL);
		V_16 = L_83;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_84;
		L_84 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_16), NULL);
		V_14 = L_84;
		// Vector3 offsetRight = Vector3.Cross(sampleNormal, sampleDirection);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_85 = V_12;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_86 = V_11;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_87;
		L_87 = Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline(L_85, L_86, NULL);
		V_15 = L_87;
		// for (int n = 0; n < _slices + 1; n++)
		V_17 = 0;
		goto IL_0461;
	}

IL_024f:
	{
		// float slicePercent = ((float)n / _slices);
		int32_t L_88 = V_17;
		int32_t L_89 = __this->____slices_63;
		V_18 = ((float)(((float)L_88)/((float)L_89)));
		// tsMesh.vertices[vertIndex] = Vector3.Lerp(bottomPosition, samplePosition, slicePercent) + normal * (offset.y * resultSize) + offsetRight * (offset.x * resultSize);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_90 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_90);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_91 = L_90->___vertices_0;
		int32_t L_92 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_93 = V_10;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_94 = V_8;
		float L_95 = V_18;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_96;
		L_96 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_93, L_94, L_95, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_97 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_98;
		L_98 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_99 = L_98.___y_3;
		float L_100 = V_7;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_101;
		L_101 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_97, ((float)il2cpp_codegen_multiply(L_99, L_100)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_102;
		L_102 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_96, L_101, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_103 = V_15;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_104;
		L_104 = MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline(__this, NULL);
		float L_105 = L_104.___x_2;
		float L_106 = V_7;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_107;
		L_107 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_103, ((float)il2cpp_codegen_multiply(L_105, L_106)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_108;
		L_108 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_102, L_107, NULL);
		NullCheck(L_91);
		(L_91)->SetAt(static_cast<il2cpp_array_size_t>(L_92), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_108);
		// tsMesh.normals[vertIndex] = right;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_109 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_109);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_110 = L_109->___normals_1;
		int32_t L_111 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_112 = V_14;
		NullCheck(L_110);
		(L_110)->SetAt(static_cast<il2cpp_array_size_t>(L_111), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_112);
		// switch (_uvWrapMode)
		int32_t L_113 = __this->____uvWrapMode_62;
		V_19 = L_113;
		int32_t L_114 = V_19;
		switch (L_114)
		{
			case 0:
			{
				goto IL_02e3;
			}
			case 1:
			{
				goto IL_033c;
			}
			case 2:
			{
				goto IL_038a;
			}
			case 3:
			{
				goto IL_03e3;
			}
		}
	}
	{
		goto IL_042f;
	}

IL_02e3:
	{
		// case UVWrapMode.Clamp: tsMesh.uv[vertIndex] = new Vector2((float)evalResult.percent * uvScale.x + uvOffset.x, slicePercent * uvScale.y + uvOffset.y); break;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_115 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_115);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_116 = L_115->___uv_4;
		int32_t L_117 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_118 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_118);
		double L_119 = L_118->___percent_5;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_120;
		L_120 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_121 = L_120.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_122;
		L_122 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_123 = L_122.___x_0;
		float L_124 = V_18;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_125;
		L_125 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_126 = L_125.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_127;
		L_127 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_128 = L_127.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_129;
		memset((&L_129), 0, sizeof(L_129));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_129), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)L_119), L_121)), L_123)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_124, L_126)), L_128)), /*hidden argument*/NULL);
		NullCheck(L_116);
		(L_116)->SetAt(static_cast<il2cpp_array_size_t>(L_117), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_129);
		// case UVWrapMode.Clamp: tsMesh.uv[vertIndex] = new Vector2((float)evalResult.percent * uvScale.x + uvOffset.x, slicePercent * uvScale.y + uvOffset.y); break;
		goto IL_042f;
	}

IL_033c:
	{
		// case UVWrapMode.UniformX: tsMesh.uv[vertIndex] = new Vector2(totalLength * uvScale.x + uvOffset.x, slicePercent * uvScale.y + uvOffset.y); break;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_130 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_130);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_131 = L_130->___uv_4;
		int32_t L_132 = V_1;
		float L_133 = V_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_134;
		L_134 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_135 = L_134.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_136;
		L_136 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_137 = L_136.___x_0;
		float L_138 = V_18;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_139;
		L_139 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_140 = L_139.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_141;
		L_141 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_142 = L_141.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_143;
		memset((&L_143), 0, sizeof(L_143));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_143), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_133, L_135)), L_137)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_138, L_140)), L_142)), /*hidden argument*/NULL);
		NullCheck(L_131);
		(L_131)->SetAt(static_cast<il2cpp_array_size_t>(L_132), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_143);
		// case UVWrapMode.UniformX: tsMesh.uv[vertIndex] = new Vector2(totalLength * uvScale.x + uvOffset.x, slicePercent * uvScale.y + uvOffset.y); break;
		goto IL_042f;
	}

IL_038a:
	{
		// case UVWrapMode.UniformY: tsMesh.uv[vertIndex] = new Vector2((float)evalResult.percent * uvScale.x + uvOffset.x, heightPercent * slicePercent * uvScale.y + uvOffset.y); break;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_144 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_144);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_145 = L_144->___uv_4;
		int32_t L_146 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_147 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		NullCheck(L_147);
		double L_148 = L_147->___percent_5;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_149;
		L_149 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_150 = L_149.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_151;
		L_151 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_152 = L_151.___x_0;
		float L_153 = V_13;
		float L_154 = V_18;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_155;
		L_155 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_156 = L_155.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_157;
		L_157 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_158 = L_157.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_159;
		memset((&L_159), 0, sizeof(L_159));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_159), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)L_148), L_150)), L_152)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_153, L_154)), L_156)), L_158)), /*hidden argument*/NULL);
		NullCheck(L_145);
		(L_145)->SetAt(static_cast<il2cpp_array_size_t>(L_146), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_159);
		// case UVWrapMode.UniformY: tsMesh.uv[vertIndex] = new Vector2((float)evalResult.percent * uvScale.x + uvOffset.x, heightPercent * slicePercent * uvScale.y + uvOffset.y); break;
		goto IL_042f;
	}

IL_03e3:
	{
		// case UVWrapMode.Uniform: tsMesh.uv[vertIndex] = new Vector2(totalLength * uvScale.x + uvOffset.x, heightPercent * slicePercent * uvScale.y + uvOffset.y); break;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_160 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_160);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_161 = L_160->___uv_4;
		int32_t L_162 = V_1;
		float L_163 = V_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_164;
		L_164 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_165 = L_164.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_166;
		L_166 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_167 = L_166.___x_0;
		float L_168 = V_13;
		float L_169 = V_18;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_170;
		L_170 = MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline(__this, NULL);
		float L_171 = L_170.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_172;
		L_172 = MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline(__this, NULL);
		float L_173 = L_172.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_174;
		memset((&L_174), 0, sizeof(L_174));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_174), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_163, L_165)), L_167)), ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_168, L_169)), L_171)), L_173)), /*hidden argument*/NULL);
		NullCheck(L_161);
		(L_161)->SetAt(static_cast<il2cpp_array_size_t>(L_162), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_174);
	}

IL_042f:
	{
		// tsMesh.colors[vertIndex] = GetBaseColor(evalResult) * color;
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_175 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_175);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_176 = L_175->___colors_3;
		int32_t L_177 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_178 = ((SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA*)__this)->___evalResult_26;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_179;
		L_179 = MeshGenerator_GetBaseColor_m0668E5049FD711975D9B6E34E4E0CA81028AFDD8(__this, L_178, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_180;
		L_180 = MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline(__this, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_181;
		L_181 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_179, L_180, NULL);
		NullCheck(L_176);
		(L_176)->SetAt(static_cast<il2cpp_array_size_t>(L_177), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_181);
		// vertIndex++;
		int32_t L_182 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_182, 1));
		// for (int n = 0; n < _slices + 1; n++)
		int32_t L_183 = V_17;
		V_17 = ((int32_t)il2cpp_codegen_add(L_183, 1));
	}

IL_0461:
	{
		// for (int n = 0; n < _slices + 1; n++)
		int32_t L_184 = V_17;
		int32_t L_185 = __this->____slices_63;
		if ((((int32_t)L_184) < ((int32_t)((int32_t)il2cpp_codegen_add(L_185, 1)))))
		{
			goto IL_024f;
		}
	}
	{
		// for (int i = 0; i < sampleCount; i++)
		int32_t L_186 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_186, 1));
	}

IL_0476:
	{
		// for (int i = 0; i < sampleCount; i++)
		int32_t L_187 = V_6;
		int32_t L_188;
		L_188 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		if ((((int32_t)L_187) < ((int32_t)L_188)))
		{
			goto IL_0096;
		}
	}
	{
		// if (sampleCount > 0) avgTop /= sampleCount;
		int32_t L_189;
		L_189 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		if ((((int32_t)L_189) <= ((int32_t)0)))
		{
			goto IL_0496;
		}
	}
	{
		// if (sampleCount > 0) avgTop /= sampleCount;
		float L_190 = V_2;
		int32_t L_191;
		L_191 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		V_2 = ((float)(L_190/((float)L_191)));
	}

IL_0496:
	{
		// MeshUtility.GeneratePlaneTriangles(ref tsMesh.triangles, _slices, sampleCount, avgTop < 0f);
		TS_Mesh_t337CC78F0025B128F116EAD38EBE814A54EBC21F* L_192 = ((MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E*)__this)->___tsMesh_53;
		NullCheck(L_192);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_193 = (&L_192->___triangles_8);
		int32_t L_194 = __this->____slices_63;
		int32_t L_195;
		L_195 = SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline(__this, NULL);
		float L_196 = V_2;
		il2cpp_codegen_runtime_class_init_inline(MeshUtility_tAF3F93312AB9831BB493403B310235ECDAA063F0_il2cpp_TypeInfo_var);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_197;
		L_197 = MeshUtility_GeneratePlaneTriangles_m7627A2B6F10209B80C86839A8E52EC35DC8DE957(L_193, L_194, L_195, (bool)((((float)L_196) < ((float)(0.0f)))? 1 : 0), 0, 0, (bool)0, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.WaveformGenerator::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaveformGenerator__ctor_mAE1BD4625AC4D25C45742CA546D4E1133EBA3CF3 (WaveformGenerator_t8D8D85A80404F3E2C2259700E867BDEB27203DD3* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private Axis _axis = Axis.Y;
		__this->____axis_60 = 1;
		// private int _slices = 1;
		__this->____slices_63 = 1;
		il2cpp_codegen_runtime_class_init_inline(MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E_il2cpp_TypeInfo_var);
		MeshGenerator__ctor_mC01695CDAB2865B65DC8307E3B9841B0B1B81182(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 Dreamteck.Splines.SampleCollection::get_Count()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, const RuntimeMethod* method) 
{
	{
		// get { return samples.Length; }
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_0 = __this->___samples_0;
		NullCheck(L_0);
		return ((int32_t)(((RuntimeArray*)L_0)->max_length));
	}
}
// System.Boolean Dreamteck.Splines.SampleCollection::get_hasSamples()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, const RuntimeMethod* method) 
{
	{
		// get { return Count > 0; }
		int32_t L_0;
		L_0 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		return (bool)((((int32_t)L_0) > ((int32_t)0))? 1 : 0);
	}
}
// System.Void Dreamteck.Splines.SampleCollection::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection__ctor_mDA23E7BBA7CA06C6E09C6C804421EA2892FBFA2D (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public SplineSample[] samples = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_0 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___samples_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___samples_0), (void*)L_0);
		// public int[] optimizedIndices = new int[0];
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___optimizedIndices_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___optimizedIndices_1), (void*)L_1);
		// private SplineSample _workSample = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_2, NULL);
		__this->____workSample_3 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____workSample_3), (void*)L_2);
		// public double clipFrom = 0.0, clipTo = 1.0;
		__this->___clipTo_5 = (1.0);
		// public SampleCollection()
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SampleCollection::.ctor(Dreamteck.Splines.SampleCollection)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection__ctor_m5057BAD91445FF21B3D7B014749A3717E09E9BBC (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* ___0_input, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public SplineSample[] samples = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_0 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___samples_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___samples_0), (void*)L_0);
		// public int[] optimizedIndices = new int[0];
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___optimizedIndices_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___optimizedIndices_1), (void*)L_1);
		// private SplineSample _workSample = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_2, NULL);
		__this->____workSample_3 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____workSample_3), (void*)L_2);
		// public double clipFrom = 0.0, clipTo = 1.0;
		__this->___clipTo_5 = (1.0);
		// public SampleCollection(SampleCollection input)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// samples = input.samples;
		SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* L_3 = ___0_input;
		NullCheck(L_3);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_4 = L_3->___samples_0;
		__this->___samples_0 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___samples_0), (void*)L_4);
		// optimizedIndices = input.optimizedIndices;
		SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* L_5 = ___0_input;
		NullCheck(L_5);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = L_5->___optimizedIndices_1;
		__this->___optimizedIndices_1 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___optimizedIndices_1), (void*)L_6);
		// sampleMode = input.sampleMode;
		SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* L_7 = ___0_input;
		NullCheck(L_7);
		int32_t L_8 = L_7->___sampleMode_2;
		__this->___sampleMode_2 = L_8;
		// }
		return;
	}
}
// System.Int32 Dreamteck.Splines.SampleCollection::GetClippedSampleCount(System.Double,System.Double,System.Int32&,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SampleCollection_GetClippedSampleCount_m1C8780E6EA73A4CC6BB1882D147622ED16D7D6A4 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_clipFrom, double ___1_clipTo, int32_t* ___2_startIndex, int32_t* ___3_endIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	double V_1 = 0.0;
	double V_2 = 0.0;
	int32_t V_3 = 0;
	{
		// startIndex = endIndex = 0;
		int32_t* L_0 = ___2_startIndex;
		int32_t* L_1 = ___3_endIndex;
		int32_t L_2 = 0;
		V_0 = L_2;
		*((int32_t*)L_1) = (int32_t)L_2;
		int32_t L_3 = V_0;
		*((int32_t*)L_0) = (int32_t)L_3;
		// if (sampleMode == SplineComputer.SampleMode.Default)
		int32_t L_4 = __this->___sampleMode_2;
		if (L_4)
		{
			goto IL_0038;
		}
	}
	{
		// startIndex = DMath.FloorInt((Count - 1) * clipFrom);
		int32_t* L_5 = ___2_startIndex;
		int32_t L_6;
		L_6 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		double L_7 = ___0_clipFrom;
		int32_t L_8;
		L_8 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(L_6, 1))), L_7)), NULL);
		*((int32_t*)L_5) = (int32_t)L_8;
		// endIndex = DMath.CeilInt((Count - 1) * clipTo);
		int32_t* L_9 = ___3_endIndex;
		int32_t L_10;
		L_10 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		double L_11 = ___1_clipTo;
		int32_t L_12;
		L_12 = DMath_CeilInt_m92CA33A9E6B959B6A1EF0CE1BF001C27983C34F8(((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(L_10, 1))), L_11)), NULL);
		*((int32_t*)L_9) = (int32_t)L_12;
		goto IL_0082;
	}

IL_0038:
	{
		// double clipFromLerp = 0.0, clipToLerp = 0.0;
		V_1 = (0.0);
		// double clipFromLerp = 0.0, clipToLerp = 0.0;
		V_2 = (0.0);
		// GetSamplingValues(clipFrom, out startIndex, out clipFromLerp);
		double L_13 = ___0_clipFrom;
		int32_t* L_14 = ___2_startIndex;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_13, L_14, (&V_1), NULL);
		// GetSamplingValues(clipTo, out endIndex, out clipToLerp);
		double L_15 = ___1_clipTo;
		int32_t* L_16 = ___3_endIndex;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_15, L_16, (&V_2), NULL);
		// if (clipToLerp > 0.0 && endIndex < Count - 1) endIndex++;
		double L_17 = V_2;
		if ((!(((double)L_17) > ((double)(0.0)))))
		{
			goto IL_0082;
		}
	}
	{
		int32_t* L_18 = ___3_endIndex;
		int32_t L_19 = *((int32_t*)L_18);
		int32_t L_20;
		L_20 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_19) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_20, 1)))))
		{
			goto IL_0082;
		}
	}
	{
		// if (clipToLerp > 0.0 && endIndex < Count - 1) endIndex++;
		int32_t* L_21 = ___3_endIndex;
		int32_t* L_22 = ___3_endIndex;
		int32_t L_23 = *((int32_t*)L_22);
		*((int32_t*)L_21) = (int32_t)((int32_t)il2cpp_codegen_add(L_23, 1));
	}

IL_0082:
	{
		// if (clipTo < clipFrom) //Handle looping segments
		double L_24 = ___1_clipTo;
		double L_25 = ___0_clipFrom;
		if ((!(((double)L_24) < ((double)L_25))))
		{
			goto IL_0098;
		}
	}
	{
		// int toSamples = endIndex + 1;
		int32_t* L_26 = ___3_endIndex;
		int32_t L_27 = *((int32_t*)L_26);
		// int fromSamples = Count - startIndex;
		int32_t L_28;
		L_28 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		int32_t* L_29 = ___2_startIndex;
		int32_t L_30 = *((int32_t*)L_29);
		V_3 = ((int32_t)il2cpp_codegen_subtract(L_28, L_30));
		// return toSamples + fromSamples;
		int32_t L_31 = V_3;
		return ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_27, 1)), L_31));
	}

IL_0098:
	{
		// return endIndex - startIndex + 1;
		int32_t* L_32 = ___3_endIndex;
		int32_t L_33 = *((int32_t*)L_32);
		int32_t* L_34 = ___2_startIndex;
		int32_t L_35 = *((int32_t*)L_34);
		return ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_33, L_35)), 1));
	}
}
// System.Void Dreamteck.Splines.SampleCollection::GetSamplingValues(System.Double,System.Int32&,System.Double&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, int32_t* ___1_sampleIndex, double* ___2_lerp, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	int32_t V_1 = 0;
	double V_2 = 0.0;
	double V_3 = 0.0;
	double V_4 = 0.0;
	{
		// lerp = 0.0;
		double* L_0 = ___2_lerp;
		*((double*)L_0) = (double)(0.0);
		// if (sampleMode == SplineComputer.SampleMode.Optimized)
		int32_t L_1 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_1) == ((uint32_t)2))))
		{
			goto IL_00ae;
		}
	}
	{
		// double indexValue = percent * (optimizedIndices.Length - 1);
		double L_2 = ___0_percent;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = __this->___optimizedIndices_1;
		NullCheck(L_3);
		V_0 = ((double)il2cpp_codegen_multiply(L_2, ((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_3)->max_length)), 1)))));
		// int index = DMath.FloorInt(indexValue);
		double L_4 = V_0;
		int32_t L_5;
		L_5 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_4, NULL);
		V_1 = L_5;
		// sampleIndex = optimizedIndices[index];
		int32_t* L_6 = ___1_sampleIndex;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_7 = __this->___optimizedIndices_1;
		int32_t L_8 = V_1;
		NullCheck(L_7);
		int32_t L_9 = L_8;
		int32_t L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		*((int32_t*)L_6) = (int32_t)L_10;
		// double lerpPercent = 0.0;
		V_2 = (0.0);
		// if (index < optimizedIndices.Length - 1)
		int32_t L_11 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_12 = __this->___optimizedIndices_1;
		NullCheck(L_12);
		if ((((int32_t)L_11) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_12)->max_length)), 1)))))
		{
			goto IL_007b;
		}
	}
	{
		// double indexLerp = indexValue - index;
		double L_13 = V_0;
		int32_t L_14 = V_1;
		V_3 = ((double)il2cpp_codegen_subtract(L_13, ((double)L_14)));
		// double sampleIndexPercent = (double)index / (optimizedIndices.Length - 1);
		int32_t L_15 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_16 = __this->___optimizedIndices_1;
		NullCheck(L_16);
		// double nextSampleIndexPercent = (double)(index + 1) / (optimizedIndices.Length - 1);
		int32_t L_17 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_18 = __this->___optimizedIndices_1;
		NullCheck(L_18);
		V_4 = ((double)(((double)((int32_t)il2cpp_codegen_add(L_17, 1)))/((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_18)->max_length)), 1)))));
		// lerpPercent = DMath.Lerp(sampleIndexPercent, nextSampleIndexPercent, indexLerp);
		double L_19 = V_4;
		double L_20 = V_3;
		double L_21;
		L_21 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(((double)(((double)L_15)/((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_16)->max_length)), 1))))), L_19, L_20, NULL);
		V_2 = L_21;
	}

IL_007b:
	{
		// if (sampleIndex < Count - 1) lerp = DMath.InverseLerp(samples[sampleIndex].percent, samples[sampleIndex + 1].percent, lerpPercent);
		int32_t* L_22 = ___1_sampleIndex;
		int32_t L_23 = *((int32_t*)L_22);
		int32_t L_24;
		L_24 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_23) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_24, 1)))))
		{
			goto IL_00ad;
		}
	}
	{
		// if (sampleIndex < Count - 1) lerp = DMath.InverseLerp(samples[sampleIndex].percent, samples[sampleIndex + 1].percent, lerpPercent);
		double* L_25 = ___2_lerp;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_26 = __this->___samples_0;
		int32_t* L_27 = ___1_sampleIndex;
		int32_t L_28 = *((int32_t*)L_27);
		NullCheck(L_26);
		int32_t L_29 = L_28;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_30 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_29));
		NullCheck(L_30);
		double L_31 = L_30->___percent_5;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_32 = __this->___samples_0;
		int32_t* L_33 = ___1_sampleIndex;
		int32_t L_34 = *((int32_t*)L_33);
		NullCheck(L_32);
		int32_t L_35 = ((int32_t)il2cpp_codegen_add(L_34, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_36 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_35));
		NullCheck(L_36);
		double L_37 = L_36->___percent_5;
		double L_38 = V_2;
		double L_39;
		L_39 = DMath_InverseLerp_mA44B700EA1DD0378E63AA498B5D91C76B8DBD60A(L_31, L_37, L_38, NULL);
		*((double*)L_25) = (double)L_39;
	}

IL_00ad:
	{
		// return;
		return;
	}

IL_00ae:
	{
		// sampleIndex = DMath.FloorInt(percent * (Count - 1));
		int32_t* L_40 = ___1_sampleIndex;
		double L_41 = ___0_percent;
		int32_t L_42;
		L_42 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		int32_t L_43;
		L_43 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(((double)il2cpp_codegen_multiply(L_41, ((double)((int32_t)il2cpp_codegen_subtract(L_42, 1))))), NULL);
		*((int32_t*)L_40) = (int32_t)L_43;
		// lerp = (Count - 1) * percent - sampleIndex;
		double* L_44 = ___2_lerp;
		int32_t L_45;
		L_45 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		double L_46 = ___0_percent;
		int32_t* L_47 = ___1_sampleIndex;
		int32_t L_48 = *((int32_t*)L_47);
		*((double*)L_44) = (double)((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(L_45, 1))), L_46)), ((double)L_48)));
		// }
		return;
	}
}
// UnityEngine.Vector3 Dreamteck.Splines.SampleCollection::EvaluatePosition(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	double V_1 = 0.0;
	{
		// if (!hasSamples) return Vector3.zero;
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if (!hasSamples) return Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		return L_1;
	}

IL_000e:
	{
		// GetSamplingValues(percent, out index, out lerp);
		double L_2 = ___0_percent;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_2, (&V_0), (&V_1), NULL);
		// if (lerp > 0.0) return Vector3.Lerp(samples[index].position, samples[index + 1].position, (float)lerp);
		double L_3 = V_1;
		if ((!(((double)L_3) > ((double)(0.0)))))
		{
			goto IL_0049;
		}
	}
	{
		// if (lerp > 0.0) return Vector3.Lerp(samples[index].position, samples[index + 1].position, (float)lerp);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_4 = __this->___samples_0;
		int32_t L_5 = V_0;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		NullCheck(L_7);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = L_7->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_9 = __this->___samples_0;
		int32_t L_10 = V_0;
		NullCheck(L_9);
		int32_t L_11 = ((int32_t)il2cpp_codegen_add(L_10, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		NullCheck(L_12);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = L_12->___position_0;
		double L_14 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15;
		L_15 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_8, L_13, ((float)L_14), NULL);
		return L_15;
	}

IL_0049:
	{
		// else return samples[index].position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_16 = __this->___samples_0;
		int32_t L_17 = V_0;
		NullCheck(L_16);
		int32_t L_18 = L_17;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_19 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		NullCheck(L_19);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = L_19->___position_0;
		return L_20;
	}
}
// Dreamteck.Splines.SplineSample Dreamteck.Splines.SampleCollection::Evaluate(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* SampleCollection_Evaluate_mD98A6D806C880D45EF1713A095E70B921B730051 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* V_0 = NULL;
	{
		// SplineSample result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_0, NULL);
		V_0 = L_0;
		// Evaluate(percent, result);
		double L_1 = ___0_percent;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = V_0;
		SampleCollection_Evaluate_mE67F0879D5C0755347AA1C1D7D2D08B22B3044A1(__this, L_1, L_2, NULL);
		// return result;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_3 = V_0;
		return L_3;
	}
}
// System.Void Dreamteck.Splines.SampleCollection::Evaluate(System.Double,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_Evaluate_mE67F0879D5C0755347AA1C1D7D2D08B22B3044A1 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_percent, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_result, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	double V_1 = 0.0;
	{
		// if (!hasSamples)
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_0010;
		}
	}
	{
		// result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_1, NULL);
		___1_result = L_1;
		// return;
		return;
	}

IL_0010:
	{
		// GetSamplingValues(percent, out index, out lerp);
		double L_2 = ___0_percent;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_2, (&V_0), (&V_1), NULL);
		// if (lerp > 0.0) SplineSample.Lerp(samples[index], samples[index + 1], lerp, result);
		double L_3 = V_1;
		if ((!(((double)L_3) > ((double)(0.0)))))
		{
			goto IL_0041;
		}
	}
	{
		// if (lerp > 0.0) SplineSample.Lerp(samples[index], samples[index + 1], lerp, result);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_4 = __this->___samples_0;
		int32_t L_5 = V_0;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_8 = __this->___samples_0;
		int32_t L_9 = V_0;
		NullCheck(L_8);
		int32_t L_10 = ((int32_t)il2cpp_codegen_add(L_9, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		double L_12 = V_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_13 = ___1_result;
		SplineSample_Lerp_mB500F377220064E5FD7A760E312BAA168A6A7820(L_7, L_11, L_12, L_13, NULL);
		return;
	}

IL_0041:
	{
		// else result.CopyFrom(samples[index]);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_14 = ___1_result;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_15 = __this->___samples_0;
		int32_t L_16 = V_0;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		NullCheck(L_14);
		SplineSample_CopyFrom_mB1BB345F571264DD4BA0290C34F20C13615F58FE(L_14, L_18, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SampleCollection::Evaluate(Dreamteck.Splines.SplineSample[]&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_Evaluate_mE6E354EAE550C8A6BE66373EDF6956DAC8C60EF9 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** ___0_results, double ___1_from, double ___2_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	double V_2 = 0.0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		// if (!hasSamples)
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		// results = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_1 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_2 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_1) = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_1, (void*)(RuntimeObject*)L_2);
		// return;
		return;
	}

IL_0011:
	{
		// Spline.FormatFromTo(ref from, ref to);
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764((&___1_from), (&___2_to), (bool)1, NULL);
		// GetSamplingValues(from, out fromIndex, out lerp);
		double L_3 = ___1_from;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_3, (&V_0), (&V_2), NULL);
		// GetSamplingValues(to, out toIndex, out lerp);
		double L_4 = ___2_to;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_4, (&V_1), (&V_2), NULL);
		// if (lerp > 0.0 && toIndex < Count - 1) toIndex++;
		double L_5 = V_2;
		if ((!(((double)L_5) > ((double)(0.0)))))
		{
			goto IL_004c;
		}
	}
	{
		int32_t L_6 = V_1;
		int32_t L_7;
		L_7 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_6) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_7, 1)))))
		{
			goto IL_004c;
		}
	}
	{
		// if (lerp > 0.0 && toIndex < Count - 1) toIndex++;
		int32_t L_8 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_004c:
	{
		// int clippedIterations = toIndex - fromIndex + 1;
		int32_t L_9 = V_1;
		int32_t L_10 = V_0;
		V_3 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_9, L_10)), 1));
		// if (results == null) results = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_11 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_12 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_11);
		if (L_12)
		{
			goto IL_0060;
		}
	}
	{
		// if (results == null) results = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_13 = ___0_results;
		int32_t L_14 = V_3;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_15 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)L_14);
		*((RuntimeObject**)L_13) = (RuntimeObject*)L_15;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_13, (void*)(RuntimeObject*)L_15);
		goto IL_006f;
	}

IL_0060:
	{
		// else if (results.Length != clippedIterations) results = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_16 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_17 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_16);
		NullCheck(L_17);
		int32_t L_18 = V_3;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_17)->max_length))) == ((int32_t)L_18)))
		{
			goto IL_006f;
		}
	}
	{
		// else if (results.Length != clippedIterations) results = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_19 = ___0_results;
		int32_t L_20 = V_3;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_21 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)L_20);
		*((RuntimeObject**)L_19) = (RuntimeObject*)L_21;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_19, (void*)(RuntimeObject*)L_21);
	}

IL_006f:
	{
		// results[0] = Evaluate(from);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_22 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_23 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_22);
		double L_24 = ___1_from;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_25;
		L_25 = SampleCollection_Evaluate_mD98A6D806C880D45EF1713A095E70B921B730051(__this, L_24, NULL);
		NullCheck(L_23);
		ArrayElementTypeCheck (L_23, L_25);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(0), (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)L_25);
		// results[results.Length - 1] = Evaluate(to);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_26 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_27 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_26);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_28 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_29 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_28);
		NullCheck(L_29);
		double L_30 = ___2_to;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_31;
		L_31 = SampleCollection_Evaluate_mD98A6D806C880D45EF1713A095E70B921B730051(__this, L_30, NULL);
		NullCheck(L_27);
		ArrayElementTypeCheck (L_27, L_31);
		(L_27)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_29)->max_length)), 1))), (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)L_31);
		// for (int i = 1; i < results.Length - 1; i++) results[i] = samples[i + fromIndex];
		V_4 = 1;
		goto IL_00a5;
	}

IL_008f:
	{
		// for (int i = 1; i < results.Length - 1; i++) results[i] = samples[i + fromIndex];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_32 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_33 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_32);
		int32_t L_34 = V_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_35 = __this->___samples_0;
		int32_t L_36 = V_4;
		int32_t L_37 = V_0;
		NullCheck(L_35);
		int32_t L_38 = ((int32_t)il2cpp_codegen_add(L_36, L_37));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_39 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_38));
		NullCheck(L_33);
		ArrayElementTypeCheck (L_33, L_39);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(L_34), (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)L_39);
		// for (int i = 1; i < results.Length - 1; i++) results[i] = samples[i + fromIndex];
		int32_t L_40 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_40, 1));
	}

IL_00a5:
	{
		// for (int i = 1; i < results.Length - 1; i++) results[i] = samples[i + fromIndex];
		int32_t L_41 = V_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_42 = ___0_results;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_43 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_42);
		NullCheck(L_43);
		if ((((int32_t)L_41) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_43)->max_length)), 1)))))
		{
			goto IL_008f;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SampleCollection::EvaluatePositions(UnityEngine.Vector3[]&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_EvaluatePositions_mB0948EF013D5F45BC88431E6C182E8DB1A4F873C (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___0_positions, double ___1_from, double ___2_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	double V_2 = 0.0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		// if (!hasSamples)
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		// positions = new Vector3[0];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_1 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_2 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_1) = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_1, (void*)(RuntimeObject*)L_2);
		// return;
		return;
	}

IL_0011:
	{
		// Spline.FormatFromTo(ref from, ref to);
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764((&___1_from), (&___2_to), (bool)1, NULL);
		// GetSamplingValues(from, out fromIndex, out lerp);
		double L_3 = ___1_from;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_3, (&V_0), (&V_2), NULL);
		// GetSamplingValues(to, out toIndex, out lerp);
		double L_4 = ___2_to;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_4, (&V_1), (&V_2), NULL);
		// if (lerp > 0.0 && toIndex < Count - 1) toIndex++;
		double L_5 = V_2;
		if ((!(((double)L_5) > ((double)(0.0)))))
		{
			goto IL_004c;
		}
	}
	{
		int32_t L_6 = V_1;
		int32_t L_7;
		L_7 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_6) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_7, 1)))))
		{
			goto IL_004c;
		}
	}
	{
		// if (lerp > 0.0 && toIndex < Count - 1) toIndex++;
		int32_t L_8 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_004c:
	{
		// int clippedIterations = toIndex - fromIndex + 1;
		int32_t L_9 = V_1;
		int32_t L_10 = V_0;
		V_3 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_9, L_10)), 1));
		// if (positions == null) positions = new Vector3[clippedIterations];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_11 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_12 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_11);
		if (L_12)
		{
			goto IL_0060;
		}
	}
	{
		// if (positions == null) positions = new Vector3[clippedIterations];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_13 = ___0_positions;
		int32_t L_14 = V_3;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_15 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_14);
		*((RuntimeObject**)L_13) = (RuntimeObject*)L_15;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_13, (void*)(RuntimeObject*)L_15);
		goto IL_006f;
	}

IL_0060:
	{
		// else if (positions.Length != clippedIterations) positions = new Vector3[clippedIterations];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_16 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_17 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_16);
		NullCheck(L_17);
		int32_t L_18 = V_3;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_17)->max_length))) == ((int32_t)L_18)))
		{
			goto IL_006f;
		}
	}
	{
		// else if (positions.Length != clippedIterations) positions = new Vector3[clippedIterations];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_19 = ___0_positions;
		int32_t L_20 = V_3;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_21 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_20);
		*((RuntimeObject**)L_19) = (RuntimeObject*)L_21;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_19, (void*)(RuntimeObject*)L_21);
	}

IL_006f:
	{
		// positions[0] = EvaluatePosition(from);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_22 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_23 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_22);
		double L_24 = ___1_from;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C(__this, L_24, NULL);
		NullCheck(L_23);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(0), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_25);
		// positions[positions.Length - 1] = EvaluatePosition(to);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_26 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_27 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_26);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_28 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_28);
		NullCheck(L_29);
		double L_30 = ___2_to;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C(__this, L_30, NULL);
		NullCheck(L_27);
		(L_27)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_29)->max_length)), 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_31);
		// for (int i = 1; i < positions.Length - 1; i++) positions[i] = samples[i + fromIndex].position;
		V_4 = 1;
		goto IL_00b6;
	}

IL_0097:
	{
		// for (int i = 1; i < positions.Length - 1; i++) positions[i] = samples[i + fromIndex].position;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_32 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_33 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_32);
		int32_t L_34 = V_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_35 = __this->___samples_0;
		int32_t L_36 = V_4;
		int32_t L_37 = V_0;
		NullCheck(L_35);
		int32_t L_38 = ((int32_t)il2cpp_codegen_add(L_36, L_37));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_39 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_38));
		NullCheck(L_39);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = L_39->___position_0;
		NullCheck(L_33);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(L_34), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_40);
		// for (int i = 1; i < positions.Length - 1; i++) positions[i] = samples[i + fromIndex].position;
		int32_t L_41 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_41, 1));
	}

IL_00b6:
	{
		// for (int i = 1; i < positions.Length - 1; i++) positions[i] = samples[i + fromIndex].position;
		int32_t L_42 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_43 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_44 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_43);
		NullCheck(L_44);
		if ((((int32_t)L_42) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_44)->max_length)), 1)))))
		{
			goto IL_0097;
		}
	}
	{
		// }
		return;
	}
}
// System.Double Dreamteck.Splines.SampleCollection::Travel(System.Double,System.Single,Dreamteck.Splines.Spline/Direction,System.Single&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SampleCollection_Travel_mC74ADC8BD2E55C17FF9E5EAC0622217977AF0637 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_start, float ___1_distance, int32_t ___2_direction, float* ___3_moved, double ___4_clipFrom, double ___5_clipTo, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	double V_3 = 0.0;
	float V_4 = 0.0f;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	bool V_7 = false;
	float V_8 = 0.0f;
	double V_9 = 0.0;
	{
		// moved = 0f;
		float* L_0 = ___3_moved;
		*((float*)L_0) = (float)(0.0f);
		// if (!hasSamples) return 0.0;
		bool L_1;
		L_1 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		// if (!hasSamples) return 0.0;
		return (0.0);
	}

IL_001a:
	{
		// if (direction == Spline.Direction.Forward && start >= 1.0) return clipTo;
		int32_t L_2 = ___2_direction;
		if ((!(((uint32_t)L_2) == ((uint32_t)1))))
		{
			goto IL_002d;
		}
	}
	{
		double L_3 = ___0_start;
		if ((!(((double)L_3) >= ((double)(1.0)))))
		{
			goto IL_002d;
		}
	}
	{
		// if (direction == Spline.Direction.Forward && start >= 1.0) return clipTo;
		double L_4 = ___5_clipTo;
		return L_4;
	}

IL_002d:
	{
		// else if (direction == Spline.Direction.Backward && start <= 0.0) return clipFrom;
		int32_t L_5 = ___2_direction;
		if ((!(((uint32_t)L_5) == ((uint32_t)(-1)))))
		{
			goto IL_0040;
		}
	}
	{
		double L_6 = ___0_start;
		if ((!(((double)L_6) <= ((double)(0.0)))))
		{
			goto IL_0040;
		}
	}
	{
		// else if (direction == Spline.Direction.Backward && start <= 0.0) return clipFrom;
		double L_7 = ___4_clipFrom;
		return L_7;
	}

IL_0040:
	{
		// double lastPercent = start;
		double L_8 = ___0_start;
		V_0 = L_8;
		// if (distance == 0f) return lastPercent;
		float L_9 = ___1_distance;
		if ((!(((float)L_9) == ((float)(0.0f)))))
		{
			goto IL_004c;
		}
	}
	{
		// if (distance == 0f) return lastPercent;
		double L_10 = V_0;
		return L_10;
	}

IL_004c:
	{
		// Vector3 lastPos = EvaluatePosition(start);
		double L_11 = ___0_start;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C(__this, L_11, NULL);
		V_1 = L_12;
		// GetSamplingValues(lastPercent, out sampleIndex, out lerp);
		double L_13 = V_0;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_13, (&V_2), (&V_3), NULL);
		// if (direction == Spline.Direction.Forward && lerp > 0.0) sampleIndex++;
		int32_t L_14 = ___2_direction;
		if ((!(((uint32_t)L_14) == ((uint32_t)1))))
		{
			goto IL_0073;
		}
	}
	{
		double L_15 = V_3;
		if ((!(((double)L_15) > ((double)(0.0)))))
		{
			goto IL_0073;
		}
	}
	{
		// if (direction == Spline.Direction.Forward && lerp > 0.0) sampleIndex++;
		int32_t L_16 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_16, 1));
	}

IL_0073:
	{
		// float lastDistance = 0f;
		V_4 = (0.0f);
		// int minIndex = 0;
		V_5 = 0;
		// int maxIndex = Count - 1;
		int32_t L_17;
		L_17 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_6 = ((int32_t)il2cpp_codegen_subtract(L_17, 1));
		// bool samplesAreLooped = clipTo < clipFrom;
		double L_18 = ___5_clipTo;
		double L_19 = ___4_clipFrom;
		V_7 = (bool)((((double)L_18) < ((double)L_19))? 1 : 0);
		// if (samplesAreLooped)
		bool L_20 = V_7;
		if (!L_20)
		{
			goto IL_0192;
		}
	}
	{
		// GetSamplingValues(clipFrom, out minIndex, out lerp);
		double L_21 = ___4_clipFrom;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_21, (&V_5), (&V_3), NULL);
		// GetSamplingValues(clipTo, out maxIndex, out lerp);
		double L_22 = ___5_clipTo;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_22, (&V_6), (&V_3), NULL);
		// if (lerp > 0.0) maxIndex++;
		double L_23 = V_3;
		if ((!(((double)L_23) > ((double)(0.0)))))
		{
			goto IL_0192;
		}
	}
	{
		// if (lerp > 0.0) maxIndex++;
		int32_t L_24 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_24, 1));
		goto IL_0192;
	}

IL_00c8:
	{
		// lastDistance = Vector3.Distance(samples[sampleIndex].position, lastPos);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_25 = __this->___samples_0;
		int32_t L_26 = V_2;
		NullCheck(L_25);
		int32_t L_27 = L_26;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_28 = (L_25)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		NullCheck(L_28);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = L_28->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30 = V_1;
		float L_31;
		L_31 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_29, L_30, NULL);
		V_4 = L_31;
		// moved += lastDistance;
		float* L_32 = ___3_moved;
		float* L_33 = ___3_moved;
		float L_34 = *((float*)L_33);
		float L_35 = V_4;
		*((float*)L_32) = (float)((float)il2cpp_codegen_add(L_34, L_35));
		// if (moved >= distance) break;
		float* L_36 = ___3_moved;
		float L_37 = *((float*)L_36);
		float L_38 = ___1_distance;
		if ((((float)L_37) >= ((float)L_38)))
		{
			goto IL_019b;
		}
	}
	{
		// lastPos = samples[sampleIndex].position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_39 = __this->___samples_0;
		int32_t L_40 = V_2;
		NullCheck(L_39);
		int32_t L_41 = L_40;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_42 = (L_39)->GetAt(static_cast<il2cpp_array_size_t>(L_41));
		NullCheck(L_42);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_43 = L_42->___position_0;
		V_1 = L_43;
		// lastPercent = samples[sampleIndex].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_44 = __this->___samples_0;
		int32_t L_45 = V_2;
		NullCheck(L_44);
		int32_t L_46 = L_45;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_47 = (L_44)->GetAt(static_cast<il2cpp_array_size_t>(L_46));
		NullCheck(L_47);
		double L_48 = L_47->___percent_5;
		V_0 = L_48;
		// if (direction == Spline.Direction.Forward)
		int32_t L_49 = ___2_direction;
		if ((!(((uint32_t)L_49) == ((uint32_t)1))))
		{
			goto IL_014b;
		}
	}
	{
		// if (sampleIndex == Count - 1)
		int32_t L_50 = V_2;
		int32_t L_51;
		L_51 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((!(((uint32_t)L_50) == ((uint32_t)((int32_t)il2cpp_codegen_subtract(L_51, 1))))))
		{
			goto IL_013c;
		}
	}
	{
		// if (samplesAreLooped)
		bool L_52 = V_7;
		if (!L_52)
		{
			goto IL_019b;
		}
	}
	{
		// lastPos = samples[0].position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_53 = __this->___samples_0;
		NullCheck(L_53);
		int32_t L_54 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_55 = (L_53)->GetAt(static_cast<il2cpp_array_size_t>(L_54));
		NullCheck(L_55);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_56 = L_55->___position_0;
		V_1 = L_56;
		// lastPercent = samples[0].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_57 = __this->___samples_0;
		NullCheck(L_57);
		int32_t L_58 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_59 = (L_57)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		NullCheck(L_59);
		double L_60 = L_59->___percent_5;
		V_0 = L_60;
		// sampleIndex = 1;
		V_2 = 1;
	}

IL_013c:
	{
		// if (samplesAreLooped && sampleIndex == maxIndex) break;
		bool L_61 = V_7;
		if (!L_61)
		{
			goto IL_0145;
		}
	}
	{
		int32_t L_62 = V_2;
		int32_t L_63 = V_6;
		if ((((int32_t)L_62) == ((int32_t)L_63)))
		{
			goto IL_019b;
		}
	}

IL_0145:
	{
		// sampleIndex++;
		int32_t L_64 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_64, 1));
		goto IL_0192;
	}

IL_014b:
	{
		// if (sampleIndex == 0)
		int32_t L_65 = V_2;
		if (L_65)
		{
			goto IL_0185;
		}
	}
	{
		// if (samplesAreLooped)
		bool L_66 = V_7;
		if (!L_66)
		{
			goto IL_019b;
		}
	}
	{
		// lastPos = samples[Count-1].position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_67 = __this->___samples_0;
		int32_t L_68;
		L_68 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_67);
		int32_t L_69 = ((int32_t)il2cpp_codegen_subtract(L_68, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_70 = (L_67)->GetAt(static_cast<il2cpp_array_size_t>(L_69));
		NullCheck(L_70);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_71 = L_70->___position_0;
		V_1 = L_71;
		// lastPercent = samples[Count - 1].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_72 = __this->___samples_0;
		int32_t L_73;
		L_73 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_72);
		int32_t L_74 = ((int32_t)il2cpp_codegen_subtract(L_73, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_75 = (L_72)->GetAt(static_cast<il2cpp_array_size_t>(L_74));
		NullCheck(L_75);
		double L_76 = L_75->___percent_5;
		V_0 = L_76;
		// sampleIndex = Count - 2;
		int32_t L_77;
		L_77 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_77, 2));
	}

IL_0185:
	{
		// if (samplesAreLooped && sampleIndex == minIndex) break;
		bool L_78 = V_7;
		if (!L_78)
		{
			goto IL_018e;
		}
	}
	{
		int32_t L_79 = V_2;
		int32_t L_80 = V_5;
		if ((((int32_t)L_79) == ((int32_t)L_80)))
		{
			goto IL_019b;
		}
	}

IL_018e:
	{
		// sampleIndex--;
		int32_t L_81 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_81, 1));
	}

IL_0192:
	{
		// while (moved < distance)
		float* L_82 = ___3_moved;
		float L_83 = *((float*)L_82);
		float L_84 = ___1_distance;
		if ((((float)L_83) < ((float)L_84)))
		{
			goto IL_00c8;
		}
	}

IL_019b:
	{
		// float moveExcess = 0f;
		V_8 = (0.0f);
		// if (moved > distance) moveExcess = moved - distance;
		float* L_85 = ___3_moved;
		float L_86 = *((float*)L_85);
		float L_87 = ___1_distance;
		if ((!(((float)L_86) > ((float)L_87))))
		{
			goto IL_01af;
		}
	}
	{
		// if (moved > distance) moveExcess = moved - distance;
		float* L_88 = ___3_moved;
		float L_89 = *((float*)L_88);
		float L_90 = ___1_distance;
		V_8 = ((float)il2cpp_codegen_subtract(L_89, L_90));
	}

IL_01af:
	{
		// double lerpPercent = 0.0;
		V_9 = (0.0);
		// if(lastDistance > 0.0)
		float L_91 = V_4;
		if ((!(((double)((double)L_91)) > ((double)(0.0)))))
		{
			goto IL_01d0;
		}
	}
	{
		// lerpPercent = moveExcess / lastDistance;
		float L_92 = V_8;
		float L_93 = V_4;
		V_9 = ((double)((float)(L_92/L_93)));
	}

IL_01d0:
	{
		// double p = DMath.Lerp(lastPercent, samples[sampleIndex].percent, 1f - lerpPercent);
		double L_94 = V_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_95 = __this->___samples_0;
		int32_t L_96 = V_2;
		NullCheck(L_95);
		int32_t L_97 = L_96;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_98 = (L_95)->GetAt(static_cast<il2cpp_array_size_t>(L_97));
		NullCheck(L_98);
		double L_99 = L_98->___percent_5;
		double L_100 = V_9;
		double L_101;
		L_101 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_94, L_99, ((double)il2cpp_codegen_subtract((1.0), L_100)), NULL);
		// moved -= moveExcess;
		float* L_102 = ___3_moved;
		float* L_103 = ___3_moved;
		float L_104 = *((float*)L_103);
		float L_105 = V_8;
		*((float*)L_102) = (float)((float)il2cpp_codegen_subtract(L_104, L_105));
		// return p;
		return L_101;
	}
}
// System.Double Dreamteck.Splines.SampleCollection::TravelWithOffset(System.Double,System.Single,Dreamteck.Splines.Spline/Direction,UnityEngine.Vector3,System.Single&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SampleCollection_TravelWithOffset_m45D8FA78F21DA1716EE0EEA450F1B0DF8A6698F3 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_start, float ___1_distance, int32_t ___2_direction, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___3_offset, float* ___4_moved, double ___5_clipFrom, double ___6_clipTo, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	double V_3 = 0.0;
	float V_4 = 0.0f;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	bool V_7 = false;
	float V_8 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_9;
	memset((&V_9), 0, sizeof(V_9));
	int32_t V_10 = 0;
	{
		// moved = 0f;
		float* L_0 = ___4_moved;
		*((float*)L_0) = (float)(0.0f);
		// if (!hasSamples) return 0.0;
		bool L_1;
		L_1 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		// if (!hasSamples) return 0.0;
		return (0.0);
	}

IL_001a:
	{
		// if (direction == Spline.Direction.Forward && start >= 1.0) return clipTo;
		int32_t L_2 = ___2_direction;
		if ((!(((uint32_t)L_2) == ((uint32_t)1))))
		{
			goto IL_002d;
		}
	}
	{
		double L_3 = ___0_start;
		if ((!(((double)L_3) >= ((double)(1.0)))))
		{
			goto IL_002d;
		}
	}
	{
		// if (direction == Spline.Direction.Forward && start >= 1.0) return clipTo;
		double L_4 = ___6_clipTo;
		return L_4;
	}

IL_002d:
	{
		// else if (direction == Spline.Direction.Backward && start <= 0.0) return clipFrom;
		int32_t L_5 = ___2_direction;
		if ((!(((uint32_t)L_5) == ((uint32_t)(-1)))))
		{
			goto IL_0040;
		}
	}
	{
		double L_6 = ___0_start;
		if ((!(((double)L_6) <= ((double)(0.0)))))
		{
			goto IL_0040;
		}
	}
	{
		// else if (direction == Spline.Direction.Backward && start <= 0.0) return clipFrom;
		double L_7 = ___5_clipFrom;
		return L_7;
	}

IL_0040:
	{
		// double lastPercent = start;
		double L_8 = ___0_start;
		V_0 = L_8;
		// if (distance == 0f) return lastPercent;
		float L_9 = ___1_distance;
		if ((!(((float)L_9) == ((float)(0.0f)))))
		{
			goto IL_004c;
		}
	}
	{
		// if (distance == 0f) return lastPercent;
		double L_10 = V_0;
		return L_10;
	}

IL_004c:
	{
		// Evaluate(start, _workSample);
		double L_11 = ___0_start;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_12 = __this->____workSample_3;
		SampleCollection_Evaluate_mE67F0879D5C0755347AA1C1D7D2D08B22B3044A1(__this, L_11, L_12, NULL);
		// Vector3 lastPos = _workSample.position + _workSample.up * (offset.y * _workSample.size) + _workSample.right * (offset.x * _workSample.size) + _workSample.forward * (offset.z * _workSample.size);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_13 = __this->____workSample_3;
		NullCheck(L_13);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14 = L_13->___position_0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_15 = __this->____workSample_3;
		NullCheck(L_15);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = L_15->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17 = ___3_offset;
		float L_18 = L_17.___y_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_19 = __this->____workSample_3;
		NullCheck(L_19);
		float L_20 = L_19->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_16, ((float)il2cpp_codegen_multiply(L_18, L_20)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22;
		L_22 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_14, L_21, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_23 = __this->____workSample_3;
		NullCheck(L_23);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_23, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = ___3_offset;
		float L_26 = L_25.___x_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_27 = __this->____workSample_3;
		NullCheck(L_27);
		float L_28 = L_27->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_24, ((float)il2cpp_codegen_multiply(L_26, L_28)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30;
		L_30 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_22, L_29, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_31 = __this->____workSample_3;
		NullCheck(L_31);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32 = L_31->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = ___3_offset;
		float L_34 = L_33.___z_4;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_35 = __this->____workSample_3;
		NullCheck(L_35);
		float L_36 = L_35->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_32, ((float)il2cpp_codegen_multiply(L_34, L_36)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38;
		L_38 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_30, L_37, NULL);
		V_1 = L_38;
		// GetSamplingValues(lastPercent, out sampleIndex, out lerp);
		double L_39 = V_0;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_39, (&V_2), (&V_3), NULL);
		// if (direction == Spline.Direction.Forward && lerp > 0.0) sampleIndex++;
		int32_t L_40 = ___2_direction;
		if ((!(((uint32_t)L_40) == ((uint32_t)1))))
		{
			goto IL_00fc;
		}
	}
	{
		double L_41 = V_3;
		if ((!(((double)L_41) > ((double)(0.0)))))
		{
			goto IL_00fc;
		}
	}
	{
		// if (direction == Spline.Direction.Forward && lerp > 0.0) sampleIndex++;
		int32_t L_42 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_42, 1));
	}

IL_00fc:
	{
		// float lastDistance = 0f;
		V_4 = (0.0f);
		// int minIndex = 0;
		V_5 = 0;
		// int maxIndex = Count - 1;
		int32_t L_43;
		L_43 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_6 = ((int32_t)il2cpp_codegen_subtract(L_43, 1));
		// bool samplesAreLooped = clipTo < clipFrom;
		double L_44 = ___6_clipTo;
		double L_45 = ___5_clipFrom;
		V_7 = (bool)((((double)L_44) < ((double)L_45))? 1 : 0);
		// if (samplesAreLooped)
		bool L_46 = V_7;
		if (!L_46)
		{
			goto IL_03b9;
		}
	}
	{
		// GetSamplingValues(clipFrom, out minIndex, out lerp);
		double L_47 = ___5_clipFrom;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_47, (&V_5), (&V_3), NULL);
		// GetSamplingValues(clipTo, out maxIndex, out lerp);
		double L_48 = ___6_clipTo;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_48, (&V_6), (&V_3), NULL);
		// if (lerp > 0.0) maxIndex++;
		double L_49 = V_3;
		if ((!(((double)L_49) > ((double)(0.0)))))
		{
			goto IL_03b9;
		}
	}
	{
		// if (lerp > 0.0) maxIndex++;
		int32_t L_50 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_50, 1));
		goto IL_03b9;
	}

IL_0151:
	{
		// Vector3 newPos = samples[sampleIndex].position + samples[sampleIndex].up * (offset.y * samples[sampleIndex].size) + samples[sampleIndex].right * (offset.x * samples[sampleIndex].size) + samples[sampleIndex].forward * (offset.z * samples[sampleIndex].size);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_51 = __this->___samples_0;
		int32_t L_52 = V_2;
		NullCheck(L_51);
		int32_t L_53 = L_52;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_54 = (L_51)->GetAt(static_cast<il2cpp_array_size_t>(L_53));
		NullCheck(L_54);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55 = L_54->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_56 = __this->___samples_0;
		int32_t L_57 = V_2;
		NullCheck(L_56);
		int32_t L_58 = L_57;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_59 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		NullCheck(L_59);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_60 = L_59->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_61 = ___3_offset;
		float L_62 = L_61.___y_3;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_63 = __this->___samples_0;
		int32_t L_64 = V_2;
		NullCheck(L_63);
		int32_t L_65 = L_64;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_66 = (L_63)->GetAt(static_cast<il2cpp_array_size_t>(L_65));
		NullCheck(L_66);
		float L_67 = L_66->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68;
		L_68 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_60, ((float)il2cpp_codegen_multiply(L_62, L_67)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69;
		L_69 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_55, L_68, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_70 = __this->___samples_0;
		int32_t L_71 = V_2;
		NullCheck(L_70);
		int32_t L_72 = L_71;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_73 = (L_70)->GetAt(static_cast<il2cpp_array_size_t>(L_72));
		NullCheck(L_73);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_74;
		L_74 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_73, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_75 = ___3_offset;
		float L_76 = L_75.___x_2;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_77 = __this->___samples_0;
		int32_t L_78 = V_2;
		NullCheck(L_77);
		int32_t L_79 = L_78;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_80 = (L_77)->GetAt(static_cast<il2cpp_array_size_t>(L_79));
		NullCheck(L_80);
		float L_81 = L_80->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82;
		L_82 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_74, ((float)il2cpp_codegen_multiply(L_76, L_81)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_83;
		L_83 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_69, L_82, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_84 = __this->___samples_0;
		int32_t L_85 = V_2;
		NullCheck(L_84);
		int32_t L_86 = L_85;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_87 = (L_84)->GetAt(static_cast<il2cpp_array_size_t>(L_86));
		NullCheck(L_87);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_88 = L_87->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_89 = ___3_offset;
		float L_90 = L_89.___z_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_91 = __this->___samples_0;
		int32_t L_92 = V_2;
		NullCheck(L_91);
		int32_t L_93 = L_92;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_94 = (L_91)->GetAt(static_cast<il2cpp_array_size_t>(L_93));
		NullCheck(L_94);
		float L_95 = L_94->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_96;
		L_96 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_88, ((float)il2cpp_codegen_multiply(L_90, L_95)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_97;
		L_97 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_83, L_96, NULL);
		V_9 = L_97;
		// lastDistance = Vector3.Distance(newPos, lastPos);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_98 = V_9;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_99 = V_1;
		float L_100;
		L_100 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_98, L_99, NULL);
		V_4 = L_100;
		// moved += lastDistance;
		float* L_101 = ___4_moved;
		float* L_102 = ___4_moved;
		float L_103 = *((float*)L_102);
		float L_104 = V_4;
		*((float*)L_101) = (float)((float)il2cpp_codegen_add(L_103, L_104));
		// if (moved >= distance)
		float* L_105 = ___4_moved;
		float L_106 = *((float*)L_105);
		float L_107 = ___1_distance;
		if ((((float)L_106) >= ((float)L_107)))
		{
			goto IL_03c2;
		}
	}
	{
		// lastPos = newPos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_108 = V_9;
		V_1 = L_108;
		// lastPercent = samples[sampleIndex].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_109 = __this->___samples_0;
		int32_t L_110 = V_2;
		NullCheck(L_109);
		int32_t L_111 = L_110;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_112 = (L_109)->GetAt(static_cast<il2cpp_array_size_t>(L_111));
		NullCheck(L_112);
		double L_113 = L_112->___percent_5;
		V_0 = L_113;
		// if (direction == Spline.Direction.Forward)
		int32_t L_114 = ___2_direction;
		if ((!(((uint32_t)L_114) == ((uint32_t)1))))
		{
			goto IL_02e4;
		}
	}
	{
		// if (sampleIndex == Count - 1)
		int32_t L_115 = V_2;
		int32_t L_116;
		L_116 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((!(((uint32_t)L_115) == ((uint32_t)((int32_t)il2cpp_codegen_subtract(L_116, 1))))))
		{
			goto IL_02cf;
		}
	}
	{
		// if (samplesAreLooped)
		bool L_117 = V_7;
		if (!L_117)
		{
			goto IL_03c2;
		}
	}
	{
		// lastPos = samples[0].position + samples[0].up * (offset.y * samples[0].size) + samples[0].right * (offset.x * samples[0].size) + samples[0].forward * (offset.z * samples[0].size);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_118 = __this->___samples_0;
		NullCheck(L_118);
		int32_t L_119 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_120 = (L_118)->GetAt(static_cast<il2cpp_array_size_t>(L_119));
		NullCheck(L_120);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_121 = L_120->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_122 = __this->___samples_0;
		NullCheck(L_122);
		int32_t L_123 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_124 = (L_122)->GetAt(static_cast<il2cpp_array_size_t>(L_123));
		NullCheck(L_124);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_125 = L_124->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_126 = ___3_offset;
		float L_127 = L_126.___y_3;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_128 = __this->___samples_0;
		NullCheck(L_128);
		int32_t L_129 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_130 = (L_128)->GetAt(static_cast<il2cpp_array_size_t>(L_129));
		NullCheck(L_130);
		float L_131 = L_130->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_132;
		L_132 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_125, ((float)il2cpp_codegen_multiply(L_127, L_131)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_133;
		L_133 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_121, L_132, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_134 = __this->___samples_0;
		NullCheck(L_134);
		int32_t L_135 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_136 = (L_134)->GetAt(static_cast<il2cpp_array_size_t>(L_135));
		NullCheck(L_136);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_137;
		L_137 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_136, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_138 = ___3_offset;
		float L_139 = L_138.___x_2;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_140 = __this->___samples_0;
		NullCheck(L_140);
		int32_t L_141 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_142 = (L_140)->GetAt(static_cast<il2cpp_array_size_t>(L_141));
		NullCheck(L_142);
		float L_143 = L_142->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_144;
		L_144 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_137, ((float)il2cpp_codegen_multiply(L_139, L_143)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_145;
		L_145 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_133, L_144, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_146 = __this->___samples_0;
		NullCheck(L_146);
		int32_t L_147 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_148 = (L_146)->GetAt(static_cast<il2cpp_array_size_t>(L_147));
		NullCheck(L_148);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_149 = L_148->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_150 = ___3_offset;
		float L_151 = L_150.___z_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_152 = __this->___samples_0;
		NullCheck(L_152);
		int32_t L_153 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_154 = (L_152)->GetAt(static_cast<il2cpp_array_size_t>(L_153));
		NullCheck(L_154);
		float L_155 = L_154->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_156;
		L_156 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_149, ((float)il2cpp_codegen_multiply(L_151, L_155)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_157;
		L_157 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_145, L_156, NULL);
		V_1 = L_157;
		// lastPercent = samples[0].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_158 = __this->___samples_0;
		NullCheck(L_158);
		int32_t L_159 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_160 = (L_158)->GetAt(static_cast<il2cpp_array_size_t>(L_159));
		NullCheck(L_160);
		double L_161 = L_160->___percent_5;
		V_0 = L_161;
		// sampleIndex = 1;
		V_2 = 1;
	}

IL_02cf:
	{
		// if (samplesAreLooped && sampleIndex == maxIndex) break;
		bool L_162 = V_7;
		if (!L_162)
		{
			goto IL_02db;
		}
	}
	{
		int32_t L_163 = V_2;
		int32_t L_164 = V_6;
		if ((((int32_t)L_163) == ((int32_t)L_164)))
		{
			goto IL_03c2;
		}
	}

IL_02db:
	{
		// sampleIndex++;
		int32_t L_165 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_165, 1));
		goto IL_03b9;
	}

IL_02e4:
	{
		// if (sampleIndex == 0)
		int32_t L_166 = V_2;
		if (L_166)
		{
			goto IL_03ac;
		}
	}
	{
		// if (samplesAreLooped)
		bool L_167 = V_7;
		if (!L_167)
		{
			goto IL_03c2;
		}
	}
	{
		// int lastIndex = Count - 1;
		int32_t L_168;
		L_168 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_10 = ((int32_t)il2cpp_codegen_subtract(L_168, 1));
		// lastPos = samples[lastIndex].position + samples[lastIndex].up * (offset.y * samples[lastIndex].size) + samples[lastIndex].right * (offset.x * samples[lastIndex].size) + samples[lastIndex].forward * (offset.z * samples[lastIndex].size);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_169 = __this->___samples_0;
		int32_t L_170 = V_10;
		NullCheck(L_169);
		int32_t L_171 = L_170;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_172 = (L_169)->GetAt(static_cast<il2cpp_array_size_t>(L_171));
		NullCheck(L_172);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_173 = L_172->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_174 = __this->___samples_0;
		int32_t L_175 = V_10;
		NullCheck(L_174);
		int32_t L_176 = L_175;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_177 = (L_174)->GetAt(static_cast<il2cpp_array_size_t>(L_176));
		NullCheck(L_177);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_178 = L_177->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_179 = ___3_offset;
		float L_180 = L_179.___y_3;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_181 = __this->___samples_0;
		int32_t L_182 = V_10;
		NullCheck(L_181);
		int32_t L_183 = L_182;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_184 = (L_181)->GetAt(static_cast<il2cpp_array_size_t>(L_183));
		NullCheck(L_184);
		float L_185 = L_184->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_186;
		L_186 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_178, ((float)il2cpp_codegen_multiply(L_180, L_185)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_187;
		L_187 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_173, L_186, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_188 = __this->___samples_0;
		int32_t L_189 = V_10;
		NullCheck(L_188);
		int32_t L_190 = L_189;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_191 = (L_188)->GetAt(static_cast<il2cpp_array_size_t>(L_190));
		NullCheck(L_191);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_192;
		L_192 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_191, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_193 = ___3_offset;
		float L_194 = L_193.___x_2;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_195 = __this->___samples_0;
		int32_t L_196 = V_10;
		NullCheck(L_195);
		int32_t L_197 = L_196;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_198 = (L_195)->GetAt(static_cast<il2cpp_array_size_t>(L_197));
		NullCheck(L_198);
		float L_199 = L_198->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_200;
		L_200 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_192, ((float)il2cpp_codegen_multiply(L_194, L_199)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_201;
		L_201 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_187, L_200, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_202 = __this->___samples_0;
		int32_t L_203 = V_10;
		NullCheck(L_202);
		int32_t L_204 = L_203;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_205 = (L_202)->GetAt(static_cast<il2cpp_array_size_t>(L_204));
		NullCheck(L_205);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_206 = L_205->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_207 = ___3_offset;
		float L_208 = L_207.___z_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_209 = __this->___samples_0;
		int32_t L_210 = V_10;
		NullCheck(L_209);
		int32_t L_211 = L_210;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_212 = (L_209)->GetAt(static_cast<il2cpp_array_size_t>(L_211));
		NullCheck(L_212);
		float L_213 = L_212->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_214;
		L_214 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_206, ((float)il2cpp_codegen_multiply(L_208, L_213)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_215;
		L_215 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_201, L_214, NULL);
		V_1 = L_215;
		// lastPercent = samples[lastIndex].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_216 = __this->___samples_0;
		int32_t L_217 = V_10;
		NullCheck(L_216);
		int32_t L_218 = L_217;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_219 = (L_216)->GetAt(static_cast<il2cpp_array_size_t>(L_218));
		NullCheck(L_219);
		double L_220 = L_219->___percent_5;
		V_0 = L_220;
		// sampleIndex = Count - 2;
		int32_t L_221;
		L_221 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_221, 2));
	}

IL_03ac:
	{
		// if (samplesAreLooped && sampleIndex == minIndex) break;
		bool L_222 = V_7;
		if (!L_222)
		{
			goto IL_03b5;
		}
	}
	{
		int32_t L_223 = V_2;
		int32_t L_224 = V_5;
		if ((((int32_t)L_223) == ((int32_t)L_224)))
		{
			goto IL_03c2;
		}
	}

IL_03b5:
	{
		// sampleIndex--;
		int32_t L_225 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_225, 1));
	}

IL_03b9:
	{
		// while (moved < distance)
		float* L_226 = ___4_moved;
		float L_227 = *((float*)L_226);
		float L_228 = ___1_distance;
		if ((((float)L_227) < ((float)L_228)))
		{
			goto IL_0151;
		}
	}

IL_03c2:
	{
		// float moveExcess = 0f;
		V_8 = (0.0f);
		// if (moved > distance)
		float* L_229 = ___4_moved;
		float L_230 = *((float*)L_229);
		float L_231 = ___1_distance;
		if ((!(((float)L_230) > ((float)L_231))))
		{
			goto IL_03d6;
		}
	}
	{
		// moveExcess = moved - distance;
		float* L_232 = ___4_moved;
		float L_233 = *((float*)L_232);
		float L_234 = ___1_distance;
		V_8 = ((float)il2cpp_codegen_subtract(L_233, L_234));
	}

IL_03d6:
	{
		// double p = DMath.Lerp(lastPercent, samples[sampleIndex].percent, 1f - moveExcess / lastDistance);
		double L_235 = V_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_236 = __this->___samples_0;
		int32_t L_237 = V_2;
		NullCheck(L_236);
		int32_t L_238 = L_237;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_239 = (L_236)->GetAt(static_cast<il2cpp_array_size_t>(L_238));
		NullCheck(L_239);
		double L_240 = L_239->___percent_5;
		float L_241 = V_8;
		float L_242 = V_4;
		double L_243;
		L_243 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_235, L_240, ((double)((float)il2cpp_codegen_subtract((1.0f), ((float)(L_241/L_242))))), NULL);
		// moved -= moveExcess;
		float* L_244 = ___4_moved;
		float* L_245 = ___4_moved;
		float L_246 = *((float*)L_245);
		float L_247 = V_8;
		*((float*)L_244) = (float)((float)il2cpp_codegen_subtract(L_246, L_247));
		// return p;
		return L_243;
	}
}
// System.Double Dreamteck.Splines.SampleCollection::Travel(System.Double,System.Single,Dreamteck.Splines.Spline/Direction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SampleCollection_Travel_m5EDDA743960C663E7D8A5F847C01151CB168AF6A (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_start, float ___1_distance, int32_t ___2_direction, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		// return Travel(start, distance, direction, out moved);
		double L_0 = ___0_start;
		float L_1 = ___1_distance;
		int32_t L_2 = ___2_direction;
		double L_3;
		L_3 = SampleCollection_Travel_mC74ADC8BD2E55C17FF9E5EAC0622217977AF0637(__this, L_0, L_1, L_2, (&V_0), (0.0), (1.0), NULL);
		return L_3;
	}
}
// System.Void Dreamteck.Splines.SampleCollection::Project(UnityEngine.Vector3,System.Int32,Dreamteck.Splines.SplineSample,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleCollection_Project_m1D5C293BA5B1263DD7FE6EB8ABB0B8BCAC2726BB (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_position, int32_t ___1_controlPointCount, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___2_result, double ___3_from, double ___4_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	double V_5 = 0.0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	int32_t V_10 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_11;
	memset((&V_11), 0, sizeof(V_11));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_12;
	memset((&V_12), 0, sizeof(V_12));
	float V_13 = 0.0f;
	float V_14 = 0.0f;
	float V_15 = 0.0f;
	float V_16 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_17;
	memset((&V_17), 0, sizeof(V_17));
	int32_t V_18 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_19;
	memset((&V_19), 0, sizeof(V_19));
	float V_20 = 0.0f;
	int32_t V_21 = 0;
	float V_22 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_23;
	memset((&V_23), 0, sizeof(V_23));
	double V_24 = 0.0;
	{
		// if (!hasSamples) return;
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// if (!hasSamples) return;
		return;
	}

IL_0009:
	{
		// if (Count == 1)
		int32_t L_1;
		L_1 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((!(((uint32_t)L_1) == ((uint32_t)1))))
		{
			goto IL_0034;
		}
	}
	{
		// if (result == null) result = new SplineSample(samples[0]);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = ___2_result;
		if (L_2)
		{
			goto IL_0025;
		}
	}
	{
		// if (result == null) result = new SplineSample(samples[0]);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_3 = __this->___samples_0;
		NullCheck(L_3);
		int32_t L_4 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_5 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_6 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_6);
		SplineSample__ctor_m6BB75B83D92E2D0698FBDECDCDAB9E200DB9541E(L_6, L_5, NULL);
		___2_result = L_6;
		return;
	}

IL_0025:
	{
		// else result.CopyFrom(samples[0]);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = ___2_result;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_8 = __this->___samples_0;
		NullCheck(L_8);
		int32_t L_9 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		NullCheck(L_7);
		SplineSample_CopyFrom_mB1BB345F571264DD4BA0290C34F20C13615F58FE(L_7, L_10, NULL);
		// return;
		return;
	}

IL_0034:
	{
		// Spline.FormatFromTo(ref from, ref to);
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764((&___3_from), (&___4_to), (bool)1, NULL);
		// int steps = (controlPointCount - 1) * 4; //Sampling four points per segment is enough to find the closest point range
		int32_t L_11 = ___1_controlPointCount;
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_11, 1)), 4));
		// int step = Count / steps;
		int32_t L_12;
		L_12 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		int32_t L_13 = V_0;
		V_1 = ((int32_t)(L_12/L_13));
		// if (step < 1) step = 1;
		int32_t L_14 = V_1;
		if ((((int32_t)L_14) >= ((int32_t)1)))
		{
			goto IL_0053;
		}
	}
	{
		// if (step < 1) step = 1;
		V_1 = 1;
	}

IL_0053:
	{
		// float minDist = (position - samples[0].position).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = ___0_position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_16 = __this->___samples_0;
		NullCheck(L_16);
		int32_t L_17 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_18 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		NullCheck(L_18);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19 = L_18->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_15, L_19, NULL);
		V_17 = L_20;
		float L_21;
		L_21 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		V_2 = L_21;
		// int fromIndex = 0;
		V_3 = 0;
		// int toIndex = Count - 1;
		int32_t L_22;
		L_22 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_4 = ((int32_t)il2cpp_codegen_subtract(L_22, 1));
		// if (from != 0.0) GetSamplingValues(from, out fromIndex, out lerp);
		double L_23 = ___3_from;
		if ((((double)L_23) == ((double)(0.0))))
		{
			goto IL_0095;
		}
	}
	{
		// if (from != 0.0) GetSamplingValues(from, out fromIndex, out lerp);
		double L_24 = ___3_from;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_24, (&V_3), (&V_5), NULL);
	}

IL_0095:
	{
		// if (to != 1.0)
		double L_25 = ___4_to;
		if ((((double)L_25) == ((double)(1.0))))
		{
			goto IL_00cd;
		}
	}
	{
		// GetSamplingValues(to, out toIndex, out lerp);
		double L_26 = ___4_to;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_26, (&V_4), (&V_5), NULL);
		// if (lerp > 0.0 && toIndex < Count - 1) toIndex++;
		double L_27 = V_5;
		if ((!(((double)L_27) > ((double)(0.0)))))
		{
			goto IL_00cd;
		}
	}
	{
		int32_t L_28 = V_4;
		int32_t L_29;
		L_29 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_28) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_29, 1)))))
		{
			goto IL_00cd;
		}
	}
	{
		// if (lerp > 0.0 && toIndex < Count - 1) toIndex++;
		int32_t L_30 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_30, 1));
	}

IL_00cd:
	{
		// int checkFrom = fromIndex;
		int32_t L_31 = V_3;
		V_6 = L_31;
		// int checkTo = toIndex;
		int32_t L_32 = V_4;
		V_7 = L_32;
		// for (int i = fromIndex; i < toIndex; i += step)
		int32_t L_33 = V_3;
		V_18 = L_33;
		goto IL_0158;
	}

IL_00d9:
	{
		// if (i >= toIndex) i = toIndex-1;
		int32_t L_34 = V_18;
		int32_t L_35 = V_4;
		if ((((int32_t)L_34) < ((int32_t)L_35)))
		{
			goto IL_00e5;
		}
	}
	{
		// if (i >= toIndex) i = toIndex-1;
		int32_t L_36 = V_4;
		V_18 = ((int32_t)il2cpp_codegen_subtract(L_36, 1));
	}

IL_00e5:
	{
		// Vector3 projected = LinearAlgebraUtility.ProjectOnLine(samples[i].position, samples[Mathf.Min(i + step, toIndex)].position, position);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_37 = __this->___samples_0;
		int32_t L_38 = V_18;
		NullCheck(L_37);
		int32_t L_39 = L_38;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_40 = (L_37)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		NullCheck(L_40);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = L_40->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_42 = __this->___samples_0;
		int32_t L_43 = V_18;
		int32_t L_44 = V_1;
		int32_t L_45 = V_4;
		int32_t L_46;
		L_46 = Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline(((int32_t)il2cpp_codegen_add(L_43, L_44)), L_45, NULL);
		NullCheck(L_42);
		int32_t L_47 = L_46;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_48 = (L_42)->GetAt(static_cast<il2cpp_array_size_t>(L_47));
		NullCheck(L_48);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49 = L_48->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51;
		L_51 = LinearAlgebraUtility_ProjectOnLine_mEC026A5EC230133DF5B0D6C5DCFAB043236D81F6(L_41, L_49, L_50, NULL);
		V_19 = L_51;
		// float dist = (position - projected).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_52 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53 = V_19;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54;
		L_54 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_52, L_53, NULL);
		V_17 = L_54;
		float L_55;
		L_55 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		V_20 = L_55;
		// if (dist < minDist)
		float L_56 = V_20;
		float L_57 = V_2;
		if ((!(((float)L_56) < ((float)L_57))))
		{
			goto IL_014c;
		}
	}
	{
		// minDist = dist;
		float L_58 = V_20;
		V_2 = L_58;
		// checkFrom = Mathf.Max(i - step, 0);
		int32_t L_59 = V_18;
		int32_t L_60 = V_1;
		int32_t L_61;
		L_61 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(((int32_t)il2cpp_codegen_subtract(L_59, L_60)), 0, NULL);
		V_6 = L_61;
		// checkTo = Mathf.Min(i + step, Count - 1);
		int32_t L_62 = V_18;
		int32_t L_63 = V_1;
		int32_t L_64;
		L_64 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		int32_t L_65;
		L_65 = Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline(((int32_t)il2cpp_codegen_add(L_62, L_63)), ((int32_t)il2cpp_codegen_subtract(L_64, 1)), NULL);
		V_7 = L_65;
	}

IL_014c:
	{
		// if (i == toIndex) break;
		int32_t L_66 = V_18;
		int32_t L_67 = V_4;
		if ((((int32_t)L_66) == ((int32_t)L_67)))
		{
			goto IL_0161;
		}
	}
	{
		// for (int i = fromIndex; i < toIndex; i += step)
		int32_t L_68 = V_18;
		int32_t L_69 = V_1;
		V_18 = ((int32_t)il2cpp_codegen_add(L_68, L_69));
	}

IL_0158:
	{
		// for (int i = fromIndex; i < toIndex; i += step)
		int32_t L_70 = V_18;
		int32_t L_71 = V_4;
		if ((((int32_t)L_70) < ((int32_t)L_71)))
		{
			goto IL_00d9;
		}
	}

IL_0161:
	{
		// minDist = (position - samples[checkFrom].position).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_72 = ___0_position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_73 = __this->___samples_0;
		int32_t L_74 = V_6;
		NullCheck(L_73);
		int32_t L_75 = L_74;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_76 = (L_73)->GetAt(static_cast<il2cpp_array_size_t>(L_75));
		NullCheck(L_76);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_77 = L_76->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_78;
		L_78 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_72, L_77, NULL);
		V_17 = L_78;
		float L_79;
		L_79 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		V_2 = L_79;
		// int index = checkFrom;
		int32_t L_80 = V_6;
		V_8 = L_80;
		// for (int i = checkFrom + 1; i <= checkTo; i++)
		int32_t L_81 = V_6;
		V_21 = ((int32_t)il2cpp_codegen_add(L_81, 1));
		goto IL_01bc;
	}

IL_018b:
	{
		// float dist = (position - samples[i].position).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82 = ___0_position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_83 = __this->___samples_0;
		int32_t L_84 = V_21;
		NullCheck(L_83);
		int32_t L_85 = L_84;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_86 = (L_83)->GetAt(static_cast<il2cpp_array_size_t>(L_85));
		NullCheck(L_86);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_87 = L_86->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_88;
		L_88 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_82, L_87, NULL);
		V_17 = L_88;
		float L_89;
		L_89 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		V_22 = L_89;
		// if (dist < minDist)
		float L_90 = V_22;
		float L_91 = V_2;
		if ((!(((float)L_90) < ((float)L_91))))
		{
			goto IL_01b6;
		}
	}
	{
		// minDist = dist;
		float L_92 = V_22;
		V_2 = L_92;
		// index = i;
		int32_t L_93 = V_21;
		V_8 = L_93;
	}

IL_01b6:
	{
		// for (int i = checkFrom + 1; i <= checkTo; i++)
		int32_t L_94 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_94, 1));
	}

IL_01bc:
	{
		// for (int i = checkFrom + 1; i <= checkTo; i++)
		int32_t L_95 = V_21;
		int32_t L_96 = V_7;
		if ((((int32_t)L_95) <= ((int32_t)L_96)))
		{
			goto IL_018b;
		}
	}
	{
		// int backIndex = index - 1;
		int32_t L_97 = V_8;
		V_9 = ((int32_t)il2cpp_codegen_subtract(L_97, 1));
		// if (backIndex < 0) backIndex = 0;
		int32_t L_98 = V_9;
		if ((((int32_t)L_98) >= ((int32_t)0)))
		{
			goto IL_01d0;
		}
	}
	{
		// if (backIndex < 0) backIndex = 0;
		V_9 = 0;
	}

IL_01d0:
	{
		// int frontIndex = index + 1;
		int32_t L_99 = V_8;
		V_10 = ((int32_t)il2cpp_codegen_add(L_99, 1));
		// if (frontIndex > Count - 1) frontIndex = Count - 1;
		int32_t L_100 = V_10;
		int32_t L_101;
		L_101 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_100) <= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_101, 1)))))
		{
			goto IL_01ec;
		}
	}
	{
		// if (frontIndex > Count - 1) frontIndex = Count - 1;
		int32_t L_102;
		L_102 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		V_10 = ((int32_t)il2cpp_codegen_subtract(L_102, 1));
	}

IL_01ec:
	{
		// Vector3 back = LinearAlgebraUtility.ProjectOnLine(samples[backIndex].position, samples[index].position, position);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_103 = __this->___samples_0;
		int32_t L_104 = V_9;
		NullCheck(L_103);
		int32_t L_105 = L_104;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_106 = (L_103)->GetAt(static_cast<il2cpp_array_size_t>(L_105));
		NullCheck(L_106);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_107 = L_106->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_108 = __this->___samples_0;
		int32_t L_109 = V_8;
		NullCheck(L_108);
		int32_t L_110 = L_109;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_111 = (L_108)->GetAt(static_cast<il2cpp_array_size_t>(L_110));
		NullCheck(L_111);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_112 = L_111->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_113 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_114;
		L_114 = LinearAlgebraUtility_ProjectOnLine_mEC026A5EC230133DF5B0D6C5DCFAB043236D81F6(L_107, L_112, L_113, NULL);
		V_11 = L_114;
		// Vector3 front = LinearAlgebraUtility.ProjectOnLine(samples[index].position, samples[frontIndex].position, position);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_115 = __this->___samples_0;
		int32_t L_116 = V_8;
		NullCheck(L_115);
		int32_t L_117 = L_116;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_118 = (L_115)->GetAt(static_cast<il2cpp_array_size_t>(L_117));
		NullCheck(L_118);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_119 = L_118->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_120 = __this->___samples_0;
		int32_t L_121 = V_10;
		NullCheck(L_120);
		int32_t L_122 = L_121;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_123 = (L_120)->GetAt(static_cast<il2cpp_array_size_t>(L_122));
		NullCheck(L_123);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_124 = L_123->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_125 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_126;
		L_126 = LinearAlgebraUtility_ProjectOnLine_mEC026A5EC230133DF5B0D6C5DCFAB043236D81F6(L_119, L_124, L_125, NULL);
		V_12 = L_126;
		// float backLength = (samples[index].position - samples[backIndex].position).magnitude;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_127 = __this->___samples_0;
		int32_t L_128 = V_8;
		NullCheck(L_127);
		int32_t L_129 = L_128;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_130 = (L_127)->GetAt(static_cast<il2cpp_array_size_t>(L_129));
		NullCheck(L_130);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_131 = L_130->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_132 = __this->___samples_0;
		int32_t L_133 = V_9;
		NullCheck(L_132);
		int32_t L_134 = L_133;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_135 = (L_132)->GetAt(static_cast<il2cpp_array_size_t>(L_134));
		NullCheck(L_135);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_136 = L_135->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_137;
		L_137 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_131, L_136, NULL);
		V_17 = L_137;
		float L_138;
		L_138 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_17), NULL);
		V_13 = L_138;
		// float frontLength = (samples[index].position - samples[frontIndex].position).magnitude;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_139 = __this->___samples_0;
		int32_t L_140 = V_8;
		NullCheck(L_139);
		int32_t L_141 = L_140;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_142 = (L_139)->GetAt(static_cast<il2cpp_array_size_t>(L_141));
		NullCheck(L_142);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_143 = L_142->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_144 = __this->___samples_0;
		int32_t L_145 = V_10;
		NullCheck(L_144);
		int32_t L_146 = L_145;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_147 = (L_144)->GetAt(static_cast<il2cpp_array_size_t>(L_146));
		NullCheck(L_147);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_148 = L_147->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_149;
		L_149 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_143, L_148, NULL);
		V_17 = L_149;
		float L_150;
		L_150 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_17), NULL);
		V_14 = L_150;
		// float backProjectDist = (back - samples[backIndex].position).magnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_151 = V_11;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_152 = __this->___samples_0;
		int32_t L_153 = V_9;
		NullCheck(L_152);
		int32_t L_154 = L_153;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_155 = (L_152)->GetAt(static_cast<il2cpp_array_size_t>(L_154));
		NullCheck(L_155);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_156 = L_155->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_157;
		L_157 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_151, L_156, NULL);
		V_17 = L_157;
		float L_158;
		L_158 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_17), NULL);
		V_15 = L_158;
		// float frontProjectDist = (front - samples[frontIndex].position).magnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_159 = V_12;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_160 = __this->___samples_0;
		int32_t L_161 = V_10;
		NullCheck(L_160);
		int32_t L_162 = L_161;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_163 = (L_160)->GetAt(static_cast<il2cpp_array_size_t>(L_162));
		NullCheck(L_163);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_164 = L_163->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_165;
		L_165 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_159, L_164, NULL);
		V_17 = L_165;
		float L_166;
		L_166 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_17), NULL);
		V_16 = L_166;
		// if (backIndex < index && index < frontIndex)
		int32_t L_167 = V_9;
		int32_t L_168 = V_8;
		if ((((int32_t)L_167) >= ((int32_t)L_168)))
		{
			goto IL_03a0;
		}
	}
	{
		int32_t L_169 = V_8;
		int32_t L_170 = V_10;
		if ((((int32_t)L_169) >= ((int32_t)L_170)))
		{
			goto IL_03a0;
		}
	}
	{
		// if ((position - back).sqrMagnitude < (position - front).sqrMagnitude)
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_171 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_172 = V_11;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_173;
		L_173 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_171, L_172, NULL);
		V_17 = L_173;
		float L_174;
		L_174 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_175 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_176 = V_12;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_177;
		L_177 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_175, L_176, NULL);
		V_17 = L_177;
		float L_178;
		L_178 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		if ((!(((float)L_174) < ((float)L_178))))
		{
			goto IL_0351;
		}
	}
	{
		// SplineSample.Lerp(samples[backIndex], samples[index], backProjectDist / backLength, result);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_179 = __this->___samples_0;
		int32_t L_180 = V_9;
		NullCheck(L_179);
		int32_t L_181 = L_180;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_182 = (L_179)->GetAt(static_cast<il2cpp_array_size_t>(L_181));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_183 = __this->___samples_0;
		int32_t L_184 = V_8;
		NullCheck(L_183);
		int32_t L_185 = L_184;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_186 = (L_183)->GetAt(static_cast<il2cpp_array_size_t>(L_185));
		float L_187 = V_15;
		float L_188 = V_13;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_189 = ___2_result;
		SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819(L_182, L_186, ((float)(L_187/L_188)), L_189, NULL);
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(backIndex), GetSamplePercent(index), backProjectDist / backLength);
		int32_t L_190 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_190) == ((uint32_t)1))))
		{
			goto IL_0436;
		}
	}
	{
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(backIndex), GetSamplePercent(index), backProjectDist / backLength);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_191 = ___2_result;
		int32_t L_192 = V_9;
		double L_193;
		L_193 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_192, NULL);
		int32_t L_194 = V_8;
		double L_195;
		L_195 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_194, NULL);
		float L_196 = V_15;
		float L_197 = V_13;
		double L_198;
		L_198 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_193, L_195, ((double)((float)(L_196/L_197))), NULL);
		NullCheck(L_191);
		L_191->___percent_5 = L_198;
		goto IL_0436;
	}

IL_0351:
	{
		// SplineSample.Lerp(samples[frontIndex], samples[index], frontProjectDist / frontLength, result);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_199 = __this->___samples_0;
		int32_t L_200 = V_10;
		NullCheck(L_199);
		int32_t L_201 = L_200;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_202 = (L_199)->GetAt(static_cast<il2cpp_array_size_t>(L_201));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_203 = __this->___samples_0;
		int32_t L_204 = V_8;
		NullCheck(L_203);
		int32_t L_205 = L_204;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_206 = (L_203)->GetAt(static_cast<il2cpp_array_size_t>(L_205));
		float L_207 = V_16;
		float L_208 = V_14;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_209 = ___2_result;
		SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819(L_202, L_206, ((float)(L_207/L_208)), L_209, NULL);
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(frontIndex), GetSamplePercent(index), frontProjectDist / frontLength);
		int32_t L_210 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_210) == ((uint32_t)1))))
		{
			goto IL_0436;
		}
	}
	{
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(frontIndex), GetSamplePercent(index), frontProjectDist / frontLength);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_211 = ___2_result;
		int32_t L_212 = V_10;
		double L_213;
		L_213 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_212, NULL);
		int32_t L_214 = V_8;
		double L_215;
		L_215 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_214, NULL);
		float L_216 = V_16;
		float L_217 = V_14;
		double L_218;
		L_218 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_213, L_215, ((double)((float)(L_216/L_217))), NULL);
		NullCheck(L_211);
		L_211->___percent_5 = L_218;
		goto IL_0436;
	}

IL_03a0:
	{
		// else if (backIndex < index)
		int32_t L_219 = V_9;
		int32_t L_220 = V_8;
		if ((((int32_t)L_219) >= ((int32_t)L_220)))
		{
			goto IL_03ef;
		}
	}
	{
		// SplineSample.Lerp(samples[backIndex], samples[index], backProjectDist / backLength, result);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_221 = __this->___samples_0;
		int32_t L_222 = V_9;
		NullCheck(L_221);
		int32_t L_223 = L_222;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_224 = (L_221)->GetAt(static_cast<il2cpp_array_size_t>(L_223));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_225 = __this->___samples_0;
		int32_t L_226 = V_8;
		NullCheck(L_225);
		int32_t L_227 = L_226;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_228 = (L_225)->GetAt(static_cast<il2cpp_array_size_t>(L_227));
		float L_229 = V_15;
		float L_230 = V_13;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_231 = ___2_result;
		SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819(L_224, L_228, ((float)(L_229/L_230)), L_231, NULL);
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(backIndex), GetSamplePercent(index), backProjectDist / backLength);
		int32_t L_232 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_232) == ((uint32_t)1))))
		{
			goto IL_0436;
		}
	}
	{
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(backIndex), GetSamplePercent(index), backProjectDist / backLength);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_233 = ___2_result;
		int32_t L_234 = V_9;
		double L_235;
		L_235 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_234, NULL);
		int32_t L_236 = V_8;
		double L_237;
		L_237 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_236, NULL);
		float L_238 = V_15;
		float L_239 = V_13;
		double L_240;
		L_240 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_235, L_237, ((double)((float)(L_238/L_239))), NULL);
		NullCheck(L_233);
		L_233->___percent_5 = L_240;
		goto IL_0436;
	}

IL_03ef:
	{
		// SplineSample.Lerp(samples[frontIndex], samples[index], frontProjectDist / frontLength, result);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_241 = __this->___samples_0;
		int32_t L_242 = V_10;
		NullCheck(L_241);
		int32_t L_243 = L_242;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_244 = (L_241)->GetAt(static_cast<il2cpp_array_size_t>(L_243));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_245 = __this->___samples_0;
		int32_t L_246 = V_8;
		NullCheck(L_245);
		int32_t L_247 = L_246;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_248 = (L_245)->GetAt(static_cast<il2cpp_array_size_t>(L_247));
		float L_249 = V_16;
		float L_250 = V_14;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_251 = ___2_result;
		SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819(L_244, L_248, ((float)(L_249/L_250)), L_251, NULL);
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(frontIndex), GetSamplePercent(index), frontProjectDist / frontLength);
		int32_t L_252 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_252) == ((uint32_t)1))))
		{
			goto IL_0436;
		}
	}
	{
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(frontIndex), GetSamplePercent(index), frontProjectDist / frontLength);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_253 = ___2_result;
		int32_t L_254 = V_10;
		double L_255;
		L_255 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_254, NULL);
		int32_t L_256 = V_8;
		double L_257;
		L_257 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, L_256, NULL);
		float L_258 = V_16;
		float L_259 = V_14;
		double L_260;
		L_260 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_255, L_257, ((double)((float)(L_258/L_259))), NULL);
		NullCheck(L_253);
		L_253->___percent_5 = L_260;
	}

IL_0436:
	{
		// if (Count > 1 && from == 0.0 && to == 1.0 && result.percent < samples[1].percent) //Handle looped splines
		int32_t L_261;
		L_261 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_261) <= ((int32_t)1)))
		{
			goto IL_055f;
		}
	}
	{
		double L_262 = ___3_from;
		if ((!(((double)L_262) == ((double)(0.0)))))
		{
			goto IL_055f;
		}
	}
	{
		double L_263 = ___4_to;
		if ((!(((double)L_263) == ((double)(1.0)))))
		{
			goto IL_055f;
		}
	}
	{
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_264 = ___2_result;
		NullCheck(L_264);
		double L_265 = L_264->___percent_5;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_266 = __this->___samples_0;
		NullCheck(L_266);
		int32_t L_267 = 1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_268 = (L_266)->GetAt(static_cast<il2cpp_array_size_t>(L_267));
		NullCheck(L_268);
		double L_269 = L_268->___percent_5;
		if ((!(((double)L_265) < ((double)L_269))))
		{
			goto IL_055f;
		}
	}
	{
		// Vector3 projected = LinearAlgebraUtility.ProjectOnLine(samples[Count - 1].position, samples[Count - 2].position, position);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_270 = __this->___samples_0;
		int32_t L_271;
		L_271 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_270);
		int32_t L_272 = ((int32_t)il2cpp_codegen_subtract(L_271, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_273 = (L_270)->GetAt(static_cast<il2cpp_array_size_t>(L_272));
		NullCheck(L_273);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_274 = L_273->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_275 = __this->___samples_0;
		int32_t L_276;
		L_276 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_275);
		int32_t L_277 = ((int32_t)il2cpp_codegen_subtract(L_276, 2));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_278 = (L_275)->GetAt(static_cast<il2cpp_array_size_t>(L_277));
		NullCheck(L_278);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_279 = L_278->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_280 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_281;
		L_281 = LinearAlgebraUtility_ProjectOnLine_mEC026A5EC230133DF5B0D6C5DCFAB043236D81F6(L_274, L_279, L_280, NULL);
		V_23 = L_281;
		// if ((position - projected).sqrMagnitude < (position - result.position).sqrMagnitude)
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_282 = ___0_position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_283 = V_23;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_284;
		L_284 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_282, L_283, NULL);
		V_17 = L_284;
		float L_285;
		L_285 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_286 = ___0_position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_287 = ___2_result;
		NullCheck(L_287);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_288 = L_287->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_289;
		L_289 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_286, L_288, NULL);
		V_17 = L_289;
		float L_290;
		L_290 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_17), NULL);
		if ((!(((float)L_285) < ((float)L_290))))
		{
			goto IL_055f;
		}
	}
	{
		// double l = LinearAlgebraUtility.InverseLerp(samples[Count - 1].position, samples[Count - 2].position, projected);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_291 = __this->___samples_0;
		int32_t L_292;
		L_292 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_291);
		int32_t L_293 = ((int32_t)il2cpp_codegen_subtract(L_292, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_294 = (L_291)->GetAt(static_cast<il2cpp_array_size_t>(L_293));
		NullCheck(L_294);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_295 = L_294->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_296 = __this->___samples_0;
		int32_t L_297;
		L_297 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_296);
		int32_t L_298 = ((int32_t)il2cpp_codegen_subtract(L_297, 2));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_299 = (L_296)->GetAt(static_cast<il2cpp_array_size_t>(L_298));
		NullCheck(L_299);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_300 = L_299->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_301 = V_23;
		float L_302;
		L_302 = LinearAlgebraUtility_InverseLerp_mF97B35AB1DDDB6785E9E96EAF24768DF07A321F8(L_295, L_300, L_301, NULL);
		V_24 = ((double)L_302);
		// SplineSample.Lerp(samples[Count - 1], samples[Count - 2], l, result);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_303 = __this->___samples_0;
		int32_t L_304;
		L_304 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_303);
		int32_t L_305 = ((int32_t)il2cpp_codegen_subtract(L_304, 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_306 = (L_303)->GetAt(static_cast<il2cpp_array_size_t>(L_305));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_307 = __this->___samples_0;
		int32_t L_308;
		L_308 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		NullCheck(L_307);
		int32_t L_309 = ((int32_t)il2cpp_codegen_subtract(L_308, 2));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_310 = (L_307)->GetAt(static_cast<il2cpp_array_size_t>(L_309));
		double L_311 = V_24;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_312 = ___2_result;
		SplineSample_Lerp_mB500F377220064E5FD7A760E312BAA168A6A7820(L_306, L_310, L_311, L_312, NULL);
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(Count - 1), GetSamplePercent(Count - 2), l);
		int32_t L_313 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_313) == ((uint32_t)1))))
		{
			goto IL_055f;
		}
	}
	{
		// if (sampleMode == SplineComputer.SampleMode.Uniform) result.percent = DMath.Lerp(GetSamplePercent(Count - 1), GetSamplePercent(Count - 2), l);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_314 = ___2_result;
		int32_t L_315;
		L_315 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		double L_316;
		L_316 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, ((int32_t)il2cpp_codegen_subtract(L_315, 1)), NULL);
		int32_t L_317;
		L_317 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		double L_318;
		L_318 = SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A(__this, ((int32_t)il2cpp_codegen_subtract(L_317, 2)), NULL);
		double L_319 = V_24;
		double L_320;
		L_320 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_316, L_318, L_319, NULL);
		NullCheck(L_314);
		L_314->___percent_5 = L_320;
	}

IL_055f:
	{
		// }
		return;
	}
}
// System.Double Dreamteck.Splines.SampleCollection::GetSamplePercent(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SampleCollection_GetSamplePercent_m14EF2E55F4BA196F2779FEFD227FECC2CCCC1A2A (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, int32_t ___0_sampleIndex, const RuntimeMethod* method) 
{
	{
		// if (sampleMode == SplineComputer.SampleMode.Optimized)
		int32_t L_0 = __this->___sampleMode_2;
		if ((!(((uint32_t)L_0) == ((uint32_t)2))))
		{
			goto IL_001e;
		}
	}
	{
		// return samples[optimizedIndices[sampleIndex]].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_1 = __this->___samples_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_2 = __this->___optimizedIndices_1;
		int32_t L_3 = ___0_sampleIndex;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		int32_t L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		NullCheck(L_1);
		int32_t L_6 = L_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		NullCheck(L_7);
		double L_8 = L_7->___percent_5;
		return L_8;
	}

IL_001e:
	{
		// return (double)sampleIndex / (Count - 1);
		int32_t L_9 = ___0_sampleIndex;
		int32_t L_10;
		L_10 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		return ((double)(((double)L_9)/((double)((int32_t)il2cpp_codegen_subtract(L_10, 1)))));
	}
}
// System.Single Dreamteck.Splines.SampleCollection::CalculateLength(System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SampleCollection_CalculateLength_mFB28FF87F0DA7E070A86422376973029586D1AE0 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, double ___0_from, double ___1_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	double V_4 = 0.0;
	int32_t V_5 = 0;
	{
		// if (!hasSamples) return 0f;
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if (!hasSamples) return 0f;
		return (0.0f);
	}

IL_000e:
	{
		// Spline.FormatFromTo(ref from, ref to);
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764((&___0_from), (&___1_to), (bool)1, NULL);
		// float length = 0f;
		V_0 = (0.0f);
		// Vector3 pos = EvaluatePosition(from);
		double L_1 = ___0_from;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C(__this, L_1, NULL);
		V_1 = L_2;
		// GetSamplingValues(from, out fromIndex, out lerp);
		double L_3 = ___0_from;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_3, (&V_2), (&V_4), NULL);
		// GetSamplingValues(to, out toIndex, out lerp);
		double L_4 = ___1_to;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_4, (&V_3), (&V_4), NULL);
		// if (lerp > 0.0 && toIndex < Count - 1)
		double L_5 = V_4;
		if ((!(((double)L_5) > ((double)(0.0)))))
		{
			goto IL_0058;
		}
	}
	{
		int32_t L_6 = V_3;
		int32_t L_7;
		L_7 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_6) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_7, 1)))))
		{
			goto IL_0058;
		}
	}
	{
		// toIndex++;
		int32_t L_8 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0058:
	{
		// for (int i = fromIndex+1; i < toIndex; i++)
		int32_t L_9 = V_2;
		V_5 = ((int32_t)il2cpp_codegen_add(L_9, 1));
		goto IL_008b;
	}

IL_005f:
	{
		// length += Vector3.Distance(samples[i].position, pos);
		float L_10 = V_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_11 = __this->___samples_0;
		int32_t L_12 = V_5;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		NullCheck(L_14);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = L_14->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = V_1;
		float L_17;
		L_17 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_15, L_16, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_10, L_17));
		// pos = samples[i].position;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_18 = __this->___samples_0;
		int32_t L_19 = V_5;
		NullCheck(L_18);
		int32_t L_20 = L_19;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		NullCheck(L_21);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = L_21->___position_0;
		V_1 = L_22;
		// for (int i = fromIndex+1; i < toIndex; i++)
		int32_t L_23 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_23, 1));
	}

IL_008b:
	{
		// for (int i = fromIndex+1; i < toIndex; i++)
		int32_t L_24 = V_5;
		int32_t L_25 = V_3;
		if ((((int32_t)L_24) < ((int32_t)L_25)))
		{
			goto IL_005f;
		}
	}
	{
		// length += Vector3.Distance(EvaluatePosition(to), pos);
		float L_26 = V_0;
		double L_27 = ___1_to;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = SampleCollection_EvaluatePosition_m657E6D6DFA6A4D270FCB1055A0238EF628CD2E7C(__this, L_27, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = V_1;
		float L_30;
		L_30 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_28, L_29, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_26, L_30));
		// return length;
		float L_31 = V_0;
		return L_31;
	}
}
// System.Single Dreamteck.Splines.SampleCollection::CalculateLengthWithOffset(UnityEngine.Vector3,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SampleCollection_CalculateLengthWithOffset_mEE1336EA143DB9FC520FB560C1455A9064278B51 (SampleCollection_t3EA269B873F0BF058D32A74365E643ADA98B2C82* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_offset, double ___1_from, double ___2_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	double V_4 = 0.0;
	int32_t V_5 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_6;
	memset((&V_6), 0, sizeof(V_6));
	{
		// if (!hasSamples) return 0f;
		bool L_0;
		L_0 = SampleCollection_get_hasSamples_m82C04E5337EC6975F1B8ED18BFE0FEB6BCBE59F6(__this, NULL);
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if (!hasSamples) return 0f;
		return (0.0f);
	}

IL_000e:
	{
		// Spline.FormatFromTo(ref from, ref to);
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764((&___1_from), (&___2_to), (bool)1, NULL);
		// float length = 0f;
		V_0 = (0.0f);
		// Evaluate(from, _workSample);
		double L_1 = ___1_from;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = __this->____workSample_3;
		SampleCollection_Evaluate_mE67F0879D5C0755347AA1C1D7D2D08B22B3044A1(__this, L_1, L_2, NULL);
		// Vector3 pos = _workSample.position + _workSample.up * (offset.y * _workSample.size) + _workSample.right * (offset.x * _workSample.size) + _workSample.forward * (offset.z * _workSample.size);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_3 = __this->____workSample_3;
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = L_3->___position_0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_5 = __this->____workSample_3;
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = L_5->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = ___0_offset;
		float L_8 = L_7.___y_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_9 = __this->____workSample_3;
		NullCheck(L_9);
		float L_10 = L_9->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11;
		L_11 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_6, ((float)il2cpp_codegen_multiply(L_8, L_10)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_4, L_11, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_13 = __this->____workSample_3;
		NullCheck(L_13);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_13, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = ___0_offset;
		float L_16 = L_15.___x_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_17 = __this->____workSample_3;
		NullCheck(L_17);
		float L_18 = L_17->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_14, ((float)il2cpp_codegen_multiply(L_16, L_18)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_12, L_19, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_21 = __this->____workSample_3;
		NullCheck(L_21);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = L_21->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = ___0_offset;
		float L_24 = L_23.___z_4;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_25 = __this->____workSample_3;
		NullCheck(L_25);
		float L_26 = L_25->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_22, ((float)il2cpp_codegen_multiply(L_24, L_26)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_20, L_27, NULL);
		V_1 = L_28;
		// GetSamplingValues(from, out fromIndex, out lerp);
		double L_29 = ___1_from;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_29, (&V_2), (&V_4), NULL);
		// GetSamplingValues(to, out toIndex, out lerp);
		double L_30 = ___2_to;
		SampleCollection_GetSamplingValues_m9555C5FEA04BFB6D155EBC2697AE2480D25D14B8(__this, L_30, (&V_3), (&V_4), NULL);
		// if (lerp > 0.0 && toIndex < Count - 1)
		double L_31 = V_4;
		if ((!(((double)L_31) > ((double)(0.0)))))
		{
			goto IL_00de;
		}
	}
	{
		int32_t L_32 = V_3;
		int32_t L_33;
		L_33 = SampleCollection_get_Count_m09B946EDE61F7A4875B7AC351F63E3C5AE1047D8(__this, NULL);
		if ((((int32_t)L_32) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_33, 1)))))
		{
			goto IL_00de;
		}
	}
	{
		// toIndex++;
		int32_t L_34 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_00de:
	{
		// for (int i = fromIndex + 1; i < toIndex; i++)
		int32_t L_35 = V_2;
		V_5 = ((int32_t)il2cpp_codegen_add(L_35, 1));
		goto IL_0193;
	}

IL_00e8:
	{
		// Vector3 newPos = samples[i].position + samples[i].up * (offset.y * samples[i].size) + samples[i].right * (offset.x * samples[i].size) + samples[i].forward * (offset.z * samples[i].size);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_36 = __this->___samples_0;
		int32_t L_37 = V_5;
		NullCheck(L_36);
		int32_t L_38 = L_37;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_39 = (L_36)->GetAt(static_cast<il2cpp_array_size_t>(L_38));
		NullCheck(L_39);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = L_39->___position_0;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_41 = __this->___samples_0;
		int32_t L_42 = V_5;
		NullCheck(L_41);
		int32_t L_43 = L_42;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_44 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_43));
		NullCheck(L_44);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45 = L_44->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46 = ___0_offset;
		float L_47 = L_46.___y_3;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_48 = __this->___samples_0;
		int32_t L_49 = V_5;
		NullCheck(L_48);
		int32_t L_50 = L_49;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_51 = (L_48)->GetAt(static_cast<il2cpp_array_size_t>(L_50));
		NullCheck(L_51);
		float L_52 = L_51->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53;
		L_53 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_45, ((float)il2cpp_codegen_multiply(L_47, L_52)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54;
		L_54 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_40, L_53, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_55 = __this->___samples_0;
		int32_t L_56 = V_5;
		NullCheck(L_55);
		int32_t L_57 = L_56;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_58 = (L_55)->GetAt(static_cast<il2cpp_array_size_t>(L_57));
		NullCheck(L_58);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59;
		L_59 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_58, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_60 = ___0_offset;
		float L_61 = L_60.___x_2;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_62 = __this->___samples_0;
		int32_t L_63 = V_5;
		NullCheck(L_62);
		int32_t L_64 = L_63;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		NullCheck(L_65);
		float L_66 = L_65->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_67;
		L_67 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_59, ((float)il2cpp_codegen_multiply(L_61, L_66)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68;
		L_68 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_54, L_67, NULL);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_69 = __this->___samples_0;
		int32_t L_70 = V_5;
		NullCheck(L_69);
		int32_t L_71 = L_70;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_72 = (L_69)->GetAt(static_cast<il2cpp_array_size_t>(L_71));
		NullCheck(L_72);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_73 = L_72->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_74 = ___0_offset;
		float L_75 = L_74.___z_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_76 = __this->___samples_0;
		int32_t L_77 = V_5;
		NullCheck(L_76);
		int32_t L_78 = L_77;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_79 = (L_76)->GetAt(static_cast<il2cpp_array_size_t>(L_78));
		NullCheck(L_79);
		float L_80 = L_79->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81;
		L_81 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_73, ((float)il2cpp_codegen_multiply(L_75, L_80)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82;
		L_82 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_68, L_81, NULL);
		V_6 = L_82;
		// length += Vector3.Distance(newPos, pos);
		float L_83 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_84 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_85 = V_1;
		float L_86;
		L_86 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_84, L_85, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_83, L_86));
		// pos = newPos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_87 = V_6;
		V_1 = L_87;
		// for (int i = fromIndex + 1; i < toIndex; i++)
		int32_t L_88 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_88, 1));
	}

IL_0193:
	{
		// for (int i = fromIndex + 1; i < toIndex; i++)
		int32_t L_89 = V_5;
		int32_t L_90 = V_3;
		if ((((int32_t)L_89) < ((int32_t)L_90)))
		{
			goto IL_00e8;
		}
	}
	{
		// Evaluate(to, _workSample);
		double L_91 = ___2_to;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_92 = __this->____workSample_3;
		SampleCollection_Evaluate_mE67F0879D5C0755347AA1C1D7D2D08B22B3044A1(__this, L_91, L_92, NULL);
		// _workSample.position += _workSample.up * (offset.y * _workSample.size) + _workSample.right * (offset.x * _workSample.size) + _workSample.forward * (offset.z * _workSample.size);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_93 = __this->____workSample_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_94 = L_93;
		NullCheck(L_94);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_95 = L_94->___position_0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_96 = __this->____workSample_3;
		NullCheck(L_96);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_97 = L_96->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_98 = ___0_offset;
		float L_99 = L_98.___y_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_100 = __this->____workSample_3;
		NullCheck(L_100);
		float L_101 = L_100->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_102;
		L_102 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_97, ((float)il2cpp_codegen_multiply(L_99, L_101)), NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_103 = __this->____workSample_3;
		NullCheck(L_103);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_104;
		L_104 = SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236(L_103, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_105 = ___0_offset;
		float L_106 = L_105.___x_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_107 = __this->____workSample_3;
		NullCheck(L_107);
		float L_108 = L_107->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_109;
		L_109 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_104, ((float)il2cpp_codegen_multiply(L_106, L_108)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_110;
		L_110 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_102, L_109, NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_111 = __this->____workSample_3;
		NullCheck(L_111);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_112 = L_111->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_113 = ___0_offset;
		float L_114 = L_113.___z_4;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_115 = __this->____workSample_3;
		NullCheck(L_115);
		float L_116 = L_115->___size_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_117;
		L_117 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_112, ((float)il2cpp_codegen_multiply(L_114, L_116)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_118;
		L_118 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_110, L_117, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_119;
		L_119 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_95, L_118, NULL);
		NullCheck(L_94);
		L_94->___position_0 = L_119;
		// length += Vector3.Distance(_workSample.position, pos);
		float L_120 = V_0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_121 = __this->____workSample_3;
		NullCheck(L_121);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_122 = L_121->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_123 = V_1;
		float L_124;
		L_124 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_122, L_123, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_120, L_124));
		// return length;
		float L_125 = V_0;
		return L_125;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean Dreamteck.Splines.Spline::get_isClosed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Spline_get_isClosed_mB39B7FC6A3652689E85F01A857B496D41201374A (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) 
{
	{
		// return closed && points.Length >= 4;
		bool L_0 = __this->___closed_1;
		if (!L_0)
		{
			goto IL_0017;
		}
	}
	{
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_1 = __this->___points_0;
		NullCheck(L_1);
		return (bool)((((int32_t)((((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length))) < ((int32_t)4))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}

IL_0017:
	{
		return (bool)0;
	}
}
// System.Void Dreamteck.Splines.Spline::set_isClosed(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_set_isClosed_m781B873C7E25BF27FD954BC6EF8595F5F580F099 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		// set { }
		return;
	}
}
// System.Double Dreamteck.Splines.Spline::get_moveStep()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) 
{
	{
		// if (type == Type.Linear) return 1f / (points.Length-1);
		int32_t L_0 = __this->___type_2;
		if ((!(((uint32_t)L_0) == ((uint32_t)3))))
		{
			goto IL_001c;
		}
	}
	{
		// if (type == Type.Linear) return 1f / (points.Length-1);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_1 = __this->___points_0;
		NullCheck(L_1);
		return ((double)((float)((1.0f)/((float)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_1)->max_length)), 1))))));
	}

IL_001c:
	{
		// return 1f / (iterations-1);
		int32_t L_2;
		L_2 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		return ((double)((float)((1.0f)/((float)((int32_t)il2cpp_codegen_subtract(L_2, 1))))));
	}
}
// System.Void Dreamteck.Splines.Spline::set_moveStep(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_set_moveStep_m98FD35B24A9B64E2E0A6CC15F98F93D0CC85D0D9 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_value, const RuntimeMethod* method) 
{
	{
		// set { }
		return;
	}
}
// System.Int32 Dreamteck.Splines.Spline::get_iterations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) 
{
	{
		// if (type == Type.Linear) return points.Length;
		int32_t L_0 = __this->___type_2;
		if ((!(((uint32_t)L_0) == ((uint32_t)3))))
		{
			goto IL_0012;
		}
	}
	{
		// if (type == Type.Linear) return points.Length;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_1 = __this->___points_0;
		NullCheck(L_1);
		return ((int32_t)(((RuntimeArray*)L_1)->max_length));
	}

IL_0012:
	{
		// return sampleRate * (points.Length - 1) - (points.Length-1) + 1;
		int32_t L_2 = __this->___sampleRate_6;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_3 = __this->___points_0;
		NullCheck(L_3);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		NullCheck(L_4);
		return ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_multiply(L_2, ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_3)->max_length)), 1)))), ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_4)->max_length)), 1)))), 1));
	}
}
// System.Void Dreamteck.Splines.Spline::.ctor(Dreamteck.Splines.Spline/Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline__ctor_mEE7F0C55383C668B358CD553918FFFD18FB974D2 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_type, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public SplinePoint[] points = new SplinePoint[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = (SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)SZArrayNew(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___points_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___points_0), (void*)L_0);
		// public Type type = Type.Bezier;
		__this->___type_2 = 2;
		// public bool linearAverageDirection = true;
		__this->___linearAverageDirection_3 = (bool)1;
		// public int sampleRate = 10;
		__this->___sampleRate_6 = ((int32_t)10);
		// public Spline(Type type){
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// this.type = type;
		int32_t L_1 = ___0_type;
		__this->___type_2 = L_1;
		// points = new SplinePoint[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = (SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)SZArrayNew(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___points_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___points_0), (void*)L_2);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::.ctor(Dreamteck.Splines.Spline/Type,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline__ctor_m5DD3AEB730AC7F00E14344C53858CCD083361EEE (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_type, int32_t ___1_sampleRate, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public SplinePoint[] points = new SplinePoint[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = (SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)SZArrayNew(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___points_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___points_0), (void*)L_0);
		// public Type type = Type.Bezier;
		__this->___type_2 = 2;
		// public bool linearAverageDirection = true;
		__this->___linearAverageDirection_3 = (bool)1;
		// public int sampleRate = 10;
		__this->___sampleRate_6 = ((int32_t)10);
		// public Spline(Type type, int sampleRate)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// this.type = type;
		int32_t L_1 = ___0_type;
		__this->___type_2 = L_1;
		// this.sampleRate = sampleRate;
		int32_t L_2 = ___1_sampleRate;
		__this->___sampleRate_6 = L_2;
		// points = new SplinePoint[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_3 = (SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)SZArrayNew(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___points_0 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___points_0), (void*)L_3);
		// }
		return;
	}
}
// System.Single Dreamteck.Splines.Spline::CalculateLength(System.Double,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Spline_CalculateLength_m787BB23CD4D7E8E9A11DC60F88A2C0E88768DE77 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_from, double ___1_to, double ___2_resolution, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	float V_2 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_3;
	memset((&V_3), 0, sizeof(V_3));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	{
		// if (points.Length == 0) return 0f;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_000f;
		}
	}
	{
		// if (points.Length == 0) return 0f;
		return (0.0f);
	}

IL_000f:
	{
		// resolution = DMath.Clamp01(resolution);
		double L_1 = ___2_resolution;
		double L_2;
		L_2 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_1, NULL);
		___2_resolution = L_2;
		// if (resolution == 0.0) return 0f;
		double L_3 = ___2_resolution;
		if ((!(((double)L_3) == ((double)(0.0)))))
		{
			goto IL_0029;
		}
	}
	{
		// if (resolution == 0.0) return 0f;
		return (0.0f);
	}

IL_0029:
	{
		// from = DMath.Clamp01(from);
		double L_4 = ___0_from;
		double L_5;
		L_5 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_4, NULL);
		___0_from = L_5;
		// to = DMath.Clamp01(to);
		double L_6 = ___1_to;
		double L_7;
		L_7 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_6, NULL);
		___1_to = L_7;
		// if (to < from) to = from;
		double L_8 = ___1_to;
		double L_9 = ___0_from;
		if ((!(((double)L_8) < ((double)L_9))))
		{
			goto IL_0040;
		}
	}
	{
		// if (to < from) to = from;
		double L_10 = ___0_from;
		___1_to = L_10;
	}

IL_0040:
	{
		// double percent = from;
		double L_11 = ___0_from;
		V_0 = L_11;
		// Vector3 lastPos = EvaluatePosition(percent);
		double L_12 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13;
		L_13 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_12, NULL);
		V_1 = L_13;
		// float sum = 0f;
		V_2 = (0.0f);
	}

IL_0050:
	{
		// percent = DMath.Move(percent, to, moveStep / resolution);
		double L_14 = V_0;
		double L_15 = ___1_to;
		double L_16;
		L_16 = Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91(__this, NULL);
		double L_17 = ___2_resolution;
		double L_18;
		L_18 = DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA(L_14, L_15, ((double)(L_16/L_17)), NULL);
		V_0 = L_18;
		// Vector3 pos = EvaluatePosition(percent);
		double L_19 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_19, NULL);
		V_3 = L_20;
		// sum += (pos - lastPos).magnitude;
		float L_21 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_22, L_23, NULL);
		V_4 = L_24;
		float L_25;
		L_25 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_4), NULL);
		V_2 = ((float)il2cpp_codegen_add(L_21, L_25));
		// lastPos = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = V_3;
		V_1 = L_26;
		// if (percent == to) break;
		double L_27 = V_0;
		double L_28 = ___1_to;
		if ((!(((double)L_27) == ((double)L_28))))
		{
			goto IL_0050;
		}
	}
	{
		// return sum;
		float L_29 = V_2;
		return L_29;
	}
}
// System.Double Dreamteck.Splines.Spline::Project(UnityEngine.Vector3,System.Int32,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_Project_mCA21177B76931DECEF87A1F90923788475AE6615 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_position, int32_t ___1_subdivide, double ___2_from, double ___3_to, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	double V_1 = 0.0;
	{
		// if (points.Length == 0) return 0.0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0013;
		}
	}
	{
		// if (points.Length == 0) return 0.0;
		return (0.0);
	}

IL_0013:
	{
		// if (closed && from == 0.0 && to == 1.0) //Handle looped splines
		bool L_1 = __this->___closed_1;
		if (!L_1)
		{
			goto IL_00c2;
		}
	}
	{
		double L_2 = ___2_from;
		if ((!(((double)L_2) == ((double)(0.0)))))
		{
			goto IL_00c2;
		}
	}
	{
		double L_3 = ___3_to;
		if ((!(((double)L_3) == ((double)(1.0)))))
		{
			goto IL_00c2;
		}
	}
	{
		// double closest = GetClosestPoint(subdivide, position, from, to, Mathf.RoundToInt(Mathf.Max(iterations / points.Length, 10)) * 5);
		int32_t L_4 = ___1_subdivide;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = ___0_position;
		double L_6 = ___2_from;
		double L_7 = ___3_to;
		int32_t L_8;
		L_8 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_9 = __this->___points_0;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(((int32_t)(L_8/((int32_t)(((RuntimeArray*)L_9)->max_length)))), ((int32_t)10), NULL);
		int32_t L_11;
		L_11 = Mathf_RoundToInt_m60F8B66CF27F1FA75AA219342BD184B75771EB4B_inline(((float)L_10), NULL);
		double L_12;
		L_12 = Spline_GetClosestPoint_mF5C6AB0488DCE8AB8DDEC400D85555CCF15780C5(__this, L_4, L_5, L_6, L_7, ((int32_t)il2cpp_codegen_multiply(L_11, 5)), NULL);
		V_0 = L_12;
		// if (closest < moveStep)
		double L_13 = V_0;
		double L_14;
		L_14 = Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91(__this, NULL);
		if ((!(((double)L_13) < ((double)L_14))))
		{
			goto IL_00c0;
		}
	}
	{
		// double nextClosest = GetClosestPoint(subdivide, position, 0.5, to, Mathf.RoundToInt(Mathf.Max(iterations / points.Length, 10)) * 5);
		int32_t L_15 = ___1_subdivide;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ___0_position;
		double L_17 = ___3_to;
		int32_t L_18;
		L_18 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_19 = __this->___points_0;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(((int32_t)(L_18/((int32_t)(((RuntimeArray*)L_19)->max_length)))), ((int32_t)10), NULL);
		int32_t L_21;
		L_21 = Mathf_RoundToInt_m60F8B66CF27F1FA75AA219342BD184B75771EB4B_inline(((float)L_20), NULL);
		double L_22;
		L_22 = Spline_GetClosestPoint_mF5C6AB0488DCE8AB8DDEC400D85555CCF15780C5(__this, L_15, L_16, (0.5), L_17, ((int32_t)il2cpp_codegen_multiply(L_21, 5)), NULL);
		V_1 = L_22;
		// if (Vector3.Distance(position, EvaluatePosition(nextClosest)) < Vector3.Distance(position, EvaluatePosition(closest))) return nextClosest;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = ___0_position;
		double L_24 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_24, NULL);
		float L_26;
		L_26 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_23, L_25, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27 = ___0_position;
		double L_28 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_28, NULL);
		float L_30;
		L_30 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_27, L_29, NULL);
		if ((!(((float)L_26) < ((float)L_30))))
		{
			goto IL_00c0;
		}
	}
	{
		// if (Vector3.Distance(position, EvaluatePosition(nextClosest)) < Vector3.Distance(position, EvaluatePosition(closest))) return nextClosest;
		double L_31 = V_1;
		return L_31;
	}

IL_00c0:
	{
		// return closest;
		double L_32 = V_0;
		return L_32;
	}

IL_00c2:
	{
		// return GetClosestPoint(subdivide, position, from, to, Mathf.RoundToInt(Mathf.Max(iterations / points.Length, 10)) * 5);
		int32_t L_33 = ___1_subdivide;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34 = ___0_position;
		double L_35 = ___2_from;
		double L_36 = ___3_to;
		int32_t L_37;
		L_37 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_38 = __this->___points_0;
		NullCheck(L_38);
		int32_t L_39;
		L_39 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(((int32_t)(L_37/((int32_t)(((RuntimeArray*)L_38)->max_length)))), ((int32_t)10), NULL);
		int32_t L_40;
		L_40 = Mathf_RoundToInt_m60F8B66CF27F1FA75AA219342BD184B75771EB4B_inline(((float)L_39), NULL);
		double L_41;
		L_41 = Spline_GetClosestPoint_mF5C6AB0488DCE8AB8DDEC400D85555CCF15780C5(__this, L_33, L_34, L_35, L_36, ((int32_t)il2cpp_codegen_multiply(L_40, 5)), NULL);
		return L_41;
	}
}
// System.Boolean Dreamteck.Splines.Spline::Raycast(UnityEngine.RaycastHit&,System.Double&,UnityEngine.LayerMask,System.Double,System.Double,System.Double,UnityEngine.QueryTriggerInteraction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Spline_Raycast_mDAB8FFA09FBC3125AF8AE2FA7CB2A33BD71C3348 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* ___0_hit, double* ___1_hitPercent, LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB ___2_layerMask, double ___3_resolution, double ___4_from, double ___5_to, int32_t ___6_hitTriggers, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	double V_2 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_3;
	memset((&V_3), 0, sizeof(V_3));
	double V_4 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_5;
	memset((&V_5), 0, sizeof(V_5));
	{
		// resolution = DMath.Clamp01(resolution);
		double L_0 = ___3_resolution;
		double L_1;
		L_1 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_0, NULL);
		___3_resolution = L_1;
		// from = DMath.Clamp01(from);
		double L_2 = ___4_from;
		double L_3;
		L_3 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_2, NULL);
		___4_from = L_3;
		// to = DMath.Clamp01(to);
		double L_4 = ___5_to;
		double L_5;
		L_5 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_4, NULL);
		___5_to = L_5;
		// double percent = from;
		double L_6 = ___4_from;
		V_0 = L_6;
		// Vector3 fromPos = EvaluatePosition(percent);
		double L_7 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_7, NULL);
		V_1 = L_8;
		// hitPercent = 0f;
		double* L_9 = ___1_hitPercent;
		*((double*)L_9) = (double)(0.0);
		// if (resolution == 0f)
		double L_10 = ___3_resolution;
		if ((!(((double)L_10) == ((double)(0.0)))))
		{
			goto IL_0052;
		}
	}
	{
		// hit = new RaycastHit();
		RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* L_11 = ___0_hit;
		il2cpp_codegen_initobj(L_11, sizeof(RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5));
		// hitPercent = 0f;
		double* L_12 = ___1_hitPercent;
		*((double*)L_12) = (double)(0.0);
		// return false;
		return (bool)0;
	}

IL_0052:
	{
		// double prevPercent = percent;
		double L_13 = V_0;
		V_2 = L_13;
		// percent = DMath.Move(percent, to, moveStep / resolution);
		double L_14 = V_0;
		double L_15 = ___5_to;
		double L_16;
		L_16 = Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91(__this, NULL);
		double L_17 = ___3_resolution;
		double L_18;
		L_18 = DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA(L_14, L_15, ((double)(L_16/L_17)), NULL);
		V_0 = L_18;
		// Vector3 toPos = EvaluatePosition(percent);
		double L_19 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_19, NULL);
		V_3 = L_20;
		// if (Physics.Linecast(fromPos, toPos, out hit, layerMask, hitTriggers))
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = V_3;
		RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* L_23 = ___0_hit;
		LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB L_24 = ___2_layerMask;
		int32_t L_25;
		L_25 = LayerMask_op_Implicit_m7F5A5B9D079281AC445ED39DEE1FCFA9D795810D(L_24, NULL);
		int32_t L_26 = ___6_hitTriggers;
		bool L_27;
		L_27 = Physics_Linecast_m399C6C11AD7ECE11241A37C08BAB4D97CF3CB925(L_21, L_22, L_23, L_25, L_26, NULL);
		if (!L_27)
		{
			goto IL_00b6;
		}
	}
	{
		// double segmentPercent = (hit.point - fromPos).sqrMagnitude / (toPos - fromPos).sqrMagnitude;
		RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5* L_28 = ___0_hit;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = RaycastHit_get_point_m02B764612562AFE0F998CC7CFB2EEDE41BA47F39(L_28, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_29, L_30, NULL);
		V_5 = L_31;
		float L_32;
		L_32 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_5), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35;
		L_35 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_33, L_34, NULL);
		V_5 = L_35;
		float L_36;
		L_36 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_5), NULL);
		V_4 = ((double)((float)(L_32/L_36)));
		// hitPercent = DMath.Lerp(prevPercent, percent, segmentPercent);
		double* L_37 = ___1_hitPercent;
		double L_38 = V_2;
		double L_39 = V_0;
		double L_40 = V_4;
		double L_41;
		L_41 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_38, L_39, L_40, NULL);
		*((double*)L_37) = (double)L_41;
		// return true;
		return (bool)1;
	}

IL_00b6:
	{
		// fromPos = toPos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42 = V_3;
		V_1 = L_42;
		// if (percent == to) break;
		double L_43 = V_0;
		double L_44 = ___5_to;
		if ((!(((double)L_43) == ((double)L_44))))
		{
			goto IL_0052;
		}
	}
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean Dreamteck.Splines.Spline::RaycastAll(UnityEngine.RaycastHit[]&,System.Double[]&,UnityEngine.LayerMask,System.Double,System.Double,System.Double,UnityEngine.QueryTriggerInteraction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Spline_RaycastAll_m058ACBEAD1B512363054BB0F9DC4F183DE0C19DB (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8** ___0_hits, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** ___1_hitPercents, LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB ___2_layerMask, double ___3_resolution, double ___4_from, double ___5_to, int32_t ___6_hitTriggers, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t495F03F47D827883530F951D563C0BB7340E5995_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* V_2 = NULL;
	List_1_t495F03F47D827883530F951D563C0BB7340E5995* V_3 = NULL;
	bool V_4 = false;
	double V_5 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_6;
	memset((&V_6), 0, sizeof(V_6));
	RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* V_7 = NULL;
	int32_t V_8 = 0;
	double V_9 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_10;
	memset((&V_10), 0, sizeof(V_10));
	{
		// resolution = DMath.Clamp01(resolution);
		double L_0 = ___3_resolution;
		double L_1;
		L_1 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_0, NULL);
		___3_resolution = L_1;
		// from = DMath.Clamp01(from);
		double L_2 = ___4_from;
		double L_3;
		L_3 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_2, NULL);
		___4_from = L_3;
		// to = DMath.Clamp01(to);
		double L_4 = ___5_to;
		double L_5;
		L_5 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_4, NULL);
		___5_to = L_5;
		// double percent = from;
		double L_6 = ___4_from;
		V_0 = L_6;
		// Vector3 fromPos = EvaluatePosition(percent);
		double L_7 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_7, NULL);
		V_1 = L_8;
		// List<RaycastHit> hitList = new List<RaycastHit>();
		List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* L_9 = (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9*)il2cpp_codegen_object_new(List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9_il2cpp_TypeInfo_var);
		NullCheck(L_9);
		List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC(L_9, List_1__ctor_m7715EBA40C1E9928D580B0D503FA394AB9503EFC_RuntimeMethod_var);
		V_2 = L_9;
		// List<double> percentList = new List<double>();
		List_1_t495F03F47D827883530F951D563C0BB7340E5995* L_10 = (List_1_t495F03F47D827883530F951D563C0BB7340E5995*)il2cpp_codegen_object_new(List_1_t495F03F47D827883530F951D563C0BB7340E5995_il2cpp_TypeInfo_var);
		NullCheck(L_10);
		List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34(L_10, List_1__ctor_m4F495AFEC1141AA7E02729E3105CB569F2CEAD34_RuntimeMethod_var);
		V_3 = L_10;
		// if (resolution == 0f)
		double L_11 = ___3_resolution;
		if ((!(((double)L_11) == ((double)(0.0)))))
		{
			goto IL_0051;
		}
	}
	{
		// hits = new RaycastHit[0];
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8** L_12 = ___0_hits;
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_13 = (RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8*)(RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8*)SZArrayNew(RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_12) = (RuntimeObject*)L_13;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_12, (void*)(RuntimeObject*)L_13);
		// hitPercents = new double[0];
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_14 = ___1_hitPercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_15 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_14) = (RuntimeObject*)L_15;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_14, (void*)(RuntimeObject*)L_15);
		// return false;
		return (bool)0;
	}

IL_0051:
	{
		// bool hasHit = false;
		V_4 = (bool)0;
	}

IL_0054:
	{
		// double prevPercent = percent;
		double L_16 = V_0;
		V_5 = L_16;
		// percent = DMath.Move(percent, to, moveStep / resolution);
		double L_17 = V_0;
		double L_18 = ___5_to;
		double L_19;
		L_19 = Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91(__this, NULL);
		double L_20 = ___3_resolution;
		double L_21;
		L_21 = DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA(L_17, L_18, ((double)(L_19/L_20)), NULL);
		V_0 = L_21;
		// Vector3 toPos = EvaluatePosition(percent);
		double L_22 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		L_23 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_22, NULL);
		V_6 = L_23;
		// RaycastHit[] h = Physics.RaycastAll(fromPos, toPos - fromPos, Vector3.Distance(fromPos, toPos), layerMask, hitTriggers);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_25, L_26, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = V_6;
		float L_30;
		L_30 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_28, L_29, NULL);
		LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB L_31 = ___2_layerMask;
		int32_t L_32;
		L_32 = LayerMask_op_Implicit_m7F5A5B9D079281AC445ED39DEE1FCFA9D795810D(L_31, NULL);
		int32_t L_33 = ___6_hitTriggers;
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_34;
		L_34 = Physics_RaycastAll_m8B7FB8419A65BEE78927D0EE84916E8DBE7ECD34(L_24, L_27, L_30, L_32, L_33, NULL);
		V_7 = L_34;
		// for (int i = 0; i < h.Length; i++)
		V_8 = 0;
		goto IL_00f1;
	}

IL_0097:
	{
		// hasHit = true;
		V_4 = (bool)1;
		// double segmentPercent = (h[i].point - fromPos).sqrMagnitude / (toPos - fromPos).sqrMagnitude;
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_35 = V_7;
		int32_t L_36 = V_8;
		NullCheck(L_35);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = RaycastHit_get_point_m02B764612562AFE0F998CC7CFB2EEDE41BA47F39(((L_35)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_36))), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39;
		L_39 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_37, L_38, NULL);
		V_10 = L_39;
		float L_40;
		L_40 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_10), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_43;
		L_43 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_41, L_42, NULL);
		V_10 = L_43;
		float L_44;
		L_44 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_10), NULL);
		V_9 = ((double)((float)(L_40/L_44)));
		// percentList.Add(DMath.Lerp(prevPercent, percent, segmentPercent));
		List_1_t495F03F47D827883530F951D563C0BB7340E5995* L_45 = V_3;
		double L_46 = V_5;
		double L_47 = V_0;
		double L_48 = V_9;
		double L_49;
		L_49 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_46, L_47, L_48, NULL);
		NullCheck(L_45);
		List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_inline(L_45, L_49, List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_RuntimeMethod_var);
		// hitList.Add(h[i]);
		List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* L_50 = V_2;
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_51 = V_7;
		int32_t L_52 = V_8;
		NullCheck(L_51);
		int32_t L_53 = L_52;
		RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 L_54 = (L_51)->GetAt(static_cast<il2cpp_array_size_t>(L_53));
		NullCheck(L_50);
		List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_inline(L_50, L_54, List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_RuntimeMethod_var);
		// for (int i = 0; i < h.Length; i++)
		int32_t L_55 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_55, 1));
	}

IL_00f1:
	{
		// for (int i = 0; i < h.Length; i++)
		int32_t L_56 = V_8;
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_57 = V_7;
		NullCheck(L_57);
		if ((((int32_t)L_56) < ((int32_t)((int32_t)(((RuntimeArray*)L_57)->max_length)))))
		{
			goto IL_0097;
		}
	}
	{
		// fromPos = toPos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58 = V_6;
		V_1 = L_58;
		// if (percent == to) break;
		double L_59 = V_0;
		double L_60 = ___5_to;
		if ((!(((double)L_59) == ((double)L_60))))
		{
			goto IL_0054;
		}
	}
	{
		// hits = hitList.ToArray();
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8** L_61 = ___0_hits;
		List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* L_62 = V_2;
		NullCheck(L_62);
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_63;
		L_63 = List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797(L_62, List_1_ToArray_mF57EFCD6CC572B292F7FCC3CE18ABDD4CA808797_RuntimeMethod_var);
		*((RuntimeObject**)L_61) = (RuntimeObject*)L_63;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_61, (void*)(RuntimeObject*)L_63);
		// hitPercents = percentList.ToArray();
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_64 = ___1_hitPercents;
		List_1_t495F03F47D827883530F951D563C0BB7340E5995* L_65 = V_3;
		NullCheck(L_65);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_66;
		L_66 = List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3(L_65, List_1_ToArray_m91B6A76F83EF0F01FE14A5BAD9D99BDDFC9499F3_RuntimeMethod_var);
		*((RuntimeObject**)L_64) = (RuntimeObject*)L_66;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_64, (void*)(RuntimeObject*)L_66);
		// return hasHit;
		bool L_67 = V_4;
		return L_67;
	}
}
// System.Double Dreamteck.Splines.Spline::GetPointPercent(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_GetPointPercent_mD3E8CF895C8F0C0A4DE9AB262479A25B3253F9E5 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_pointIndex, const RuntimeMethod* method) 
{
	{
		// return DMath.Clamp01((double)pointIndex / (points.Length - 1));
		int32_t L_0 = ___0_pointIndex;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_1 = __this->___points_0;
		NullCheck(L_1);
		double L_2;
		L_2 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(((double)(((double)L_0)/((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_1)->max_length)), 1))))), NULL);
		return L_2;
	}
}
// UnityEngine.Vector3 Dreamteck.Splines.Spline::EvaluatePosition(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_percent, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// if (points.Length == 0) return Vector3.zero;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_000f;
		}
	}
	{
		// if (points.Length == 0) return Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		return L_1;
	}

IL_000f:
	{
		// Vector3 point = new Vector3();
		il2cpp_codegen_initobj((&V_0), sizeof(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2));
		// EvaluatePosition(ref point, percent);
		double L_2 = ___0_percent;
		Spline_EvaluatePosition_m7312161C2C2CF4DA1EDBEFD4F0B3E65FB54707CD(__this, (&V_0), L_2, NULL);
		// return point;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = V_0;
		return L_3;
	}
}
// Dreamteck.Splines.SplineSample Dreamteck.Splines.Spline::Evaluate(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* Spline_Evaluate_m7E6845261066AD52B8EB7367C904584C8AE5BFB6 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_percent, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* V_0 = NULL;
	{
		// SplineSample result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_0, NULL);
		V_0 = L_0;
		// Evaluate(result, percent);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = V_0;
		double L_2 = ___0_percent;
		Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC(__this, L_1, L_2, NULL);
		// return result;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_3 = V_0;
		return L_3;
	}
}
// Dreamteck.Splines.SplineSample Dreamteck.Splines.Spline::Evaluate(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* Spline_Evaluate_m4E9331985D63428E43D84C0A8F3165E9654F2DC1 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_pointIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* V_0 = NULL;
	{
		// SplineSample result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_0, NULL);
		V_0 = L_0;
		// Evaluate(result, GetPointPercent(pointIndex));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = V_0;
		int32_t L_2 = ___0_pointIndex;
		double L_3;
		L_3 = Spline_GetPointPercent_mD3E8CF895C8F0C0A4DE9AB262479A25B3253F9E5(__this, L_2, NULL);
		Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC(__this, L_1, L_3, NULL);
		// return result;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = V_0;
		return L_4;
	}
}
// System.Void Dreamteck.Splines.Spline::Evaluate(Dreamteck.Splines.SplineSample,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Evaluate_mFCCB83D95682B0A1426A3601D4E601BE4FF8AF4F (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_result, int32_t ___1_pointIndex, const RuntimeMethod* method) 
{
	{
		// Evaluate(result, GetPointPercent(pointIndex));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ___0_result;
		int32_t L_1 = ___1_pointIndex;
		double L_2;
		L_2 = Spline_GetPointPercent_mD3E8CF895C8F0C0A4DE9AB262479A25B3253F9E5(__this, L_1, NULL);
		Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC(__this, L_0, L_2, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::Evaluate(Dreamteck.Splines.SplineSample,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_result, double ___1_percent, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	double V_1 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB V_3;
	memset((&V_3), 0, sizeof(V_3));
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	double V_6 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_7;
	memset((&V_7), 0, sizeof(V_7));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_8;
	memset((&V_8), 0, sizeof(V_8));
	{
		// if (points.Length == 0)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0011;
		}
	}
	{
		// result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_1, NULL);
		___0_result = L_1;
		// return;
		return;
	}

IL_0011:
	{
		// percent = DMath.Clamp01(percent);
		double L_2 = ___1_percent;
		double L_3;
		L_3 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_2, NULL);
		___1_percent = L_3;
		// if (closed && points.Length <= 2) closed = false;
		bool L_4 = __this->___closed_1;
		if (!L_4)
		{
			goto IL_0033;
		}
	}
	{
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_5 = __this->___points_0;
		NullCheck(L_5);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_5)->max_length))) > ((int32_t)2)))
		{
			goto IL_0033;
		}
	}
	{
		// if (closed && points.Length <= 2) closed = false;
		__this->___closed_1 = (bool)0;
	}

IL_0033:
	{
		// if (points.Length == 1)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_6 = __this->___points_0;
		NullCheck(L_6);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_6)->max_length))) == ((uint32_t)1))))
		{
			goto IL_00ad;
		}
	}
	{
		// result.position = points[0].position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_8 = __this->___points_0;
		NullCheck(L_8);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = ((L_8)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___position_1;
		NullCheck(L_7);
		L_7->___position_0 = L_9;
		// result.up = points[0].normal;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_10 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_11 = __this->___points_0;
		NullCheck(L_11);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = ((L_11)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___normal_3;
		NullCheck(L_10);
		L_10->___up_1 = L_12;
		// result.forward = Vector3.forward;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_13 = ___0_result;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		NullCheck(L_13);
		L_13->___forward_2 = L_14;
		// result.size = points[0].size;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_15 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_16 = __this->___points_0;
		NullCheck(L_16);
		float L_17 = ((L_16)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___size_4;
		NullCheck(L_15);
		L_15->___size_4 = L_17;
		// result.color = points[0].color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_18 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_19 = __this->___points_0;
		NullCheck(L_19);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_20 = ((L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___color_2;
		NullCheck(L_18);
		L_18->___color_3 = L_20;
		// result.percent = percent;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_21 = ___0_result;
		double L_22 = ___1_percent;
		NullCheck(L_21);
		L_21->___percent_5 = L_22;
		// return;
		return;
	}

IL_00ad:
	{
		// double doubleIndex = (points.Length - 1) * percent;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_23 = __this->___points_0;
		NullCheck(L_23);
		double L_24 = ___1_percent;
		// int pointIndex = Mathf.Clamp(DMath.FloorInt(doubleIndex), 0, points.Length - 2);
		double L_25 = ((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_23)->max_length)), 1))), L_24));
		int32_t L_26;
		L_26 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_25, NULL);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_27 = __this->___points_0;
		NullCheck(L_27);
		int32_t L_28;
		L_28 = Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline(L_26, 0, ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_27)->max_length)), 2)), NULL);
		V_0 = L_28;
		// double getPercent = doubleIndex - pointIndex;
		int32_t L_29 = V_0;
		V_1 = ((double)il2cpp_codegen_subtract(L_25, ((double)L_29)));
		// Vector3 point = EvaluatePosition(percent);
		double L_30 = ___1_percent;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_30, NULL);
		V_2 = L_31;
		// result.position = point;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_32 = ___0_result;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = V_2;
		NullCheck(L_32);
		L_32->___position_0 = L_33;
		// result.percent = percent;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_34 = ___0_result;
		double L_35 = ___1_percent;
		NullCheck(L_34);
		L_34->___percent_5 = L_35;
		// if (pointIndex <= points.Length - 2)
		int32_t L_36 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_37 = __this->___points_0;
		NullCheck(L_37);
		if ((((int32_t)L_36) > ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_37)->max_length)), 2)))))
		{
			goto IL_01ef;
		}
	}
	{
		// SplinePoint nextPoint = points[pointIndex + 1];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_38 = __this->___points_0;
		int32_t L_39 = V_0;
		NullCheck(L_38);
		int32_t L_40 = ((int32_t)il2cpp_codegen_add(L_39, 1));
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_41 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_40));
		V_3 = L_41;
		// if (pointIndex == points.Length - 2 && closed) nextPoint = points[0];
		int32_t L_42 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_43 = __this->___points_0;
		NullCheck(L_43);
		if ((!(((uint32_t)L_42) == ((uint32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_43)->max_length)), 2))))))
		{
			goto IL_012c;
		}
	}
	{
		bool L_44 = __this->___closed_1;
		if (!L_44)
		{
			goto IL_012c;
		}
	}
	{
		// if (pointIndex == points.Length - 2 && closed) nextPoint = points[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_45 = __this->___points_0;
		NullCheck(L_45);
		int32_t L_46 = 0;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_47 = (L_45)->GetAt(static_cast<il2cpp_array_size_t>(L_46));
		V_3 = L_47;
	}

IL_012c:
	{
		// float valueInterpolation = (float)getPercent;
		double L_48 = V_1;
		V_4 = ((float)L_48);
		// if (customValueInterpolation != null)
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_49 = __this->___customValueInterpolation_4;
		if (!L_49)
		{
			goto IL_0155;
		}
	}
	{
		// if (customValueInterpolation.length > 0) valueInterpolation = customValueInterpolation.Evaluate(valueInterpolation);
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_50 = __this->___customValueInterpolation_4;
		NullCheck(L_50);
		int32_t L_51;
		L_51 = AnimationCurve_get_length_m259A67BB0870D3A153F6FEDBB06CB0D24089CD81(L_50, NULL);
		if ((((int32_t)L_51) <= ((int32_t)0)))
		{
			goto IL_0155;
		}
	}
	{
		// if (customValueInterpolation.length > 0) valueInterpolation = customValueInterpolation.Evaluate(valueInterpolation);
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_52 = __this->___customValueInterpolation_4;
		float L_53 = V_4;
		NullCheck(L_52);
		float L_54;
		L_54 = AnimationCurve_Evaluate_m50B857043DE251A186032ADBCBB4CEF817F4EE3C(L_52, L_53, NULL);
		V_4 = L_54;
	}

IL_0155:
	{
		// float normalInterpolation = (float)getPercent;
		double L_55 = V_1;
		V_5 = ((float)L_55);
		// if (customNormalInterpolation != null)
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_56 = __this->___customNormalInterpolation_5;
		if (!L_56)
		{
			goto IL_017e;
		}
	}
	{
		// if (customNormalInterpolation.length > 0) normalInterpolation = customNormalInterpolation.Evaluate(normalInterpolation);
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_57 = __this->___customNormalInterpolation_5;
		NullCheck(L_57);
		int32_t L_58;
		L_58 = AnimationCurve_get_length_m259A67BB0870D3A153F6FEDBB06CB0D24089CD81(L_57, NULL);
		if ((((int32_t)L_58) <= ((int32_t)0)))
		{
			goto IL_017e;
		}
	}
	{
		// if (customNormalInterpolation.length > 0) normalInterpolation = customNormalInterpolation.Evaluate(normalInterpolation);
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_59 = __this->___customNormalInterpolation_5;
		float L_60 = V_5;
		NullCheck(L_59);
		float L_61;
		L_61 = AnimationCurve_Evaluate_m50B857043DE251A186032ADBCBB4CEF817F4EE3C(L_59, L_60, NULL);
		V_5 = L_61;
	}

IL_017e:
	{
		// result.size = Mathf.Lerp(points[pointIndex].size, nextPoint.size, valueInterpolation);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_62 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_63 = __this->___points_0;
		int32_t L_64 = V_0;
		NullCheck(L_63);
		float L_65 = ((L_63)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_64)))->___size_4;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_66 = V_3;
		float L_67 = L_66.___size_4;
		float L_68 = V_4;
		float L_69;
		L_69 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_65, L_67, L_68, NULL);
		NullCheck(L_62);
		L_62->___size_4 = L_69;
		// result.color = Color.Lerp(points[pointIndex].color, nextPoint.color, valueInterpolation);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_70 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_71 = __this->___points_0;
		int32_t L_72 = V_0;
		NullCheck(L_71);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_73 = ((L_71)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_72)))->___color_2;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_74 = V_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_75 = L_74.___color_2;
		float L_76 = V_4;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_77;
		L_77 = Color_Lerp_mE79F87889843ECDC188E4CB5B5E1F1B2256E5EBE_inline(L_73, L_75, L_76, NULL);
		NullCheck(L_70);
		L_70->___color_3 = L_77;
		// result.up = Vector3.Slerp(points[pointIndex].normal, nextPoint.normal, normalInterpolation);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_78 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_79 = __this->___points_0;
		int32_t L_80 = V_0;
		NullCheck(L_79);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81 = ((L_79)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_80)))->___normal_3;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_82 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_83 = L_82.___normal_3;
		float L_84 = V_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_85;
		L_85 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_81, L_83, L_84, NULL);
		NullCheck(L_78);
		L_78->___up_1 = L_85;
		goto IL_0283;
	}

IL_01ef:
	{
		// if (closed)
		bool L_86 = __this->___closed_1;
		if (!L_86)
		{
			goto IL_023e;
		}
	}
	{
		// result.size = points[0].size;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_87 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_88 = __this->___points_0;
		NullCheck(L_88);
		float L_89 = ((L_88)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___size_4;
		NullCheck(L_87);
		L_87->___size_4 = L_89;
		// result.color = points[0].color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_90 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_91 = __this->___points_0;
		NullCheck(L_91);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_92 = ((L_91)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___color_2;
		NullCheck(L_90);
		L_90->___color_3 = L_92;
		// result.up = points[0].normal;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_93 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_94 = __this->___points_0;
		NullCheck(L_94);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_95 = ((L_94)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___normal_3;
		NullCheck(L_93);
		L_93->___up_1 = L_95;
		goto IL_0283;
	}

IL_023e:
	{
		// result.size = points[pointIndex].size;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_96 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_97 = __this->___points_0;
		int32_t L_98 = V_0;
		NullCheck(L_97);
		float L_99 = ((L_97)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_98)))->___size_4;
		NullCheck(L_96);
		L_96->___size_4 = L_99;
		// result.color = points[pointIndex].color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_100 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_101 = __this->___points_0;
		int32_t L_102 = V_0;
		NullCheck(L_101);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_103 = ((L_101)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_102)))->___color_2;
		NullCheck(L_100);
		L_100->___color_3 = L_103;
		// result.up = points[pointIndex].normal;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_104 = ___0_result;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_105 = __this->___points_0;
		int32_t L_106 = V_0;
		NullCheck(L_105);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_107 = ((L_105)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_106)))->___normal_3;
		NullCheck(L_104);
		L_104->___up_1 = L_107;
	}

IL_0283:
	{
		// if (type == Type.BSpline)
		int32_t L_108 = __this->___type_2;
		if ((!(((uint32_t)L_108) == ((uint32_t)1))))
		{
			goto IL_03ad;
		}
	}
	{
		// double step = 1.0 / (iterations-1);
		int32_t L_109;
		L_109 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		V_6 = ((double)((1.0)/((double)((int32_t)il2cpp_codegen_subtract(L_109, 1)))));
		// if (percent <= 1.0 - step && percent >= step) result.forward = EvaluatePosition(percent + step) - EvaluatePosition(percent - step);
		double L_110 = ___1_percent;
		double L_111 = V_6;
		if ((!(((double)L_110) <= ((double)((double)il2cpp_codegen_subtract((1.0), L_111))))))
		{
			goto IL_02dc;
		}
	}
	{
		double L_112 = ___1_percent;
		double L_113 = V_6;
		if ((!(((double)L_112) >= ((double)L_113))))
		{
			goto IL_02dc;
		}
	}
	{
		// if (percent <= 1.0 - step && percent >= step) result.forward = EvaluatePosition(percent + step) - EvaluatePosition(percent - step);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_114 = ___0_result;
		double L_115 = ___1_percent;
		double L_116 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_117;
		L_117 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_add(L_115, L_116)), NULL);
		double L_118 = ___1_percent;
		double L_119 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_120;
		L_120 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_subtract(L_118, L_119)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_121;
		L_121 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_117, L_120, NULL);
		NullCheck(L_114);
		L_114->___forward_2 = L_121;
		goto IL_03ba;
	}

IL_02dc:
	{
		// Vector3 back = Vector3.zero, front = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_122;
		L_122 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_7 = L_122;
		// Vector3 back = Vector3.zero, front = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_123;
		L_123 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_8 = L_123;
		// if (closed)
		bool L_124 = __this->___closed_1;
		if (!L_124)
		{
			goto IL_035f;
		}
	}
	{
		// if (percent < step) back = EvaluatePosition(1.0 - (step - percent));
		double L_125 = ___1_percent;
		double L_126 = V_6;
		if ((!(((double)L_125) < ((double)L_126))))
		{
			goto IL_030f;
		}
	}
	{
		// if (percent < step) back = EvaluatePosition(1.0 - (step - percent));
		double L_127 = V_6;
		double L_128 = ___1_percent;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_129;
		L_129 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_subtract((1.0), ((double)il2cpp_codegen_subtract(L_127, L_128)))), NULL);
		V_7 = L_129;
		goto IL_031b;
	}

IL_030f:
	{
		// else back = EvaluatePosition(percent - step);
		double L_130 = ___1_percent;
		double L_131 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_132;
		L_132 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_subtract(L_130, L_131)), NULL);
		V_7 = L_132;
	}

IL_031b:
	{
		// if (percent > 1.0 - step) front = EvaluatePosition(step - (1.0 - percent));
		double L_133 = ___1_percent;
		double L_134 = V_6;
		if ((!(((double)L_133) > ((double)((double)il2cpp_codegen_subtract((1.0), L_134))))))
		{
			goto IL_0342;
		}
	}
	{
		// if (percent > 1.0 - step) front = EvaluatePosition(step - (1.0 - percent));
		double L_135 = V_6;
		double L_136 = ___1_percent;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_137;
		L_137 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_subtract(L_135, ((double)il2cpp_codegen_subtract((1.0), L_136)))), NULL);
		V_8 = L_137;
		goto IL_034e;
	}

IL_0342:
	{
		// else front = EvaluatePosition(percent + step);
		double L_138 = ___1_percent;
		double L_139 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_140;
		L_140 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_add(L_138, L_139)), NULL);
		V_8 = L_140;
	}

IL_034e:
	{
		// result.forward = front - back;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_141 = ___0_result;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_142 = V_8;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_143 = V_7;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_144;
		L_144 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_142, L_143, NULL);
		NullCheck(L_141);
		L_141->___forward_2 = L_144;
		goto IL_03ba;
	}

IL_035f:
	{
		// back = result.position - EvaluatePosition(percent - step);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_145 = ___0_result;
		NullCheck(L_145);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_146 = L_145->___position_0;
		double L_147 = ___1_percent;
		double L_148 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_149;
		L_149 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_subtract(L_147, L_148)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_150;
		L_150 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_146, L_149, NULL);
		V_7 = L_150;
		// front = EvaluatePosition(percent + step) - result.position;
		double L_151 = ___1_percent;
		double L_152 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_153;
		L_153 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, ((double)il2cpp_codegen_add(L_151, L_152)), NULL);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_154 = ___0_result;
		NullCheck(L_154);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_155 = L_154->___position_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_156;
		L_156 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_153, L_155, NULL);
		V_8 = L_156;
		// result.forward = Vector3.Slerp(front, back, back.magnitude / front.magnitude);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_157 = ___0_result;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_158 = V_8;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_159 = V_7;
		float L_160;
		L_160 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_7), NULL);
		float L_161;
		L_161 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_8), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_162;
		L_162 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_158, L_159, ((float)(L_160/L_161)), NULL);
		NullCheck(L_157);
		L_157->___forward_2 = L_162;
		goto IL_03ba;
	}

IL_03ad:
	{
		// } else EvaluateTangent(ref result.forward, percent);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_163 = ___0_result;
		NullCheck(L_163);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_164 = (&L_163->___forward_2);
		double L_165 = ___1_percent;
		Spline_EvaluateTangent_m2FCD441A9260957B50B1668103D6F2AB22B31B44(__this, L_164, L_165, NULL);
	}

IL_03ba:
	{
		// result.forward.Normalize();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_166 = ___0_result;
		NullCheck(L_166);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_167 = (&L_166->___forward_2);
		Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline(L_167, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::Evaluate(Dreamteck.Splines.SplineSample[]&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Evaluate_m3A1E57F006DDC001678FD9F7B3B9620DDAE5D16A (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** ___0_samples, double ___1_from, double ___2_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	int32_t V_1 = 0;
	double V_2 = 0.0;
	double V_3 = 0.0;
	int32_t V_4 = 0;
	{
		// if (points.Length == 0) {
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0012;
		}
	}
	{
		// samples = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_1 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_2 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_1) = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_1, (void*)(RuntimeObject*)L_2);
		// return;
		return;
	}

IL_0012:
	{
		// from = DMath.Clamp01(from);
		double L_3 = ___1_from;
		double L_4;
		L_4 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_3, NULL);
		___1_from = L_4;
		// to = DMath.Clamp(to, from, 1.0);
		double L_5 = ___2_to;
		double L_6 = ___1_from;
		double L_7;
		L_7 = DMath_Clamp_m5FF4D892D00AB10A164C167334755F3232981EFD(L_5, L_6, (1.0), NULL);
		___2_to = L_7;
		// double fromValue = from * (iterations - 1);
		double L_8 = ___1_from;
		int32_t L_9;
		L_9 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		V_0 = ((double)il2cpp_codegen_multiply(L_8, ((double)((int32_t)il2cpp_codegen_subtract(L_9, 1)))));
		// double toValue = to * (iterations - 1);
		double L_10 = ___2_to;
		int32_t L_11;
		L_11 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		// int clippedIterations = DMath.CeilInt(toValue) - DMath.FloorInt(fromValue) + 1;
		int32_t L_12;
		L_12 = DMath_CeilInt_m92CA33A9E6B959B6A1EF0CE1BF001C27983C34F8(((double)il2cpp_codegen_multiply(L_10, ((double)((int32_t)il2cpp_codegen_subtract(L_11, 1))))), NULL);
		double L_13 = V_0;
		int32_t L_14;
		L_14 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_13, NULL);
		V_1 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_12, L_14)), 1));
		// if (samples == null) samples = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_15 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_16 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_15);
		if (L_16)
		{
			goto IL_0060;
		}
	}
	{
		// if (samples == null) samples = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_17 = ___0_samples;
		int32_t L_18 = V_1;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_19 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)L_18);
		*((RuntimeObject**)L_17) = (RuntimeObject*)L_19;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_17, (void*)(RuntimeObject*)L_19);
		goto IL_006f;
	}

IL_0060:
	{
		// else if (samples.Length != clippedIterations) samples = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_20 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_21 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_20);
		NullCheck(L_21);
		int32_t L_22 = V_1;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_21)->max_length))) == ((int32_t)L_22)))
		{
			goto IL_006f;
		}
	}
	{
		// else if (samples.Length != clippedIterations) samples = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_23 = ___0_samples;
		int32_t L_24 = V_1;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_25 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)L_24);
		*((RuntimeObject**)L_23) = (RuntimeObject*)L_25;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_23, (void*)(RuntimeObject*)L_25);
	}

IL_006f:
	{
		// double percent = from;
		double L_26 = ___1_from;
		V_2 = L_26;
		// double ms = moveStep;
		double L_27;
		L_27 = Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91(__this, NULL);
		V_3 = L_27;
		// int index = 0;
		V_4 = 0;
	}

IL_007b:
	{
		// samples[index] = Evaluate(percent);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_28 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_29 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_28);
		int32_t L_30 = V_4;
		double L_31 = V_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_32;
		L_32 = Spline_Evaluate_m7E6845261066AD52B8EB7367C904584C8AE5BFB6(__this, L_31, NULL);
		NullCheck(L_29);
		ArrayElementTypeCheck (L_29, L_32);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(L_30), (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)L_32);
		// index++;
		int32_t L_33 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_33, 1));
		// if (index >= samples.Length) break;
		int32_t L_34 = V_4;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_35 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_36 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_35);
		NullCheck(L_36);
		if ((((int32_t)L_34) >= ((int32_t)((int32_t)(((RuntimeArray*)L_36)->max_length)))))
		{
			goto IL_00a0;
		}
	}
	{
		// percent = DMath.Move(percent, to, ms);
		double L_37 = V_2;
		double L_38 = ___2_to;
		double L_39 = V_3;
		double L_40;
		L_40 = DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA(L_37, L_38, L_39, NULL);
		V_2 = L_40;
		// while (true)
		goto IL_007b;
	}

IL_00a0:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::EvaluateUniform(Dreamteck.Splines.SplineSample[]&,System.Double[]&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_EvaluateUniform_mC574E2837EC6004E0BB964CA0E2AD9BA586DA329 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** ___0_samples, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** ___1_originalSamplePercents, double ___2_from, double ___3_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	double V_3 = 0.0;
	float V_4 = 0.0f;
	int32_t V_5 = 0;
	double V_6 = 0.0;
	int32_t V_7 = 0;
	{
		// if (points.Length == 0)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0012;
		}
	}
	{
		// samples = new SplineSample[0];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_1 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_2 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_1) = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_1, (void*)(RuntimeObject*)L_2);
		// return;
		return;
	}

IL_0012:
	{
		// from = DMath.Clamp01(from);
		double L_3 = ___2_from;
		double L_4;
		L_4 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_3, NULL);
		___2_from = L_4;
		// to = DMath.Clamp(to, from, 1.0);
		double L_5 = ___3_to;
		double L_6 = ___2_from;
		double L_7;
		L_7 = DMath_Clamp_m5FF4D892D00AB10A164C167334755F3232981EFD(L_5, L_6, (1.0), NULL);
		___3_to = L_7;
		// double fromValue = from * (iterations - 1);
		double L_8 = ___2_from;
		int32_t L_9;
		L_9 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		V_0 = ((double)il2cpp_codegen_multiply(L_8, ((double)((int32_t)il2cpp_codegen_subtract(L_9, 1)))));
		// double toValue = to * (iterations - 1);
		double L_10 = ___3_to;
		int32_t L_11;
		L_11 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		// int clippedIterations = DMath.CeilInt(toValue) - DMath.FloorInt(fromValue) + 1;
		int32_t L_12;
		L_12 = DMath_CeilInt_m92CA33A9E6B959B6A1EF0CE1BF001C27983C34F8(((double)il2cpp_codegen_multiply(L_10, ((double)((int32_t)il2cpp_codegen_subtract(L_11, 1))))), NULL);
		double L_13 = V_0;
		int32_t L_14;
		L_14 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_13, NULL);
		V_1 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_12, L_14)), 1));
		// if (samples == null || samples.Length != clippedIterations) samples = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_15 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_16 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_15);
		if (!L_16)
		{
			goto IL_005f;
		}
	}
	{
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_17 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_18 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_17);
		NullCheck(L_18);
		int32_t L_19 = V_1;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_18)->max_length))) == ((int32_t)L_19)))
		{
			goto IL_0067;
		}
	}

IL_005f:
	{
		// if (samples == null || samples.Length != clippedIterations) samples = new SplineSample[clippedIterations];
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_20 = ___0_samples;
		int32_t L_21 = V_1;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_22 = (SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE*)SZArrayNew(SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE_il2cpp_TypeInfo_var, (uint32_t)L_21);
		*((RuntimeObject**)L_20) = (RuntimeObject*)L_22;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_20, (void*)(RuntimeObject*)L_22);
	}

IL_0067:
	{
		// if (originalSamplePercents == null || originalSamplePercents.Length != clippedIterations) originalSamplePercents = new double[clippedIterations];
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_23 = ___1_originalSamplePercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_24 = *((DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE**)L_23);
		if (!L_24)
		{
			goto IL_0072;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_25 = ___1_originalSamplePercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_26 = *((DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE**)L_25);
		NullCheck(L_26);
		int32_t L_27 = V_1;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_26)->max_length))) == ((int32_t)L_27)))
		{
			goto IL_007a;
		}
	}

IL_0072:
	{
		// if (originalSamplePercents == null || originalSamplePercents.Length != clippedIterations) originalSamplePercents = new double[clippedIterations];
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_28 = ___1_originalSamplePercents;
		int32_t L_29 = V_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_30 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)L_29);
		*((RuntimeObject**)L_28) = (RuntimeObject*)L_30;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_28, (void*)(RuntimeObject*)L_30);
	}

IL_007a:
	{
		// for (int i = 0; i < samples.Length; i++)
		V_5 = 0;
		goto IL_0096;
	}

IL_007f:
	{
		// if (samples[i] == null) samples[i] = new SplineSample();
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_31 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_32 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_31);
		int32_t L_33 = V_5;
		NullCheck(L_32);
		int32_t L_34 = L_33;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_35 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_34));
		if (L_35)
		{
			goto IL_0090;
		}
	}
	{
		// if (samples[i] == null) samples[i] = new SplineSample();
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_36 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_37 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_36);
		int32_t L_38 = V_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_39 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_39);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_39, NULL);
		NullCheck(L_37);
		ArrayElementTypeCheck (L_37, L_39);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(L_38), (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)L_39);
	}

IL_0090:
	{
		// for (int i = 0; i < samples.Length; i++)
		int32_t L_40 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_40, 1));
	}

IL_0096:
	{
		// for (int i = 0; i < samples.Length; i++)
		int32_t L_41 = V_5;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_42 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_43 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_42);
		NullCheck(L_43);
		if ((((int32_t)L_41) < ((int32_t)((int32_t)(((RuntimeArray*)L_43)->max_length)))))
		{
			goto IL_007f;
		}
	}
	{
		// float lengthStep = CalculateLength(from, to) / (iterations - 1);
		double L_44 = ___2_from;
		double L_45 = ___3_to;
		float L_46;
		L_46 = Spline_CalculateLength_m787BB23CD4D7E8E9A11DC60F88A2C0E88768DE77(__this, L_44, L_45, (1.0), NULL);
		int32_t L_47;
		L_47 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		V_2 = ((float)(L_46/((float)((int32_t)il2cpp_codegen_subtract(L_47, 1)))));
		// Evaluate(samples[0], from);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_48 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_49 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_48);
		NullCheck(L_49);
		int32_t L_50 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_51 = (L_49)->GetAt(static_cast<il2cpp_array_size_t>(L_50));
		double L_52 = ___2_from;
		Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC(__this, L_51, L_52, NULL);
		// samples[0].percent = originalSamplePercents[0] = from;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_53 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_54 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_53);
		NullCheck(L_54);
		int32_t L_55 = 0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_56 = (L_54)->GetAt(static_cast<il2cpp_array_size_t>(L_55));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_57 = ___1_originalSamplePercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_58 = *((DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE**)L_57);
		double L_59 = ___2_from;
		double L_60 = L_59;
		V_6 = L_60;
		NullCheck(L_58);
		(L_58)->SetAt(static_cast<il2cpp_array_size_t>(0), (double)L_60);
		double L_61 = V_6;
		NullCheck(L_56);
		L_56->___percent_5 = L_61;
		// double lastPercent = from;
		double L_62 = ___2_from;
		V_3 = L_62;
		// float moved = 0f;
		V_4 = (0.0f);
		// for (int i = 1; i < samples.Length - 1; i++)
		V_7 = 1;
		goto IL_0131;
	}

IL_00e7:
	{
		// Evaluate(samples[i], Travel(lastPercent, lengthStep, out moved, Direction.Forward));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_63 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_64 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_63);
		int32_t L_65 = V_7;
		NullCheck(L_64);
		int32_t L_66 = L_65;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_67 = (L_64)->GetAt(static_cast<il2cpp_array_size_t>(L_66));
		double L_68 = V_3;
		float L_69 = V_2;
		double L_70;
		L_70 = Spline_Travel_m3E26056E9A6ED0565DEC43E6E1FD5782BADF4176(__this, L_68, L_69, (&V_4), 1, NULL);
		Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC(__this, L_67, L_70, NULL);
		// lastPercent = samples[i].percent;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_71 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_72 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_71);
		int32_t L_73 = V_7;
		NullCheck(L_72);
		int32_t L_74 = L_73;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_75 = (L_72)->GetAt(static_cast<il2cpp_array_size_t>(L_74));
		NullCheck(L_75);
		double L_76 = L_75->___percent_5;
		V_3 = L_76;
		// originalSamplePercents[i] = lastPercent;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_77 = ___1_originalSamplePercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_78 = *((DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE**)L_77);
		int32_t L_79 = V_7;
		double L_80 = V_3;
		NullCheck(L_78);
		(L_78)->SetAt(static_cast<il2cpp_array_size_t>(L_79), (double)L_80);
		// samples[i].percent = DMath.Lerp(from, to, (double)i/ (samples.Length - 1));
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_81 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_82 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_81);
		int32_t L_83 = V_7;
		NullCheck(L_82);
		int32_t L_84 = L_83;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_85 = (L_82)->GetAt(static_cast<il2cpp_array_size_t>(L_84));
		double L_86 = ___2_from;
		double L_87 = ___3_to;
		int32_t L_88 = V_7;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_89 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_90 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_89);
		NullCheck(L_90);
		double L_91;
		L_91 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_86, L_87, ((double)(((double)L_88)/((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_90)->max_length)), 1))))), NULL);
		NullCheck(L_85);
		L_85->___percent_5 = L_91;
		// for (int i = 1; i < samples.Length - 1; i++)
		int32_t L_92 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_92, 1));
	}

IL_0131:
	{
		// for (int i = 1; i < samples.Length - 1; i++)
		int32_t L_93 = V_7;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_94 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_95 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_94);
		NullCheck(L_95);
		if ((((int32_t)L_93) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_95)->max_length)), 1)))))
		{
			goto IL_00e7;
		}
	}
	{
		// Evaluate(samples[samples.Length - 1], to);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_96 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_97 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_96);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_98 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_99 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_98);
		NullCheck(L_99);
		NullCheck(L_97);
		int32_t L_100 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_99)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_101 = (L_97)->GetAt(static_cast<il2cpp_array_size_t>(L_100));
		double L_102 = ___3_to;
		Spline_Evaluate_m801AF76BCD24D35D49B1B079E8217CE8F19808FC(__this, L_101, L_102, NULL);
		// samples[samples.Length - 1].percent = originalSamplePercents[originalSamplePercents.Length - 1] = to;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_103 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_104 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_103);
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE** L_105 = ___0_samples;
		SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE* L_106 = *((SplineSampleU5BU5D_tB6F5BBA04238B194E5C0ED2E16EB8F06C32224CE**)L_105);
		NullCheck(L_106);
		NullCheck(L_104);
		int32_t L_107 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_106)->max_length)), 1));
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_108 = (L_104)->GetAt(static_cast<il2cpp_array_size_t>(L_107));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_109 = ___1_originalSamplePercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_110 = *((DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE**)L_109);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE** L_111 = ___1_originalSamplePercents;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_112 = *((DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE**)L_111);
		NullCheck(L_112);
		double L_113 = ___3_to;
		double L_114 = L_113;
		V_6 = L_114;
		NullCheck(L_110);
		(L_110)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_112)->max_length)), 1))), (double)L_114);
		double L_115 = V_6;
		NullCheck(L_108);
		L_108->___percent_5 = L_115;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::EvaluatePositions(UnityEngine.Vector3[]&,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_EvaluatePositions_m18BE88A4A34A400F3F223D6654E9F36F063A0B9A (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___0_positions, double ___1_from, double ___2_to, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	int32_t V_1 = 0;
	double V_2 = 0.0;
	double V_3 = 0.0;
	int32_t V_4 = 0;
	{
		// if (points.Length == 0) {
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0012;
		}
	}
	{
		// positions = new Vector3[0];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_1 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_2 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)0);
		*((RuntimeObject**)L_1) = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_1, (void*)(RuntimeObject*)L_2);
		// return;
		return;
	}

IL_0012:
	{
		// from = DMath.Clamp01(from);
		double L_3 = ___1_from;
		double L_4;
		L_4 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_3, NULL);
		___1_from = L_4;
		// to = DMath.Clamp(to, from, 1.0);
		double L_5 = ___2_to;
		double L_6 = ___1_from;
		double L_7;
		L_7 = DMath_Clamp_m5FF4D892D00AB10A164C167334755F3232981EFD(L_5, L_6, (1.0), NULL);
		___2_to = L_7;
		// double fromValue = from * (iterations - 1);
		double L_8 = ___1_from;
		int32_t L_9;
		L_9 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		V_0 = ((double)il2cpp_codegen_multiply(L_8, ((double)((int32_t)il2cpp_codegen_subtract(L_9, 1)))));
		// double toValue = to * (iterations - 1);
		double L_10 = ___2_to;
		int32_t L_11;
		L_11 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		// int clippedIterations = DMath.CeilInt(toValue) - DMath.FloorInt(fromValue) + 1;
		int32_t L_12;
		L_12 = DMath_CeilInt_m92CA33A9E6B959B6A1EF0CE1BF001C27983C34F8(((double)il2cpp_codegen_multiply(L_10, ((double)((int32_t)il2cpp_codegen_subtract(L_11, 1))))), NULL);
		double L_13 = V_0;
		int32_t L_14;
		L_14 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_13, NULL);
		V_1 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_12, L_14)), 1));
		// if (positions.Length != clippedIterations) positions = new Vector3[clippedIterations];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_15 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_16 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_15);
		NullCheck(L_16);
		int32_t L_17 = V_1;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_16)->max_length))) == ((int32_t)L_17)))
		{
			goto IL_0061;
		}
	}
	{
		// if (positions.Length != clippedIterations) positions = new Vector3[clippedIterations];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_18 = ___0_positions;
		int32_t L_19 = V_1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_20 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_19);
		*((RuntimeObject**)L_18) = (RuntimeObject*)L_20;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_18, (void*)(RuntimeObject*)L_20);
	}

IL_0061:
	{
		// double percent = from;
		double L_21 = ___1_from;
		V_2 = L_21;
		// double ms = moveStep;
		double L_22;
		L_22 = Spline_get_moveStep_m4506EB0D540F1F76E4801155E1BC8EB13A703F91(__this, NULL);
		V_3 = L_22;
		// int index = 0;
		V_4 = 0;
	}

IL_006d:
	{
		// positions[index] = EvaluatePosition(percent);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_23 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_24 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_23);
		int32_t L_25 = V_4;
		double L_26 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_26, NULL);
		NullCheck(L_24);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(L_25), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_27);
		// index++;
		int32_t L_28 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_28, 1));
		// if (index >= positions.Length) break;
		int32_t L_29 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_30 = ___0_positions;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_30);
		NullCheck(L_31);
		if ((((int32_t)L_29) >= ((int32_t)((int32_t)(((RuntimeArray*)L_31)->max_length)))))
		{
			goto IL_0096;
		}
	}
	{
		// percent = DMath.Move(percent, to, ms);
		double L_32 = V_2;
		double L_33 = ___2_to;
		double L_34 = V_3;
		double L_35;
		L_35 = DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA(L_32, L_33, L_34, NULL);
		V_2 = L_35;
		// while (true)
		goto IL_006d;
	}

IL_0096:
	{
		// }
		return;
	}
}
// System.Double Dreamteck.Splines.Spline::Travel(System.Double,System.Single,System.Single&,Dreamteck.Splines.Spline/Direction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_Travel_m3E26056E9A6ED0565DEC43E6E1FD5782BADF4176 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_start, float ___1_distance, float* ___2_moved, int32_t ___3_direction, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	double V_2 = 0.0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	float V_5 = 0.0f;
	double V_6 = 0.0;
	int32_t G_B13_0 = 0;
	{
		// moved = 0f;
		float* L_0 = ___2_moved;
		*((float*)L_0) = (float)(0.0f);
		// if (points.Length <= 1) return 0.0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_1 = __this->___points_0;
		NullCheck(L_1);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length))) > ((int32_t)1)))
		{
			goto IL_001c;
		}
	}
	{
		// if (points.Length <= 1) return 0.0;
		return (0.0);
	}

IL_001c:
	{
		// if (direction == Direction.Forward && start >= 1.0) return 1.0;
		int32_t L_2 = ___3_direction;
		if ((!(((uint32_t)L_2) == ((uint32_t)1))))
		{
			goto IL_0037;
		}
	}
	{
		double L_3 = ___0_start;
		if ((!(((double)L_3) >= ((double)(1.0)))))
		{
			goto IL_0037;
		}
	}
	{
		// if (direction == Direction.Forward && start >= 1.0) return 1.0;
		return (1.0);
	}

IL_0037:
	{
		// else if (direction == Direction.Backward && start <= 0.0) return 0.0; ;
		int32_t L_4 = ___3_direction;
		if ((!(((uint32_t)L_4) == ((uint32_t)(-1)))))
		{
			goto IL_0052;
		}
	}
	{
		double L_5 = ___0_start;
		if ((!(((double)L_5) <= ((double)(0.0)))))
		{
			goto IL_0052;
		}
	}
	{
		// else if (direction == Direction.Backward && start <= 0.0) return 0.0; ;
		return (0.0);
	}

IL_0052:
	{
		// if (distance == 0f) return DMath.Clamp01(start);
		float L_6 = ___1_distance;
		if ((!(((float)L_6) == ((float)(0.0f)))))
		{
			goto IL_0061;
		}
	}
	{
		// if (distance == 0f) return DMath.Clamp01(start);
		double L_7 = ___0_start;
		double L_8;
		L_8 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_7, NULL);
		return L_8;
	}

IL_0061:
	{
		// Vector3 pos = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_0 = L_9;
		// EvaluatePosition(ref pos, start);
		double L_10 = ___0_start;
		Spline_EvaluatePosition_m7312161C2C2CF4DA1EDBEFD4F0B3E65FB54707CD(__this, (&V_0), L_10, NULL);
		// Vector3 lastPosition = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = V_0;
		V_1 = L_11;
		// double lastPercent = start;
		double L_12 = ___0_start;
		V_2 = L_12;
		// int i = iterations - 1;
		int32_t L_13;
		L_13 = Spline_get_iterations_m5810BD4A807B79EC55F4B5DADD04F51AF5E26DEA(__this, NULL);
		V_3 = ((int32_t)il2cpp_codegen_subtract(L_13, 1));
		// int nextSampleIndex = direction == Spline.Direction.Forward ? DMath.CeilInt(start * i) : DMath.FloorInt(start * i);
		int32_t L_14 = ___3_direction;
		if ((((int32_t)L_14) == ((int32_t)1)))
		{
			goto IL_008d;
		}
	}
	{
		double L_15 = ___0_start;
		int32_t L_16 = V_3;
		int32_t L_17;
		L_17 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(((double)il2cpp_codegen_multiply(L_15, ((double)L_16))), NULL);
		G_B13_0 = L_17;
		goto IL_0096;
	}

IL_008d:
	{
		double L_18 = ___0_start;
		int32_t L_19 = V_3;
		int32_t L_20;
		L_20 = DMath_CeilInt_m92CA33A9E6B959B6A1EF0CE1BF001C27983C34F8(((double)il2cpp_codegen_multiply(L_18, ((double)L_19))), NULL);
		G_B13_0 = L_20;
	}

IL_0096:
	{
		V_4 = G_B13_0;
		// float lastDistance = 0f;
		V_5 = (0.0f);
		// double percent = start;
		double L_21 = ___0_start;
		V_6 = L_21;
	}

IL_00a2:
	{
		// percent = (double)nextSampleIndex / i;
		int32_t L_22 = V_4;
		int32_t L_23 = V_3;
		V_6 = ((double)(((double)L_22)/((double)L_23)));
		// pos = EvaluatePosition(percent);
		double L_24 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_24, NULL);
		V_0 = L_25;
		// lastDistance = Vector3.Distance(pos, lastPosition);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27 = V_1;
		float L_28;
		L_28 = Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline(L_26, L_27, NULL);
		V_5 = L_28;
		// lastPosition = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = V_0;
		V_1 = L_29;
		// moved += lastDistance;
		float* L_30 = ___2_moved;
		float* L_31 = ___2_moved;
		float L_32 = *((float*)L_31);
		float L_33 = V_5;
		*((float*)L_30) = (float)((float)il2cpp_codegen_add(L_32, L_33));
		// if (moved >= distance) break;
		float* L_34 = ___2_moved;
		float L_35 = *((float*)L_34);
		float L_36 = ___1_distance;
		if ((((float)L_35) >= ((float)L_36)))
		{
			goto IL_00eb;
		}
	}
	{
		// lastPercent = percent;
		double L_37 = V_6;
		V_2 = L_37;
		// if (direction == Spline.Direction.Forward)
		int32_t L_38 = ___3_direction;
		if ((!(((uint32_t)L_38) == ((uint32_t)1))))
		{
			goto IL_00df;
		}
	}
	{
		// if (nextSampleIndex == i) break;
		int32_t L_39 = V_4;
		int32_t L_40 = V_3;
		if ((((int32_t)L_39) == ((int32_t)L_40)))
		{
			goto IL_00eb;
		}
	}
	{
		// nextSampleIndex++;
		int32_t L_41 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_41, 1));
		goto IL_00a2;
	}

IL_00df:
	{
		// if (nextSampleIndex == 0) break;
		int32_t L_42 = V_4;
		if (!L_42)
		{
			goto IL_00eb;
		}
	}
	{
		// nextSampleIndex--;
		int32_t L_43 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_subtract(L_43, 1));
		// while (true)
		goto IL_00a2;
	}

IL_00eb:
	{
		// return DMath.Lerp(lastPercent, percent, 1f - (moved - distance) / lastDistance);
		double L_44 = V_2;
		double L_45 = V_6;
		float* L_46 = ___2_moved;
		float L_47 = *((float*)L_46);
		float L_48 = ___1_distance;
		float L_49 = V_5;
		double L_50;
		L_50 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_44, L_45, ((double)((float)il2cpp_codegen_subtract((1.0f), ((float)(((float)il2cpp_codegen_subtract(L_47, L_48))/L_49))))), NULL);
		return L_50;
	}
}
// System.Double Dreamteck.Splines.Spline::Travel(System.Double,System.Single,Dreamteck.Splines.Spline/Direction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_Travel_m64F6900AA92CE6EBF965E5900DC40AE4DF128E57 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, double ___0_start, float ___1_distance, int32_t ___2_direction, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		// return Travel(start, distance, out moved, direction);
		double L_0 = ___0_start;
		float L_1 = ___1_distance;
		int32_t L_2 = ___2_direction;
		double L_3;
		L_3 = Spline_Travel_m3E26056E9A6ED0565DEC43E6E1FD5782BADF4176(__this, L_0, L_1, (&V_0), L_2, NULL);
		return L_3;
	}
}
// System.Void Dreamteck.Splines.Spline::EvaluatePosition(UnityEngine.Vector3&,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_EvaluatePosition_m7312161C2C2CF4DA1EDBEFD4F0B3E65FB54707CD (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_percent, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	int32_t V_1 = 0;
	{
		// percent = DMath.Clamp01(percent);
		double L_0 = ___1_percent;
		double L_1;
		L_1 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_0, NULL);
		___1_percent = L_1;
		// double doubleIndex = (points.Length - 1) * percent;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		NullCheck(L_2);
		double L_3 = ___1_percent;
		V_0 = ((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_2)->max_length)), 1))), L_3));
		// int pointIndex = DMath.FloorInt(doubleIndex);
		double L_4 = V_0;
		int32_t L_5;
		L_5 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_4, NULL);
		V_1 = L_5;
		// if (type == Type.Bezier) pointIndex = Mathf.Clamp(pointIndex, 0, Mathf.Max(points.Length - 2, 0));
		int32_t L_6 = __this->___type_2;
		if ((!(((uint32_t)L_6) == ((uint32_t)2))))
		{
			goto IL_003e;
		}
	}
	{
		// if (type == Type.Bezier) pointIndex = Mathf.Clamp(pointIndex, 0, Mathf.Max(points.Length - 2, 0));
		int32_t L_7 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_8 = __this->___points_0;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_8)->max_length)), 2)), 0, NULL);
		int32_t L_10;
		L_10 = Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline(L_7, 0, L_9, NULL);
		V_1 = L_10;
	}

IL_003e:
	{
		// GetPoint(ref point, doubleIndex - pointIndex, pointIndex);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_11 = ___0_point;
		double L_12 = V_0;
		int32_t L_13 = V_1;
		int32_t L_14 = V_1;
		Spline_GetPoint_mB32C7A254C40F490575EF91597EA99BC71C84A91(__this, L_11, ((double)il2cpp_codegen_subtract(L_12, ((double)L_13))), L_14, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::EvaluateTangent(UnityEngine.Vector3&,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_EvaluateTangent_m2FCD441A9260957B50B1668103D6F2AB22B31B44 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_percent, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	int32_t V_1 = 0;
	{
		// percent = DMath.Clamp01(percent);
		double L_0 = ___1_percent;
		double L_1;
		L_1 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_0, NULL);
		___1_percent = L_1;
		// double doubleIndex = (points.Length - 1) * percent;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		NullCheck(L_2);
		double L_3 = ___1_percent;
		V_0 = ((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_2)->max_length)), 1))), L_3));
		// int pointIndex = DMath.FloorInt(doubleIndex);
		double L_4 = V_0;
		int32_t L_5;
		L_5 = DMath_FloorInt_mB971BB23A3FBFF8FF17F21F623F7FF62E34ED556(L_4, NULL);
		V_1 = L_5;
		// if (type == Type.Bezier) pointIndex = Mathf.Clamp(pointIndex, 0, Mathf.Max(points.Length - 2, 0));
		int32_t L_6 = __this->___type_2;
		if ((!(((uint32_t)L_6) == ((uint32_t)2))))
		{
			goto IL_003e;
		}
	}
	{
		// if (type == Type.Bezier) pointIndex = Mathf.Clamp(pointIndex, 0, Mathf.Max(points.Length - 2, 0));
		int32_t L_7 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_8 = __this->___points_0;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_8)->max_length)), 2)), 0, NULL);
		int32_t L_10;
		L_10 = Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline(L_7, 0, L_9, NULL);
		V_1 = L_10;
	}

IL_003e:
	{
		// GetTangent(ref tangent, doubleIndex - pointIndex, pointIndex);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_11 = ___0_tangent;
		double L_12 = V_0;
		int32_t L_13 = V_1;
		int32_t L_14 = V_1;
		Spline_GetTangent_mF6E73EC157647B30D942CD7DA04345E88C43F688(__this, L_11, ((double)il2cpp_codegen_subtract(L_12, ((double)L_13))), L_14, NULL);
		// }
		return;
	}
}
// System.Double Dreamteck.Splines.Spline::GetClosestPoint(System.Int32,UnityEngine.Vector3,System.Double,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Spline_GetClosestPoint_mF5C6AB0488DCE8AB8DDEC400D85555CCF15780C5 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_iterations, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_point, double ___2_start, double ___3_end, int32_t ___4_slices, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	float V_1 = 0.0f;
	double V_2 = 0.0;
	double V_3 = 0.0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	double V_5 = 0.0;
	double V_6 = 0.0;
	float V_7 = 0.0f;
	float V_8 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_9;
	memset((&V_9), 0, sizeof(V_9));
	float V_10 = 0.0f;
	{
		// if (iterations <= 0)
		int32_t L_0 = ___0_iterations;
		if ((((int32_t)L_0) > ((int32_t)0)))
		{
			goto IL_0055;
		}
	}
	{
		// float startDist = (point - EvaluatePosition(start)).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_point;
		double L_2 = ___2_start;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_2, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_1, L_3, NULL);
		V_9 = L_4;
		float L_5;
		L_5 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_9), NULL);
		V_7 = L_5;
		// float endDist = (point - EvaluatePosition(end)).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_point;
		double L_7 = ___3_end;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Spline_EvaluatePosition_mDEAC33840CDF579057168F43A43868EDF41B5B7B(__this, L_7, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_6, L_8, NULL);
		V_9 = L_9;
		float L_10;
		L_10 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_9), NULL);
		V_8 = L_10;
		// if (startDist < endDist) return start;
		float L_11 = V_7;
		float L_12 = V_8;
		if ((!(((float)L_11) < ((float)L_12))))
		{
			goto IL_003d;
		}
	}
	{
		// if (startDist < endDist) return start;
		double L_13 = ___2_start;
		return L_13;
	}

IL_003d:
	{
		// else if (endDist < startDist) return end;
		float L_14 = V_8;
		float L_15 = V_7;
		if ((!(((float)L_14) < ((float)L_15))))
		{
			goto IL_0046;
		}
	}
	{
		// else if (endDist < startDist) return end;
		double L_16 = ___3_end;
		return L_16;
	}

IL_0046:
	{
		// else return (start + end) / 2;
		double L_17 = ___2_start;
		double L_18 = ___3_end;
		return ((double)(((double)il2cpp_codegen_add(L_17, L_18))/(2.0)));
	}

IL_0055:
	{
		// double closestPercent = 0.0;
		V_0 = (0.0);
		// float closestDistance = Mathf.Infinity;
		V_1 = (std::numeric_limits<float>::infinity());
		// double tick = (end - start) / slices;
		double L_19 = ___3_end;
		double L_20 = ___2_start;
		int32_t L_21 = ___4_slices;
		V_2 = ((double)(((double)il2cpp_codegen_subtract(L_19, L_20))/((double)L_21)));
		// double t = start;
		double L_22 = ___2_start;
		V_3 = L_22;
		// Vector3 pos = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		L_23 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_4 = L_23;
	}

IL_0077:
	{
		// EvaluatePosition(ref pos, t);
		double L_24 = V_3;
		Spline_EvaluatePosition_m7312161C2C2CF4DA1EDBEFD4F0B3E65FB54707CD(__this, (&V_4), L_24, NULL);
		// float dist = (point - pos).sqrMagnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = ___1_point;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_25, L_26, NULL);
		V_9 = L_27;
		float L_28;
		L_28 = Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline((&V_9), NULL);
		V_10 = L_28;
		// if (dist < closestDistance)
		float L_29 = V_10;
		float L_30 = V_1;
		if ((!(((float)L_29) < ((float)L_30))))
		{
			goto IL_009d;
		}
	}
	{
		// closestDistance = dist;
		float L_31 = V_10;
		V_1 = L_31;
		// closestPercent = t;
		double L_32 = V_3;
		V_0 = L_32;
	}

IL_009d:
	{
		// if (t == end) break;
		double L_33 = V_3;
		double L_34 = ___3_end;
		if ((((double)L_33) == ((double)L_34)))
		{
			goto IL_00ae;
		}
	}
	{
		// t = DMath.Move(t, end, tick);
		double L_35 = V_3;
		double L_36 = ___3_end;
		double L_37 = V_2;
		double L_38;
		L_38 = DMath_Move_m587FE98E4D916A6F53CD5D30D0098645EE33CCCA(L_35, L_36, L_37, NULL);
		V_3 = L_38;
		// while (true)
		goto IL_0077;
	}

IL_00ae:
	{
		// double newStart = closestPercent - tick;
		double L_39 = V_0;
		double L_40 = V_2;
		V_5 = ((double)il2cpp_codegen_subtract(L_39, L_40));
		// if (newStart < start) newStart = start;
		double L_41 = V_5;
		double L_42 = ___2_start;
		if ((!(((double)L_41) < ((double)L_42))))
		{
			goto IL_00bb;
		}
	}
	{
		// if (newStart < start) newStart = start;
		double L_43 = ___2_start;
		V_5 = L_43;
	}

IL_00bb:
	{
		// double newEnd = closestPercent + tick;
		double L_44 = V_0;
		double L_45 = V_2;
		V_6 = ((double)il2cpp_codegen_add(L_44, L_45));
		// if (newEnd > end) newEnd = end;
		double L_46 = V_6;
		double L_47 = ___3_end;
		if ((!(((double)L_46) > ((double)L_47))))
		{
			goto IL_00ca;
		}
	}
	{
		// if (newEnd > end) newEnd = end;
		double L_48 = ___3_end;
		V_6 = L_48;
	}

IL_00ca:
	{
		// return GetClosestPoint(--iterations, point, newStart, newEnd, slices);
		int32_t L_49 = ___0_iterations;
		int32_t L_50 = ((int32_t)il2cpp_codegen_subtract(L_49, 1));
		___0_iterations = L_50;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51 = ___1_point;
		double L_52 = V_5;
		double L_53 = V_6;
		int32_t L_54 = ___4_slices;
		double L_55;
		L_55 = Spline_GetClosestPoint_mF5C6AB0488DCE8AB8DDEC400D85555CCF15780C5(__this, L_50, L_51, L_52, L_53, L_54, NULL);
		return L_55;
	}
}
// System.Void Dreamteck.Splines.Spline::Break()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Break_m62F2AF223810F8853F201DA0E2B0C7D14866992F (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) 
{
	{
		// Break(0);
		Spline_Break_mCCDEB091443D97798A4690BFA5409010ADDD74EF(__this, 0, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::Break(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Break_mCCDEB091443D97798A4690BFA5409010ADDD74EF (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_at, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		// if (!closed) return;
		bool L_0 = __this->___closed_1;
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// if (!closed) return;
		return;
	}

IL_0009:
	{
		// if (at >= points.Length) return;
		int32_t L_1 = ___0_at;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		NullCheck(L_2);
		if ((((int32_t)L_1) < ((int32_t)((int32_t)(((RuntimeArray*)L_2)->max_length)))))
		{
			goto IL_0015;
		}
	}
	{
		// if (at >= points.Length) return;
		return;
	}

IL_0015:
	{
		// SplinePoint[] prev = new SplinePoint[at];
		int32_t L_3 = ___0_at;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = (SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C*)SZArrayNew(SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C_il2cpp_TypeInfo_var, (uint32_t)L_3);
		V_0 = L_4;
		// for (int i = 0; i < prev.Length; i++) prev[i] = points[i];
		V_1 = 0;
		goto IL_0037;
	}

IL_0020:
	{
		// for (int i = 0; i < prev.Length; i++) prev[i] = points[i];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_5 = V_0;
		int32_t L_6 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_7 = __this->___points_0;
		int32_t L_8 = V_1;
		NullCheck(L_7);
		int32_t L_9 = L_8;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB)L_10);
		// for (int i = 0; i < prev.Length; i++) prev[i] = points[i];
		int32_t L_11 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0037:
	{
		// for (int i = 0; i < prev.Length; i++) prev[i] = points[i];
		int32_t L_12 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_13 = V_0;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0020;
		}
	}
	{
		// for (int i = at; i < points.Length - 1; i++) points[i - at] = points[i];
		int32_t L_14 = ___0_at;
		V_2 = L_14;
		goto IL_005f;
	}

IL_0041:
	{
		// for (int i = at; i < points.Length - 1; i++) points[i - at] = points[i];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_15 = __this->___points_0;
		int32_t L_16 = V_2;
		int32_t L_17 = ___0_at;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_18 = __this->___points_0;
		int32_t L_19 = V_2;
		NullCheck(L_18);
		int32_t L_20 = L_19;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		NullCheck(L_15);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(L_16, L_17))), (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB)L_21);
		// for (int i = at; i < points.Length - 1; i++) points[i - at] = points[i];
		int32_t L_22 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_22, 1));
	}

IL_005f:
	{
		// for (int i = at; i < points.Length - 1; i++) points[i - at] = points[i];
		int32_t L_23 = V_2;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_24 = __this->___points_0;
		NullCheck(L_24);
		if ((((int32_t)L_23) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_24)->max_length)), 1)))))
		{
			goto IL_0041;
		}
	}
	{
		// for (int i = 0; i < prev.Length; i++) points[points.Length - at + i - 1] = prev[i];
		V_3 = 0;
		goto IL_0094;
	}

IL_0070:
	{
		// for (int i = 0; i < prev.Length; i++) points[points.Length - at + i - 1] = prev[i];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_25 = __this->___points_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_26 = __this->___points_0;
		NullCheck(L_26);
		int32_t L_27 = ___0_at;
		int32_t L_28 = V_3;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_29 = V_0;
		int32_t L_30 = V_3;
		NullCheck(L_29);
		int32_t L_31 = L_30;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_32 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_31));
		NullCheck(L_25);
		(L_25)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_26)->max_length)), L_27)), L_28)), 1))), (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB)L_32);
		// for (int i = 0; i < prev.Length; i++) points[points.Length - at + i - 1] = prev[i];
		int32_t L_33 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_33, 1));
	}

IL_0094:
	{
		// for (int i = 0; i < prev.Length; i++) points[points.Length - at + i - 1] = prev[i];
		int32_t L_34 = V_3;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_35 = V_0;
		NullCheck(L_35);
		if ((((int32_t)L_34) < ((int32_t)((int32_t)(((RuntimeArray*)L_35)->max_length)))))
		{
			goto IL_0070;
		}
	}
	{
		// points[points.Length - 1] = points[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_36 = __this->___points_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_37 = __this->___points_0;
		NullCheck(L_37);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_38 = __this->___points_0;
		NullCheck(L_38);
		int32_t L_39 = 0;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_40 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		NullCheck(L_36);
		(L_36)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_37)->max_length)), 1))), (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB)L_40);
		// closed = false;
		__this->___closed_1 = (bool)0;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::Close()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_Close_mE0B7BE563A37E77232313C315AA09AC15F8CC15C (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4CFC5ABA1C919D113FC5E9034608A0133787E620);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (points.Length < 4)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_0)->max_length))) >= ((int32_t)4)))
		{
			goto IL_0016;
		}
	}
	{
		// Debug.LogError("Points need to be at least 4 to close the spline");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteral4CFC5ABA1C919D113FC5E9034608A0133787E620, NULL);
		// return;
		return;
	}

IL_0016:
	{
		// closed = true;
		__this->___closed_1 = (bool)1;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::CatToBezierTangents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_CatToBezierTangents_m896F8AF1615451C6A6688F1B64D5D95B3536D898 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_3;
	memset((&V_3), 0, sizeof(V_3));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_5;
	memset((&V_5), 0, sizeof(V_5));
	{
		// switch (type)
		int32_t L_0 = __this->___type_2;
		V_0 = L_0;
		int32_t L_1 = V_0;
		switch (L_1)
		{
			case 0:
			{
				goto IL_0090;
			}
			case 1:
			{
				goto IL_023c;
			}
			case 2:
			{
				goto IL_023c;
			}
			case 3:
			{
				goto IL_0022;
			}
		}
	}
	{
		goto IL_023c;
	}

IL_0022:
	{
		// for (int i = 0; i < points.Length; i++)
		V_1 = 0;
		goto IL_0080;
	}

IL_0026:
	{
		// points[i].type = SplinePoint.Type.Broken;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		int32_t L_3 = V_1;
		NullCheck(L_2);
		SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF(((L_2)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_3))), 1, NULL);
		// points[i].SetTangentPosition(points[i].position);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		int32_t L_5 = V_1;
		NullCheck(L_4);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_6 = __this->___points_0;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ((L_6)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_7)))->___position_1;
		SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(((L_4)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_5))), L_8, NULL);
		// points[i].SetTangent2Position(points[i].position);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_9 = __this->___points_0;
		int32_t L_10 = V_1;
		NullCheck(L_9);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_11 = __this->___points_0;
		int32_t L_12 = V_1;
		NullCheck(L_11);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = ((L_11)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_12)))->___position_1;
		SplinePoint_SetTangent2Position_m5B8AF2AF551EA75864610CC9031A15E16CA6C709(((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_10))), L_13, NULL);
		// for (int i = 0; i < points.Length; i++)
		int32_t L_14 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_14, 1));
	}

IL_0080:
	{
		// for (int i = 0; i < points.Length; i++)
		int32_t L_15 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_16 = __this->___points_0;
		NullCheck(L_16);
		if ((((int32_t)L_15) < ((int32_t)((int32_t)(((RuntimeArray*)L_16)->max_length)))))
		{
			goto IL_0026;
		}
	}
	{
		// break;
		goto IL_023c;
	}

IL_0090:
	{
		// for (int i = 0; i < points.Length; i++)
		V_2 = 0;
		goto IL_022e;
	}

IL_0097:
	{
		// GetCatPoints(i);
		int32_t L_17 = V_2;
		Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E(__this, L_17, NULL);
		// points[i].type = SplinePoint.Type.SmoothMirrored;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_18 = __this->___points_0;
		int32_t L_19 = V_2;
		NullCheck(L_18);
		SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF(((L_18)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_19))), 0, NULL);
		// if (i == 0)
		int32_t L_20 = V_2;
		if (L_20)
		{
			goto IL_017b;
		}
	}
	{
		// Vector3 direction = catPoints[1] - catPoints[2];
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_21 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_21);
		int32_t L_22 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = (L_21)->GetAt(static_cast<il2cpp_array_size_t>(L_22));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_24 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_24);
		int32_t L_25 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = (L_24)->GetAt(static_cast<il2cpp_array_size_t>(L_25));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_23, L_26, NULL);
		V_3 = L_27;
		// if (closed)
		bool L_28 = __this->___closed_1;
		if (!L_28)
		{
			goto IL_0144;
		}
	}
	{
		// direction = points[points.Length - 2].position - points[i + 1].position;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_29 = __this->___points_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_30 = __this->___points_0;
		NullCheck(L_30);
		NullCheck(L_29);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31 = ((L_29)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_30)->max_length)), 2)))))->___position_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_32 = __this->___points_0;
		int32_t L_33 = V_2;
		NullCheck(L_32);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34 = ((L_32)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_33, 1)))))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35;
		L_35 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_31, L_34, NULL);
		V_3 = L_35;
		// points[i].SetTangentPosition(points[i].position + direction / 6f);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_36 = __this->___points_0;
		int32_t L_37 = V_2;
		NullCheck(L_36);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_38 = __this->___points_0;
		int32_t L_39 = V_2;
		NullCheck(L_38);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = ((L_38)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_39)))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42;
		L_42 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_41, (6.0f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_43;
		L_43 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_40, L_42, NULL);
		SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(((L_36)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_37))), L_43, NULL);
		goto IL_022a;
	}

IL_0144:
	{
		// } else points[i].SetTangentPosition(points[i].position + direction / 3f);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_44 = __this->___points_0;
		int32_t L_45 = V_2;
		NullCheck(L_44);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_46 = __this->___points_0;
		int32_t L_47 = V_2;
		NullCheck(L_46);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_48 = ((L_46)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_47)))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50;
		L_50 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_49, (3.0f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51;
		L_51 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_48, L_50, NULL);
		SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(((L_44)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_45))), L_51, NULL);
		goto IL_022a;
	}

IL_017b:
	{
		// else if (i == points.Length - 1)
		int32_t L_52 = V_2;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_53 = __this->___points_0;
		NullCheck(L_53);
		if ((!(((uint32_t)L_52) == ((uint32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_53)->max_length)), 1))))))
		{
			goto IL_01da;
		}
	}
	{
		// Vector3 direction = catPoints[2] - catPoints[3];
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_54 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_54);
		int32_t L_55 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_56 = (L_54)->GetAt(static_cast<il2cpp_array_size_t>(L_55));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_57 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_57);
		int32_t L_58 = 3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59 = (L_57)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_60;
		L_60 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_56, L_59, NULL);
		V_4 = L_60;
		// points[i].SetTangentPosition(points[i].position + direction / 3f);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_61 = __this->___points_0;
		int32_t L_62 = V_2;
		NullCheck(L_61);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_63 = __this->___points_0;
		int32_t L_64 = V_2;
		NullCheck(L_63);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65 = ((L_63)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_64)))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_66 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_67;
		L_67 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_66, (3.0f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68;
		L_68 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_65, L_67, NULL);
		SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(((L_61)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_62))), L_68, NULL);
		goto IL_022a;
	}

IL_01da:
	{
		// Vector3 direction = catPoints[0] - catPoints[2];
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_69 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_69);
		int32_t L_70 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_71 = (L_69)->GetAt(static_cast<il2cpp_array_size_t>(L_70));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_72 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_72);
		int32_t L_73 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_74 = (L_72)->GetAt(static_cast<il2cpp_array_size_t>(L_73));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_75;
		L_75 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_71, L_74, NULL);
		V_5 = L_75;
		// points[i].SetTangentPosition(points[i].position + direction / 6f);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_76 = __this->___points_0;
		int32_t L_77 = V_2;
		NullCheck(L_76);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_78 = __this->___points_0;
		int32_t L_79 = V_2;
		NullCheck(L_78);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_80 = ((L_78)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_79)))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81 = V_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82;
		L_82 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_81, (6.0f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_83;
		L_83 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_80, L_82, NULL);
		SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(((L_76)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_77))), L_83, NULL);
	}

IL_022a:
	{
		// for (int i = 0; i < points.Length; i++)
		int32_t L_84 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_84, 1));
	}

IL_022e:
	{
		// for (int i = 0; i < points.Length; i++)
		int32_t L_85 = V_2;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_86 = __this->___points_0;
		NullCheck(L_86);
		if ((((int32_t)L_85) < ((int32_t)((int32_t)(((RuntimeArray*)L_86)->max_length)))))
		{
			goto IL_0097;
		}
	}

IL_023c:
	{
		// type = Type.Bezier;
		__this->___type_2 = 2;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::GetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetPoint_mB32C7A254C40F490575EF91597EA99BC71C84A91 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_percent, int32_t ___2_pointIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// if (closed && points.Length > 3)
		bool L_0 = __this->___closed_1;
		if (!L_0)
		{
			goto IL_006e;
		}
	}
	{
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_1 = __this->___points_0;
		NullCheck(L_1);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length))) <= ((int32_t)3)))
		{
			goto IL_006e;
		}
	}
	{
		// if (pointIndex == points.Length - 2)
		int32_t L_2 = ___2_pointIndex;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_3 = __this->___points_0;
		NullCheck(L_3);
		if ((!(((uint32_t)L_2) == ((uint32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_3)->max_length)), 2))))))
		{
			goto IL_0075;
		}
	}
	{
		// points[0].SetTangentPosition(points[points.Length - 1].tangent);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		NullCheck(L_4);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_5 = __this->___points_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_6 = __this->___points_0;
		NullCheck(L_6);
		NullCheck(L_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = ((L_5)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_6)->max_length)), 1)))))->___tangent_5;
		SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(((L_4)->GetAddressAt(static_cast<il2cpp_array_size_t>(0))), L_7, NULL);
		// points[points.Length - 1] = points[0];
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_8 = __this->___points_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_9 = __this->___points_0;
		NullCheck(L_9);
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_10 = __this->___points_0;
		NullCheck(L_10);
		int32_t L_11 = 0;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_12 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		NullCheck(L_8);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_9)->max_length)), 1))), (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB)L_12);
		goto IL_0075;
	}

IL_006e:
	{
		// } else closed = false;
		__this->___closed_1 = (bool)0;
	}

IL_0075:
	{
		// switch (type)
		int32_t L_13 = __this->___type_2;
		V_0 = L_13;
		int32_t L_14 = V_0;
		switch (L_14)
		{
			case 0:
			{
				goto IL_0093;
			}
			case 1:
			{
				goto IL_00a7;
			}
			case 2:
			{
				goto IL_009d;
			}
			case 3:
			{
				goto IL_00b1;
			}
		}
	}
	{
		return;
	}

IL_0093:
	{
		// case Type.CatmullRom: CatmullRomGetPoint(ref point, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_15 = ___0_point;
		double L_16 = ___1_percent;
		int32_t L_17 = ___2_pointIndex;
		Spline_CatmullRomGetPoint_m1AC3943C3EF3392C689F1967625BE4CF7D8BD62B(__this, L_15, L_16, L_17, NULL);
		// case Type.CatmullRom: CatmullRomGetPoint(ref point, percent, pointIndex); break;
		return;
	}

IL_009d:
	{
		// case Type.Bezier: BezierGetPoint(ref point, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_18 = ___0_point;
		double L_19 = ___1_percent;
		int32_t L_20 = ___2_pointIndex;
		Spline_BezierGetPoint_mF488DEAF2BFFE1C6457729D545B3C37FC0D6CF39(__this, L_18, L_19, L_20, NULL);
		// case Type.Bezier: BezierGetPoint(ref point, percent, pointIndex); break;
		return;
	}

IL_00a7:
	{
		// case Type.BSpline: BSPGetPoint(ref point, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_21 = ___0_point;
		double L_22 = ___1_percent;
		int32_t L_23 = ___2_pointIndex;
		Spline_BSPGetPoint_mBB1EAF649CE9594188EBBA68994A6629952BCD2A(__this, L_21, L_22, L_23, NULL);
		// case Type.BSpline: BSPGetPoint(ref point, percent, pointIndex); break;
		return;
	}

IL_00b1:
	{
		// case Type.Linear: LinearGetPoint(ref point, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_24 = ___0_point;
		double L_25 = ___1_percent;
		int32_t L_26 = ___2_pointIndex;
		Spline_LinearGetPoint_m5082CFCA1CE9ED30A2C987BBCAC8D06DFB6C0CB0(__this, L_24, L_25, L_26, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::GetTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetTangent_mF6E73EC157647B30D942CD7DA04345E88C43F688 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_percent, int32_t ___2_pointIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// switch (type)
		int32_t L_0 = __this->___type_2;
		V_0 = L_0;
		int32_t L_1 = V_0;
		switch (L_1)
		{
			case 0:
			{
				goto IL_001e;
			}
			case 1:
			{
				goto IL_003b;
			}
			case 2:
			{
				goto IL_0028;
			}
			case 3:
			{
				goto IL_0032;
			}
		}
	}
	{
		return;
	}

IL_001e:
	{
		// case Type.CatmullRom: GetCatmullRomTangent(ref tangent, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_2 = ___0_tangent;
		double L_3 = ___1_percent;
		int32_t L_4 = ___2_pointIndex;
		Spline_GetCatmullRomTangent_mC2E20E825154CD11CBB31543984660B55EE7773F(__this, L_2, L_3, L_4, NULL);
		// case Type.CatmullRom: GetCatmullRomTangent(ref tangent, percent, pointIndex); break;
		return;
	}

IL_0028:
	{
		// case Type.Bezier: BezierGetTangent(ref tangent, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_5 = ___0_tangent;
		double L_6 = ___1_percent;
		int32_t L_7 = ___2_pointIndex;
		Spline_BezierGetTangent_mA55EB1C827D49D884D96225A1C464ED30F6CF95C(__this, L_5, L_6, L_7, NULL);
		// case Type.Bezier: BezierGetTangent(ref tangent, percent, pointIndex); break;
		return;
	}

IL_0032:
	{
		// case Type.Linear: LinearGetTangent(ref tangent, percent, pointIndex); break;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_8 = ___0_tangent;
		double L_9 = ___1_percent;
		int32_t L_10 = ___2_pointIndex;
		Spline_LinearGetTangent_mB82558C318EAFAE8C5DE036AB7A580B049AF824C(__this, L_8, L_9, L_10, NULL);
	}

IL_003b:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::LinearGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_LinearGetPoint_m5082CFCA1CE9ED30A2C987BBCAC8D06DFB6C0CB0 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) 
{
	{
		// if (points.Length == 0)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0015;
		}
	}
	{
		// point = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_1 = ___0_point;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_1 = L_2;
		// return;
		return;
	}

IL_0015:
	{
		// if (i < points.Length - 1)
		int32_t L_3 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		NullCheck(L_4);
		if ((((int32_t)L_3) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_4)->max_length)), 1)))))
		{
			goto IL_006f;
		}
	}
	{
		// t = DMath.Clamp01(t);
		double L_5 = ___1_t;
		double L_6;
		L_6 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_5, NULL);
		___1_t = L_6;
		// i = Mathf.Clamp(i, 0, points.Length - 2);
		int32_t L_7 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_8 = __this->___points_0;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline(L_7, 0, ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_8)->max_length)), 2)), NULL);
		___2_i = L_9;
		// point = Vector3.Lerp(points[i].position, points[i + 1].position, (float)t);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_10 = ___0_point;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_11 = __this->___points_0;
		int32_t L_12 = ___2_i;
		NullCheck(L_11);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = ((L_11)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_12)))->___position_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_14 = __this->___points_0;
		int32_t L_15 = ___2_i;
		NullCheck(L_14);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ((L_14)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_15, 1)))))->___position_1;
		double L_17 = ___1_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_13, L_16, ((float)L_17), NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_10 = L_18;
		return;
	}

IL_006f:
	{
		// } else point = points[i].position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_19 = ___0_point;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_20 = __this->___points_0;
		int32_t L_21 = ___2_i;
		NullCheck(L_20);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = ((L_20)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_21)))->___position_1;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_19 = L_22;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::LinearGetTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_LinearGetTangent_mB82558C318EAFAE8C5DE036AB7A580B049AF824C (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (points.Length == 0)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if ((((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0015;
		}
	}
	{
		// tangent = Vector3.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_1 = ___0_tangent;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_1 = L_2;
		// return;
		return;
	}

IL_0015:
	{
		// GetCatPoints(i);
		int32_t L_3 = ___2_i;
		Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E(__this, L_3, NULL);
		// if (linearAverageDirection) tangent = Vector3.Slerp(catPoints[1] - catPoints[0], catPoints[2] - catPoints[1], 0.5f);
		bool L_4 = __this->___linearAverageDirection_3;
		if (!L_4)
		{
			goto IL_006b;
		}
	}
	{
		// if (linearAverageDirection) tangent = Vector3.Slerp(catPoints[1] - catPoints[0], catPoints[2] - catPoints[1], 0.5f);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_5 = ___0_tangent;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_6 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_6);
		int32_t L_7 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_9 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_9);
		int32_t L_10 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_8, L_11, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_13 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_13);
		int32_t L_14 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_16 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_16);
		int32_t L_17 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_15, L_18, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_12, L_19, (0.5f), NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_5 = L_20;
		return;
	}

IL_006b:
	{
		// else tangent = catPoints[2] - catPoints[1];
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_21 = ___0_tangent;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_22);
		int32_t L_23 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_25 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_25);
		int32_t L_26 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27 = (L_25)->GetAt(static_cast<il2cpp_array_size_t>(L_26));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_24, L_27, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_21 = L_28;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::BSPGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_BSPGetPoint_mBB1EAF649CE9594188EBBA68994A6629952BCD2A (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_time, int32_t ___2_i, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		// if (points.Length > 0) point = points[0].position;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if (!(((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0020;
		}
	}
	{
		// if (points.Length > 0) point = points[0].position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_1 = ___0_point;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		NullCheck(L_2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ((L_2)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___position_1;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_1 = L_3;
	}

IL_0020:
	{
		// if (points.Length > 1)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		NullCheck(L_4);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))) <= ((int32_t)1)))
		{
			goto IL_016a;
		}
	}
	{
		// float t1 = (float)DMath.Clamp01(time);
		double L_5 = ___1_time;
		double L_6;
		L_6 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_5, NULL);
		V_0 = ((float)L_6);
		// GetCatPoints(i);
		int32_t L_7 = ___2_i;
		Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E(__this, L_7, NULL);
		// point = ((-catPoints[0] + catPoints[2]) / 2f
		// + t1 * ((catPoints[0] - 2f * catPoints[1] + catPoints[2]) / 2f
		// + t1 * (-catPoints[0] + 3f * catPoints[1] - 3f * catPoints[2] + catPoints[3]) / 6f)) * t1
		// + (catPoints[0] + 4f * catPoints[1] + catPoints[2]) / 6f;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_8 = ___0_point;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_9 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_9);
		int32_t L_10 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_11, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_13 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_13);
		int32_t L_14 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_12, L_15, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17;
		L_17 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_16, (2.0f), NULL);
		float L_18 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_19 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_19);
		int32_t L_20 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21 = (L_19)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_22);
		int32_t L_23 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((2.0f), L_24, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_21, L_25, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_27 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_27);
		int32_t L_28 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = (L_27)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30;
		L_30 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_26, L_29, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_30, (2.0f), NULL);
		float L_32 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_33 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_33);
		int32_t L_34 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = (L_33)->GetAt(static_cast<il2cpp_array_size_t>(L_34));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36;
		L_36 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_35, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_37 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_37);
		int32_t L_38 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39 = (L_37)->GetAt(static_cast<il2cpp_array_size_t>(L_38));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40;
		L_40 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((3.0f), L_39, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41;
		L_41 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_36, L_40, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_42 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_42);
		int32_t L_43 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44 = (L_42)->GetAt(static_cast<il2cpp_array_size_t>(L_43));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45;
		L_45 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((3.0f), L_44, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46;
		L_46 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_41, L_45, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_47 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_47);
		int32_t L_48 = 3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49 = (L_47)->GetAt(static_cast<il2cpp_array_size_t>(L_48));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50;
		L_50 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_46, L_49, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51;
		L_51 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_32, L_50, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_52;
		L_52 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_51, (6.0f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53;
		L_53 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_31, L_52, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54;
		L_54 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_18, L_53, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55;
		L_55 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_17, L_54, NULL);
		float L_56 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57;
		L_57 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_55, L_56, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_58 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_58);
		int32_t L_59 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_60 = (L_58)->GetAt(static_cast<il2cpp_array_size_t>(L_59));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_61 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_61);
		int32_t L_62 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_63 = (L_61)->GetAt(static_cast<il2cpp_array_size_t>(L_62));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_64;
		L_64 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((4.0f), L_63, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65;
		L_65 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_60, L_64, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_66 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_66);
		int32_t L_67 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68 = (L_66)->GetAt(static_cast<il2cpp_array_size_t>(L_67));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69;
		L_69 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_65, L_68, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_70;
		L_70 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_69, (6.0f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_71;
		L_71 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_57, L_70, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_8 = L_71;
	}

IL_016a:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::BezierGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_BezierGetPoint_mF488DEAF2BFFE1C6457729D545B3C37FC0D6CF39 (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		// if (points.Length > 0) point = points[0].position;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if (!(((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0022;
		}
	}
	{
		// if (points.Length > 0) point = points[0].position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_1 = ___0_point;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		NullCheck(L_2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ((L_2)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___position_1;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_1 = L_3;
		goto IL_0023;
	}

IL_0022:
	{
		// else return;
		return;
	}

IL_0023:
	{
		// if (points.Length == 1) return;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		NullCheck(L_4);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))) == ((uint32_t)1))))
		{
			goto IL_002f;
		}
	}
	{
		// if (points.Length == 1) return;
		return;
	}

IL_002f:
	{
		// if (i < points.Length - 1)
		int32_t L_5 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_6 = __this->___points_0;
		NullCheck(L_6);
		if ((((int32_t)L_5) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_6)->max_length)), 1)))))
		{
			goto IL_00f6;
		}
	}
	{
		// t = DMath.Clamp01(t);
		double L_7 = ___1_t;
		double L_8;
		L_8 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_7, NULL);
		___1_t = L_8;
		// i = Mathf.Clamp(i, 0, points.Length - 2);
		int32_t L_9 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_10 = __this->___points_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline(L_9, 0, ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_10)->max_length)), 2)), NULL);
		___2_i = L_11;
		// float ft = (float)t;
		double L_12 = ___1_t;
		V_0 = ((float)L_12);
		// float nt = 1f - ft;
		float L_13 = V_0;
		V_1 = ((float)il2cpp_codegen_subtract((1.0f), L_13));
		// point = nt * nt * nt * points[i].position +
		//     3f * nt * nt * ft * points[i].tangent2 +
		//     3f * nt * ft * ft * points[i + 1].tangent +
		//     ft * ft * ft * points[i + 1].position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_14 = ___0_point;
		float L_15 = V_1;
		float L_16 = V_1;
		float L_17 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_18 = __this->___points_0;
		int32_t L_19 = ___2_i;
		NullCheck(L_18);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = ((L_18)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_19)))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_15, L_16)), L_17)), L_20, NULL);
		float L_22 = V_1;
		float L_23 = V_1;
		float L_24 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_25 = __this->___points_0;
		int32_t L_26 = ___2_i;
		NullCheck(L_25);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27 = ((L_25)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_26)))->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((3.0f), L_22)), L_23)), L_24)), L_27, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_21, L_28, NULL);
		float L_30 = V_1;
		float L_31 = V_0;
		float L_32 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_33 = __this->___points_0;
		int32_t L_34 = ___2_i;
		NullCheck(L_33);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = ((L_33)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_34, 1)))))->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36;
		L_36 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((3.0f), L_30)), L_31)), L_32)), L_35, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_29, L_36, NULL);
		float L_38 = V_0;
		float L_39 = V_0;
		float L_40 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_41 = __this->___points_0;
		int32_t L_42 = ___2_i;
		NullCheck(L_41);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_43 = ((L_41)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_42, 1)))))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44;
		L_44 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_38, L_39)), L_40)), L_43, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45;
		L_45 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_37, L_44, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_14 = L_45;
	}

IL_00f6:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::BezierGetTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_BezierGetTangent_mA55EB1C827D49D884D96225A1C464ED30F6CF95C (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_tangent, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		// if (points.Length > 0) tangent = points[0].tangent2;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_0 = __this->___points_0;
		NullCheck(L_0);
		if (!(((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0022;
		}
	}
	{
		// if (points.Length > 0) tangent = points[0].tangent2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_1 = ___0_tangent;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		NullCheck(L_2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ((L_2)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___tangent2_6;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_1 = L_3;
		goto IL_0023;
	}

IL_0022:
	{
		// else return;
		return;
	}

IL_0023:
	{
		// if (points.Length == 1) return;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_4 = __this->___points_0;
		NullCheck(L_4);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))) == ((uint32_t)1))))
		{
			goto IL_002f;
		}
	}
	{
		// if (points.Length == 1) return;
		return;
	}

IL_002f:
	{
		// if (i < points.Length - 1)
		int32_t L_5 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_6 = __this->___points_0;
		NullCheck(L_6);
		if ((((int32_t)L_5) >= ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_6)->max_length)), 1)))))
		{
			goto IL_0144;
		}
	}
	{
		// t = DMath.Clamp01(t);
		double L_7 = ___1_t;
		double L_8;
		L_8 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_7, NULL);
		___1_t = L_8;
		// i = Mathf.Clamp(i, 0, points.Length - 2);
		int32_t L_9 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_10 = __this->___points_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline(L_9, 0, ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_10)->max_length)), 2)), NULL);
		___2_i = L_11;
		// float ft = (float)t;
		double L_12 = ___1_t;
		V_0 = ((float)L_12);
		// float nt = 1f - ft;
		float L_13 = V_0;
		V_1 = ((float)il2cpp_codegen_subtract((1.0f), L_13));
		// tangent = -3 * nt * nt * points[i].position +
		//     3 * nt * nt * points[i].tangent2 -
		//     6 * ft * nt * points[i].tangent2 -
		//     3 * ft * ft * points[i + 1].tangent +
		//     6 * ft * nt * points[i + 1].tangent +
		//     3 * ft * ft * points[i + 1].position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_14 = ___0_tangent;
		float L_15 = V_1;
		float L_16 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_17 = __this->___points_0;
		int32_t L_18 = ___2_i;
		NullCheck(L_17);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19 = ((L_17)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_18)))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((-3.0f), L_15)), L_16)), L_19, NULL);
		float L_21 = V_1;
		float L_22 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_23 = __this->___points_0;
		int32_t L_24 = ___2_i;
		NullCheck(L_23);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = ((L_23)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_24)))->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((3.0f), L_21)), L_22)), L_25, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_20, L_26, NULL);
		float L_28 = V_0;
		float L_29 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_30 = __this->___points_0;
		int32_t L_31 = ___2_i;
		NullCheck(L_30);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32 = ((L_30)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_31)))->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33;
		L_33 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((6.0f), L_28)), L_29)), L_32, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34;
		L_34 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_27, L_33, NULL);
		float L_35 = V_0;
		float L_36 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_37 = __this->___points_0;
		int32_t L_38 = ___2_i;
		NullCheck(L_37);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39 = ((L_37)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_38, 1)))))->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40;
		L_40 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((3.0f), L_35)), L_36)), L_39, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41;
		L_41 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_34, L_40, NULL);
		float L_42 = V_0;
		float L_43 = V_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_44 = __this->___points_0;
		int32_t L_45 = ___2_i;
		NullCheck(L_44);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46 = ((L_44)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_45, 1)))))->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_47;
		L_47 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((6.0f), L_42)), L_43)), L_46, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_48;
		L_48 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_41, L_47, NULL);
		float L_49 = V_0;
		float L_50 = V_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_51 = __this->___points_0;
		int32_t L_52 = ___2_i;
		NullCheck(L_51);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53 = ((L_51)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_52, 1)))))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54;
		L_54 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply((3.0f), L_49)), L_50)), L_53, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55;
		L_55 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_48, L_54, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_14 = L_55;
	}

IL_0144:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::CatmullRomGetPoint(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_CatmullRomGetPoint_m1AC3943C3EF3392C689F1967625BE4CF7D8BD62B (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_point, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	{
		// float t1 = (float)t;
		double L_0 = ___1_t;
		V_0 = ((float)L_0);
		// float t2 = t1 * t1;
		float L_1 = V_0;
		float L_2 = V_0;
		V_1 = ((float)il2cpp_codegen_multiply(L_1, L_2));
		// float t3 = t2 * t1;
		float L_3 = V_1;
		float L_4 = V_0;
		V_2 = ((float)il2cpp_codegen_multiply(L_3, L_4));
		// if (points.Length > 0) point = points[0].position;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_5 = __this->___points_0;
		NullCheck(L_5);
		if (!(((RuntimeArray*)L_5)->max_length))
		{
			goto IL_002b;
		}
	}
	{
		// if (points.Length > 0) point = points[0].position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_6 = ___0_point;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_7 = __this->___points_0;
		NullCheck(L_7);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ((L_7)->GetAddressAt(static_cast<il2cpp_array_size_t>(0)))->___position_1;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_6 = L_8;
	}

IL_002b:
	{
		// if (i >= points.Length) return;
		int32_t L_9 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_10 = __this->___points_0;
		NullCheck(L_10);
		if ((((int32_t)L_9) < ((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length)))))
		{
			goto IL_0037;
		}
	}
	{
		// if (i >= points.Length) return;
		return;
	}

IL_0037:
	{
		// if (points.Length > 1)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_11 = __this->___points_0;
		NullCheck(L_11);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_11)->max_length))) <= ((int32_t)1)))
		{
			goto IL_015f;
		}
	}
	{
		// GetCatPoints(i);
		int32_t L_12 = ___2_i;
		Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E(__this, L_12, NULL);
		// point = 0.5f * ((2f * catPoints[1]) + (-catPoints[0] + catPoints[2]) * t1
		// + (2f * catPoints[0] - 5f * catPoints[1] + 4f * catPoints[2] - catPoints[3]) * t2
		// + (-catPoints[0] + 3f * catPoints[1] - 3f * catPoints[2] + catPoints[3]) * t3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_13 = ___0_point;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_14 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_14);
		int32_t L_15 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17;
		L_17 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((2.0f), L_16, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_18 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_18);
		int32_t L_19 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_20, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_22);
		int32_t L_23 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_21, L_24, NULL);
		float L_26 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_25, L_26, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_17, L_27, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_29);
		int32_t L_30 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32;
		L_32 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((2.0f), L_31, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_33 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_33);
		int32_t L_34 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = (L_33)->GetAt(static_cast<il2cpp_array_size_t>(L_34));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36;
		L_36 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((5.0f), L_35, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_32, L_36, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_38);
		int32_t L_39 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41;
		L_41 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((4.0f), L_40, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42;
		L_42 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_37, L_41, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_43 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_43);
		int32_t L_44 = 3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45 = (L_43)->GetAt(static_cast<il2cpp_array_size_t>(L_44));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46;
		L_46 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_42, L_45, NULL);
		float L_47 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_48;
		L_48 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_46, L_47, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49;
		L_49 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_28, L_48, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_50 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_50);
		int32_t L_51 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_52 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_51));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53;
		L_53 = Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline(L_52, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_54 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_54);
		int32_t L_55 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_56 = (L_54)->GetAt(static_cast<il2cpp_array_size_t>(L_55));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57;
		L_57 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((3.0f), L_56, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58;
		L_58 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_53, L_57, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_59 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_59);
		int32_t L_60 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_61 = (L_59)->GetAt(static_cast<il2cpp_array_size_t>(L_60));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_62;
		L_62 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((3.0f), L_61, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_63;
		L_63 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_58, L_62, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_64 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_64);
		int32_t L_65 = 3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_66 = (L_64)->GetAt(static_cast<il2cpp_array_size_t>(L_65));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_67;
		L_67 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_63, L_66, NULL);
		float L_68 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69;
		L_69 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_67, L_68, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_70;
		L_70 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_49, L_69, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_71;
		L_71 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline((0.5f), L_70, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_13 = L_71;
	}

IL_015f:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::GetCatmullRomTangent(UnityEngine.Vector3&,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetCatmullRomTangent_mC2E20E825154CD11CBB31543984660B55EE7773F (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_direction, double ___1_t, int32_t ___2_i, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		// float t1 = (float)t;
		double L_0 = ___1_t;
		V_0 = ((float)L_0);
		// float t2 = t1 * t1;
		float L_1 = V_0;
		float L_2 = V_0;
		V_1 = ((float)il2cpp_codegen_multiply(L_1, L_2));
		// if (points.Length > 0) direction = Vector3.forward;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_3 = __this->___points_0;
		NullCheck(L_3);
		if (!(((RuntimeArray*)L_3)->max_length))
		{
			goto IL_001b;
		}
	}
	{
		// if (points.Length > 0) direction = Vector3.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_4 = ___0_direction;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5;
		L_5 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_4 = L_5;
	}

IL_001b:
	{
		// if (i >= points.Length) return;
		int32_t L_6 = ___2_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_7 = __this->___points_0;
		NullCheck(L_7);
		if ((((int32_t)L_6) < ((int32_t)((int32_t)(((RuntimeArray*)L_7)->max_length)))))
		{
			goto IL_0027;
		}
	}
	{
		// if (i >= points.Length) return;
		return;
	}

IL_0027:
	{
		// if (points.Length > 1)
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_8 = __this->___points_0;
		NullCheck(L_8);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length))) <= ((int32_t)1)))
		{
			goto IL_0107;
		}
	}
	{
		// GetCatPoints(i);
		int32_t L_9 = ___2_i;
		Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E(__this, L_9, NULL);
		// direction = (6 * t2 - 6 * t1) * catPoints[1]
		// + (3 * t2 - 4 * t1 + 1) * (catPoints[2] - catPoints[0]) * 0.5f
		// + (-6 * t2 + 6 * t1) * catPoints[2]
		// + (3 * t2 - 2 * t1) * (catPoints[3] - catPoints[1]) * 0.5f;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_10 = ___0_direction;
		float L_11 = V_1;
		float L_12 = V_0;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_13 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_13);
		int32_t L_14 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply((6.0f), L_11)), ((float)il2cpp_codegen_multiply((6.0f), L_12)))), L_15, NULL);
		float L_17 = V_1;
		float L_18 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_19 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_19);
		int32_t L_20 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21 = (L_19)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_22);
		int32_t L_23 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_21, L_24, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_add(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply((3.0f), L_17)), ((float)il2cpp_codegen_multiply((4.0f), L_18)))), (1.0f))), L_25, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_26, (0.5f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_16, L_27, NULL);
		float L_29 = V_1;
		float L_30 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_31);
		int32_t L_32 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = (L_31)->GetAt(static_cast<il2cpp_array_size_t>(L_32));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34;
		L_34 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply((-6.0f), L_29)), ((float)il2cpp_codegen_multiply((6.0f), L_30)))), L_33, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35;
		L_35 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_28, L_34, NULL);
		float L_36 = V_1;
		float L_37 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_38);
		int32_t L_39 = 3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_41 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_41);
		int32_t L_42 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_43 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44;
		L_44 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_40, L_43, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45;
		L_45 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply((3.0f), L_36)), ((float)il2cpp_codegen_multiply((2.0f), L_37)))), L_44, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46;
		L_46 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_45, (0.5f), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_47;
		L_47 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_35, L_46, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_10 = L_47;
	}

IL_0107:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::GetCatPoints(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_GetCatPoints_m8B898C13C2307DE40B6E7E1A1FB3996D5C82F43E (Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B* __this, int32_t ___0_i, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (i > 0) catPoints[0] = points[i - 1].position;
		int32_t L_0 = ___0_i;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0027;
		}
	}
	{
		// if (i > 0) catPoints[0] = points[i - 1].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_1 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_2 = __this->___points_0;
		int32_t L_3 = ___0_i;
		NullCheck(L_2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ((L_2)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(L_3, 1)))))->___position_1;
		NullCheck(L_1);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_4);
		goto IL_00d8;
	}

IL_0027:
	{
		// else if (closed && points.Length - 2 > i) catPoints[0] = points[points.Length - 2].position;
		bool L_5 = __this->___closed_1;
		if (!L_5)
		{
			goto IL_0063;
		}
	}
	{
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_6 = __this->___points_0;
		NullCheck(L_6);
		int32_t L_7 = ___0_i;
		if ((((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_6)->max_length)), 2))) <= ((int32_t)L_7)))
		{
			goto IL_0063;
		}
	}
	{
		// else if (closed && points.Length - 2 > i) catPoints[0] = points[points.Length - 2].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_8 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_9 = __this->___points_0;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_10 = __this->___points_0;
		NullCheck(L_10);
		NullCheck(L_9);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = ((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_10)->max_length)), 2)))))->___position_1;
		NullCheck(L_8);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(0), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_11);
		goto IL_00d8;
	}

IL_0063:
	{
		// else if (i + 1 < points.Length) catPoints[0] = points[i].position + (points[i].position - points[i + 1].position); //Extrapolate
		int32_t L_12 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_13 = __this->___points_0;
		NullCheck(L_13);
		if ((((int32_t)((int32_t)il2cpp_codegen_add(L_12, 1))) >= ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_00bc;
		}
	}
	{
		// else if (i + 1 < points.Length) catPoints[0] = points[i].position + (points[i].position - points[i + 1].position); //Extrapolate
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_14 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_15 = __this->___points_0;
		int32_t L_16 = ___0_i;
		NullCheck(L_15);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17 = ((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16)))->___position_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_18 = __this->___points_0;
		int32_t L_19 = ___0_i;
		NullCheck(L_18);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = ((L_18)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_19)))->___position_1;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_21 = __this->___points_0;
		int32_t L_22 = ___0_i;
		NullCheck(L_21);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = ((L_21)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_22, 1)))))->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_20, L_23, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_17, L_24, NULL);
		NullCheck(L_14);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(0), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_25);
		goto IL_00d8;
	}

IL_00bc:
	{
		// else catPoints[0] = points[i].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_26 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_27 = __this->___points_0;
		int32_t L_28 = ___0_i;
		NullCheck(L_27);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = ((L_27)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_28)))->___position_1;
		NullCheck(L_26);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(0), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_29);
	}

IL_00d8:
	{
		// catPoints[1] = points[i].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_30 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_31 = __this->___points_0;
		int32_t L_32 = ___0_i;
		NullCheck(L_31);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = ((L_31)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_32)))->___position_1;
		NullCheck(L_30);
		(L_30)->SetAt(static_cast<il2cpp_array_size_t>(1), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_33);
		// if (i + 1 < points.Length) catPoints[2] = points[i + 1].position;
		int32_t L_34 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_35 = __this->___points_0;
		NullCheck(L_35);
		if ((((int32_t)((int32_t)il2cpp_codegen_add(L_34, 1))) >= ((int32_t)((int32_t)(((RuntimeArray*)L_35)->max_length)))))
		{
			goto IL_0121;
		}
	}
	{
		// if (i + 1 < points.Length) catPoints[2] = points[i + 1].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_36 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_37 = __this->___points_0;
		int32_t L_38 = ___0_i;
		NullCheck(L_37);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39 = ((L_37)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_38, 1)))))->___position_1;
		NullCheck(L_36);
		(L_36)->SetAt(static_cast<il2cpp_array_size_t>(2), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_39);
		goto IL_0197;
	}

IL_0121:
	{
		// else if (closed && (i + 2) - points.Length != i) catPoints[2] = points[(i + 2) - points.Length].position;
		bool L_40 = __this->___closed_1;
		if (!L_40)
		{
			goto IL_0161;
		}
	}
	{
		int32_t L_41 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_42 = __this->___points_0;
		NullCheck(L_42);
		int32_t L_43 = ___0_i;
		if ((((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_41, 2)), ((int32_t)(((RuntimeArray*)L_42)->max_length))))) == ((int32_t)L_43)))
		{
			goto IL_0161;
		}
	}
	{
		// else if (closed && (i + 2) - points.Length != i) catPoints[2] = points[(i + 2) - points.Length].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_44 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_45 = __this->___points_0;
		int32_t L_46 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_47 = __this->___points_0;
		NullCheck(L_47);
		NullCheck(L_45);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_48 = ((L_45)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_46, 2)), ((int32_t)(((RuntimeArray*)L_47)->max_length)))))))->___position_1;
		NullCheck(L_44);
		(L_44)->SetAt(static_cast<il2cpp_array_size_t>(2), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_48);
		goto IL_0197;
	}

IL_0161:
	{
		// else catPoints[2] = catPoints[1] + (catPoints[1] - catPoints[0]); //Extrapolate
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_49 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_50 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_50);
		int32_t L_51 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_52 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_51));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_53 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_53);
		int32_t L_54 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55 = (L_53)->GetAt(static_cast<il2cpp_array_size_t>(L_54));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_56 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_56);
		int32_t L_57 = 0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_57));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59;
		L_59 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_55, L_58, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_60;
		L_60 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_52, L_59, NULL);
		NullCheck(L_49);
		(L_49)->SetAt(static_cast<il2cpp_array_size_t>(2), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_60);
	}

IL_0197:
	{
		// if (i + 2 < points.Length) catPoints[3] = points[i + 2].position;
		int32_t L_61 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_62 = __this->___points_0;
		NullCheck(L_62);
		if ((((int32_t)((int32_t)il2cpp_codegen_add(L_61, 2))) >= ((int32_t)((int32_t)(((RuntimeArray*)L_62)->max_length)))))
		{
			goto IL_01c3;
		}
	}
	{
		// if (i + 2 < points.Length) catPoints[3] = points[i + 2].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_63 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_64 = __this->___points_0;
		int32_t L_65 = ___0_i;
		NullCheck(L_64);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_66 = ((L_64)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_65, 2)))))->___position_1;
		NullCheck(L_63);
		(L_63)->SetAt(static_cast<il2cpp_array_size_t>(3), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_66);
		return;
	}

IL_01c3:
	{
		// else if (closed && (i + 3) - points.Length != i) catPoints[3] = points[(i + 3) - points.Length].position;
		bool L_67 = __this->___closed_1;
		if (!L_67)
		{
			goto IL_0202;
		}
	}
	{
		int32_t L_68 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_69 = __this->___points_0;
		NullCheck(L_69);
		int32_t L_70 = ___0_i;
		if ((((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_68, 3)), ((int32_t)(((RuntimeArray*)L_69)->max_length))))) == ((int32_t)L_70)))
		{
			goto IL_0202;
		}
	}
	{
		// else if (closed && (i + 3) - points.Length != i) catPoints[3] = points[(i + 3) - points.Length].position;
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_71 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_72 = __this->___points_0;
		int32_t L_73 = ___0_i;
		SplinePointU5BU5D_tE98F69C60D05234480890ECBE9DC8B4982990E3C* L_74 = __this->___points_0;
		NullCheck(L_74);
		NullCheck(L_72);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_75 = ((L_72)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_73, 3)), ((int32_t)(((RuntimeArray*)L_74)->max_length)))))))->___position_1;
		NullCheck(L_71);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(3), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_75);
		return;
	}

IL_0202:
	{
		// else catPoints[3] = catPoints[2] + (catPoints[2] - catPoints[1]); //Extrapolate
		il2cpp_codegen_runtime_class_init_inline(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_76 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_77 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_77);
		int32_t L_78 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_79 = (L_77)->GetAt(static_cast<il2cpp_array_size_t>(L_78));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_80 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_80);
		int32_t L_81 = 2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_82 = (L_80)->GetAt(static_cast<il2cpp_array_size_t>(L_81));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_83 = ((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7;
		NullCheck(L_83);
		int32_t L_84 = 1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_85 = (L_83)->GetAt(static_cast<il2cpp_array_size_t>(L_84));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_86;
		L_86 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_82, L_85, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_87;
		L_87 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_79, L_86, NULL);
		NullCheck(L_76);
		(L_76)->SetAt(static_cast<il2cpp_array_size_t>(3), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_87);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::FormatFromTo(System.Double&,System.Double&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline_FormatFromTo_m33C9E800134DC57E5F75D9E5850D9AC6CA77F764 (double* ___0_from, double* ___1_to, bool ___2_preventInvert, const RuntimeMethod* method) 
{
	double V_0 = 0.0;
	{
		// from = DMath.Clamp01(from);
		double* L_0 = ___0_from;
		double* L_1 = ___0_from;
		double L_2 = *((double*)L_1);
		double L_3;
		L_3 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_2, NULL);
		*((double*)L_0) = (double)L_3;
		// to = DMath.Clamp01(to);
		double* L_4 = ___1_to;
		double* L_5 = ___1_to;
		double L_6 = *((double*)L_5);
		double L_7;
		L_7 = DMath_Clamp01_mE1231DFF86EB6B17903D185364FC56451EE84F1E(L_6, NULL);
		*((double*)L_4) = (double)L_7;
		// if (preventInvert && from > to)
		bool L_8 = ___2_preventInvert;
		if (!L_8)
		{
			goto IL_0026;
		}
	}
	{
		double* L_9 = ___0_from;
		double L_10 = *((double*)L_9);
		double* L_11 = ___1_to;
		double L_12 = *((double*)L_11);
		if ((!(((double)L_10) > ((double)L_12))))
		{
			goto IL_0026;
		}
	}
	{
		// double tmp = from;
		double* L_13 = ___0_from;
		double L_14 = *((double*)L_13);
		V_0 = L_14;
		// from = to;
		double* L_15 = ___0_from;
		double* L_16 = ___1_to;
		double L_17 = *((double*)L_16);
		*((double*)L_15) = (double)L_17;
		// to = tmp;
		double* L_18 = ___1_to;
		double L_19 = V_0;
		*((double*)L_18) = (double)L_19;
		return;
	}

IL_0026:
	{
		// } else  to = DMath.Clamp(to, 0.0, 1.0);
		double* L_20 = ___1_to;
		double* L_21 = ___1_to;
		double L_22 = *((double*)L_21);
		double L_23;
		L_23 = DMath_Clamp_m5FF4D892D00AB10A164C167334755F3232981EFD(L_22, (0.0), (1.0), NULL);
		*((double*)L_20) = (double)L_23;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.Spline::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Spline__cctor_mE32F2F3D2A9080FC8A1C31305FC6C35CEBF7CD85 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private static Vector3[] catPoints = new Vector3[4];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_0 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)4);
		((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_StaticFields*)il2cpp_codegen_static_fields_for(Spline_tB76ECE12D4B0865E26CE5BA5EDA670759FE1E84B_il2cpp_TypeInfo_var))->___catPoints_7), (void*)L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Dreamteck.Splines.SplinePoint/Type Dreamteck.Splines.SplinePoint::get_type()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) 
{
	{
		// get { return _type; }
		int32_t L_0 = __this->____type_0;
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Void Dreamteck.Splines.SplinePoint::set_type(Dreamteck.Splines.SplinePoint/Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		// _type = value;
		int32_t L_0 = ___0_value;
		__this->____type_0 = L_0;
		// if(value == Type.SmoothMirrored) SmoothMirrorTangent2();
		int32_t L_1 = ___0_value;
		if (L_1)
		{
			goto IL_0010;
		}
	}
	{
		// if(value == Type.SmoothMirrored) SmoothMirrorTangent2();
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
	}

IL_0010:
	{
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF_AdjustorThunk (RuntimeObject* __this, int32_t ___0_value, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF(_thisAdjusted, ___0_value, method);
}
// Dreamteck.Splines.SplinePoint Dreamteck.Splines.SplinePoint::Lerp(Dreamteck.Splines.SplinePoint,Dreamteck.Splines.SplinePoint,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB SplinePoint_Lerp_m846D0513298EC3B10CCD623AA27A737DB1638E6B (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___0_a, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// SplinePoint result = a;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_0 = ___0_a;
		V_0 = L_0;
		// if (a.type == Type.Broken || b.type == Type.Broken) result.type = Type.Broken;
		int32_t L_1;
		L_1 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline((&___0_a), NULL);
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0016;
		}
	}
	{
		int32_t L_2;
		L_2 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline((&___1_b), NULL);
		if ((!(((uint32_t)L_2) == ((uint32_t)1))))
		{
			goto IL_0020;
		}
	}

IL_0016:
	{
		// if (a.type == Type.Broken || b.type == Type.Broken) result.type = Type.Broken;
		SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF((&V_0), 1, NULL);
		goto IL_0046;
	}

IL_0020:
	{
		// else if (a.type == Type.SmoothFree || b.type == Type.SmoothFree) result.type = Type.SmoothFree;
		int32_t L_3;
		L_3 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline((&___0_a), NULL);
		if ((((int32_t)L_3) == ((int32_t)2)))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_4;
		L_4 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline((&___1_b), NULL);
		if ((!(((uint32_t)L_4) == ((uint32_t)2))))
		{
			goto IL_003e;
		}
	}

IL_0034:
	{
		// else if (a.type == Type.SmoothFree || b.type == Type.SmoothFree) result.type = Type.SmoothFree;
		SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF((&V_0), 2, NULL);
		goto IL_0046;
	}

IL_003e:
	{
		// else result.type = Type.SmoothMirrored;
		SplinePoint_set_type_m96E8C0DA5FABC6F5FC956F863AC4D31B442AD0AF((&V_0), 0, NULL);
	}

IL_0046:
	{
		// result.position = Vector3.Lerp(a.position, b.position, t);
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_5 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = L_5.___position_1;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_7 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = L_7.___position_1;
		float L_9 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_6, L_8, L_9, NULL);
		(&V_0)->___position_1 = L_10;
		// GetInterpolatedTangents(a, b, t, out result.tangent, out result.tangent2);
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_11 = ___0_a;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_12 = ___1_b;
		float L_13 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_14 = (&(&V_0)->___tangent_5);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_15 = (&(&V_0)->___tangent2_6);
		SplinePoint_GetInterpolatedTangents_mB11DCA5F98C4C5F5137968CAC801095756BAF2C1(L_11, L_12, L_13, L_14, L_15, NULL);
		// result.color = Color.Lerp(a.color, b.color, t);
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_16 = ___0_a;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_17 = L_16.___color_2;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_18 = ___1_b;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_19 = L_18.___color_2;
		float L_20 = ___2_t;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_21;
		L_21 = Color_Lerp_mE79F87889843ECDC188E4CB5B5E1F1B2256E5EBE_inline(L_17, L_19, L_20, NULL);
		(&V_0)->___color_2 = L_21;
		// result.size = Mathf.Lerp(a.size, b.size, t);
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_22 = ___0_a;
		float L_23 = L_22.___size_4;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_24 = ___1_b;
		float L_25 = L_24.___size_4;
		float L_26 = ___2_t;
		float L_27;
		L_27 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_23, L_25, L_26, NULL);
		(&V_0)->___size_4 = L_27;
		// result.normal = Vector3.Slerp(a.normal, b.normal, t);
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_28 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = L_28.___normal_3;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_30 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31 = L_30.___normal_3;
		float L_32 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33;
		L_33 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_29, L_31, L_32, NULL);
		(&V_0)->___normal_3 = L_33;
		// return result;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_34 = V_0;
		return L_34;
	}
}
// System.Void Dreamteck.Splines.SplinePoint::GetInterpolatedTangents(Dreamteck.Splines.SplinePoint,Dreamteck.Splines.SplinePoint,System.Single,UnityEngine.Vector3&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_GetInterpolatedTangents_mB11DCA5F98C4C5F5137968CAC801095756BAF2C1 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___0_a, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___1_b, float ___2_t, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___3_t1, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___4_t2, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_3;
	memset((&V_3), 0, sizeof(V_3));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	{
		// Vector3 P0_1 = (1f - t) * a.position + t * a.tangent2;
		float L_0 = ___2_t;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_1 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = L_1.___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract((1.0f), L_0)), L_2, NULL);
		float L_4 = ___2_t;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_5 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = L_5.___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_4, L_6, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_3, L_7, NULL);
		V_0 = L_8;
		// Vector3 P1_2 = (1f - t) * a.tangent2 + t * b.tangent;
		float L_9 = ___2_t;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_10 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = L_10.___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract((1.0f), L_9)), L_11, NULL);
		float L_13 = ___2_t;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_14 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = L_14.___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_13, L_15, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17;
		L_17 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_12, L_16, NULL);
		V_1 = L_17;
		// Vector3 P2_3 = (1f - t) * b.tangent + t * b.position;
		float L_18 = ___2_t;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_19 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = L_19.___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract((1.0f), L_18)), L_20, NULL);
		float L_22 = ___2_t;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_23 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = L_23.___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25;
		L_25 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_22, L_24, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_21, L_25, NULL);
		V_2 = L_26;
		// Vector3 P01_12 = (1 - t) * P0_1 + t * P1_2;
		float L_27 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract((1.0f), L_27)), L_28, NULL);
		float L_30 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32;
		L_32 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_30, L_31, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33;
		L_33 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_29, L_32, NULL);
		V_3 = L_33;
		// Vector3 P12_23 = (1 - t) * P1_2 + t * P2_3;
		float L_34 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36;
		L_36 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(((float)il2cpp_codegen_subtract((1.0f), L_34)), L_35, NULL);
		float L_37 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39;
		L_39 = Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline(L_37, L_38, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40;
		L_40 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_36, L_39, NULL);
		V_4 = L_40;
		// t1 = P01_12;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_41 = ___3_t1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_42 = V_3;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_41 = L_42;
		// t2 = P12_23;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_43 = ___4_t2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44 = V_4;
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_43 = L_44;
		// }
		return;
	}
}
// System.Boolean Dreamteck.Splines.SplinePoint::AreDifferent(Dreamteck.Splines.SplinePoint&,Dreamteck.Splines.SplinePoint&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SplinePoint_AreDifferent_mD6F131070C742284538AE3E586FD791E45261643 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* ___0_a, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* ___1_b, const RuntimeMethod* method) 
{
	{
		// if (a.position != b.position) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_0 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = L_0->___position_1;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_2 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = L_2->___position_1;
		bool L_4;
		L_4 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_1, L_3, NULL);
		if (!L_4)
		{
			goto IL_0015;
		}
	}
	{
		// if (a.position != b.position) return true;
		return (bool)1;
	}

IL_0015:
	{
		// if (a.tangent != b.tangent) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_5 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = L_5->___tangent_5;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_7 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = L_7->___tangent_5;
		bool L_9;
		L_9 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_6, L_8, NULL);
		if (!L_9)
		{
			goto IL_002a;
		}
	}
	{
		// if (a.tangent != b.tangent) return true;
		return (bool)1;
	}

IL_002a:
	{
		// if (a.tangent2 != b.tangent2) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_10 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = L_10->___tangent2_6;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_12 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = L_12->___tangent2_6;
		bool L_14;
		L_14 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_11, L_13, NULL);
		if (!L_14)
		{
			goto IL_003f;
		}
	}
	{
		// if (a.tangent2 != b.tangent2) return true;
		return (bool)1;
	}

IL_003f:
	{
		// if (a.normal != b.normal) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_15 = ___0_a;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = L_15->___normal_3;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_17 = ___1_b;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = L_17->___normal_3;
		bool L_19;
		L_19 = Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline(L_16, L_18, NULL);
		if (!L_19)
		{
			goto IL_0054;
		}
	}
	{
		// if (a.normal != b.normal) return true;
		return (bool)1;
	}

IL_0054:
	{
		// if (a.color != b.color) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_20 = ___0_a;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_21 = L_20->___color_2;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_22 = ___1_b;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_23 = L_22->___color_2;
		bool L_24;
		L_24 = Color_op_Inequality_mF1C733BA10E60B086AB950A71143678AE76C4D92_inline(L_21, L_23, NULL);
		if (!L_24)
		{
			goto IL_0069;
		}
	}
	{
		// if (a.color != b.color) return true;
		return (bool)1;
	}

IL_0069:
	{
		// if (a.size != b.size) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_25 = ___0_a;
		float L_26 = L_25->___size_4;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_27 = ___1_b;
		float L_28 = L_27->___size_4;
		if ((((float)L_26) == ((float)L_28)))
		{
			goto IL_0079;
		}
	}
	{
		// if (a.size != b.size) return true;
		return (bool)1;
	}

IL_0079:
	{
		// if (a.type != b.type) return true;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_29 = ___0_a;
		int32_t L_30;
		L_30 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline(L_29, NULL);
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* L_31 = ___1_b;
		int32_t L_32;
		L_32 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline(L_31, NULL);
		if ((((int32_t)L_30) == ((int32_t)L_32)))
		{
			goto IL_0089;
		}
	}
	{
		// if (a.type != b.type) return true;
		return (bool)1;
	}

IL_0089:
	{
		// return false;
		return (bool)0;
	}
}
// System.Void Dreamteck.Splines.SplinePoint::SetPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SetPosition_m1F2299CBE14258E1A15D14E4DB5548FC012EB8E3 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method) 
{
	{
		// tangent -= position - pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_1, L_2, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_0, L_3, NULL);
		__this->___tangent_5 = L_4;
		// tangent2 -= position - pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = __this->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = ___0_pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_6, L_7, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_5, L_8, NULL);
		__this->___tangent2_6 = L_9;
		// position = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___0_pos;
		__this->___position_1 = L_10;
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SetPosition_m1F2299CBE14258E1A15D14E4DB5548FC012EB8E3_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SetPosition_m1F2299CBE14258E1A15D14E4DB5548FC012EB8E3(_thisAdjusted, ___0_pos, method);
}
// System.Void Dreamteck.Splines.SplinePoint::SetTangentPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// tangent = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_pos;
		__this->___tangent_5 = L_0;
		// switch (_type)
		int32_t L_1 = __this->____type_0;
		V_0 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_0016;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)2)))
		{
			goto IL_001d;
		}
	}
	{
		return;
	}

IL_0016:
	{
		// case Type.SmoothMirrored: SmoothMirrorTangent2(); break;
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
		// case Type.SmoothMirrored: SmoothMirrorTangent2(); break;
		return;
	}

IL_001d:
	{
		// case Type.SmoothFree: SmoothFreeTangent2(); break;
		SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SetTangentPosition_mE9E94ABED3CAED4C1EBA67FB9DD1B4DB594E4D43(_thisAdjusted, ___0_pos, method);
}
// System.Void Dreamteck.Splines.SplinePoint::SetTangent2Position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SetTangent2Position_m5B8AF2AF551EA75864610CC9031A15E16CA6C709 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// tangent2 = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_pos;
		__this->___tangent2_6 = L_0;
		// switch (_type)
		int32_t L_1 = __this->____type_0;
		V_0 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_0016;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)2)))
		{
			goto IL_001d;
		}
	}
	{
		return;
	}

IL_0016:
	{
		// case Type.SmoothMirrored: SmoothMirrorTangent(); break;
		SplinePoint_SmoothMirrorTangent_m6629C39EF35EED097AE1515B67CEA4F07585CB4F(__this, NULL);
		// case Type.SmoothMirrored: SmoothMirrorTangent(); break;
		return;
	}

IL_001d:
	{
		// case Type.SmoothFree: SmoothFreeTangent(); break;
		SplinePoint_SmoothFreeTangent_mC66202A3720F69113A60B5D62C20B91452BADB09(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SetTangent2Position_m5B8AF2AF551EA75864610CC9031A15E16CA6C709_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SetTangent2Position_m5B8AF2AF551EA75864610CC9031A15E16CA6C709(_thisAdjusted, ___0_pos, method);
}
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m718BF2D1D560533D5B1F0E5D5C47D01C2D7774D0 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_p, const RuntimeMethod* method) 
{
	{
		// position = p;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_p;
		__this->___position_1 = L_0;
		// tangent = p;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___0_p;
		__this->___tangent_5 = L_1;
		// tangent2 = p;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_p;
		__this->___tangent2_6 = L_2;
		// color = Color.white;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3;
		L_3 = Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline(NULL);
		__this->___color_2 = L_3;
		// normal = Vector3.up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		__this->___normal_3 = L_4;
		// size = 1f;
		__this->___size_4 = (1.0f);
		// _type = Type.SmoothMirrored;
		__this->____type_0 = 0;
		// SmoothMirrorTangent2();
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint__ctor_m718BF2D1D560533D5B1F0E5D5C47D01C2D7774D0_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_p, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint__ctor_m718BF2D1D560533D5B1F0E5D5C47D01C2D7774D0(_thisAdjusted, ___0_p, method);
}
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m34BE52F582225E64066CA0C9AF666C3DE6FFE281 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_p, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_t, const RuntimeMethod* method) 
{
	{
		// position = p;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_p;
		__this->___position_1 = L_0;
		// tangent = t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_t;
		__this->___tangent_5 = L_1;
		// tangent2 = p + (p - t);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_p;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_p;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___1_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5;
		L_5 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_3, L_4, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_2, L_5, NULL);
		__this->___tangent2_6 = L_6;
		// color = Color.white;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7;
		L_7 = Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline(NULL);
		__this->___color_2 = L_7;
		// normal = Vector3.up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		__this->___normal_3 = L_8;
		// size = 1f;
		__this->___size_4 = (1.0f);
		// _type = Type.SmoothMirrored;
		__this->____type_0 = 0;
		// SmoothMirrorTangent2();
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint__ctor_m34BE52F582225E64066CA0C9AF666C3DE6FFE281_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_p, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_t, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint__ctor_m34BE52F582225E64066CA0C9AF666C3DE6FFE281(_thisAdjusted, ___0_p, ___1_t, method);
}
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_mF4465401AF66C3C44EF1F4824249192284BB3440 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_tan, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_nor, float ___3_s, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___4_col, const RuntimeMethod* method) 
{
	{
		// position = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_pos;
		__this->___position_1 = L_0;
		// tangent = tan;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_tan;
		__this->___tangent_5 = L_1;
		// tangent2 = pos + (pos - tan);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___1_tan;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5;
		L_5 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_3, L_4, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_2, L_5, NULL);
		__this->___tangent2_6 = L_6;
		// normal = nor;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = ___2_nor;
		__this->___normal_3 = L_7;
		// size = s;
		float L_8 = ___3_s;
		__this->___size_4 = L_8;
		// color = col;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_9 = ___4_col;
		__this->___color_2 = L_9;
		// _type = Type.SmoothMirrored;
		__this->____type_0 = 0;
		// SmoothMirrorTangent2();
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint__ctor_mF4465401AF66C3C44EF1F4824249192284BB3440_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_tan, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_nor, float ___3_s, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___4_col, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint__ctor_mF4465401AF66C3C44EF1F4824249192284BB3440(_thisAdjusted, ___0_pos, ___1_tan, ___2_nor, ___3_s, ___4_col, method);
}
// System.Void Dreamteck.Splines.SplinePoint::.ctor(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m7DCDA279715CF65AAA5E41C7CFCAC1A2086B53FF (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_tan, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_tan2, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___3_nor, float ___4_s, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___5_col, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// position = pos;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_pos;
		__this->___position_1 = L_0;
		// tangent = tan;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_tan;
		__this->___tangent_5 = L_1;
		// tangent2 = tan2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___2_tan2;
		__this->___tangent2_6 = L_2;
		// normal = nor;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___3_nor;
		__this->___normal_3 = L_3;
		// size = s;
		float L_4 = ___4_s;
		__this->___size_4 = L_4;
		// color = col;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5 = ___5_col;
		__this->___color_2 = L_5;
		// _type = Type.Broken;
		__this->____type_0 = 1;
		// switch (_type)
		int32_t L_6 = __this->____type_0;
		V_0 = L_6;
		int32_t L_7 = V_0;
		if (!L_7)
		{
			goto IL_0043;
		}
	}
	{
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) == ((int32_t)2)))
		{
			goto IL_004a;
		}
	}
	{
		return;
	}

IL_0043:
	{
		// case Type.SmoothMirrored: SmoothMirrorTangent2(); break;
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
		// case Type.SmoothMirrored: SmoothMirrorTangent2(); break;
		return;
	}

IL_004a:
	{
		// case Type.SmoothFree: SmoothFreeTangent2(); break;
		SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint__ctor_m7DCDA279715CF65AAA5E41C7CFCAC1A2086B53FF_AdjustorThunk (RuntimeObject* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_pos, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_tan, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_tan2, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___3_nor, float ___4_s, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___5_col, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint__ctor_m7DCDA279715CF65AAA5E41C7CFCAC1A2086B53FF(_thisAdjusted, ___0_pos, ___1_tan, ___2_tan2, ___3_nor, ___4_s, ___5_col, method);
}
// System.Void Dreamteck.Splines.SplinePoint::.ctor(Dreamteck.Splines.SplinePoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint__ctor_m952EEFB42104ED263F2287EA03F341B65FE850F3 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___0_source, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// position = source.position;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_0 = ___0_source;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = L_0.___position_1;
		__this->___position_1 = L_1;
		// tangent = source.tangent;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_2 = ___0_source;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = L_2.___tangent_5;
		__this->___tangent_5 = L_3;
		// tangent2 = source.tangent2;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_4 = ___0_source;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = L_4.___tangent2_6;
		__this->___tangent2_6 = L_5;
		// color = source.color;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_6 = ___0_source;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7 = L_6.___color_2;
		__this->___color_2 = L_7;
		// normal = source.normal;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_8 = ___0_source;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = L_8.___normal_3;
		__this->___normal_3 = L_9;
		// size = source.size;
		SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB L_10 = ___0_source;
		float L_11 = L_10.___size_4;
		__this->___size_4 = L_11;
		// _type = source.type;
		int32_t L_12;
		L_12 = SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline((&___0_source), NULL);
		__this->____type_0 = L_12;
		// switch (_type)
		int32_t L_13 = __this->____type_0;
		V_0 = L_13;
		int32_t L_14 = V_0;
		if (!L_14)
		{
			goto IL_0064;
		}
	}
	{
		int32_t L_15 = V_0;
		if ((((int32_t)L_15) == ((int32_t)2)))
		{
			goto IL_006b;
		}
	}
	{
		return;
	}

IL_0064:
	{
		// case Type.SmoothMirrored: SmoothMirrorTangent2(); break;
		SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(__this, NULL);
		// case Type.SmoothMirrored: SmoothMirrorTangent2(); break;
		return;
	}

IL_006b:
	{
		// case Type.SmoothFree: SmoothFreeTangent2(); break;
		SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667(__this, NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint__ctor_m952EEFB42104ED263F2287EA03F341B65FE850F3_AdjustorThunk (RuntimeObject* __this, SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB ___0_source, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint__ctor_m952EEFB42104ED263F2287EA03F341B65FE850F3(_thisAdjusted, ___0_source, method);
}
// System.Void Dreamteck.Splines.SplinePoint::SmoothMirrorTangent2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) 
{
	{
		// tangent2 = position + (position - tangent);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = __this->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_1, L_2, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_0, L_3, NULL);
		__this->___tangent2_6 = L_4;
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SmoothMirrorTangent2_mAC67481B87AE2B3238A69CB41BC6C44094A51AC4(_thisAdjusted, method);
}
// System.Void Dreamteck.Splines.SplinePoint::SmoothMirrorTangent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothMirrorTangent_m6629C39EF35EED097AE1515B67CEA4F07585CB4F (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) 
{
	{
		// tangent = position + (position - tangent2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = __this->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_1, L_2, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_0, L_3, NULL);
		__this->___tangent_5 = L_4;
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SmoothMirrorTangent_m6629C39EF35EED097AE1515B67CEA4F07585CB4F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SmoothMirrorTangent_m6629C39EF35EED097AE1515B67CEA4F07585CB4F(_thisAdjusted, method);
}
// System.Void Dreamteck.Splines.SplinePoint::SmoothFreeTangent2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// tangent2 = position + (position - tangent).normalized * (tangent2 - position).magnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = __this->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_1, L_2, NULL);
		V_0 = L_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = __this->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_5, L_6, NULL);
		V_0 = L_7;
		float L_8;
		L_8 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_4, L_8, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_0, L_9, NULL);
		__this->___tangent2_6 = L_10;
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SmoothFreeTangent2_m5C74F24939BCF36E01E7B1EF326048D5AB3C8667(_thisAdjusted, method);
}
// System.Void Dreamteck.Splines.SplinePoint::SmoothFreeTangent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplinePoint_SmoothFreeTangent_mC66202A3720F69113A60B5D62C20B91452BADB09 (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// tangent = position + (position - tangent2).normalized * (tangent - position).magnitude;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = __this->___tangent2_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_1, L_2, NULL);
		V_0 = L_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = __this->___tangent_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = __this->___position_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_5, L_6, NULL);
		V_0 = L_7;
		float L_8;
		L_8 = Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline((&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_4, L_8, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_0, L_9, NULL);
		__this->___tangent_5 = L_10;
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void SplinePoint_SmoothFreeTangent_mC66202A3720F69113A60B5D62C20B91452BADB09_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB*>(__this + _offset);
	SplinePoint_SmoothFreeTangent_mC66202A3720F69113A60B5D62C20B91452BADB09(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Quaternion Dreamteck.Splines.SplineSample::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 SplineSample_get_rotation_m4C55C2F2CA674E9A0D4ABCFE7A8B080FD0540CE4 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, const RuntimeMethod* method) 
{
	{
		// if (up == forward)
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___forward_2;
		bool L_2;
		L_2 = Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_0046;
		}
	}
	{
		// if (up == Vector3.up) return Quaternion.LookRotation(Vector3.up, Vector3.back);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = __this->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		bool L_5;
		L_5 = Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline(L_3, L_4, NULL);
		if (!L_5)
		{
			goto IL_0035;
		}
	}
	{
		// if (up == Vector3.up) return Quaternion.LookRotation(Vector3.up, Vector3.back);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_get_back_mCA5A84170E8DE5CE38C0551B4CCAD647BF215E57_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_8;
		L_8 = Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307(L_6, L_7, NULL);
		return L_8;
	}

IL_0035:
	{
		// else return Quaternion.LookRotation(forward, Vector3.up);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = __this->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_11;
		L_11 = Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307(L_9, L_10, NULL);
		return L_11;
	}

IL_0046:
	{
		// return Quaternion.LookRotation(forward, up); }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = __this->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = __this->___up_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_14;
		L_14 = Quaternion_LookRotation_mFB02EDC8F733774DFAC3BEA4B4BB265A228F8307(L_12, L_13, NULL);
		return L_14;
	}
}
// UnityEngine.Vector3 Dreamteck.Splines.SplineSample::get_right()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineSample_get_right_m4319E1CF37AE2AF088D28285824E92349B14E236 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// if(up == forward)
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = __this->___forward_2;
		bool L_2;
		L_2 = Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_0044;
		}
	}
	{
		// if (up == Vector3.up) return Vector3.right;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = __this->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		bool L_5;
		L_5 = Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline(L_3, L_4, NULL);
		if (!L_5)
		{
			goto IL_002b;
		}
	}
	{
		// if (up == Vector3.up) return Vector3.right;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline(NULL);
		return L_6;
	}

IL_002b:
	{
		// else return Vector3.Cross(Vector3.up, forward).normalized;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = __this->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline(L_7, L_8, NULL);
		V_0 = L_9;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_0), NULL);
		return L_10;
	}

IL_0044:
	{
		// return Vector3.Cross(up, forward).normalized; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = __this->___up_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = __this->___forward_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13;
		L_13 = Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline(L_11, L_12, NULL);
		V_0 = L_13;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline((&V_0), NULL);
		return L_14;
	}
}
// Dreamteck.Splines.SplineSample Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,Dreamteck.Splines.SplineSample,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* SplineSample_Lerp_m6C04275C8AE498028E577AE8C9D2CDB3E9194522 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_a, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* V_0 = NULL;
	{
		// SplineSample result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_0, NULL);
		V_0 = L_0;
		// Lerp(a, b, t, result);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = ___0_a;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = ___1_b;
		float L_3 = ___2_t;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = V_0;
		SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819(L_1, L_2, L_3, L_4, NULL);
		// return result;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_5 = V_0;
		return L_5;
	}
}
// Dreamteck.Splines.SplineSample Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,Dreamteck.Splines.SplineSample,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* SplineSample_Lerp_mA3728A200B592390CA54FA94C2F763B942FA88F7 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_a, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_b, double ___2_t, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* V_0 = NULL;
	{
		// SplineSample result = new SplineSample();
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE*)il2cpp_codegen_object_new(SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA(L_0, NULL);
		V_0 = L_0;
		// Lerp(a, b, t, result);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = ___0_a;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = ___1_b;
		double L_3 = ___2_t;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = V_0;
		SplineSample_Lerp_mB500F377220064E5FD7A760E312BAA168A6A7820(L_1, L_2, L_3, L_4, NULL);
		// return result;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_5 = V_0;
		return L_5;
	}
}
// System.Void Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,Dreamteck.Splines.SplineSample,System.Double,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_Lerp_mB500F377220064E5FD7A760E312BAA168A6A7820 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_a, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_b, double ___2_t, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___3_target, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		// float ft = (float)t;
		double L_0 = ___2_t;
		V_0 = ((float)L_0);
		// target.position = DMath.LerpVector3(a.position, b.position, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = ___0_a;
		NullCheck(L_2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = L_2->___position_0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = ___1_b;
		NullCheck(L_4);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = L_4->___position_0;
		double L_6 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = DMath_LerpVector3_mD7444DF6760CA16627233C2A87F392094595DF26(L_3, L_5, L_6, NULL);
		NullCheck(L_1);
		L_1->___position_0 = L_7;
		// target.forward = Vector3.Slerp(a.forward, b.forward, ft);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_8 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_9 = ___0_a;
		NullCheck(L_9);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = L_9->___forward_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_11 = ___1_b;
		NullCheck(L_11);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = L_11->___forward_2;
		float L_13 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_10, L_12, L_13, NULL);
		NullCheck(L_8);
		L_8->___forward_2 = L_14;
		// target.up = Vector3.Slerp(a.up, b.up, ft);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_15 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_16 = ___0_a;
		NullCheck(L_16);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17 = L_16->___up_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_18 = ___1_b;
		NullCheck(L_18);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19 = L_18->___up_1;
		float L_20 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_17, L_19, L_20, NULL);
		NullCheck(L_15);
		L_15->___up_1 = L_21;
		// target.color = Color.Lerp(a.color, b.color, ft);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_22 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_23 = ___0_a;
		NullCheck(L_23);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_24 = L_23->___color_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_25 = ___1_b;
		NullCheck(L_25);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_26 = L_25->___color_3;
		float L_27 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_28;
		L_28 = Color_Lerp_mE79F87889843ECDC188E4CB5B5E1F1B2256E5EBE_inline(L_24, L_26, L_27, NULL);
		NullCheck(L_22);
		L_22->___color_3 = L_28;
		// target.size = Mathf.Lerp(a.size, b.size, ft);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_29 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_30 = ___0_a;
		NullCheck(L_30);
		float L_31 = L_30->___size_4;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_32 = ___1_b;
		NullCheck(L_32);
		float L_33 = L_32->___size_4;
		float L_34 = V_0;
		float L_35;
		L_35 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_31, L_33, L_34, NULL);
		NullCheck(L_29);
		L_29->___size_4 = L_35;
		// target.percent = DMath.Lerp(a.percent, b.percent, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_36 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_37 = ___0_a;
		NullCheck(L_37);
		double L_38 = L_37->___percent_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_39 = ___1_b;
		NullCheck(L_39);
		double L_40 = L_39->___percent_5;
		double L_41 = ___2_t;
		double L_42;
		L_42 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_38, L_40, L_41, NULL);
		NullCheck(L_36);
		L_36->___percent_5 = L_42;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,Dreamteck.Splines.SplineSample,System.Single,Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_a, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___1_b, float ___2_t, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___3_target, const RuntimeMethod* method) 
{
	{
		// target.position = DMath.LerpVector3(a.position, b.position, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_1 = ___0_a;
		NullCheck(L_1);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = L_1->___position_0;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_3 = ___1_b;
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = L_3->___position_0;
		float L_5 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = DMath_LerpVector3_mD7444DF6760CA16627233C2A87F392094595DF26(L_2, L_4, ((double)L_5), NULL);
		NullCheck(L_0);
		L_0->___position_0 = L_6;
		// target.forward = Vector3.Slerp(a.forward, b.forward, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_7 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_8 = ___0_a;
		NullCheck(L_8);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = L_8->___forward_2;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_10 = ___1_b;
		NullCheck(L_10);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = L_10->___forward_2;
		float L_12 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13;
		L_13 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_9, L_11, L_12, NULL);
		NullCheck(L_7);
		L_7->___forward_2 = L_13;
		// target.up = Vector3.Slerp(a.up, b.up, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_14 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_15 = ___0_a;
		NullCheck(L_15);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = L_15->___up_1;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_17 = ___1_b;
		NullCheck(L_17);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = L_17->___up_1;
		float L_19 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector3_Slerp_m6CA14E5B6F6217802BAA0ADD2C9D086C741BA09C(L_16, L_18, L_19, NULL);
		NullCheck(L_14);
		L_14->___up_1 = L_20;
		// target.color = Color.Lerp(a.color, b.color, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_21 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_22 = ___0_a;
		NullCheck(L_22);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_23 = L_22->___color_3;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_24 = ___1_b;
		NullCheck(L_24);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_25 = L_24->___color_3;
		float L_26 = ___2_t;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_27;
		L_27 = Color_Lerp_mE79F87889843ECDC188E4CB5B5E1F1B2256E5EBE_inline(L_23, L_25, L_26, NULL);
		NullCheck(L_21);
		L_21->___color_3 = L_27;
		// target.size = Mathf.Lerp(a.size, b.size, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_28 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_29 = ___0_a;
		NullCheck(L_29);
		float L_30 = L_29->___size_4;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_31 = ___1_b;
		NullCheck(L_31);
		float L_32 = L_31->___size_4;
		float L_33 = ___2_t;
		float L_34;
		L_34 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_30, L_32, L_33, NULL);
		NullCheck(L_28);
		L_28->___size_4 = L_34;
		// target.percent = DMath.Lerp(a.percent, b.percent, t);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_35 = ___3_target;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_36 = ___0_a;
		NullCheck(L_36);
		double L_37 = L_36->___percent_5;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_38 = ___1_b;
		NullCheck(L_38);
		double L_39 = L_38->___percent_5;
		float L_40 = ___2_t;
		double L_41;
		L_41 = DMath_Lerp_m0187E8E882CD6B7B7079678722D1047CFA36BA30(L_37, L_39, ((double)L_40), NULL);
		NullCheck(L_35);
		L_35->___percent_5 = L_41;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_Lerp_m827B0057D878D965FEE10B491F6075433E6820B8 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_b, double ___1_t, const RuntimeMethod* method) 
{
	{
		// Lerp(this, b, t, this);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ___0_b;
		double L_1 = ___1_t;
		SplineSample_Lerp_mB500F377220064E5FD7A760E312BAA168A6A7820(__this, L_0, L_1, __this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::Lerp(Dreamteck.Splines.SplineSample,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_Lerp_m6783A782465C833CF13EB4489140B8C58E01354C (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_b, float ___1_t, const RuntimeMethod* method) 
{
	{
		// Lerp(this, b, t, this);
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ___0_b;
		float L_1 = ___1_t;
		SplineSample_Lerp_m02BE0D3FCA6EB2EA24CA8F34040E0346A210E819(__this, L_0, L_1, __this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::CopyFrom(Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample_CopyFrom_mB1BB345F571264DD4BA0290C34F20C13615F58FE (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_input, const RuntimeMethod* method) 
{
	{
		// position = input.position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_0 = ___0_input;
		NullCheck(L_0);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = L_0->___position_0;
		__this->___position_0 = L_1;
		// forward = input.forward;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_2 = ___0_input;
		NullCheck(L_2);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = L_2->___forward_2;
		__this->___forward_2 = L_3;
		// up = input.up;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = ___0_input;
		NullCheck(L_4);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = L_4->___up_1;
		__this->___up_1 = L_5;
		// color = input.color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_6 = ___0_input;
		NullCheck(L_6);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7 = L_6->___color_3;
		__this->___color_3 = L_7;
		// size = input.size;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_8 = ___0_input;
		NullCheck(L_8);
		float L_9 = L_8->___size_4;
		__this->___size_4 = L_9;
		// percent = input.percent;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_10 = ___0_input;
		NullCheck(L_10);
		double L_11 = L_10->___percent_5;
		__this->___percent_5 = L_11;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample__ctor_m69D281FCC5D3C987D9DF507274C65FE0D5A265FA (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, const RuntimeMethod* method) 
{
	{
		// public Vector3 position = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		__this->___position_0 = L_0;
		// public Vector3 up = Vector3.up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		__this->___up_1 = L_1;
		// public Vector3 forward = Vector3.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		__this->___forward_2 = L_2;
		// public Color color = Color.white;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3;
		L_3 = Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline(NULL);
		__this->___color_3 = L_3;
		// public float size = 1f;
		__this->___size_4 = (1.0f);
		// public SplineSample()
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::.ctor(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Color,System.Single,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample__ctor_mA2ABA5155EDCA766B21E86CCABBB40F5D4DB2085 (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_position, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_normal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___2_direction, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_color, float ___4_size, double ___5_percent, const RuntimeMethod* method) 
{
	{
		// public Vector3 position = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		__this->___position_0 = L_0;
		// public Vector3 up = Vector3.up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		__this->___up_1 = L_1;
		// public Vector3 forward = Vector3.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		__this->___forward_2 = L_2;
		// public Color color = Color.white;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3;
		L_3 = Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline(NULL);
		__this->___color_3 = L_3;
		// public float size = 1f;
		__this->___size_4 = (1.0f);
		// public SplineSample(Vector3 position, Vector3 normal, Vector3 direction, Color color, float size, double percent)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// this.position = position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_position;
		__this->___position_0 = L_4;
		// this.up = normal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = ___1_normal;
		__this->___up_1 = L_5;
		// this.forward = direction;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___2_direction;
		__this->___forward_2 = L_6;
		// this.color = color;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7 = ___3_color;
		__this->___color_3 = L_7;
		// this.size = size;
		float L_8 = ___4_size;
		__this->___size_4 = L_8;
		// this.percent = percent;
		double L_9 = ___5_percent;
		__this->___percent_5 = L_9;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineSample::.ctor(Dreamteck.Splines.SplineSample)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineSample__ctor_m6BB75B83D92E2D0698FBDECDCDAB9E200DB9541E (SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* __this, SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* ___0_input, const RuntimeMethod* method) 
{
	{
		// public Vector3 position = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		__this->___position_0 = L_0;
		// public Vector3 up = Vector3.up;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		__this->___up_1 = L_1;
		// public Vector3 forward = Vector3.forward;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline(NULL);
		__this->___forward_2 = L_2;
		// public Color color = Color.white;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3;
		L_3 = Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline(NULL);
		__this->___color_3 = L_3;
		// public float size = 1f;
		__this->___size_4 = (1.0f);
		// public SplineSample(SplineSample input)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// position = input.position;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_4 = ___0_input;
		NullCheck(L_4);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = L_4->___position_0;
		__this->___position_0 = L_5;
		// up = input.up;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_6 = ___0_input;
		NullCheck(L_6);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = L_6->___up_1;
		__this->___up_1 = L_7;
		// forward = input.forward;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_8 = ___0_input;
		NullCheck(L_8);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = L_8->___forward_2;
		__this->___forward_2 = L_9;
		// color = input.color;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_10 = ___0_input;
		NullCheck(L_10);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_11 = L_10->___color_3;
		__this->___color_3 = L_11;
		// size = input.size;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_12 = ___0_input;
		NullCheck(L_12);
		float L_13 = L_12->___size_4;
		__this->___size_4 = L_13;
		// percent = input.percent;
		SplineSample_t2BEBF6C95CBAEF69A7DC41A4ACD408AE13E8EDEE* L_14 = ___0_input;
		NullCheck(L_14);
		double L_15 = L_14->___percent_5;
		__this->___percent_5 = L_15;
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 Dreamteck.Splines.SplineThreading::get_threadCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SplineThreading_get_threadCount_m388B031E91C8810D3905BCF991984C6D0A1A0082 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return threads.Length;
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_0 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_0);
		return ((int32_t)(((RuntimeArray*)L_0)->max_length));
	}
}
// System.Void Dreamteck.Splines.SplineThreading::set_threadCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_set_threadCount_m99ADB29FB4E1BF4C0DA35A3AEFF6062B6F36FBC4 (int32_t ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArrayUtility_Add_TisThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_m7AA2A015A47078C2BBC1C12D7F87B749CCF6EC7E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* V_0 = NULL;
	{
		// if(value > threads.Length)
		int32_t L_0 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_1 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_1);
		if ((((int32_t)L_0) <= ((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))))
		{
			goto IL_002d;
		}
	}
	{
		goto IL_0023;
	}

IL_000c:
	{
		// ThreadDef thread = new ThreadDef();
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_2 = (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203*)il2cpp_codegen_object_new(ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		ThreadDef__ctor_m4DEBDB384AE201A2DF410F046853B5A3CBC4EF66(L_2, NULL);
		V_0 = L_2;
		// thread.Restart();
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_3 = V_0;
		NullCheck(L_3);
		ThreadDef_Restart_m5D2F9CCAD3B5731A3B61DF4D2E73E812463F1E2C(L_3, NULL);
		// ArrayUtility.Add(ref threads, thread);
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_4 = V_0;
		ArrayUtility_Add_TisThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_m7AA2A015A47078C2BBC1C12D7F87B749CCF6EC7E((&((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0), L_4, ArrayUtility_Add_TisThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_m7AA2A015A47078C2BBC1C12D7F87B749CCF6EC7E_RuntimeMethod_var);
	}

IL_0023:
	{
		// while (threads.Length < value)
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_5 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_5);
		int32_t L_6 = ___0_value;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_5)->max_length))) < ((int32_t)L_6)))
		{
			goto IL_000c;
		}
	}

IL_002d:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading__cctor_m4349F7C05A44557EB297631066498F5E032FC543 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_Quitting_mFABFBD154A784EB6DC8B2C1B169AA79DF1AFC5B3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// internal static ThreadDef[] threads = new ThreadDef[2];
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_0 = (ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606*)(ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606*)SZArrayNew(ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606_il2cpp_TypeInfo_var, (uint32_t)2);
		((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0), (void*)L_0);
		// internal static readonly object locker = new object();
		RuntimeObject* L_1 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_1, NULL);
		((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___locker_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___locker_1), (void*)L_1);
		// Application.quitting += Quitting;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_2 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_2, NULL, (intptr_t)((void*)SplineThreading_Quitting_mFABFBD154A784EB6DC8B2C1B169AA79DF1AFC5B3_RuntimeMethod_var), NULL);
		Application_add_quitting_m5767AC63F23ABFD5BC3D60710906643BA536CCC5(L_2, NULL);
		// for (int i = 0; i < threads.Length; i++)
		V_0 = 0;
		goto IL_003a;
	}

IL_002a:
	{
		// threads[i] = new ThreadDef();
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_3 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_4 = V_0;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_5 = (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203*)il2cpp_codegen_object_new(ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		ThreadDef__ctor_m4DEBDB384AE201A2DF410F046853B5A3CBC4EF66(L_5, NULL);
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, L_5);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(L_4), (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203*)L_5);
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_6 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_6, 1));
	}

IL_003a:
	{
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_7 = V_0;
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_8 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_8);
		if ((((int32_t)L_7) < ((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length)))))
		{
			goto IL_002a;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading::Quitting()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_Quitting_mFABFBD154A784EB6DC8B2C1B169AA79DF1AFC5B3 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Stop();
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		SplineThreading_Stop_m9E741FD702CC4F2D1475284BB9BA63AB8C798494(NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading::RunThread(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_RunThread_mDF557DB8E00DDD010B6A00B1EB167CEF016734DB (RuntimeObject* ___0_o, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral88EB21CA5454C0DC11F3E2DCF04D902104818319);
		s_Il2CppMethodInitialized = true;
	}
	Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	bool V_2 = false;
	EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* V_3 = NULL;
	Exception_t* V_4 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		// ThreadDef.Worker work = (ThreadDef.Worker)o;
		RuntimeObject* L_0 = ___0_o;
		V_0 = ((Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87*)CastclassClass((RuntimeObject*)L_0, Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87_il2cpp_TypeInfo_var));
	}

IL_0007:
	{
	}
	try
	{// begin try (depth: 1)
		// work.computing = false;
		Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_1 = V_0;
		NullCheck(L_1);
		L_1->___computing_0 = (bool)0;
		// Thread.Sleep(Timeout.Infinite);
		Thread_Sleep_m71DE163765BF465EC4A0163F2ED4D43143094549((-1), NULL);
		// }
		goto IL_0007;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ThreadInterruptedException_t5F777BF218B009092789F6DA0013E4DC3A0987CC_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0017;
		}
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0062;
		}
		throw e;
	}

CATCH_0017:
	{// begin catch(System.Threading.ThreadInterruptedException)
		{
			// catch (ThreadInterruptedException)
			// work.computing = true;
			Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_2 = V_0;
			NullCheck(L_2);
			L_2->___computing_0 = (bool)1;
			// lock (locker)
			il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var)));
			RuntimeObject* L_3 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))))->___locker_1;
			V_1 = L_3;
			V_2 = (bool)0;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0056:
				{// begin finally (depth: 2)
					{
						bool L_4 = V_2;
						if (!L_4)
						{
							goto IL_005f;
						}
					}
					{
						RuntimeObject* L_5 = V_1;
						Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_5, NULL);
					}

IL_005f:
					{
						return;
					}
				}// end finally (depth: 2)
			});
			try
			{// begin try (depth: 2)
				{
					RuntimeObject* L_6 = V_1;
					Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_6, (&V_2), NULL);
					goto IL_0046_1;
				}

IL_0031_1:
				{
					// EmptyHandler h = work.instructions.Dequeue();
					Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_7 = V_0;
					NullCheck(L_7);
					Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* L_8 = L_7->___instructions_1;
					NullCheck(L_8);
					EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* L_9;
					L_9 = Queue_1_Dequeue_mC90913E91A7B06DCAE75B561DB0D1366461A2903(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Queue_1_Dequeue_mC90913E91A7B06DCAE75B561DB0D1366461A2903_RuntimeMethod_var)));
					V_3 = L_9;
					// if (h != null) h();
					EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* L_10 = V_3;
					if (!L_10)
					{
						goto IL_0046_1;
					}
				}
				{
					// if (h != null) h();
					EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* L_11 = V_3;
					NullCheck(L_11);
					EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_inline(L_11, NULL);
				}

IL_0046_1:
				{
					// while (work.instructions.Count > 0)
					Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_12 = V_0;
					NullCheck(L_12);
					Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* L_13 = L_12->___instructions_1;
					NullCheck(L_13);
					int32_t L_14;
					L_14 = Queue_1_get_Count_m2624F89E4009D9F306525357B93267F2E9A18060_inline(L_13, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Queue_1_get_Count_m2624F89E4009D9F306525357B93267F2E9A18060_RuntimeMethod_var)));
					if ((((int32_t)L_14) > ((int32_t)0)))
					{
						goto IL_0031_1;
					}
				}
				{
					// }
					goto IL_0060;
				}
			}// end try (depth: 2)
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_0060:
		{
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0007;
		}
	}// end catch (depth: 1)

CATCH_0062:
	{// begin catch(System.Exception)
		{
			// catch (System.Exception ex)
			V_4 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
			// if(ex.Message != "") Debug.Log("THREAD EXCEPTION " + ex.Message);
			Exception_t* L_15 = V_4;
			NullCheck(L_15);
			String_t* L_16;
			L_16 = VirtualFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_15);
			bool L_17;
			L_17 = String_op_Inequality_m8C940F3CFC42866709D7CA931B3D77B4BE94BCB6(L_16, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709)), NULL);
			if (!L_17)
			{
				goto IL_008d;
			}
		}
		{
			// if(ex.Message != "") Debug.Log("THREAD EXCEPTION " + ex.Message);
			Exception_t* L_18 = V_4;
			NullCheck(L_18);
			String_t* L_19;
			L_19 = VirtualFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_18);
			String_t* L_20;
			L_20 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2EB6E2A95D5C3E11CE312FE16B937D8DB184DBE5)), L_19, NULL);
			il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
			Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(L_20, NULL);
		}

IL_008d:
		{
			// break;
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_008f;
		}
	}// end catch (depth: 1)

IL_008f:
	{
		// Debug.Log("Thread stopped");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral88EB21CA5454C0DC11F3E2DCF04D902104818319, NULL);
		// work.computing = false;
		Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_21 = V_0;
		NullCheck(L_21);
		L_21->___computing_0 = (bool)0;
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading::Run(Dreamteck.Splines.SplineThreading/EmptyHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_Run_m1C019D5A6AAE9F71C170E7296BD796D06AAA3D82 (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* ___0_handler, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// for (int i = 0; i < threads.Length; i++)
		V_0 = 0;
		goto IL_0064;
	}

IL_0004:
	{
		// if (!threads[i].isAlive) threads[i].Restart();
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_0 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		NullCheck(L_3);
		bool L_4;
		L_4 = ThreadDef_get_isAlive_mB0B5DE1368BFCE2ABFAA588ED42955217A4549A2(L_3, NULL);
		if (L_4)
		{
			goto IL_001e;
		}
	}
	{
		// if (!threads[i].isAlive) threads[i].Restart();
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_5 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_6 = V_0;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		NullCheck(L_8);
		ThreadDef_Restart_m5D2F9CCAD3B5731A3B61DF4D2E73E812463F1E2C(L_8, NULL);
	}

IL_001e:
	{
		// if (!threads[i].computing || i == threads.Length - 1)
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_9 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_10 = V_0;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		NullCheck(L_12);
		bool L_13;
		L_13 = ThreadDef_get_computing_mFDC15BD2D22DCBC6EEAA9E1A87B8B1880D841CCD(L_12, NULL);
		if (!L_13)
		{
			goto IL_0038;
		}
	}
	{
		int32_t L_14 = V_0;
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_15 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_15);
		if ((!(((uint32_t)L_14) == ((uint32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_15)->max_length)), 1))))))
		{
			goto IL_0060;
		}
	}

IL_0038:
	{
		// threads[i].Queue(handler);
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_16 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_17 = V_0;
		NullCheck(L_16);
		int32_t L_18 = L_17;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_19 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* L_20 = ___0_handler;
		NullCheck(L_19);
		ThreadDef_Queue_mC4874F604D1DC69A41F1FF0AAE9ED29BEB1A7935(L_19, L_20, NULL);
		// if(!threads[i].computing)threads[i].Interrupt();
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_21 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_22 = V_0;
		NullCheck(L_21);
		int32_t L_23 = L_22;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_24 = (L_21)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		NullCheck(L_24);
		bool L_25;
		L_25 = ThreadDef_get_computing_mFDC15BD2D22DCBC6EEAA9E1A87B8B1880D841CCD(L_24, NULL);
		if (L_25)
		{
			goto IL_006e;
		}
	}
	{
		// if(!threads[i].computing)threads[i].Interrupt();
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_26 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_27 = V_0;
		NullCheck(L_26);
		int32_t L_28 = L_27;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_29 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		NullCheck(L_29);
		ThreadDef_Interrupt_m13ED736535FD5A887AD7730B3C670073F693C82C(L_29, NULL);
		// break;
		return;
	}

IL_0060:
	{
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_30 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_30, 1));
	}

IL_0064:
	{
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_31 = V_0;
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_32 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_32);
		if ((((int32_t)L_31) < ((int32_t)((int32_t)(((RuntimeArray*)L_32)->max_length)))))
		{
			goto IL_0004;
		}
	}

IL_006e:
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading::PrewarmThreads()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_PrewarmThreads_m91E06DC614006D9EB256D55833225DDA34A35B58 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// for (int i = 0; i < threads.Length; i++)
		V_0 = 0;
		goto IL_0022;
	}

IL_0004:
	{
		// if (!threads[i].isAlive)
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_0 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		NullCheck(L_3);
		bool L_4;
		L_4 = ThreadDef_get_isAlive_mB0B5DE1368BFCE2ABFAA588ED42955217A4549A2(L_3, NULL);
		if (L_4)
		{
			goto IL_001e;
		}
	}
	{
		// threads[i].Restart();
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_5 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_6 = V_0;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		NullCheck(L_8);
		ThreadDef_Restart_m5D2F9CCAD3B5731A3B61DF4D2E73E812463F1E2C(L_8, NULL);
	}

IL_001e:
	{
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_9 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_9, 1));
	}

IL_0022:
	{
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_10 = V_0;
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_11 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_11);
		if ((((int32_t)L_10) < ((int32_t)((int32_t)(((RuntimeArray*)L_11)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading::Stop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SplineThreading_Stop_m9E741FD702CC4F2D1475284BB9BA63AB8C798494 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// for (int i = 0; i < threads.Length; i++)
		V_0 = 0;
		goto IL_0014;
	}

IL_0004:
	{
		// threads[i].Abort();
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_0 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		NullCheck(L_3);
		ThreadDef_Abort_m3AE7C07F359AD6F99DE321E1186E22F7D4F112AC(L_3, NULL);
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_4 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_4, 1));
	}

IL_0014:
	{
		// for (int i = 0; i < threads.Length; i++)
		int32_t L_5 = V_0;
		il2cpp_codegen_runtime_class_init_inline(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var);
		ThreadDefU5BU5D_t19FA2921F8939AE0D051ADB5F9A26BF79592F606* L_6 = ((SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_StaticFields*)il2cpp_codegen_static_fields_for(SplineThreading_t4A06F34343142DA9B434790A97C1FECFBA1921B1_il2cpp_TypeInfo_var))->___threads_0;
		NullCheck(L_6);
		if ((((int32_t)L_5) < ((int32_t)((int32_t)(((RuntimeArray*)L_6)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_Multicast(EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* currentDelegate = reinterpret_cast<EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_OpenInst(EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_OpenStatic(EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_OpenStaticInvoker(EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker0::Invoke(__this->___method_ptr_0, method, NULL);
}
void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_ClosedStaticInvoker(EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker1< RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void Dreamteck.Splines.SplineThreading/EmptyHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EmptyHandler__ctor_m2533D24BAEA6F83E339FA2F2C2539F0A907D1C61 (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___1_method);
	__this->___method_3 = ___1_method;
	__this->___m_target_2 = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___1_method))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___0_object == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_Multicast;
}
// System.Void Dreamteck.Splines.SplineThreading/EmptyHandler::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5 (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult Dreamteck.Splines.SplineThreading/EmptyHandler::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* EmptyHandler_BeginInvoke_mCD8F1614EC153C3EE390A557920B1A07F3B5B7E4 (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___0_callback, RuntimeObject* ___1_object, const RuntimeMethod* method) 
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___0_callback, (RuntimeObject*)___1_object);
}
// System.Void Dreamteck.Splines.SplineThreading/EmptyHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EmptyHandler_EndInvoke_m2DEE5155D9688E041BE1AFCBE198994983A1325B (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean Dreamteck.Splines.SplineThreading/ThreadDef::get_isAlive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ThreadDef_get_isAlive_mB0B5DE1368BFCE2ABFAA588ED42955217A4549A2 (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) 
{
	{
		// get { return thread != null && thread.IsAlive; }
		Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* L_0 = __this->___thread_1;
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* L_1 = __this->___thread_1;
		NullCheck(L_1);
		bool L_2;
		L_2 = Thread_get_IsAlive_m87922B882A526D780570799F497EEB4C99F005DF(L_1, NULL);
		return L_2;
	}

IL_0014:
	{
		return (bool)0;
	}
}
// System.Boolean Dreamteck.Splines.SplineThreading/ThreadDef::get_computing()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ThreadDef_get_computing_mFDC15BD2D22DCBC6EEAA9E1A87B8B1880D841CCD (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) 
{
	{
		// return worker.computing;
		Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_0 = __this->___worker_2;
		NullCheck(L_0);
		bool L_1 = L_0->___computing_0;
		return L_1;
	}
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef__ctor_m4DEBDB384AE201A2DF410F046853B5A3CBC4EF66 (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineThreading_RunThread_mDF557DB8E00DDD010B6A00B1EB167CEF016734DB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private Worker worker = new Worker();
		Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_0 = (Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87*)il2cpp_codegen_object_new(Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		Worker__ctor_m24E0DEC6ED9146413DC7AEEF3AF2F41E8DBC16A6(L_0, NULL);
		__this->___worker_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___worker_2), (void*)L_0);
		// internal ThreadDef()
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// start = new ParameterizedThreadStart(RunThread);
		ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9* L_1 = (ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9*)il2cpp_codegen_object_new(ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		ParameterizedThreadStart__ctor_m31EA734851CB478E822BAB7E1B479CA4FDBF2718(L_1, NULL, (intptr_t)((void*)SplineThreading_RunThread_mDF557DB8E00DDD010B6A00B1EB167CEF016734DB_RuntimeMethod_var), NULL);
		__this->___start_0 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___start_0), (void*)L_1);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Queue(Dreamteck.Splines.SplineThreading/EmptyHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Queue_mC4874F604D1DC69A41F1FF0AAE9ED29BEB1A7935 (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* ___0_handler, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Queue_1_Enqueue_m03169B6B661DD5BE1E05AF38EC0787E4E8A47208_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// worker.instructions.Enqueue(handler);
		Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_0 = __this->___worker_2;
		NullCheck(L_0);
		Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* L_1 = L_0->___instructions_1;
		EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* L_2 = ___0_handler;
		NullCheck(L_1);
		Queue_1_Enqueue_m03169B6B661DD5BE1E05AF38EC0787E4E8A47208(L_1, L_2, Queue_1_Enqueue_m03169B6B661DD5BE1E05AF38EC0787E4E8A47208_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Interrupt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Interrupt_m13ED736535FD5A887AD7730B3C670073F693C82C (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) 
{
	{
		// thread.Interrupt();
		Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* L_0 = __this->___thread_1;
		NullCheck(L_0);
		Thread_Interrupt_mDBD6FD816042E18A5B33E6EDCE1168B324DEAD7E(L_0, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Restart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Restart_m5D2F9CCAD3B5731A3B61DF4D2E73E812463F1E2C (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// thread = new Thread(start);
		ParameterizedThreadStart_tAA8FDC4E868056A7CB7CB2C4AB4986039B1D91E9* L_0 = __this->___start_0;
		Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* L_1 = (Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F*)il2cpp_codegen_object_new(Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		Thread__ctor_m7319B115C7E11770EEEC7F1D4A01A50E29550700(L_1, L_0, NULL);
		__this->___thread_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___thread_1), (void*)L_1);
		// thread.Start(worker);
		Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* L_2 = __this->___thread_1;
		Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* L_3 = __this->___worker_2;
		NullCheck(L_2);
		Thread_Start_m64E3F27883C3CCCE7209F5D2BD268A33D4C71566(L_2, L_3, NULL);
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef::Abort()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThreadDef_Abort_m3AE7C07F359AD6F99DE321E1186E22F7D4F112AC (ThreadDef_t6961F51A789CFD95C918124ADEC64E648C93C203* __this, const RuntimeMethod* method) 
{
	{
		// if (isAlive)
		bool L_0;
		L_0 = ThreadDef_get_isAlive_mB0B5DE1368BFCE2ABFAA588ED42955217A4549A2(__this, NULL);
		if (!L_0)
		{
			goto IL_0013;
		}
	}
	{
		// thread.Abort();
		Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* L_1 = __this->___thread_1;
		NullCheck(L_1);
		Thread_Abort_mB956BACF405EFC38C6A3D0B93142E4CEDD64D941(L_1, NULL);
	}

IL_0013:
	{
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef/Worker::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Worker__ctor_m24E0DEC6ED9146413DC7AEEF3AF2F41E8DBC16A6 (Worker_t873BEDB00967823F5C9D6C4B97982D3071766C87* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Queue_1__ctor_mB77C6E0D45FF98C70022A1A4274DC0DF66CF6AEB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// internal Queue<EmptyHandler> instructions = new Queue<EmptyHandler>();
		Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371* L_0 = (Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371*)il2cpp_codegen_object_new(Queue_1_t882DDBD0ABF01D1B4504CB529E6E1D35ED8C1371_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		Queue_1__ctor_mB77C6E0D45FF98C70022A1A4274DC0DF66CF6AEB(L_0, Queue_1__ctor_mB77C6E0D45FF98C70022A1A4274DC0DF66CF6AEB_RuntimeMethod_var);
		__this->___instructions_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___instructions_1), (void*)L_0);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_Multicast(BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* currentDelegate = reinterpret_cast<BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, bool, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___0_flag, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_OpenInst(BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___0_flag, method);
}
void BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_OpenStatic(BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___0_flag, method);
}
void BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_OpenStaticInvoker(BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method)
{
	InvokerActionInvoker1< bool >::Invoke(__this->___method_ptr_0, method, NULL, ___0_flag);
}
void BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_ClosedStaticInvoker(BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method)
{
	InvokerActionInvoker2< RuntimeObject*, bool >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___0_flag);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF (BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc(static_cast<int32_t>(___0_flag));

}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BoolHandler__ctor_m3A6CD543A2487E9388DBB71B88E49CD27807C68E (BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___1_method);
	__this->___method_3 = ___1_method;
	__this->___m_target_2 = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 1;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___1_method))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___0_object == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7_Multicast;
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler::Invoke(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BoolHandler_Invoke_m4A6290860C5C5FEC02D841BB19278448C948E2D7 (BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_flag, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler::BeginInvoke(System.Boolean,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* BoolHandler_BeginInvoke_m2222B35135664D658A7BC12946F0A879E18EDA37 (BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, bool ___0_flag, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___1_callback, RuntimeObject* ___2_object, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_il2cpp_TypeInfo_var, &___0_flag);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___1_callback, (RuntimeObject*)___2_object);
}
// System.Void Dreamteck.Splines.SplineThreading/ThreadDef/BoolHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BoolHandler_EndInvoke_m9B12FD8C6F8201193A4E1E5F34FDBB162C31B658 (BoolHandler_t28DAD124476A53DDD0C5A820586FBDF86F2453CF* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dreamteck.Splines.TriggerGroup::Check(System.Double,System.Double,Dreamteck.Splines.SplineUser)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TriggerGroup_Check_m1BDD318E4190AD91CC0574E0CA69F57D1AC07791 (TriggerGroup_tF128CA84FCAE0CB4549FC7141431DEA981C2D43E* __this, double ___0_start, double ___1_end, SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* ___2_user, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// for (int i = 0; i < triggers.Length; i++)
		V_0 = 0;
		goto IL_0031;
	}

IL_0004:
	{
		// if (triggers[i] == null)
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_0 = __this->___triggers_3;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		if (!L_3)
		{
			goto IL_002d;
		}
	}
	{
		// if (triggers[i].Check(start, end))
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_4 = __this->___triggers_3;
		int32_t L_5 = V_0;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		double L_8 = ___0_start;
		double L_9 = ___1_end;
		NullCheck(L_7);
		bool L_10;
		L_10 = SplineTrigger_Check_m7B0807E1819E15937AA4DD856CFD7AF0A250288B(L_7, L_8, L_9, NULL);
		if (!L_10)
		{
			goto IL_002d;
		}
	}
	{
		// triggers[i].Invoke(user);
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_11 = __this->___triggers_3;
		int32_t L_12 = V_0;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* L_15 = ___2_user;
		NullCheck(L_14);
		SplineTrigger_Invoke_m6B1D9EEDE84BEC94544D18FEC705989A238744B4(L_14, L_15, NULL);
	}

IL_002d:
	{
		// for (int i = 0; i < triggers.Length; i++)
		int32_t L_16 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_16, 1));
	}

IL_0031:
	{
		// for (int i = 0; i < triggers.Length; i++)
		int32_t L_17 = V_0;
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_18 = __this->___triggers_3;
		NullCheck(L_18);
		if ((((int32_t)L_17) < ((int32_t)((int32_t)(((RuntimeArray*)L_18)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TriggerGroup::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TriggerGroup_Reset_m86B49D66354045BD44E7E836459CC1A5125F5C02 (TriggerGroup_tF128CA84FCAE0CB4549FC7141431DEA981C2D43E* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// for (int i = 0; i < triggers.Length; i++) triggers[i].Reset();
		V_0 = 0;
		goto IL_0015;
	}

IL_0004:
	{
		// for (int i = 0; i < triggers.Length; i++) triggers[i].Reset();
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_0 = __this->___triggers_3;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		SplineTrigger_t33522785BD90B796763016FFB6C242E3CE4E2FAD* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		NullCheck(L_3);
		SplineTrigger_Reset_m995F2E4883C1BC9F03F60ECDB80ACC9E38117249(L_3, NULL);
		// for (int i = 0; i < triggers.Length; i++) triggers[i].Reset();
		int32_t L_4 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_4, 1));
	}

IL_0015:
	{
		// for (int i = 0; i < triggers.Length; i++) triggers[i].Reset();
		int32_t L_5 = V_0;
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_6 = __this->___triggers_3;
		NullCheck(L_6);
		if ((((int32_t)L_5) < ((int32_t)((int32_t)(((RuntimeArray*)L_6)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dreamteck.Splines.TriggerGroup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TriggerGroup__ctor_m3EF91CE1019B902E03CD77C4B0C236DF4FA9EDCE (TriggerGroup_tF128CA84FCAE0CB4549FC7141431DEA981C2D43E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public bool enabled = true;
		__this->___enabled_0 = (bool)1;
		// public string name = "";
		__this->___name_1 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___name_1), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		// public Color color = Color.white;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		L_0 = Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline(NULL);
		__this->___color_2 = L_0;
		// public SplineTrigger[] triggers = new SplineTrigger[0];
		SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262* L_1 = (SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262*)(SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262*)SZArrayNew(SplineTriggerU5BU5D_t587A0EF497515DBC673F7930E32144AD897E3262_il2cpp_TypeInfo_var, (uint32_t)0);
		__this->___triggers_3 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___triggers_3), (void*)L_1);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector2_op_Inequality_mBEA93B5A0E954FEFB863DC61CB209119980EC713_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_lhs, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_rhs, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_lhs;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = ___1_rhs;
		bool L_2;
		L_2 = Vector2_op_Equality_m6F2E069A50E787D131261E5CB25FC9E03F95B5E1_inline(L_0, L_1, NULL);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_000e;
	}

IL_000e:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector3_op_Inequality_m9F170CDFBF1E490E559DA5D06D6547501A402BBF_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lhs;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_rhs;
		bool L_2;
		L_2 = Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline(L_0, L_1, NULL);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_000e;
	}

IL_000e:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* SplineUser_get_trs_mF55B1D1CC702B234E1DF62C3622CB8D89D24A978_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) 
{
	{
		// get {  return _trs;  }
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0 = __this->____trs_22;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* SplineUser_get_spline_m4DB2FFFB96E4DCD0B5EE606579F27B57ABC1E753_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) 
{
	{
		// return _spline;
		SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* L_0 = __this->____spline_5;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t SplineUser_get_sampleCount_m150365B12469D297DF9C84BA90600A4E248C3EF1_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) 
{
	{
		// get { return _sampleCount; }
		int32_t L_0 = __this->____sampleCount_24;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 MeshGenerator_get_offset_mCFEBE7DE4A3ED5BC0766E5512BCD5647E6D1353C_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _offset; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->____offset_37;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		float L_2 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_a;
		float L_4 = L_3.___y_3;
		float L_5 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_a;
		float L_7 = L_6.___z_4;
		float L_8 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), ((float)il2cpp_codegen_multiply(L_1, L_2)), ((float)il2cpp_codegen_multiply(L_4, L_5)), ((float)il2cpp_codegen_multiply(L_7, L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_12), ((float)il2cpp_codegen_add(L_1, L_3)), ((float)il2cpp_codegen_add(L_5, L_7)), ((float)il2cpp_codegen_add(L_9, L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F MeshGenerator_get_color_m01EEB09936DF89EF424BE05DD3EBE41FF9600AC6_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _color; }
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = __this->____color_36;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_a;
		float L_1 = L_0.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___1_b;
		float L_3 = L_2.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___0_a;
		float L_5 = L_4.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___1_b;
		float L_7 = L_6.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8 = ___0_a;
		float L_9 = L_8.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_10 = ___1_b;
		float L_11 = L_10.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12 = ___0_a;
		float L_13 = L_12.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_14 = ___1_b;
		float L_15 = L_14.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_16;
		memset((&L_16), 0, sizeof(L_16));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_16), ((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)), ((float)il2cpp_codegen_multiply(L_9, L_11)), ((float)il2cpp_codegen_multiply(L_13, L_15)), /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_003d;
	}

IL_003d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_17 = V_0;
		return L_17;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline (float ___0_a, float ___1_b, float ___2_value, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	{
		float L_0 = ___0_a;
		float L_1 = ___1_b;
		V_0 = (bool)((((int32_t)((((float)L_0) == ((float)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		float L_3 = ___2_value;
		float L_4 = ___0_a;
		float L_5 = ___1_b;
		float L_6 = ___0_a;
		float L_7;
		L_7 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(((float)il2cpp_codegen_subtract(L_3, L_4))/((float)il2cpp_codegen_subtract(L_5, L_6)))), NULL);
		V_1 = L_7;
		goto IL_0023;
	}

IL_001b:
	{
		V_1 = (0.0f);
		goto IL_0023;
	}

IL_0023:
	{
		float L_8 = V_1;
		return L_8;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 MeshGenerator_get_uvScale_mD0CC553E59CA2EEBBEC15DBF54ABB0DBD3BA3A63_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uvScale; }
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = __this->____uvScale_46;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 MeshGenerator_get_uvOffset_m3418697F29246491E79C0539E9AEB55C72DCB634_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uvOffset; }
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = __this->____uvOffset_47;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_UnaryNegation_m5450829F333BD2A88AF9A592C4EE331661225915_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_a;
		float L_3 = L_2.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		memset((&L_6), 0, sizeof(L_6));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_6), ((-L_1)), ((-L_3)), ((-L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_001e;
	}

IL_001e:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = V_0;
		return L_7;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___0_x, float ___1_y, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_0 = L_0;
		float L_1 = ___1_y;
		__this->___y_1 = L_1;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Distance_m2314DB9B8BD01157E013DF87BEA557375C7F9FF9_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		V_0 = ((float)il2cpp_codegen_subtract(L_1, L_3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		V_1 = ((float)il2cpp_codegen_subtract(L_5, L_7));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		V_2 = ((float)il2cpp_codegen_subtract(L_9, L_11));
		float L_12 = V_0;
		float L_13 = V_0;
		float L_14 = V_1;
		float L_15 = V_1;
		float L_16 = V_2;
		float L_17 = V_2;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_18;
		L_18 = sqrt(((double)((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_12, L_13)), ((float)il2cpp_codegen_multiply(L_14, L_15)))), ((float)il2cpp_codegen_multiply(L_16, L_17))))));
		V_3 = ((float)L_18);
		goto IL_0040;
	}

IL_0040:
	{
		float L_19 = V_3;
		return L_19;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_12), ((float)il2cpp_codegen_subtract(L_1, L_3)), ((float)il2cpp_codegen_subtract(L_5, L_7)), ((float)il2cpp_codegen_subtract(L_9, L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___zeroVector_5;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	bool V_1 = false;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this);
		float L_1;
		L_1 = Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline(L_0, NULL);
		V_0 = L_1;
		float L_2 = V_0;
		V_1 = (bool)((((float)L_2) > ((float)(9.99999975E-06f)))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_002d;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this);
		float L_5 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_4, L_5, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this = L_6;
		goto IL_0038;
	}

IL_002d:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this = L_7;
	}

IL_0038:
	{
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		float L_2 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_a;
		float L_4 = L_3.___y_3;
		float L_5 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_a;
		float L_7 = L_6.___z_4;
		float L_8 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), ((float)(L_1/L_2)), ((float)(L_4/L_5)), ((float)(L_7/L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___upVector_7;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_right_mFF573AFBBB2186E7AFA1BA7CA271A78DF67E4EA0_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___rightVector_10;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Project_m85DF3CB297EC5E1A17BD6266FF65E86AB7372C9B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_vector, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_onNormal, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	bool V_1 = false;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	float V_3 = 0.0f;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___1_onNormal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_onNormal;
		float L_2;
		L_2 = Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline(L_0, L_1, NULL);
		V_0 = L_2;
		float L_3 = V_0;
		float L_4 = ((Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682_StaticFields*)il2cpp_codegen_static_fields_for(Mathf_tE284D016E3B297B72311AAD9EB8F0E643F6A4682_il2cpp_TypeInfo_var))->___Epsilon_0;
		V_1 = (bool)((((float)L_3) < ((float)L_4))? 1 : 0);
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_001d;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_2 = L_6;
		goto IL_004c;
	}

IL_001d:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = ___0_vector;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___1_onNormal;
		float L_9;
		L_9 = Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline(L_7, L_8, NULL);
		V_3 = L_9;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_onNormal;
		float L_11 = L_10.___x_2;
		float L_12 = V_3;
		float L_13 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14 = ___1_onNormal;
		float L_15 = L_14.___y_3;
		float L_16 = V_3;
		float L_17 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = ___1_onNormal;
		float L_19 = L_18.___z_4;
		float L_20 = V_3;
		float L_21 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22;
		memset((&L_22), 0, sizeof(L_22));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_22), ((float)(((float)il2cpp_codegen_multiply(L_11, L_12))/L_13)), ((float)(((float)il2cpp_codegen_multiply(L_15, L_16))/L_17)), ((float)(((float)il2cpp_codegen_multiply(L_19, L_20))/L_21)), /*hidden argument*/NULL);
		V_2 = L_22;
		goto IL_004c;
	}

IL_004c:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23 = V_2;
		return L_23;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_get_magnitude_mF0D6017E90B345F1F52D1CC564C640F1A847AF2D_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		float L_0 = __this->___x_2;
		float L_1 = __this->___x_2;
		float L_2 = __this->___y_3;
		float L_3 = __this->___y_3;
		float L_4 = __this->___z_4;
		float L_5 = __this->___z_4;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_6;
		L_6 = sqrt(((double)((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_0, L_1)), ((float)il2cpp_codegen_multiply(L_2, L_3)))), ((float)il2cpp_codegen_multiply(L_4, L_5))))));
		V_0 = ((float)L_6);
		goto IL_0034;
	}

IL_0034:
	{
		float L_7 = V_0;
		return L_7;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lhs;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_rhs;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_lhs;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_rhs;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_lhs;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_rhs;
		float L_11 = L_10.___z_4;
		V_0 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_multiply(L_9, L_11))));
		goto IL_002d;
	}

IL_002d:
	{
		float L_12 = V_0;
		return L_12;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ((Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var))->___oneVector_3;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_zero_m32506C40EC2EE7D5D4410BF40D3EE683A3D5F32C_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ((Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var))->___zeroVector_2;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_forward_mAA55A7034304DF8B2152EAD49AE779FC4CA2EB4A_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___forwardVector_11;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t TubeGenerator_get_sides_m1DA51D8E697079A3370C7E13979F54F700B3BAC7_inline (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _sides; }
		int32_t L_0 = __this->____sides_60;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m7F3B0FA9256CE368D7636558EFEFC4AB0E1A0F41_inline (float ___0_d, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_a, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___1_a;
		float L_1 = L_0.___x_2;
		float L_2 = ___0_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___1_a;
		float L_4 = L_3.___y_3;
		float L_5 = ___0_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_a;
		float L_7 = L_6.___z_4;
		float L_8 = ___0_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), ((float)il2cpp_codegen_multiply(L_1, L_2)), ((float)il2cpp_codegen_multiply(L_4, L_5)), ((float)il2cpp_codegen_multiply(L_7, L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t MeshGenerator_get_uvMode_m069663A59CCF805CF43951424B6CE3CE106AE889_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uvMode; }
		int32_t L_0 = __this->____uvMode_45;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float MeshGenerator_get_rotation_mB779241C82CC9BB0235F09AA0D249EE1B87CE122_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _rotation; }
		float L_0 = __this->____rotation_42;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float MeshGenerator_get_size_mBD907719927C0D75540784A5B4F18741ADF68F44_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _size; }
		float L_0 = __this->____size_35;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Multiply_m2D984B613020089BF5165BA4CA10988E2DC771FE_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_a, float ___1_d, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_a;
		float L_1 = L_0.___x_0;
		float L_2 = ___1_d;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_3 = ___0_a;
		float L_4 = L_3.___y_1;
		float L_5 = ___1_d;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6;
		memset((&L_6), 0, sizeof(L_6));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_6), ((float)il2cpp_codegen_multiply(L_1, L_2)), ((float)il2cpp_codegen_multiply(L_4, L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0019;
	}

IL_0019:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_7 = V_0;
		return L_7;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float MeshGenerator_get_uvRotation_m38AD623D63FEDB94A5DFEEF63F3352AC5E707964_inline (MeshGenerator_t12E6AC30EEC5A19B1FD3D7EA506B7275108FBB7E* __this, const RuntimeMethod* method) 
{
	{
		// get { return _uvRotation; }
		float L_0 = __this->____uvRotation_48;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_right_m99043ED6B3D5AEA5033313FE3DA9571F39D1B280_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ((Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var))->___rightVector_7;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Addition_m8136742CE6EE33BA4EB81C5F584678455917D2AE_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_a, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_b, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_a;
		float L_1 = L_0.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = ___1_b;
		float L_3 = L_2.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4 = ___0_a;
		float L_5 = L_4.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6 = ___1_b;
		float L_7 = L_6.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_8), ((float)il2cpp_codegen_add(L_1, L_3)), ((float)il2cpp_codegen_add(L_5, L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0023;
	}

IL_0023:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_a, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_b, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_a;
		float L_1 = L_0.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = ___1_b;
		float L_3 = L_2.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4 = ___0_a;
		float L_5 = L_4.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6 = ___1_b;
		float L_7 = L_6.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_8), ((float)il2cpp_codegen_subtract(L_1, L_3)), ((float)il2cpp_codegen_subtract(L_5, L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0023;
	}

IL_0023:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector2_op_Implicit_m6D9CABB2C791A192867D7A4559D132BE86DD3EB7_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_v, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_v;
		float L_1 = L_0.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = ___0_v;
		float L_3 = L_2.___y_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_4), L_1, L_3, (0.0f), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_001a;
	}

IL_001a:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Implicit_mE8EBEE9291F11BB02F062D6E000F4798968CBD96_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_v, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_v;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_v;
		float L_3 = L_2.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_4), L_1, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_0015;
	}

IL_0015:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Normalize_mEF8349CC39674236CFC694189AFD36E31F89AC8F_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	bool V_1 = false;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_value;
		float L_1;
		L_1 = Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline(L_0, NULL);
		V_0 = L_1;
		float L_2 = V_0;
		V_1 = (bool)((((float)L_2) > ((float)(9.99999975E-06f)))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_001e;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_value;
		float L_5 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_4, L_5, NULL);
		V_2 = L_6;
		goto IL_0026;
	}

IL_001e:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_2 = L_7;
		goto IL_0026;
	}

IL_0026:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = V_2;
		return L_8;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float TubeGenerator_get_capUVScale_mEF333A82CE736CDF2EA7B378B85C5440AEDF6B81_inline (TubeGenerator_tB8F8E81596AE5074E52FB4FC6B3B9546F3266E46* __this, const RuntimeMethod* method) 
{
	{
		// get { return _capUVScale; }
		float L_0 = __this->____capUVScale_64;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double SplineUser_get_clipFrom_m699C755D0B41B89666EEAF9BC216338150573B13_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) 
{
	{
		// return _clipFrom;
		double L_0 = __this->____clipFrom_15;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double SplineUser_get_clipTo_m8887A1FBDE58D63C6681E3E70783345CE4C6AAFD_inline (SplineUser_tEB1991509BC38C72B0D6D875405537EBA17D8BDA* __this, const RuntimeMethod* method) 
{
	{
		// return _clipTo;
		double L_0 = __this->____clipTo_16;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_op_Multiply_mCB375FCCC12A2EC8F9EB824A1BFB4453B58C2012_inline (Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_lhs, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rhs, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = ___0_lhs;
		float L_1 = L_0.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_2 = ___1_rhs;
		float L_3 = L_2.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_4 = ___0_lhs;
		float L_5 = L_4.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_6 = ___1_rhs;
		float L_7 = L_6.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_8 = ___0_lhs;
		float L_9 = L_8.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_10 = ___1_rhs;
		float L_11 = L_10.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_12 = ___0_lhs;
		float L_13 = L_12.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_14 = ___1_rhs;
		float L_15 = L_14.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_16 = ___0_lhs;
		float L_17 = L_16.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_18 = ___1_rhs;
		float L_19 = L_18.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_20 = ___0_lhs;
		float L_21 = L_20.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_22 = ___1_rhs;
		float L_23 = L_22.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_24 = ___0_lhs;
		float L_25 = L_24.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_26 = ___1_rhs;
		float L_27 = L_26.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_28 = ___0_lhs;
		float L_29 = L_28.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_30 = ___1_rhs;
		float L_31 = L_30.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_32 = ___0_lhs;
		float L_33 = L_32.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_34 = ___1_rhs;
		float L_35 = L_34.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_36 = ___0_lhs;
		float L_37 = L_36.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_38 = ___1_rhs;
		float L_39 = L_38.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_40 = ___0_lhs;
		float L_41 = L_40.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_42 = ___1_rhs;
		float L_43 = L_42.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_44 = ___0_lhs;
		float L_45 = L_44.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_46 = ___1_rhs;
		float L_47 = L_46.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_48 = ___0_lhs;
		float L_49 = L_48.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_50 = ___1_rhs;
		float L_51 = L_50.___w_3;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_52 = ___0_lhs;
		float L_53 = L_52.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_54 = ___1_rhs;
		float L_55 = L_54.___x_0;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_56 = ___0_lhs;
		float L_57 = L_56.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_58 = ___1_rhs;
		float L_59 = L_58.___y_1;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_60 = ___0_lhs;
		float L_61 = L_60.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_62 = ___1_rhs;
		float L_63 = L_62.___z_2;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_64;
		memset((&L_64), 0, sizeof(L_64));
		Quaternion__ctor_m868FD60AA65DD5A8AC0C5DEB0608381A8D85FCD8_inline((&L_64), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_multiply(L_9, L_11)))), ((float)il2cpp_codegen_multiply(L_13, L_15)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_17, L_19)), ((float)il2cpp_codegen_multiply(L_21, L_23)))), ((float)il2cpp_codegen_multiply(L_25, L_27)))), ((float)il2cpp_codegen_multiply(L_29, L_31)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_33, L_35)), ((float)il2cpp_codegen_multiply(L_37, L_39)))), ((float)il2cpp_codegen_multiply(L_41, L_43)))), ((float)il2cpp_codegen_multiply(L_45, L_47)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_49, L_51)), ((float)il2cpp_codegen_multiply(L_53, L_55)))), ((float)il2cpp_codegen_multiply(L_57, L_59)))), ((float)il2cpp_codegen_multiply(L_61, L_63)))), /*hidden argument*/NULL);
		V_0 = L_64;
		goto IL_00e5;
	}

IL_00e5:
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_65 = V_0;
		return L_65;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_normalized_m736BBF65D5CDA7A18414370D15B4DFCC1E466F07_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Vector3_Normalize_mEF8349CC39674236CFC694189AFD36E31F89AC8F_inline(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = V_0;
		return L_2;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 SplineComputer_get_position_mD2F6425281CB9AFF55B9A81B5433F4454793D725_inline (SplineComputer_tF710DB72C0DEA24ACBF8D1D6497761846F505A22* __this, const RuntimeMethod* method) 
{
	{
		// return _lastPosition;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->____lastPosition_30;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lhs;
		float L_1 = L_0.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_rhs;
		float L_3 = L_2.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_lhs;
		float L_5 = L_4.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_rhs;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_lhs;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_rhs;
		float L_11 = L_10.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = ___0_lhs;
		float L_13 = L_12.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14 = ___1_rhs;
		float L_15 = L_14.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ___0_lhs;
		float L_17 = L_16.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = ___1_rhs;
		float L_19 = L_18.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = ___0_lhs;
		float L_21 = L_20.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = ___1_rhs;
		float L_23 = L_22.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		memset((&L_24), 0, sizeof(L_24));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_24), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_9, L_11)), ((float)il2cpp_codegen_multiply(L_13, L_15)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_17, L_19)), ((float)il2cpp_codegen_multiply(L_21, L_23)))), /*hidden argument*/NULL);
		V_0 = L_24;
		goto IL_005a;
	}

IL_005a:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = V_0;
		return L_25;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		float L_0 = ___2_t;
		float L_1;
		L_1 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_0, NULL);
		___2_t = L_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_a;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___1_b;
		float L_5 = L_4.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_a;
		float L_7 = L_6.___x_2;
		float L_8 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = ___0_a;
		float L_10 = L_9.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = ___1_b;
		float L_12 = L_11.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = ___0_a;
		float L_14 = L_13.___y_3;
		float L_15 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ___0_a;
		float L_17 = L_16.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = ___1_b;
		float L_19 = L_18.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = ___0_a;
		float L_21 = L_20.___z_4;
		float L_22 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		memset((&L_23), 0, sizeof(L_23));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_23), ((float)il2cpp_codegen_add(L_3, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_5, L_7)), L_8)))), ((float)il2cpp_codegen_add(L_10, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_12, L_14)), L_15)))), ((float)il2cpp_codegen_add(L_17, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_19, L_21)), L_22)))), /*hidden argument*/NULL);
		V_0 = L_23;
		goto IL_0053;
	}

IL_0053:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = V_0;
		return L_24;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_get_sqrMagnitude_m43C27DEC47C4811FB30AB474FF2131A963B66FC8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___x_2;
		float L_1 = __this->___x_2;
		float L_2 = __this->___y_3;
		float L_3 = __this->___y_3;
		float L_4 = __this->___z_4;
		float L_5 = __this->___z_4;
		V_0 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_0, L_1)), ((float)il2cpp_codegen_multiply(L_2, L_3)))), ((float)il2cpp_codegen_multiply(L_4, L_5))));
		goto IL_002d;
	}

IL_002d:
	{
		float L_6 = V_0;
		return L_6;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0 = ___0_a;
		int32_t L_1 = ___1_b;
		if ((((int32_t)L_0) < ((int32_t)L_1)))
		{
			goto IL_0008;
		}
	}
	{
		int32_t L_2 = ___1_b;
		G_B3_0 = L_2;
		goto IL_0009;
	}

IL_0008:
	{
		int32_t L_3 = ___0_a;
		G_B3_0 = L_3;
	}

IL_0009:
	{
		V_0 = G_B3_0;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0 = ___0_a;
		int32_t L_1 = ___1_b;
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			goto IL_0008;
		}
	}
	{
		int32_t L_2 = ___1_b;
		G_B3_0 = L_2;
		goto IL_0009;
	}

IL_0008:
	{
		int32_t L_3 = ___0_a;
		G_B3_0 = L_3;
	}

IL_0009:
	{
		V_0 = G_B3_0;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_RoundToInt_m60F8B66CF27F1FA75AA219342BD184B75771EB4B_inline (float ___0_f, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		float L_0 = ___0_f;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_1;
		L_1 = bankers_round(((double)L_0));
		V_0 = il2cpp_codegen_cast_double_to_int<int32_t>(L_1);
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Clamp_m4DC36EEFDBE5F07C16249DA568023C5ECCFF0E7B_inline (int32_t ___0_value, int32_t ___1_min, int32_t ___2_max, const RuntimeMethod* method) 
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	{
		int32_t L_0 = ___0_value;
		int32_t L_1 = ___1_min;
		V_0 = (bool)((((int32_t)L_0) < ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_000e;
		}
	}
	{
		int32_t L_3 = ___1_min;
		___0_value = L_3;
		goto IL_0019;
	}

IL_000e:
	{
		int32_t L_4 = ___0_value;
		int32_t L_5 = ___2_max;
		V_1 = (bool)((((int32_t)L_4) > ((int32_t)L_5))? 1 : 0);
		bool L_6 = V_1;
		if (!L_6)
		{
			goto IL_0019;
		}
	}
	{
		int32_t L_7 = ___2_max;
		___0_value = L_7;
	}

IL_0019:
	{
		int32_t L_8 = ___0_value;
		V_2 = L_8;
		goto IL_001d;
	}

IL_001d:
	{
		int32_t L_9 = V_2;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline (float ___0_a, float ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = ___0_a;
		float L_1 = ___1_b;
		float L_2 = ___0_a;
		float L_3 = ___2_t;
		float L_4;
		L_4 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_3, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_0, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_1, L_2)), L_4))));
		goto IL_0010;
	}

IL_0010:
	{
		float L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_Lerp_mE79F87889843ECDC188E4CB5B5E1F1B2256E5EBE_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		float L_0 = ___2_t;
		float L_1;
		L_1 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_0, NULL);
		___2_t = L_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___0_a;
		float L_3 = L_2.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___1_b;
		float L_5 = L_4.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___0_a;
		float L_7 = L_6.___r_0;
		float L_8 = ___2_t;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_9 = ___0_a;
		float L_10 = L_9.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_11 = ___1_b;
		float L_12 = L_11.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_13 = ___0_a;
		float L_14 = L_13.___g_1;
		float L_15 = ___2_t;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_16 = ___0_a;
		float L_17 = L_16.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_18 = ___1_b;
		float L_19 = L_18.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_20 = ___0_a;
		float L_21 = L_20.___b_2;
		float L_22 = ___2_t;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_23 = ___0_a;
		float L_24 = L_23.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_25 = ___1_b;
		float L_26 = L_25.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_27 = ___0_a;
		float L_28 = L_27.___a_3;
		float L_29 = ___2_t;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_30;
		memset((&L_30), 0, sizeof(L_30));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_30), ((float)il2cpp_codegen_add(L_3, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_5, L_7)), L_8)))), ((float)il2cpp_codegen_add(L_10, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_12, L_14)), L_15)))), ((float)il2cpp_codegen_add(L_17, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_19, L_21)), L_22)))), ((float)il2cpp_codegen_add(L_24, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_26, L_28)), L_29)))), /*hidden argument*/NULL);
		V_0 = L_30;
		goto IL_0069;
	}

IL_0069:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_31 = V_0;
		return L_31;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t SplinePoint_get_type_m9B440904AE6657408EF005DE17D5AE3C2FB3BF79_inline (SplinePoint_t8E0F21C3D563F58011716CD9D376C4D52D949CFB* __this, const RuntimeMethod* method) 
{
	{
		// get { return _type; }
		int32_t L_0 = __this->____type_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Color_op_Inequality_mF1C733BA10E60B086AB950A71143678AE76C4D92_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_lhs, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_rhs, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_lhs;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = ___1_rhs;
		bool L_2;
		L_2 = Color_op_Equality_mB2BDC39B0B367BA15AA8DF22F8CB0D02D20BDC71_inline(L_0, L_1, NULL);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_000e;
	}

IL_000e:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_white_m068F5AF879B0FCA584E3693F762EA41BB65532C6_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (1.0f), (1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector3_op_Equality_mCDCBB8D2EDC3D3BF20F31A25ACB34705D352B479_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	bool V_4 = false;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lhs;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_rhs;
		float L_3 = L_2.___x_2;
		V_0 = ((float)il2cpp_codegen_subtract(L_1, L_3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_lhs;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_rhs;
		float L_7 = L_6.___y_3;
		V_1 = ((float)il2cpp_codegen_subtract(L_5, L_7));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_lhs;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_rhs;
		float L_11 = L_10.___z_4;
		V_2 = ((float)il2cpp_codegen_subtract(L_9, L_11));
		float L_12 = V_0;
		float L_13 = V_0;
		float L_14 = V_1;
		float L_15 = V_1;
		float L_16 = V_2;
		float L_17 = V_2;
		V_3 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_12, L_13)), ((float)il2cpp_codegen_multiply(L_14, L_15)))), ((float)il2cpp_codegen_multiply(L_16, L_17))));
		float L_18 = V_3;
		V_4 = (bool)((((float)L_18) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_0043;
	}

IL_0043:
	{
		bool L_19 = V_4;
		return L_19;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_back_mCA5A84170E8DE5CE38C0551B4CCAD647BF215E57_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___backVector_12;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EmptyHandler_Invoke_mA37B15BB990634F169A02D16A2C1B7940739FFA5_inline (EmptyHandler_t114A5175D4FB70420446E617A7881739AD29C9EE* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m5D83C79B12616961D8147BB59AD5E55683361E85_gshared_inline (List_1_t495F03F47D827883530F951D563C0BB7340E5995* __this, double ___0_item, const RuntimeMethod* method) 
{
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_6 = V_0;
		int32_t L_7 = V_1;
		double L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (double)L_8);
		return;
	}

IL_0034:
	{
		double L_9 = ___0_item;
		((  void (*) (List_1_t495F03F47D827883530F951D563C0BB7340E5995*, double, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m20263C594A01149776C2D378AB9C1151F4C597AD_gshared_inline (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9* __this, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 ___0_item, const RuntimeMethod* method) 
{
	RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_1 = (RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		RaycastHitU5BU5D_t008B8309DE422FE7567068D743D68054D5EBF1A8* L_6 = V_0;
		int32_t L_7 = V_1;
		RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5)L_8);
		return;
	}

IL_0034:
	{
		RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5 L_9 = ___0_item;
		((  void (*) (List_1_t616BC508412283D06A62FEEDA7C4D4C3E75D63D9*, RaycastHit_t6F30BD0B38B56401CA833A1B87BD74F2ACD2F2B5, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Queue_1_get_Count_m1768ADA9855B7CDA14C9C42E098A287F1A39C3A2_gshared_inline (Queue_1_tE9EF546915795972C3BFD68FBB8FA859D3BAF3B5* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->____size_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector2_op_Equality_m6F2E069A50E787D131261E5CB25FC9E03F95B5E1_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___0_lhs, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___1_rhs, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	bool V_2 = false;
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___0_lhs;
		float L_1 = L_0.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = ___1_rhs;
		float L_3 = L_2.___x_0;
		V_0 = ((float)il2cpp_codegen_subtract(L_1, L_3));
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4 = ___0_lhs;
		float L_5 = L_4.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6 = ___1_rhs;
		float L_7 = L_6.___y_1;
		V_1 = ((float)il2cpp_codegen_subtract(L_5, L_7));
		float L_8 = V_0;
		float L_9 = V_0;
		float L_10 = V_1;
		float L_11 = V_1;
		V_2 = (bool)((((float)((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_8, L_9)), ((float)il2cpp_codegen_multiply(L_10, L_11))))) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_002e;
	}

IL_002e:
	{
		bool L_12 = V_2;
		return L_12;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___0_x, float ___1_y, float ___2_z, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_2 = L_0;
		float L_1 = ___1_y;
		__this->___y_3 = L_1;
		float L_2 = ___2_z;
		__this->___z_4 = L_2;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_r;
		__this->___r_0 = L_0;
		float L_1 = ___1_g;
		__this->___g_1 = L_1;
		float L_2 = ___2_b;
		__this->___b_2 = L_2;
		float L_3 = ___3_a;
		__this->___a_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___0_value, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	bool V_2 = false;
	{
		float L_0 = ___0_value;
		V_0 = (bool)((((float)L_0) < ((float)(0.0f)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = (0.0f);
		goto IL_002d;
	}

IL_0015:
	{
		float L_2 = ___0_value;
		V_2 = (bool)((((float)L_2) > ((float)(1.0f)))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0029;
		}
	}
	{
		V_1 = (1.0f);
		goto IL_002d;
	}

IL_0029:
	{
		float L_4 = ___0_value;
		V_1 = L_4;
		goto IL_002d;
	}

IL_002d:
	{
		float L_5 = V_1;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_vector, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_vector;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_vector;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_vector;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_vector;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_vector;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___0_vector;
		float L_11 = L_10.___z_4;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_12;
		L_12 = sqrt(((double)((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_multiply(L_9, L_11))))));
		V_0 = ((float)L_12);
		goto IL_0034;
	}

IL_0034:
	{
		float L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Quaternion__ctor_m868FD60AA65DD5A8AC0C5DEB0608381A8D85FCD8_inline (Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* __this, float ___0_x, float ___1_y, float ___2_z, float ___3_w, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_0 = L_0;
		float L_1 = ___1_y;
		__this->___y_1 = L_1;
		float L_2 = ___2_z;
		__this->___z_2 = L_2;
		float L_3 = ___3_w;
		__this->___w_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Color_op_Equality_mB2BDC39B0B367BA15AA8DF22F8CB0D02D20BDC71_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_lhs, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_rhs, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_lhs;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_1;
		L_1 = Color_op_Implicit_m9B3228DAFA8DC57A75DE00CBBF13ED4F1E7B01FF_inline(L_0, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___1_rhs;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_3;
		L_3 = Color_op_Implicit_m9B3228DAFA8DC57A75DE00CBBF13ED4F1E7B01FF_inline(L_2, NULL);
		bool L_4;
		L_4 = Vector4_op_Equality_mCEA0E5F229F4AE8C55152F7A8F84345F24F52DC6_inline(L_1, L_3, NULL);
		V_0 = L_4;
		goto IL_0015;
	}

IL_0015:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 Color_op_Implicit_m9B3228DAFA8DC57A75DE00CBBF13ED4F1E7B01FF_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_c, const RuntimeMethod* method) 
{
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_c;
		float L_1 = L_0.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___0_c;
		float L_3 = L_2.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___0_c;
		float L_5 = L_4.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___0_c;
		float L_7 = L_6.___a_3;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline((&L_8), L_1, L_3, L_5, L_7, /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0021;
	}

IL_0021:
	{
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector4_op_Equality_mCEA0E5F229F4AE8C55152F7A8F84345F24F52DC6_inline (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___0_lhs, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_rhs, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	bool V_5 = false;
	{
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_0 = ___0_lhs;
		float L_1 = L_0.___x_1;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_2 = ___1_rhs;
		float L_3 = L_2.___x_1;
		V_0 = ((float)il2cpp_codegen_subtract(L_1, L_3));
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_4 = ___0_lhs;
		float L_5 = L_4.___y_2;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_6 = ___1_rhs;
		float L_7 = L_6.___y_2;
		V_1 = ((float)il2cpp_codegen_subtract(L_5, L_7));
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_8 = ___0_lhs;
		float L_9 = L_8.___z_3;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_10 = ___1_rhs;
		float L_11 = L_10.___z_3;
		V_2 = ((float)il2cpp_codegen_subtract(L_9, L_11));
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_12 = ___0_lhs;
		float L_13 = L_12.___w_4;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_14 = ___1_rhs;
		float L_15 = L_14.___w_4;
		V_3 = ((float)il2cpp_codegen_subtract(L_13, L_15));
		float L_16 = V_0;
		float L_17 = V_0;
		float L_18 = V_1;
		float L_19 = V_1;
		float L_20 = V_2;
		float L_21 = V_2;
		float L_22 = V_3;
		float L_23 = V_3;
		V_4 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_16, L_17)), ((float)il2cpp_codegen_multiply(L_18, L_19)))), ((float)il2cpp_codegen_multiply(L_20, L_21)))), ((float)il2cpp_codegen_multiply(L_22, L_23))));
		float L_24 = V_4;
		V_5 = (bool)((((float)L_24) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_0057;
	}

IL_0057:
	{
		bool L_25 = V_5;
		return L_25;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* __this, float ___0_x, float ___1_y, float ___2_z, float ___3_w, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_1 = L_0;
		float L_1 = ___1_y;
		__this->___y_2 = L_1;
		float L_2 = ___2_z;
		__this->___z_3 = L_2;
		float L_3 = ___3_w;
		__this->___w_4 = L_3;
		return;
	}
}
