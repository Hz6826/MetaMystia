using System;
using DayScene.Interactables.Collections.ConditionExtensions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000173 RID: 371
	public class EntityConditionComponent : MonoBehaviour
	{
		// Token: 0x060028DD RID: 10461 RVA: 0x001266E0 File Offset: 0x001248E0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConditionComponent()
		{
			Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "EntityConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr);
			EntityConditionComponent.NativeFieldInfoPtr_conditionUpdateAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "conditionUpdateAction");
			EntityConditionComponent.NativeFieldInfoPtr_onRefreshEntityCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "onRefreshEntityCallback");
			EntityConditionComponent.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "initialized");
			EntityConditionComponent.NativeFieldInfoPtr_CheckRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "CheckRule");
			EntityConditionComponent.NativeFieldInfoPtr_DisableInNX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "DisableInNX");
			EntityConditionComponent.NativeFieldInfoPtr_Extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "Extensions");
			EntityConditionComponent.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "m_Status");
			EntityConditionComponent.NativeMethodInfoPtr_TryUpdateConditionComponent_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670446);
			EntityConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670447);
			EntityConditionComponent.NativeMethodInfoPtr_AutoInitialize_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670448);
			EntityConditionComponent.NativeMethodInfoPtr_ShouldFadeOut_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670449);
			EntityConditionComponent.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670450);
			EntityConditionComponent.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670451);
			EntityConditionComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670452);
			EntityConditionComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670453);
			EntityConditionComponent.NativeMethodInfoPtr_PostDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670454);
			EntityConditionComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670455);
			EntityConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670456);
			EntityConditionComponent.NativeMethodInfoPtr_GetAvailability_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670457);
			EntityConditionComponent.NativeMethodInfoPtr_Refresh_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670458);
			EntityConditionComponent.NativeMethodInfoPtr_CalculateAvailability_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670459);
			EntityConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670460);
			EntityConditionComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, 100670461);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x001268DC File Offset: 0x00124ADC
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 92618, RefRangeEnd = 92670, XrefRangeStart = 92564, XrefRangeEnd = 92618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryUpdateConditionComponent<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.MethodInfoStoreGeneric_TryUpdateConditionComponent_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00126904 File Offset: 0x00124B04
		[CallerCount(0)]
		public unsafe virtual Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00126950 File Offset: 0x00124B50
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AutoInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_AutoInitialize_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00126998 File Offset: 0x00124B98
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_ShouldFadeOut_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x001269E0 File Offset: 0x00124BE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92678, RefRangeEnd = 92680, XrefRangeStart = 92670, XrefRangeEnd = 92678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00126A08 File Offset: 0x00124C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92756, RefRangeEnd = 92758, XrefRangeStart = 92680, XrefRangeEnd = 92756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00126A3C File Offset: 0x00124C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92758, XrefRangeEnd = 92759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00126A70 File Offset: 0x00124C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92759, XrefRangeEnd = 92782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00126AA4 File Offset: 0x00124CA4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_PostDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00126AE0 File Offset: 0x00124CE0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00126B1C File Offset: 0x00124D1C
		[CallerCount(0)]
		public unsafe virtual bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00126B64 File Offset: 0x00124D64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92790, RefRangeEnd = 92793, XrefRangeStart = 92782, XrefRangeEnd = 92790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_GetAvailability_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00126BA0 File Offset: 0x00124DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92793, XrefRangeEnd = 92806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_Refresh_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00126BD4 File Offset: 0x00124DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92806, XrefRangeEnd = 92807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CalculateAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr_CalculateAvailability_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00126C10 File Offset: 0x00124E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00126C4C File Offset: 0x00124E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92807, XrefRangeEnd = 92812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00017F0B File Offset: 0x0001610B
		public EntityConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00126C88 File Offset: 0x00124E88
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x00017F14 File Offset: 0x00016114
		public unsafe static Dictionary<Type, HashSet<Action>> conditionUpdateAction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityConditionComponent.NativeFieldInfoPtr_conditionUpdateAction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, HashSet<Action>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityConditionComponent.NativeFieldInfoPtr_conditionUpdateAction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x00126CB0 File Offset: 0x00124EB0
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x00017F26 File Offset: 0x00016126
		public unsafe Action<bool, bool> onRefreshEntityCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_onRefreshEntityCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_onRefreshEntityCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x00126CE0 File Offset: 0x00124EE0
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x00017F45 File Offset: 0x00016145
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x00126D08 File Offset: 0x00124F08
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00017F60 File Offset: 0x00016160
		public unsafe EntityConditionComponent.Rule CheckRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_CheckRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_CheckRule)) = value;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x00126D30 File Offset: 0x00124F30
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x00017F7B File Offset: 0x0001617B
		public unsafe bool DisableInNX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_DisableInNX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_DisableInNX)) = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x00126D58 File Offset: 0x00124F58
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x00017F96 File Offset: 0x00016196
		public unsafe Il2CppReferenceArray<EntityConditionExtension> Extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_Extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityConditionExtension>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_Extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x00126D88 File Offset: 0x00124F88
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x00017FB5 File Offset: 0x000161B5
		public unsafe Il2CppStructArray<bool> m_Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_m_Status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConditionComponent.NativeFieldInfoPtr_m_Status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeFieldInfoPtr_conditionUpdateAction;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeFieldInfoPtr_onRefreshEntityCallback;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeFieldInfoPtr_CheckRule;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeFieldInfoPtr_DisableInNX;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeFieldInfoPtr_Extensions;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeFieldInfoPtr_m_Status;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateConditionComponent_Public_Static_Void_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Abstract_Virtual_New_Type_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_AutoInitialize_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_ShouldFadeOut_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_PostDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailability_Private_Boolean_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Protected_Void_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAvailability_Private_Boolean_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000792 RID: 1938
		public enum Rule
		{
			// Token: 0x040069E4 RID: 27108
			AllTrue,
			// Token: 0x040069E5 RID: 27109
			AnyTrue,
			// Token: 0x040069E6 RID: 27110
			AllFalseExceptItself
		}

		// Token: 0x02000793 RID: 1939
		[ObfuscatedName("DayScene.Interactables.Collections.ConditionComponents.EntityConditionComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A396 RID: 41878 RVA: 0x002AE1D8 File Offset: 0x002AC3D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr);
				EntityConditionComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr, "<>9");
				EntityConditionComponent.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr, "<>9__19_0");
				EntityConditionComponent.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr, "<>9__19_1");
				EntityConditionComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr, 100670464);
				EntityConditionComponent.__c.NativeMethodInfoPtr__GetAvailability_b__19_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr, 100670465);
				EntityConditionComponent.__c.NativeMethodInfoPtr__GetAvailability_b__19_1_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr, 100670466);
			}

			// Token: 0x0600A397 RID: 41879 RVA: 0x002AE27C File Offset: 0x002AC47C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConditionComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A398 RID: 41880 RVA: 0x002AE2B8 File Offset: 0x002AC4B8
			[CallerCount(0)]
			public unsafe bool _GetAvailability_b__19_0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.__c.NativeMethodInfoPtr__GetAvailability_b__19_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A399 RID: 41881 RVA: 0x002AE304 File Offset: 0x002AC504
			[CallerCount(0)]
			public unsafe bool _GetAvailability_b__19_1(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionComponent.__c.NativeMethodInfoPtr__GetAvailability_b__19_1_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A39A RID: 41882 RVA: 0x00058555 File Offset: 0x00056755
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035F3 RID: 13811
			// (get) Token: 0x0600A39B RID: 41883 RVA: 0x002AE350 File Offset: 0x002AC550
			// (set) Token: 0x0600A39C RID: 41884 RVA: 0x0005855E File Offset: 0x0005675E
			public unsafe static EntityConditionComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityConditionComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConditionComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityConditionComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F4 RID: 13812
			// (get) Token: 0x0600A39D RID: 41885 RVA: 0x002AE378 File Offset: 0x002AC578
			// (set) Token: 0x0600A39E RID: 41886 RVA: 0x00058570 File Offset: 0x00056770
			public unsafe static Func<bool, bool> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityConditionComponent.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityConditionComponent.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F5 RID: 13813
			// (get) Token: 0x0600A39F RID: 41887 RVA: 0x002AE3A0 File Offset: 0x002AC5A0
			// (set) Token: 0x0600A3A0 RID: 41888 RVA: 0x00058582 File Offset: 0x00056782
			public unsafe static Func<bool, bool> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityConditionComponent.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityConditionComponent.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069E7 RID: 27111
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040069E8 RID: 27112
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040069E9 RID: 27113
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x040069EA RID: 27114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069EB RID: 27115
			private static readonly IntPtr NativeMethodInfoPtr__GetAvailability_b__19_0_Internal_Boolean_Boolean_0;

			// Token: 0x040069EC RID: 27116
			private static readonly IntPtr NativeMethodInfoPtr__GetAvailability_b__19_1_Internal_Boolean_Boolean_0;
		}

		// Token: 0x02000794 RID: 1940
		private sealed class MethodInfoStoreGeneric_TryUpdateConditionComponent_Public_Static_Void_0<T>
		{
			// Token: 0x040069ED RID: 27117
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityConditionComponent.NativeMethodInfoPtr_TryUpdateConditionComponent_Public_Static_Void_0, Il2CppClassPointerStore<EntityConditionComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
