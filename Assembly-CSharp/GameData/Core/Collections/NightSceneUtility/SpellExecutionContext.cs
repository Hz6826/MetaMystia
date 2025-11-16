using System;
using Common.CharacterUtility;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200024E RID: 590
	public class SpellExecutionContext : Il2CppSystem.Object
	{
		// Token: 0x060049A9 RID: 18857 RVA: 0x0019E548 File Offset: 0x0019C748
		// Note: this type is marked as 'beforefieldinit'.
		static SpellExecutionContext()
		{
			Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "SpellExecutionContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr);
			SpellExecutionContext.NativeFieldInfoPtr_m_RotationsCoroutineHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "m_RotationsCoroutineHandles");
			SpellExecutionContext.NativeFieldInfoPtr__GuestsController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<GuestsController>k__BackingField");
			SpellExecutionContext.NativeFieldInfoPtr__CharacterData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<CharacterData>k__BackingField");
			SpellExecutionContext.NativeFieldInfoPtr__GuestCharacterInstances_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<GuestCharacterInstances>k__BackingField");
			SpellExecutionContext.NativeFieldInfoPtr__SpellLanguageData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<SpellLanguageData>k__BackingField");
			SpellExecutionContext.NativeFieldInfoPtr__OnFinishCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<OnFinishCallback>k__BackingField");
			SpellExecutionContext.NativeFieldInfoPtr__ShouldRecordSpellNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<ShouldRecordSpellNum>k__BackingField");
			SpellExecutionContext.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuestsController_SpecialGuest_Il2CppReferenceArray_1_AStarInputGeneratorComponent_Il2CppReferenceArray_1_LanguageBase_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677958);
			SpellExecutionContext.NativeMethodInfoPtr_get_GuestPosition_Public_get_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677959);
			SpellExecutionContext.NativeMethodInfoPtr_get_IsSitInLeftSeat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677960);
			SpellExecutionContext.NativeMethodInfoPtr_get_GuestsController_Public_get_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677961);
			SpellExecutionContext.NativeMethodInfoPtr_get_CharacterData_Public_get_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677962);
			SpellExecutionContext.NativeMethodInfoPtr_get_GuestCharacterInstances_Public_get_Il2CppReferenceArray_1_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677963);
			SpellExecutionContext.NativeMethodInfoPtr_get_SpellLanguageData_Public_get_Il2CppReferenceArray_1_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677964);
			SpellExecutionContext.NativeMethodInfoPtr_get_OnFinishCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677965);
			SpellExecutionContext.NativeMethodInfoPtr_set_OnFinishCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677966);
			SpellExecutionContext.NativeMethodInfoPtr_get_ShouldRecordSpellNum_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677967);
			SpellExecutionContext.NativeMethodInfoPtr_get_RotationsCoroutineHandles_Public_get_Dictionary_2_String_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, 100677968);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x0019E6E0 File Offset: 0x0019C8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191836, RefRangeEnd = 191837, XrefRangeStart = 191829, XrefRangeEnd = 191836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellExecutionContext(SpecialGuestsController guestsController, SpecialGuest characterData, Il2CppReferenceArray<AStarInputGeneratorComponent> guestCharacterInstances, Il2CppReferenceArray<LanguageBase> spellLanguageData, Action onFinishCallback, bool shouldRecordSpellNum) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestsController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestCharacterInstances);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spellLanguageData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldRecordSpellNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuestsController_SpecialGuest_Il2CppReferenceArray_1_AStarInputGeneratorComponent_Il2CppReferenceArray_1_LanguageBase_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x0019E784 File Offset: 0x0019C984
		public unsafe Nullable<Vector3> GuestPosition
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 191845, RefRangeEnd = 191887, XrefRangeStart = 191837, XrefRangeEnd = 191845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_GuestPosition_Public_get_Nullable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<Vector3>(pointer);
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x0019E7BC File Offset: 0x0019C9BC
		public unsafe bool IsSitInLeftSeat
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 191888, RefRangeEnd = 191893, XrefRangeStart = 191887, XrefRangeEnd = 191888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_IsSitInLeftSeat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x0019E7F8 File Offset: 0x0019C9F8
		public unsafe SpecialGuestsController GuestsController
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_GuestsController_Public_get_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr3) : null;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060049AE RID: 18862 RVA: 0x0019E838 File Offset: 0x0019CA38
		public unsafe SpecialGuest CharacterData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_CharacterData_Public_get_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x0019E878 File Offset: 0x0019CA78
		public unsafe Il2CppReferenceArray<AStarInputGeneratorComponent> GuestCharacterInstances
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_GuestCharacterInstances_Public_get_Il2CppReferenceArray_1_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AStarInputGeneratorComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x0019E8B8 File Offset: 0x0019CAB8
		public unsafe Il2CppReferenceArray<LanguageBase> SpellLanguageData
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_SpellLanguageData_Public_get_Il2CppReferenceArray_1_LanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageBase>>(intPtr3) : null;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060049B1 RID: 18865 RVA: 0x0019E8F8 File Offset: 0x0019CAF8
		// (set) Token: 0x060049B2 RID: 18866 RVA: 0x0019E938 File Offset: 0x0019CB38
		public unsafe Action OnFinishCallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_OnFinishCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_set_OnFinishCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x0019E97C File Offset: 0x0019CB7C
		public unsafe bool ShouldRecordSpellNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_ShouldRecordSpellNum_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x0019E9B8 File Offset: 0x0019CBB8
		public unsafe Dictionary<string, Coroutine> RotationsCoroutineHandles
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 191900, RefRangeEnd = 191903, XrefRangeStart = 191893, XrefRangeEnd = 191900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.NativeMethodInfoPtr_get_RotationsCoroutineHandles_Public_get_Dictionary_2_String_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr3) : null;
			}
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x00025CA9 File Offset: 0x00023EA9
		public SpellExecutionContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x0019E9F8 File Offset: 0x0019CBF8
		// (set) Token: 0x060049B7 RID: 18871 RVA: 0x00025CB2 File Offset: 0x00023EB2
		public unsafe Dictionary<string, Coroutine> m_RotationsCoroutineHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr_m_RotationsCoroutineHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr_m_RotationsCoroutineHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x0019EA28 File Offset: 0x0019CC28
		// (set) Token: 0x060049B9 RID: 18873 RVA: 0x00025CD1 File Offset: 0x00023ED1
		public unsafe SpecialGuestsController _GuestsController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__GuestsController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__GuestsController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x0019EA58 File Offset: 0x0019CC58
		// (set) Token: 0x060049BB RID: 18875 RVA: 0x00025CF0 File Offset: 0x00023EF0
		public unsafe SpecialGuest _CharacterData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__CharacterData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__CharacterData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060049BC RID: 18876 RVA: 0x0019EA88 File Offset: 0x0019CC88
		// (set) Token: 0x060049BD RID: 18877 RVA: 0x00025D0F File Offset: 0x00023F0F
		public unsafe Il2CppReferenceArray<AStarInputGeneratorComponent> _GuestCharacterInstances_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__GuestCharacterInstances_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AStarInputGeneratorComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__GuestCharacterInstances_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x0019EAB8 File Offset: 0x0019CCB8
		// (set) Token: 0x060049BF RID: 18879 RVA: 0x00025D2E File Offset: 0x00023F2E
		public unsafe Il2CppReferenceArray<LanguageBase> _SpellLanguageData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__SpellLanguageData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__SpellLanguageData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x0019EAE8 File Offset: 0x0019CCE8
		// (set) Token: 0x060049C1 RID: 18881 RVA: 0x00025D4D File Offset: 0x00023F4D
		public unsafe Action _OnFinishCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__OnFinishCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__OnFinishCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x0019EB18 File Offset: 0x0019CD18
		// (set) Token: 0x060049C3 RID: 18883 RVA: 0x00025D6C File Offset: 0x00023F6C
		public unsafe bool _ShouldRecordSpellNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__ShouldRecordSpellNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellExecutionContext.NativeFieldInfoPtr__ShouldRecordSpellNum_k__BackingField)) = value;
			}
		}

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeFieldInfoPtr_m_RotationsCoroutineHandles;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeFieldInfoPtr__GuestsController_k__BackingField;

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeFieldInfoPtr__CharacterData_k__BackingField;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeFieldInfoPtr__GuestCharacterInstances_k__BackingField;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeFieldInfoPtr__SpellLanguageData_k__BackingField;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeFieldInfoPtr__OnFinishCallback_k__BackingField;

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeFieldInfoPtr__ShouldRecordSpellNum_k__BackingField;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpecialGuestsController_SpecialGuest_Il2CppReferenceArray_1_AStarInputGeneratorComponent_Il2CppReferenceArray_1_LanguageBase_Action_Boolean_0;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestPosition_Public_get_Nullable_1_Vector3_0;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSitInLeftSeat_Public_get_Boolean_0;

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestsController_Public_get_SpecialGuestsController_0;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterData_Public_get_SpecialGuest_0;

		// Token: 0x040032B1 RID: 12977
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestCharacterInstances_Public_get_Il2CppReferenceArray_1_AStarInputGeneratorComponent_0;

		// Token: 0x040032B2 RID: 12978
		private static readonly IntPtr NativeMethodInfoPtr_get_SpellLanguageData_Public_get_Il2CppReferenceArray_1_LanguageBase_0;

		// Token: 0x040032B3 RID: 12979
		private static readonly IntPtr NativeMethodInfoPtr_get_OnFinishCallback_Public_get_Action_0;

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr_set_OnFinishCallback_Public_set_Void_Action_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldRecordSpellNum_Public_get_Boolean_0;

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationsCoroutineHandles_Public_get_Dictionary_2_String_Coroutine_0;

		// Token: 0x02000ACE RID: 2766
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellExecutionContext+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE79 RID: 52857 RVA: 0x0032DCA0 File Offset: 0x0032BEA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellExecutionContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr);
				SpellExecutionContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr, "<>9");
				SpellExecutionContext.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr, "<>9__3_0");
				SpellExecutionContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr, 100677970);
				SpellExecutionContext.__c.NativeMethodInfoPtr__get_GuestPosition_b__3_0_Internal_Boolean_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr, 100677971);
			}

			// Token: 0x0600CE7A RID: 52858 RVA: 0x0032DD1C File Offset: 0x0032BF1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellExecutionContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE7B RID: 52859 RVA: 0x0032DD58 File Offset: 0x0032BF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191825, XrefRangeEnd = 191829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_GuestPosition_b__3_0(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellExecutionContext.__c.NativeMethodInfoPtr__get_GuestPosition_b__3_0_Internal_Boolean_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE7C RID: 52860 RVA: 0x0006E844 File Offset: 0x0006CA44
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700431A RID: 17178
			// (get) Token: 0x0600CE7D RID: 52861 RVA: 0x0032DDA8 File Offset: 0x0032BFA8
			// (set) Token: 0x0600CE7E RID: 52862 RVA: 0x0006E84D File Offset: 0x0006CA4D
			public unsafe static SpellExecutionContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellExecutionContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellExecutionContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431B RID: 17179
			// (get) Token: 0x0600CE7F RID: 52863 RVA: 0x0032DDD0 File Offset: 0x0032BFD0
			// (set) Token: 0x0600CE80 RID: 52864 RVA: 0x0006E85F File Offset: 0x0006CA5F
			public unsafe static Func<AStarInputGeneratorComponent, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellExecutionContext.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AStarInputGeneratorComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellExecutionContext.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084DF RID: 34015
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084E0 RID: 34016
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040084E1 RID: 34017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084E2 RID: 34018
			private static readonly IntPtr NativeMethodInfoPtr__get_GuestPosition_b__3_0_Internal_Boolean_AStarInputGeneratorComponent_0;
		}
	}
}
