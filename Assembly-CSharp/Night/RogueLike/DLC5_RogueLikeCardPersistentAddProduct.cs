using System;
using DayScene.UI.RogueLike;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace Night.RogueLike
{
	// Token: 0x0200005E RID: 94
	public class DLC5_RogueLikeCardPersistentAddProduct : RogueLikeCardPersistent
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x000C353C File Offset: 0x000C173C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentAddProduct()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentAddProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665178);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665179);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665180);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_String_String_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665181);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665182);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665183);
			DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_Method_Internal_Static_Void_String_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, 100665184);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000C35F8 File Offset: 0x000C17F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40903, XrefRangeEnd = 40906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000C3674 File Offset: 0x000C1874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40906, XrefRangeEnd = 41128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000C36D4 File Offset: 0x000C18D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41128, XrefRangeEnd = 41173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000C375C File Offset: 0x000C195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41173, XrefRangeEnd = 41176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_String_String_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000C37C4 File Offset: 0x000C19C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41176, XrefRangeEnd = 41191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000C3824 File Offset: 0x000C1A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentAddProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000C3860 File Offset: 0x000C1A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41373, RefRangeEnd = 41375, XrefRangeStart = 41191, XrefRangeEnd = 41373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_String_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref___c__DisplayClass1_0_0(string mapLabel, out Il2CppStructArray<int> cooker, out Il2CppStructArray<int> decoration, out Il2CppStructArray<int> clothes, out Il2CppStructArray<int> partner, ref DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0 A_5)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_5);
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.NativeMethodInfoPtr_Method_Internal_Static_Void_String_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref___c__DisplayClass1_0_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			cooker = ((intPtr7 == 0) ? null : new Il2CppStructArray<int>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			decoration = ((intPtr8 == 0) ? null : new Il2CppStructArray<int>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			clothes = ((intPtr9 == 0) ? null : new Il2CppStructArray<int>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			partner = ((intPtr10 == 0) ? null : new Il2CppStructArray<int>(intPtr10));
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00008344 File Offset: 0x00006544
		public DLC5_RogueLikeCardPersistentAddProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_String_String_RogueLikeRunTimeData_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_String_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref___c__DisplayClass1_0_0;

		// Token: 0x02000527 RID: 1319
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentAddProduct+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : ValueType
		{
			// Token: 0x06008564 RID: 34148 RVA: 0x00254FBC File Offset: 0x002531BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0>.NativeClassPtr, "rogueLikeRunTimeData");
				DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0.NativeFieldInfoPtr_obtainedPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0>.NativeClassPtr, "obtainedPartners");
			}

			// Token: 0x06008565 RID: 34149 RVA: 0x00047D26 File Offset: 0x00045F26
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008566 RID: 34150 RVA: 0x00047D2F File Offset: 0x00045F2F
			public __c__DisplayClass1_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0>.NativeClassPtr))
			{
			}

			// Token: 0x17002CCA RID: 11466
			// (get) Token: 0x06008567 RID: 34151 RVA: 0x00255010 File Offset: 0x00253210
			// (set) Token: 0x06008568 RID: 34152 RVA: 0x00047D41 File Offset: 0x00045F41
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CCB RID: 11467
			// (get) Token: 0x06008569 RID: 34153 RVA: 0x00255040 File Offset: 0x00253240
			// (set) Token: 0x0600856A RID: 34154 RVA: 0x00047D60 File Offset: 0x00045F60
			public unsafe Il2CppStructArray<int> obtainedPartners
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0.NativeFieldInfoPtr_obtainedPartners);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddProduct.__c__DisplayClass1_0.NativeFieldInfoPtr_obtainedPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057A9 RID: 22441
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x040057AA RID: 22442
			private static readonly IntPtr NativeFieldInfoPtr_obtainedPartners;
		}

		// Token: 0x02000528 RID: 1320
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentAddProduct+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600856B RID: 34155 RVA: 0x00255070 File Offset: 0x00253270
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_0");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_1");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_3");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_4");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_5");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_6");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_7");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_8");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_9");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_10");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_11");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_12");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_13");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_14");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, "<>9__1_15");
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665186);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665187);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_1_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665188);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_3_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665189);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_4_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665190);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_5_Internal_Int32_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665191);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_6_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665192);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_7_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665193);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_8_Internal_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665194);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_9_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665195);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_10_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665196);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_11_Internal_Int32_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665197);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_12_Internal_CookerSeries_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665198);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_13_Internal_ValueTuple_2_CookerSeries_List_1_Int32_IGrouping_2_CookerSeries_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665199);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_14_Internal_CookerSeries_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665200);
				DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_15_Internal_ValueTuple_2_CookerSeries_List_1_Int32_IGrouping_2_CookerSeries_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr, 100665201);
			}

			// Token: 0x0600856C RID: 34156 RVA: 0x0025531C File Offset: 0x0025351C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddProduct.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600856D RID: 34157 RVA: 0x00255358 File Offset: 0x00253558
			[CallerCount(0)]
			public unsafe bool _AfterInitialize_b__1_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600856E RID: 34158 RVA: 0x002553AC File Offset: 0x002535AC
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_1_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600856F RID: 34159 RVA: 0x00255400 File Offset: 0x00253600
			[CallerCount(0)]
			public unsafe bool _AfterInitialize_b__1_3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_3_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008570 RID: 34160 RVA: 0x00255454 File Offset: 0x00253654
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_4(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_4_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008571 RID: 34161 RVA: 0x002554A8 File Offset: 0x002536A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40882, XrefRangeEnd = 40883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AfterInitialize_b__1_5(KeyValuePair<Cooker, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_5_Internal_Int32_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008572 RID: 34162 RVA: 0x002554FC File Offset: 0x002536FC
			[CallerCount(0)]
			public unsafe bool _AfterInitialize_b__1_6(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_6_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008573 RID: 34163 RVA: 0x00255550 File Offset: 0x00253750
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_7(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_7_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008574 RID: 34164 RVA: 0x002555A4 File Offset: 0x002537A4
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_8(Decoration x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_8_Internal_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008575 RID: 34165 RVA: 0x002555F4 File Offset: 0x002537F4
			[CallerCount(0)]
			public unsafe bool _AfterInitialize_b__1_9(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_9_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008576 RID: 34166 RVA: 0x00255648 File Offset: 0x00253848
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_10(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_10_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008577 RID: 34167 RVA: 0x0025569C File Offset: 0x0025389C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40883, XrefRangeEnd = 40884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AfterInitialize_b__1_11(KeyValuePair<Item, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_11_Internal_Int32_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008578 RID: 34168 RVA: 0x002556F0 File Offset: 0x002538F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40884, XrefRangeEnd = 40885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cooker.CookerSeries _AfterInitialize_b__1_12(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_12_Internal_CookerSeries_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008579 RID: 34169 RVA: 0x0025573C File Offset: 0x0025393C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40885, XrefRangeEnd = 40894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Cooker.CookerSeries, List<int>> _AfterInitialize_b__1_13(IGrouping<Cooker.CookerSeries, int> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_13_Internal_ValueTuple_2_CookerSeries_List_1_Int32_IGrouping_2_CookerSeries_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Cooker.CookerSeries, List<int>>(pointer);
			}

			// Token: 0x0600857A RID: 34170 RVA: 0x00255784 File Offset: 0x00253984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cooker.CookerSeries _AfterInitialize_b__1_14(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_14_Internal_CookerSeries_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600857B RID: 34171 RVA: 0x002557D0 File Offset: 0x002539D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40894, XrefRangeEnd = 40903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Cooker.CookerSeries, List<int>> _AfterInitialize_b__1_15(IGrouping<Cooker.CookerSeries, int> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_15_Internal_ValueTuple_2_CookerSeries_List_1_Int32_IGrouping_2_CookerSeries_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Cooker.CookerSeries, List<int>>(pointer);
			}

			// Token: 0x0600857C RID: 34172 RVA: 0x00047D7F File Offset: 0x00045F7F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CCC RID: 11468
			// (get) Token: 0x0600857D RID: 34173 RVA: 0x00255818 File Offset: 0x00253A18
			// (set) Token: 0x0600857E RID: 34174 RVA: 0x00047D88 File Offset: 0x00045F88
			public unsafe static DLC5_RogueLikeCardPersistentAddProduct.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentAddProduct.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CCD RID: 11469
			// (get) Token: 0x0600857F RID: 34175 RVA: 0x00255840 File Offset: 0x00253A40
			// (set) Token: 0x06008580 RID: 34176 RVA: 0x00047D9A File Offset: 0x00045F9A
			public unsafe static Func<Product, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CCE RID: 11470
			// (get) Token: 0x06008581 RID: 34177 RVA: 0x00255868 File Offset: 0x00253A68
			// (set) Token: 0x06008582 RID: 34178 RVA: 0x00047DAC File Offset: 0x00045FAC
			public unsafe static Func<Product, int> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CCF RID: 11471
			// (get) Token: 0x06008583 RID: 34179 RVA: 0x00255890 File Offset: 0x00253A90
			// (set) Token: 0x06008584 RID: 34180 RVA: 0x00047DBE File Offset: 0x00045FBE
			public unsafe static Func<Product, bool> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD0 RID: 11472
			// (get) Token: 0x06008585 RID: 34181 RVA: 0x002558B8 File Offset: 0x00253AB8
			// (set) Token: 0x06008586 RID: 34182 RVA: 0x00047DD0 File Offset: 0x00045FD0
			public unsafe static Func<Product, int> __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD1 RID: 11473
			// (get) Token: 0x06008587 RID: 34183 RVA: 0x002558E0 File Offset: 0x00253AE0
			// (set) Token: 0x06008588 RID: 34184 RVA: 0x00047DE2 File Offset: 0x00045FE2
			public unsafe static Func<KeyValuePair<Cooker, int>, int> __9__1_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD2 RID: 11474
			// (get) Token: 0x06008589 RID: 34185 RVA: 0x00255908 File Offset: 0x00253B08
			// (set) Token: 0x0600858A RID: 34186 RVA: 0x00047DF4 File Offset: 0x00045FF4
			public unsafe static Func<Product, bool> __9__1_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD3 RID: 11475
			// (get) Token: 0x0600858B RID: 34187 RVA: 0x00255930 File Offset: 0x00253B30
			// (set) Token: 0x0600858C RID: 34188 RVA: 0x00047E06 File Offset: 0x00046006
			public unsafe static Func<Product, int> __9__1_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD4 RID: 11476
			// (get) Token: 0x0600858D RID: 34189 RVA: 0x00255958 File Offset: 0x00253B58
			// (set) Token: 0x0600858E RID: 34190 RVA: 0x00047E18 File Offset: 0x00046018
			public unsafe static Func<Decoration, int> __9__1_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decoration, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD5 RID: 11477
			// (get) Token: 0x0600858F RID: 34191 RVA: 0x00255980 File Offset: 0x00253B80
			// (set) Token: 0x06008590 RID: 34192 RVA: 0x00047E2A File Offset: 0x0004602A
			public unsafe static Func<Product, bool> __9__1_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD6 RID: 11478
			// (get) Token: 0x06008591 RID: 34193 RVA: 0x002559A8 File Offset: 0x00253BA8
			// (set) Token: 0x06008592 RID: 34194 RVA: 0x00047E3C File Offset: 0x0004603C
			public unsafe static Func<Product, int> __9__1_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD7 RID: 11479
			// (get) Token: 0x06008593 RID: 34195 RVA: 0x002559D0 File Offset: 0x00253BD0
			// (set) Token: 0x06008594 RID: 34196 RVA: 0x00047E4E File Offset: 0x0004604E
			public unsafe static Func<KeyValuePair<Item, int>, int> __9__1_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD8 RID: 11480
			// (get) Token: 0x06008595 RID: 34197 RVA: 0x002559F8 File Offset: 0x00253BF8
			// (set) Token: 0x06008596 RID: 34198 RVA: 0x00047E60 File Offset: 0x00046060
			public unsafe static Func<int, Cooker.CookerSeries> __9__1_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Cooker.CookerSeries>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CD9 RID: 11481
			// (get) Token: 0x06008597 RID: 34199 RVA: 0x00255A20 File Offset: 0x00253C20
			// (set) Token: 0x06008598 RID: 34200 RVA: 0x00047E72 File Offset: 0x00046072
			public unsafe static Func<IGrouping<Cooker.CookerSeries, int>, ValueTuple<Cooker.CookerSeries, List<int>>> __9__1_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Cooker.CookerSeries, int>, ValueTuple<Cooker.CookerSeries, List<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDA RID: 11482
			// (get) Token: 0x06008599 RID: 34201 RVA: 0x00255A48 File Offset: 0x00253C48
			// (set) Token: 0x0600859A RID: 34202 RVA: 0x00047E84 File Offset: 0x00046084
			public unsafe static Func<int, Cooker.CookerSeries> __9__1_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Cooker.CookerSeries>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDB RID: 11483
			// (get) Token: 0x0600859B RID: 34203 RVA: 0x00255A70 File Offset: 0x00253C70
			// (set) Token: 0x0600859C RID: 34204 RVA: 0x00047E96 File Offset: 0x00046096
			public unsafe static Func<IGrouping<Cooker.CookerSeries, int>, ValueTuple<Cooker.CookerSeries, List<int>>> __9__1_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Cooker.CookerSeries, int>, ValueTuple<Cooker.CookerSeries, List<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentAddProduct.__c.NativeFieldInfoPtr___9__1_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057AB RID: 22443
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040057AC RID: 22444
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040057AD RID: 22445
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040057AE RID: 22446
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x040057AF RID: 22447
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x040057B0 RID: 22448
			private static readonly IntPtr NativeFieldInfoPtr___9__1_5;

			// Token: 0x040057B1 RID: 22449
			private static readonly IntPtr NativeFieldInfoPtr___9__1_6;

			// Token: 0x040057B2 RID: 22450
			private static readonly IntPtr NativeFieldInfoPtr___9__1_7;

			// Token: 0x040057B3 RID: 22451
			private static readonly IntPtr NativeFieldInfoPtr___9__1_8;

			// Token: 0x040057B4 RID: 22452
			private static readonly IntPtr NativeFieldInfoPtr___9__1_9;

			// Token: 0x040057B5 RID: 22453
			private static readonly IntPtr NativeFieldInfoPtr___9__1_10;

			// Token: 0x040057B6 RID: 22454
			private static readonly IntPtr NativeFieldInfoPtr___9__1_11;

			// Token: 0x040057B7 RID: 22455
			private static readonly IntPtr NativeFieldInfoPtr___9__1_12;

			// Token: 0x040057B8 RID: 22456
			private static readonly IntPtr NativeFieldInfoPtr___9__1_13;

			// Token: 0x040057B9 RID: 22457
			private static readonly IntPtr NativeFieldInfoPtr___9__1_14;

			// Token: 0x040057BA RID: 22458
			private static readonly IntPtr NativeFieldInfoPtr___9__1_15;

			// Token: 0x040057BB RID: 22459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057BC RID: 22460
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_0_Internal_Boolean_Product_0;

			// Token: 0x040057BD RID: 22461
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_1_Internal_Int32_Product_0;

			// Token: 0x040057BE RID: 22462
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_3_Internal_Boolean_Product_0;

			// Token: 0x040057BF RID: 22463
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_4_Internal_Int32_Product_0;

			// Token: 0x040057C0 RID: 22464
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_5_Internal_Int32_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x040057C1 RID: 22465
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_6_Internal_Boolean_Product_0;

			// Token: 0x040057C2 RID: 22466
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_7_Internal_Int32_Product_0;

			// Token: 0x040057C3 RID: 22467
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_8_Internal_Int32_Decoration_0;

			// Token: 0x040057C4 RID: 22468
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_9_Internal_Boolean_Product_0;

			// Token: 0x040057C5 RID: 22469
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_10_Internal_Int32_Product_0;

			// Token: 0x040057C6 RID: 22470
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_11_Internal_Int32_KeyValuePair_2_Item_Int32_0;

			// Token: 0x040057C7 RID: 22471
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_12_Internal_CookerSeries_Int32_0;

			// Token: 0x040057C8 RID: 22472
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_13_Internal_ValueTuple_2_CookerSeries_List_1_Int32_IGrouping_2_CookerSeries_Int32_0;

			// Token: 0x040057C9 RID: 22473
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_14_Internal_CookerSeries_Int32_0;

			// Token: 0x040057CA RID: 22474
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_15_Internal_ValueTuple_2_CookerSeries_List_1_Int32_IGrouping_2_CookerSeries_Int32_0;
		}
	}
}
