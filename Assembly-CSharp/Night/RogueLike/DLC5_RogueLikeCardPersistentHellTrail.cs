using System;
using DayScene.UI.RogueLike;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;

namespace Night.RogueLike
{
	// Token: 0x02000069 RID: 105
	public class DLC5_RogueLikeCardPersistentHellTrail : RogueLikeCardPersistent
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x000C5594 File Offset: 0x000C3794
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentHellTrail()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentHellTrail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_NeedCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_NeedCombo");
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageLevelLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_BeverageLevelLine");
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageNumOverLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_BeverageNumOverLine");
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageNumBelowLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_BeverageNumBelowLine");
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientLevelLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_IngredientLevelLine");
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientNumOverLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_IngredientNumOverLine");
			DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientNumBelowLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "m_IngredientNumBelowLine");
			DLC5_RogueLikeCardPersistentHellTrail.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, 100665263);
			DLC5_RogueLikeCardPersistentHellTrail.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, 100665264);
			DLC5_RogueLikeCardPersistentHellTrail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, 100665265);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000C568C File Offset: 0x000C388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41891, XrefRangeEnd = 41896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentHellTrail.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000C5714 File Offset: 0x000C3914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41896, XrefRangeEnd = 41926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentHellTrail.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000C5794 File Offset: 0x000C3994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentHellTrail() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000084D0 File Offset: 0x000066D0
		public DLC5_RogueLikeCardPersistentHellTrail(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000C57D0 File Offset: 0x000C39D0
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x000084D9 File Offset: 0x000066D9
		public unsafe int m_NeedCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_NeedCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_NeedCombo)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000C57F8 File Offset: 0x000C39F8
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x000084F4 File Offset: 0x000066F4
		public unsafe int m_BeverageLevelLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageLevelLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageLevelLine)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x000C5820 File Offset: 0x000C3A20
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0000850F File Offset: 0x0000670F
		public unsafe int m_BeverageNumOverLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageNumOverLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageNumOverLine)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000C5848 File Offset: 0x000C3A48
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0000852A File Offset: 0x0000672A
		public unsafe int m_BeverageNumBelowLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageNumBelowLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_BeverageNumBelowLine)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000C5870 File Offset: 0x000C3A70
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00008545 File Offset: 0x00006745
		public unsafe int m_IngredientLevelLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientLevelLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientLevelLine)) = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000C5898 File Offset: 0x000C3A98
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00008560 File Offset: 0x00006760
		public unsafe int m_IngredientNumOverLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientNumOverLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientNumOverLine)) = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000C58C0 File Offset: 0x000C3AC0
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0000857B File Offset: 0x0000677B
		public unsafe int m_IngredientNumBelowLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientNumBelowLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.NativeFieldInfoPtr_m_IngredientNumBelowLine)) = value;
			}
		}

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedCombo;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageLevelLine;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageNumOverLine;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageNumBelowLine;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientLevelLine;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientNumOverLine;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientNumBelowLine;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200052E RID: 1326
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentHellTrail+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x060085C8 RID: 34248 RVA: 0x002561DC File Offset: 0x002543DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_recordedCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "recordedCombo");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_interruptThisBuffCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "interruptThisBuffCallback");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "<>9__8");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "<>9__9");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "<>9__10");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, "<>9__11");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665266);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665267);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665268);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665269);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665270);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__9_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665271);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__10_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665272);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__11_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr, 100665273);
			}

			// Token: 0x060085C9 RID: 34249 RVA: 0x0025635C File Offset: 0x0025455C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085CA RID: 34250 RVA: 0x00256398 File Offset: 0x00254598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41599, XrefRangeEnd = 41604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060085CB RID: 34251 RVA: 0x002563E0 File Offset: 0x002545E0
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int currentCombo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentCombo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085CC RID: 34252 RVA: 0x00256420 File Offset: 0x00254620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41604, XrefRangeEnd = 41825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085CD RID: 34253 RVA: 0x00256454 File Offset: 0x00254654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41825, XrefRangeEnd = 41826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CardEffectBeforeWorking_b__8(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085CE RID: 34254 RVA: 0x002564A8 File Offset: 0x002546A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41826, XrefRangeEnd = 41827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CardEffectBeforeWorking_b__9(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__9_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085CF RID: 34255 RVA: 0x002564FC File Offset: 0x002546FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41827, XrefRangeEnd = 41828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CardEffectBeforeWorking_b__10(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__10_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085D0 RID: 34256 RVA: 0x00256550 File Offset: 0x00254750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41828, XrefRangeEnd = 41829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CardEffectBeforeWorking_b__11(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__11_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085D1 RID: 34257 RVA: 0x00048000 File Offset: 0x00046200
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CE7 RID: 11495
			// (get) Token: 0x060085D2 RID: 34258 RVA: 0x002565A4 File Offset: 0x002547A4
			// (set) Token: 0x060085D3 RID: 34259 RVA: 0x00048009 File Offset: 0x00046209
			public unsafe DLC5_RogueLikeCardPersistentHellTrail __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentHellTrail>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE8 RID: 11496
			// (get) Token: 0x060085D4 RID: 34260 RVA: 0x002565D4 File Offset: 0x002547D4
			// (set) Token: 0x060085D5 RID: 34261 RVA: 0x00048028 File Offset: 0x00046228
			public unsafe int recordedCombo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_recordedCombo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_recordedCombo)) = value;
				}
			}

			// Token: 0x17002CE9 RID: 11497
			// (get) Token: 0x060085D6 RID: 34262 RVA: 0x002565FC File Offset: 0x002547FC
			// (set) Token: 0x060085D7 RID: 34263 RVA: 0x00048043 File Offset: 0x00046243
			public unsafe Action interruptThisBuffCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_interruptThisBuffCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_interruptThisBuffCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEA RID: 11498
			// (get) Token: 0x060085D8 RID: 34264 RVA: 0x0025662C File Offset: 0x0025482C
			// (set) Token: 0x060085D9 RID: 34265 RVA: 0x00048062 File Offset: 0x00046262
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEB RID: 11499
			// (get) Token: 0x060085DA RID: 34266 RVA: 0x0025665C File Offset: 0x0025485C
			// (set) Token: 0x060085DB RID: 34267 RVA: 0x00048081 File Offset: 0x00046281
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEC RID: 11500
			// (get) Token: 0x060085DC RID: 34268 RVA: 0x0025668C File Offset: 0x0025488C
			// (set) Token: 0x060085DD RID: 34269 RVA: 0x000480A0 File Offset: 0x000462A0
			public unsafe Func<KeyValuePair<int, int>, bool> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CED RID: 11501
			// (get) Token: 0x060085DE RID: 34270 RVA: 0x002566BC File Offset: 0x002548BC
			// (set) Token: 0x060085DF RID: 34271 RVA: 0x000480BF File Offset: 0x000462BF
			public unsafe Func<KeyValuePair<int, int>, bool> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEE RID: 11502
			// (get) Token: 0x060085E0 RID: 34272 RVA: 0x002566EC File Offset: 0x002548EC
			// (set) Token: 0x060085E1 RID: 34273 RVA: 0x000480DE File Offset: 0x000462DE
			public unsafe Func<KeyValuePair<int, int>, bool> __9__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEF RID: 11503
			// (get) Token: 0x060085E2 RID: 34274 RVA: 0x0025671C File Offset: 0x0025491C
			// (set) Token: 0x060085E3 RID: 34275 RVA: 0x000480FD File Offset: 0x000462FD
			public unsafe Func<KeyValuePair<int, int>, bool> __9__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0.NativeFieldInfoPtr___9__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057E1 RID: 22497
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040057E2 RID: 22498
			private static readonly IntPtr NativeFieldInfoPtr_recordedCombo;

			// Token: 0x040057E3 RID: 22499
			private static readonly IntPtr NativeFieldInfoPtr_interruptThisBuffCallback;

			// Token: 0x040057E4 RID: 22500
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040057E5 RID: 22501
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040057E6 RID: 22502
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x040057E7 RID: 22503
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x040057E8 RID: 22504
			private static readonly IntPtr NativeFieldInfoPtr___9__10;

			// Token: 0x040057E9 RID: 22505
			private static readonly IntPtr NativeFieldInfoPtr___9__11;

			// Token: 0x040057EA RID: 22506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057EB RID: 22507
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0;

			// Token: 0x040057EC RID: 22508
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;

			// Token: 0x040057ED RID: 22509
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040057EE RID: 22510
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040057EF RID: 22511
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__9_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040057F0 RID: 22512
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__10_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040057F1 RID: 22513
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__11_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x0200052F RID: 1327
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentHellTrail+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Object
		{
			// Token: 0x060085E4 RID: 34276 RVA: 0x0025674C File Offset: 0x0025494C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeFieldInfoPtr_productList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr, "productList");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr, 100665274);
				DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeMethodInfoPtr__CardEffectBeforeWorking_b__12_Internal_Void_Dictionary_2_CardType_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr, 100665275);
			}

			// Token: 0x060085E5 RID: 34277 RVA: 0x002567C8 File Offset: 0x002549C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085E6 RID: 34278 RVA: 0x00256804 File Offset: 0x00254A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41829, XrefRangeEnd = 41889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CardEffectBeforeWorking_b__12(Dictionary<RogueLikeCardBase.CardType, List<Product>> finalDic)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(finalDic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeMethodInfoPtr__CardEffectBeforeWorking_b__12_Internal_Void_Dictionary_2_CardType_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085E7 RID: 34279 RVA: 0x0004811C File Offset: 0x0004631C
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CF0 RID: 11504
			// (get) Token: 0x060085E8 RID: 34280 RVA: 0x00256848 File Offset: 0x00254A48
			// (set) Token: 0x060085E9 RID: 34281 RVA: 0x00048125 File Offset: 0x00046325
			public unsafe List<Product> productList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeFieldInfoPtr_productList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeFieldInfoPtr_productList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF1 RID: 11505
			// (get) Token: 0x060085EA RID: 34282 RVA: 0x00256878 File Offset: 0x00254A78
			// (set) Token: 0x060085EB RID: 34283 RVA: 0x00048144 File Offset: 0x00046344
			public unsafe DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentHellTrail.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057F2 RID: 22514
			private static readonly IntPtr NativeFieldInfoPtr_productList;

			// Token: 0x040057F3 RID: 22515
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x040057F4 RID: 22516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057F5 RID: 22517
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__12_Internal_Void_Dictionary_2_CardType_List_1_Product_0;
		}

		// Token: 0x02000530 RID: 1328
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentHellTrail+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060085EC RID: 34284 RVA: 0x002568A8 File Offset: 0x00254AA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, "<>9__8_3");
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, "<>9__8_4");
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, "<>9__8_5");
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, "<>9__8_6");
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, "<>9__8_7");
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, 100665277);
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_3_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, 100665278);
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_4_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, 100665279);
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, 100665280);
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_6_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, 100665281);
				DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_7_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr, 100665282);
			}

			// Token: 0x060085ED RID: 34285 RVA: 0x002569C4 File Offset: 0x00254BC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentHellTrail.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085EE RID: 34286 RVA: 0x00256A00 File Offset: 0x00254C00
			[CallerCount(0)]
			public unsafe int _CardEffectBeforeWorking_b__8_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_3_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085EF RID: 34287 RVA: 0x00256A4C File Offset: 0x00254C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41889, XrefRangeEnd = 41890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CardEffectBeforeWorking_b__8_4(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_4_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085F0 RID: 34288 RVA: 0x00256A98 File Offset: 0x00254C98
			[CallerCount(0)]
			public unsafe bool _CardEffectBeforeWorking_b__8_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085F1 RID: 34289 RVA: 0x00256AE4 File Offset: 0x00254CE4
			[CallerCount(0)]
			public unsafe int _CardEffectBeforeWorking_b__8_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_6_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085F2 RID: 34290 RVA: 0x00256B30 File Offset: 0x00254D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41890, XrefRangeEnd = 41891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CardEffectBeforeWorking_b__8_7(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_7_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060085F3 RID: 34291 RVA: 0x00048163 File Offset: 0x00046363
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CF2 RID: 11506
			// (get) Token: 0x060085F4 RID: 34292 RVA: 0x00256B7C File Offset: 0x00254D7C
			// (set) Token: 0x060085F5 RID: 34293 RVA: 0x0004816C File Offset: 0x0004636C
			public unsafe static DLC5_RogueLikeCardPersistentHellTrail.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentHellTrail.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF3 RID: 11507
			// (get) Token: 0x060085F6 RID: 34294 RVA: 0x00256BA4 File Offset: 0x00254DA4
			// (set) Token: 0x060085F7 RID: 34295 RVA: 0x0004817E File Offset: 0x0004637E
			public unsafe static Func<int, int> __9__8_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF4 RID: 11508
			// (get) Token: 0x060085F8 RID: 34296 RVA: 0x00256BCC File Offset: 0x00254DCC
			// (set) Token: 0x060085F9 RID: 34297 RVA: 0x00048190 File Offset: 0x00046390
			public unsafe static Func<int, int> __9__8_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF5 RID: 11509
			// (get) Token: 0x060085FA RID: 34298 RVA: 0x00256BF4 File Offset: 0x00254DF4
			// (set) Token: 0x060085FB RID: 34299 RVA: 0x000481A2 File Offset: 0x000463A2
			public unsafe static Func<int, bool> __9__8_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF6 RID: 11510
			// (get) Token: 0x060085FC RID: 34300 RVA: 0x00256C1C File Offset: 0x00254E1C
			// (set) Token: 0x060085FD RID: 34301 RVA: 0x000481B4 File Offset: 0x000463B4
			public unsafe static Func<int, int> __9__8_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF7 RID: 11511
			// (get) Token: 0x060085FE RID: 34302 RVA: 0x00256C44 File Offset: 0x00254E44
			// (set) Token: 0x060085FF RID: 34303 RVA: 0x000481C6 File Offset: 0x000463C6
			public unsafe static Func<int, int> __9__8_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentHellTrail.__c.NativeFieldInfoPtr___9__8_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057F6 RID: 22518
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040057F7 RID: 22519
			private static readonly IntPtr NativeFieldInfoPtr___9__8_3;

			// Token: 0x040057F8 RID: 22520
			private static readonly IntPtr NativeFieldInfoPtr___9__8_4;

			// Token: 0x040057F9 RID: 22521
			private static readonly IntPtr NativeFieldInfoPtr___9__8_5;

			// Token: 0x040057FA RID: 22522
			private static readonly IntPtr NativeFieldInfoPtr___9__8_6;

			// Token: 0x040057FB RID: 22523
			private static readonly IntPtr NativeFieldInfoPtr___9__8_7;

			// Token: 0x040057FC RID: 22524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057FD RID: 22525
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_3_Internal_Int32_Int32_0;

			// Token: 0x040057FE RID: 22526
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_4_Internal_Int32_Int32_0;

			// Token: 0x040057FF RID: 22527
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_5_Internal_Boolean_Int32_0;

			// Token: 0x04005800 RID: 22528
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_6_Internal_Int32_Int32_0;

			// Token: 0x04005801 RID: 22529
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__8_7_Internal_Int32_Int32_0;
		}
	}
}
