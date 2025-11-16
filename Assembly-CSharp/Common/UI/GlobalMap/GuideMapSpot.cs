using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Common.UI.GlobalMap
{
	// Token: 0x020003D5 RID: 981
	public class GuideMapSpot : MonoBehaviour
	{
		// Token: 0x06007507 RID: 29959 RVA: 0x00224738 File Offset: 0x00222938
		// Note: this type is marked as 'beforefieldinit'.
		static GuideMapSpot()
		{
			Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GlobalMap", "GuideMapSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr);
			GuideMapSpot.NativeFieldInfoPtr__MapName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "<MapName>k__BackingField");
			GuideMapSpot.NativeFieldInfoPtr_s_TurnOffPointerInteractionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "s_TurnOffPointerInteractionCallback");
			GuideMapSpot.NativeFieldInfoPtr_s_IsPointerInteractionOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "s_IsPointerInteractionOn");
			GuideMapSpot.NativeFieldInfoPtr_m_MapSubsetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "m_MapSubsetName");
			GuideMapSpot.NativeFieldInfoPtr_m_OnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "m_OnHover");
			GuideMapSpot.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "m_CanvasGroup");
			GuideMapSpot.NativeFieldInfoPtr_m_MapSubsetNameHashSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "m_MapSubsetNameHashSet");
			GuideMapSpot.NativeFieldInfoPtr__UIButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "<UIButton>k__BackingField");
			GuideMapSpot.NativeFieldInfoPtr__IsActivated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, "<IsActivated>k__BackingField");
			GuideMapSpot.NativeMethodInfoPtr_DisablePointerInteraction_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687337);
			GuideMapSpot.NativeMethodInfoPtr_EnablePointerInteraction_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687338);
			GuideMapSpot.NativeMethodInfoPtr_get_MapName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687339);
			GuideMapSpot.NativeMethodInfoPtr_set_MapName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687340);
			GuideMapSpot.NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687341);
			GuideMapSpot.NativeMethodInfoPtr_MatchesMapNameOrSubset_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687342);
			GuideMapSpot.NativeMethodInfoPtr_get_PrimaryName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687343);
			GuideMapSpot.NativeMethodInfoPtr_get_UIButton_Public_Virtual_Final_New_get_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687344);
			GuideMapSpot.NativeMethodInfoPtr_set_UIButton_Private_set_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687345);
			GuideMapSpot.NativeMethodInfoPtr_get_IsActivated_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687346);
			GuideMapSpot.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687347);
			GuideMapSpot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687348);
			GuideMapSpot.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687349);
			GuideMapSpot.NativeMethodInfoPtr_OnTurnOffPointerInteraction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687350);
			GuideMapSpot.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687351);
			GuideMapSpot.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687352);
			GuideMapSpot.NativeMethodInfoPtr_UpdateVisual_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687353);
			GuideMapSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr, 100687354);
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x00224984 File Offset: 0x00222B84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 291141, RefRangeEnd = 291146, XrefRangeStart = 291134, XrefRangeEnd = 291141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisablePointerInteraction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_DisablePointerInteraction_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x002249AC File Offset: 0x00222BAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 291150, RefRangeEnd = 291155, XrefRangeStart = 291146, XrefRangeEnd = 291150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnablePointerInteraction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_EnablePointerInteraction_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600750A RID: 29962 RVA: 0x002249D4 File Offset: 0x00222BD4
		// (set) Token: 0x0600750B RID: 29963 RVA: 0x00224A0C File Offset: 0x00222C0C
		public unsafe string MapName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_get_MapName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_set_MapName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600750C RID: 29964 RVA: 0x00224A50 File Offset: 0x00222C50
		public unsafe virtual RectTransform RectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291155, XrefRangeEnd = 291158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x00224A90 File Offset: 0x00222C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291158, XrefRangeEnd = 291162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MatchesMapNameOrSubset(string mapName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_MatchesMapNameOrSubset_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600750E RID: 29966 RVA: 0x00224AE0 File Offset: 0x00222CE0
		public unsafe virtual string PrimaryName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_get_PrimaryName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x00224B18 File Offset: 0x00222D18
		// (set) Token: 0x06007510 RID: 29968 RVA: 0x00224B58 File Offset: 0x00222D58
		public unsafe virtual UIButtonSimple UIButton
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_get_UIButton_Public_Virtual_Final_New_get_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_set_UIButton_Private_set_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x00224B9C File Offset: 0x00222D9C
		// (set) Token: 0x06007512 RID: 29970 RVA: 0x00224BD8 File Offset: 0x00222DD8
		public unsafe virtual bool IsActivated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_get_IsActivated_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x00224C18 File Offset: 0x00222E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291162, XrefRangeEnd = 291196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00224C4C File Offset: 0x00222E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291196, XrefRangeEnd = 291217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00224C80 File Offset: 0x00222E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291217, XrefRangeEnd = 291219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTurnOffPointerInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_OnTurnOffPointerInteraction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x00224CB4 File Offset: 0x00222EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291219, XrefRangeEnd = 291224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x00224CF8 File Offset: 0x00222EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x00224D3C File Offset: 0x00222F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291228, RefRangeEnd = 291229, XrefRangeStart = 291224, XrefRangeEnd = 291228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(bool activate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr_UpdateVisual_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x00224D7C File Offset: 0x00222F7C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuideMapSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x0003F58C File Offset: 0x0003D78C
		public GuideMapSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600751B RID: 29979 RVA: 0x00224DB8 File Offset: 0x00222FB8
		// (set) Token: 0x0600751C RID: 29980 RVA: 0x0003F595 File Offset: 0x0003D795
		public unsafe string _MapName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr__MapName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr__MapName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x00224DE0 File Offset: 0x00222FE0
		// (set) Token: 0x0600751E RID: 29982 RVA: 0x0003F5B4 File Offset: 0x0003D7B4
		public unsafe static Action s_TurnOffPointerInteractionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuideMapSpot.NativeFieldInfoPtr_s_TurnOffPointerInteractionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuideMapSpot.NativeFieldInfoPtr_s_TurnOffPointerInteractionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x00224E08 File Offset: 0x00223008
		// (set) Token: 0x06007520 RID: 29984 RVA: 0x0003F5C6 File Offset: 0x0003D7C6
		public unsafe static bool s_IsPointerInteractionOn
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GuideMapSpot.NativeFieldInfoPtr_s_IsPointerInteractionOn, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuideMapSpot.NativeFieldInfoPtr_s_IsPointerInteractionOn, (void*)(&value));
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x00224E24 File Offset: 0x00223024
		// (set) Token: 0x06007522 RID: 29986 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
		public unsafe Il2CppStringArray m_MapSubsetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_MapSubsetName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_MapSubsetName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x00224E54 File Offset: 0x00223054
		// (set) Token: 0x06007524 RID: 29988 RVA: 0x0003F5F3 File Offset: 0x0003D7F3
		public unsafe CanvasGroup m_OnHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_OnHover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_OnHover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x00224E84 File Offset: 0x00223084
		// (set) Token: 0x06007526 RID: 29990 RVA: 0x0003F612 File Offset: 0x0003D812
		public unsafe CanvasGroup m_CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x00224EB4 File Offset: 0x002230B4
		// (set) Token: 0x06007528 RID: 29992 RVA: 0x0003F631 File Offset: 0x0003D831
		public unsafe HashSet<string> m_MapSubsetNameHashSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_MapSubsetNameHashSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr_m_MapSubsetNameHashSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x00224EE4 File Offset: 0x002230E4
		// (set) Token: 0x0600752A RID: 29994 RVA: 0x0003F650 File Offset: 0x0003D850
		public unsafe UIButtonSimple _UIButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr__UIButton_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr__UIButton_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600752B RID: 29995 RVA: 0x00224F14 File Offset: 0x00223114
		// (set) Token: 0x0600752C RID: 29996 RVA: 0x0003F66F File Offset: 0x0003D86F
		public unsafe bool _IsActivated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr__IsActivated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpot.NativeFieldInfoPtr__IsActivated_k__BackingField)) = value;
			}
		}

		// Token: 0x04004D87 RID: 19847
		private static readonly IntPtr NativeFieldInfoPtr__MapName_k__BackingField;

		// Token: 0x04004D88 RID: 19848
		private static readonly IntPtr NativeFieldInfoPtr_s_TurnOffPointerInteractionCallback;

		// Token: 0x04004D89 RID: 19849
		private static readonly IntPtr NativeFieldInfoPtr_s_IsPointerInteractionOn;

		// Token: 0x04004D8A RID: 19850
		private static readonly IntPtr NativeFieldInfoPtr_m_MapSubsetName;

		// Token: 0x04004D8B RID: 19851
		private static readonly IntPtr NativeFieldInfoPtr_m_OnHover;

		// Token: 0x04004D8C RID: 19852
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

		// Token: 0x04004D8D RID: 19853
		private static readonly IntPtr NativeFieldInfoPtr_m_MapSubsetNameHashSet;

		// Token: 0x04004D8E RID: 19854
		private static readonly IntPtr NativeFieldInfoPtr__UIButton_k__BackingField;

		// Token: 0x04004D8F RID: 19855
		private static readonly IntPtr NativeFieldInfoPtr__IsActivated_k__BackingField;

		// Token: 0x04004D90 RID: 19856
		private static readonly IntPtr NativeMethodInfoPtr_DisablePointerInteraction_Public_Static_Void_0;

		// Token: 0x04004D91 RID: 19857
		private static readonly IntPtr NativeMethodInfoPtr_EnablePointerInteraction_Public_Static_Void_0;

		// Token: 0x04004D92 RID: 19858
		private static readonly IntPtr NativeMethodInfoPtr_get_MapName_Public_get_String_0;

		// Token: 0x04004D93 RID: 19859
		private static readonly IntPtr NativeMethodInfoPtr_set_MapName_Private_set_Void_String_0;

		// Token: 0x04004D94 RID: 19860
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0;

		// Token: 0x04004D95 RID: 19861
		private static readonly IntPtr NativeMethodInfoPtr_MatchesMapNameOrSubset_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04004D96 RID: 19862
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004D97 RID: 19863
		private static readonly IntPtr NativeMethodInfoPtr_get_UIButton_Public_Virtual_Final_New_get_UIButtonSimple_0;

		// Token: 0x04004D98 RID: 19864
		private static readonly IntPtr NativeMethodInfoPtr_set_UIButton_Private_set_Void_UIButtonSimple_0;

		// Token: 0x04004D99 RID: 19865
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004D9A RID: 19866
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0;

		// Token: 0x04004D9B RID: 19867
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D9C RID: 19868
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004D9D RID: 19869
		private static readonly IntPtr NativeMethodInfoPtr_OnTurnOffPointerInteraction_Private_Void_0;

		// Token: 0x04004D9E RID: 19870
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04004D9F RID: 19871
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04004DA0 RID: 19872
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Public_Void_Boolean_0;

		// Token: 0x04004DA1 RID: 19873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
