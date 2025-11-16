using System;
using DayScene.UI.RogueLike;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Night.RogueLike
{
	// Token: 0x0200006A RID: 106
	public class DLC5_RogueLikeCardPersistentRandomProduct : RogueLikeCardPersistent
	{
		// Token: 0x06000BE7 RID: 3047 RVA: 0x000C58E8 File Offset: 0x000C3AE8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentRandomProduct()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentRandomProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentRandomProduct.NativeFieldInfoPtr_randomCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr, "randomCount");
			DLC5_RogueLikeCardPersistentRandomProduct.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr, 100665283);
			DLC5_RogueLikeCardPersistentRandomProduct.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr, 100665284);
			DLC5_RogueLikeCardPersistentRandomProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr, 100665285);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000C5968 File Offset: 0x000C3B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41935, XrefRangeEnd = 42092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentRandomProduct.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000C59C8 File Offset: 0x000C3BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42092, XrefRangeEnd = 42353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentRandomProduct.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000C5A28 File Offset: 0x000C3C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42353, XrefRangeEnd = 42354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentRandomProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00008596 File Offset: 0x00006796
		public DLC5_RogueLikeCardPersistentRandomProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000C5A64 File Offset: 0x000C3C64
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0000859F File Offset: 0x0000679F
		public unsafe int randomCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentRandomProduct.NativeFieldInfoPtr_randomCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentRandomProduct.NativeFieldInfoPtr_randomCount)) = value;
			}
		}

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_randomCount;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000531 RID: 1329
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentRandomProduct+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008600 RID: 34304 RVA: 0x00256C6C File Offset: 0x00254E6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__1_0");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__1_1");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__1_2");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__1_3");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__1_4");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__1_5");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_0");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_1");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_2");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_4");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_5");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_6");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_8");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, "<>9__2_9");
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665287);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665288);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_1_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665289);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_2_Internal_Int32_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665290);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_3_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665291);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_4_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665292);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_5_Internal_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665293);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665294);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_1_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665295);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_2_Internal_Int32_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665296);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_4_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665297);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_5_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665298);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_6_Internal_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665299);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_8_Internal_Boolean_IngredientRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665300);
				DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_9_Internal_IEnumerable_1_Int32_IngredientRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr, 100665301);
			}

			// Token: 0x06008601 RID: 34305 RVA: 0x00256EF0 File Offset: 0x002550F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008602 RID: 34306 RVA: 0x00256F2C File Offset: 0x0025512C
			[CallerCount(0)]
			public unsafe bool _AfterInitialize_b__1_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008603 RID: 34307 RVA: 0x00256F80 File Offset: 0x00255180
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_1_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008604 RID: 34308 RVA: 0x00256FD4 File Offset: 0x002551D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41926, XrefRangeEnd = 41927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AfterInitialize_b__1_2(KeyValuePair<Cooker, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_2_Internal_Int32_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008605 RID: 34309 RVA: 0x00257028 File Offset: 0x00255228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41927, XrefRangeEnd = 41928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AfterInitialize_b__1_3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_3_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008606 RID: 34310 RVA: 0x0025707C File Offset: 0x0025527C
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_4(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_4_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008607 RID: 34311 RVA: 0x002570D0 File Offset: 0x002552D0
			[CallerCount(0)]
			public unsafe int _AfterInitialize_b__1_5(Decoration x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterInitialize_b__1_5_Internal_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008608 RID: 34312 RVA: 0x00257120 File Offset: 0x00255320
			[CallerCount(0)]
			public unsafe bool _AfterSelect_b__2_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008609 RID: 34313 RVA: 0x00257174 File Offset: 0x00255374
			[CallerCount(0)]
			public unsafe int _AfterSelect_b__2_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_1_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600860A RID: 34314 RVA: 0x002571C8 File Offset: 0x002553C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41928, XrefRangeEnd = 41929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AfterSelect_b__2_2(KeyValuePair<Cooker, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_2_Internal_Int32_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600860B RID: 34315 RVA: 0x0025721C File Offset: 0x0025541C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41929, XrefRangeEnd = 41930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AfterSelect_b__2_4(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_4_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600860C RID: 34316 RVA: 0x00257270 File Offset: 0x00255470
			[CallerCount(0)]
			public unsafe int _AfterSelect_b__2_5(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_5_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600860D RID: 34317 RVA: 0x002572C4 File Offset: 0x002554C4
			[CallerCount(0)]
			public unsafe int _AfterSelect_b__2_6(Decoration x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_6_Internal_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600860E RID: 34318 RVA: 0x00257314 File Offset: 0x00255514
			[CallerCount(0)]
			public unsafe bool _AfterSelect_b__2_8(DLC5_RogueLikeDataProfile.MapSetup.IngredientRange x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_8_Internal_Boolean_IngredientRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600860F RID: 34319 RVA: 0x00257360 File Offset: 0x00255560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41930, XrefRangeEnd = 41934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _AfterSelect_b__2_9(DLC5_RogueLikeDataProfile.MapSetup.IngredientRange x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeMethodInfoPtr__AfterSelect_b__2_9_Internal_IEnumerable_1_Int32_IngredientRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008610 RID: 34320 RVA: 0x000481D8 File Offset: 0x000463D8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CF8 RID: 11512
			// (get) Token: 0x06008611 RID: 34321 RVA: 0x002573AC File Offset: 0x002555AC
			// (set) Token: 0x06008612 RID: 34322 RVA: 0x000481E1 File Offset: 0x000463E1
			public unsafe static DLC5_RogueLikeCardPersistentRandomProduct.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentRandomProduct.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF9 RID: 11513
			// (get) Token: 0x06008613 RID: 34323 RVA: 0x002573D4 File Offset: 0x002555D4
			// (set) Token: 0x06008614 RID: 34324 RVA: 0x000481F3 File Offset: 0x000463F3
			public unsafe static Func<Product, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CFA RID: 11514
			// (get) Token: 0x06008615 RID: 34325 RVA: 0x002573FC File Offset: 0x002555FC
			// (set) Token: 0x06008616 RID: 34326 RVA: 0x00048205 File Offset: 0x00046405
			public unsafe static Func<Product, int> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CFB RID: 11515
			// (get) Token: 0x06008617 RID: 34327 RVA: 0x00257424 File Offset: 0x00255624
			// (set) Token: 0x06008618 RID: 34328 RVA: 0x00048217 File Offset: 0x00046417
			public unsafe static Func<KeyValuePair<Cooker, int>, int> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CFC RID: 11516
			// (get) Token: 0x06008619 RID: 34329 RVA: 0x0025744C File Offset: 0x0025564C
			// (set) Token: 0x0600861A RID: 34330 RVA: 0x00048229 File Offset: 0x00046429
			public unsafe static Func<Product, bool> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CFD RID: 11517
			// (get) Token: 0x0600861B RID: 34331 RVA: 0x00257474 File Offset: 0x00255674
			// (set) Token: 0x0600861C RID: 34332 RVA: 0x0004823B File Offset: 0x0004643B
			public unsafe static Func<Product, int> __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CFE RID: 11518
			// (get) Token: 0x0600861D RID: 34333 RVA: 0x0025749C File Offset: 0x0025569C
			// (set) Token: 0x0600861E RID: 34334 RVA: 0x0004824D File Offset: 0x0004644D
			public unsafe static Func<Decoration, int> __9__1_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decoration, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__1_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CFF RID: 11519
			// (get) Token: 0x0600861F RID: 34335 RVA: 0x002574C4 File Offset: 0x002556C4
			// (set) Token: 0x06008620 RID: 34336 RVA: 0x0004825F File Offset: 0x0004645F
			public unsafe static Func<Product, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D00 RID: 11520
			// (get) Token: 0x06008621 RID: 34337 RVA: 0x002574EC File Offset: 0x002556EC
			// (set) Token: 0x06008622 RID: 34338 RVA: 0x00048271 File Offset: 0x00046471
			public unsafe static Func<Product, int> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D01 RID: 11521
			// (get) Token: 0x06008623 RID: 34339 RVA: 0x00257514 File Offset: 0x00255714
			// (set) Token: 0x06008624 RID: 34340 RVA: 0x00048283 File Offset: 0x00046483
			public unsafe static Func<KeyValuePair<Cooker, int>, int> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D02 RID: 11522
			// (get) Token: 0x06008625 RID: 34341 RVA: 0x0025753C File Offset: 0x0025573C
			// (set) Token: 0x06008626 RID: 34342 RVA: 0x00048295 File Offset: 0x00046495
			public unsafe static Func<Product, bool> __9__2_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D03 RID: 11523
			// (get) Token: 0x06008627 RID: 34343 RVA: 0x00257564 File Offset: 0x00255764
			// (set) Token: 0x06008628 RID: 34344 RVA: 0x000482A7 File Offset: 0x000464A7
			public unsafe static Func<Product, int> __9__2_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D04 RID: 11524
			// (get) Token: 0x06008629 RID: 34345 RVA: 0x0025758C File Offset: 0x0025578C
			// (set) Token: 0x0600862A RID: 34346 RVA: 0x000482B9 File Offset: 0x000464B9
			public unsafe static Func<Decoration, int> __9__2_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decoration, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D05 RID: 11525
			// (get) Token: 0x0600862B RID: 34347 RVA: 0x002575B4 File Offset: 0x002557B4
			// (set) Token: 0x0600862C RID: 34348 RVA: 0x000482CB File Offset: 0x000464CB
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange, bool> __9__2_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D06 RID: 11526
			// (get) Token: 0x0600862D RID: 34349 RVA: 0x002575DC File Offset: 0x002557DC
			// (set) Token: 0x0600862E RID: 34350 RVA: 0x000482DD File Offset: 0x000464DD
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange, IEnumerable<int>> __9__2_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentRandomProduct.__c.NativeFieldInfoPtr___9__2_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005802 RID: 22530
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005803 RID: 22531
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04005804 RID: 22532
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04005805 RID: 22533
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x04005806 RID: 22534
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x04005807 RID: 22535
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x04005808 RID: 22536
			private static readonly IntPtr NativeFieldInfoPtr___9__1_5;

			// Token: 0x04005809 RID: 22537
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400580A RID: 22538
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x0400580B RID: 22539
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x0400580C RID: 22540
			private static readonly IntPtr NativeFieldInfoPtr___9__2_4;

			// Token: 0x0400580D RID: 22541
			private static readonly IntPtr NativeFieldInfoPtr___9__2_5;

			// Token: 0x0400580E RID: 22542
			private static readonly IntPtr NativeFieldInfoPtr___9__2_6;

			// Token: 0x0400580F RID: 22543
			private static readonly IntPtr NativeFieldInfoPtr___9__2_8;

			// Token: 0x04005810 RID: 22544
			private static readonly IntPtr NativeFieldInfoPtr___9__2_9;

			// Token: 0x04005811 RID: 22545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005812 RID: 22546
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_0_Internal_Boolean_Product_0;

			// Token: 0x04005813 RID: 22547
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_1_Internal_Int32_Product_0;

			// Token: 0x04005814 RID: 22548
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_2_Internal_Int32_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x04005815 RID: 22549
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_3_Internal_Boolean_Product_0;

			// Token: 0x04005816 RID: 22550
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_4_Internal_Int32_Product_0;

			// Token: 0x04005817 RID: 22551
			private static readonly IntPtr NativeMethodInfoPtr__AfterInitialize_b__1_5_Internal_Int32_Decoration_0;

			// Token: 0x04005818 RID: 22552
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_0_Internal_Boolean_Product_0;

			// Token: 0x04005819 RID: 22553
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_1_Internal_Int32_Product_0;

			// Token: 0x0400581A RID: 22554
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_2_Internal_Int32_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x0400581B RID: 22555
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_4_Internal_Boolean_Product_0;

			// Token: 0x0400581C RID: 22556
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_5_Internal_Int32_Product_0;

			// Token: 0x0400581D RID: 22557
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_6_Internal_Int32_Decoration_0;

			// Token: 0x0400581E RID: 22558
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_8_Internal_Boolean_IngredientRange_0;

			// Token: 0x0400581F RID: 22559
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__2_9_Internal_IEnumerable_1_Int32_IngredientRange_0;
		}

		// Token: 0x02000532 RID: 1330
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentRandomProduct+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600862F RID: 34351 RVA: 0x00257604 File Offset: 0x00255804
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr, "cooker");
				DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeFieldInfoPtr_decoration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr, "decoration");
				DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr, 100665302);
				DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__AfterSelect_b__3_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr, 100665303);
				DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__AfterSelect_b__7_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr, 100665304);
				DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__AfterSelect_b__10_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr, 100665305);
			}

			// Token: 0x06008630 RID: 34352 RVA: 0x002576A8 File Offset: 0x002558A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008631 RID: 34353 RVA: 0x002576E4 File Offset: 0x002558E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41934, XrefRangeEnd = 41935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AfterSelect_b__3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__AfterSelect_b__3_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008632 RID: 34354 RVA: 0x00257738 File Offset: 0x00255938
			[CallerCount(0)]
			public unsafe bool _AfterSelect_b__7(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__AfterSelect_b__7_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008633 RID: 34355 RVA: 0x0025778C File Offset: 0x0025598C
			[CallerCount(0)]
			public unsafe bool _AfterSelect_b__10(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeMethodInfoPtr__AfterSelect_b__10_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008634 RID: 34356 RVA: 0x000482EF File Offset: 0x000464EF
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D07 RID: 11527
			// (get) Token: 0x06008635 RID: 34357 RVA: 0x002577E0 File Offset: 0x002559E0
			// (set) Token: 0x06008636 RID: 34358 RVA: 0x000482F8 File Offset: 0x000464F8
			public unsafe List<int> cooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeFieldInfoPtr_cooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeFieldInfoPtr_cooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D08 RID: 11528
			// (get) Token: 0x06008637 RID: 34359 RVA: 0x00257810 File Offset: 0x00255A10
			// (set) Token: 0x06008638 RID: 34360 RVA: 0x00048317 File Offset: 0x00046517
			public unsafe int decoration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeFieldInfoPtr_decoration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentRandomProduct.__c__DisplayClass2_0.NativeFieldInfoPtr_decoration)) = value;
				}
			}

			// Token: 0x04005820 RID: 22560
			private static readonly IntPtr NativeFieldInfoPtr_cooker;

			// Token: 0x04005821 RID: 22561
			private static readonly IntPtr NativeFieldInfoPtr_decoration;

			// Token: 0x04005822 RID: 22562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005823 RID: 22563
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__3_Internal_Boolean_Product_0;

			// Token: 0x04005824 RID: 22564
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__7_Internal_Boolean_Product_0;

			// Token: 0x04005825 RID: 22565
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__10_Internal_Boolean_Product_0;
		}
	}
}
