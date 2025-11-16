using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000DC RID: 220
	public class DLC5_RogueLikeCardGiveItem : RogueLikeCard
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x000F63B8 File Offset: 0x000F45B8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardGiveItem()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardGiveItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr);
			DLC5_RogueLikeCardGiveItem.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardGiveItem.NativeMethodInfoPtr_GetDataByRarity_Protected_RarityDataMappingForGiveItem_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr, 100667998);
			DLC5_RogueLikeCardGiveItem.NativeMethodInfoPtr_GetSelectedItem_Protected_Void_RogueLikeRunTimeData_Boolean_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr, 100667999);
			DLC5_RogueLikeCardGiveItem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr, 100668000);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000F6438 File Offset: 0x000F4638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70503, XrefRangeEnd = 70506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItem.NativeMethodInfoPtr_GetDataByRarity_Protected_RarityDataMappingForGiveItem_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>(intPtr3) : null;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x000F6484 File Offset: 0x000F4684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70506, XrefRangeEnd = 70555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSelectedItem(RogueLikeRunTimeData runTimeData, bool isIngredient, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIngredient;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItem.NativeMethodInfoPtr_GetSelectedItem_Protected_Void_RogueLikeRunTimeData_Boolean_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000F64E4 File Offset: 0x000F46E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardGiveItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00010664 File Offset: 0x0000E864
		public DLC5_RogueLikeCardGiveItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000F6520 File Offset: 0x000F4720
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0001066D File Offset: 0x0000E86D
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItem.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItem.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_GetDataByRarity_Protected_RarityDataMappingForGiveItem_Rarity_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedItem_Protected_Void_RogueLikeRunTimeData_Boolean_Rarity_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000699 RID: 1689
		[Serializable]
		public class RarityDataMappingForGiveItem : RarityDataMapping
		{
			// Token: 0x06009738 RID: 38712 RVA: 0x00288588 File Offset: 0x00286788
			// Note: this type is marked as 'beforefieldinit'.
			static RarityDataMappingForGiveItem()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr, "RarityDataMappingForGiveItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>.NativeClassPtr);
				DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeFieldInfoPtr_TypeNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>.NativeClassPtr, "TypeNum");
				DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeFieldInfoPtr_GiveNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>.NativeClassPtr, "GiveNum");
				DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>.NativeClassPtr, 100668001);
			}

			// Token: 0x06009739 RID: 38713 RVA: 0x002885F0 File Offset: 0x002867F0
			[CallerCount(201)]
			[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RarityDataMappingForGiveItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600973A RID: 38714 RVA: 0x00051C77 File Offset: 0x0004FE77
			public RarityDataMappingForGiveItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003239 RID: 12857
			// (get) Token: 0x0600973B RID: 38715 RVA: 0x0028862C File Offset: 0x0028682C
			// (set) Token: 0x0600973C RID: 38716 RVA: 0x00051C80 File Offset: 0x0004FE80
			public unsafe Vector2Int TypeNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeFieldInfoPtr_TypeNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeFieldInfoPtr_TypeNum)) = value;
				}
			}

			// Token: 0x1700323A RID: 12858
			// (get) Token: 0x0600973D RID: 38717 RVA: 0x00288654 File Offset: 0x00286854
			// (set) Token: 0x0600973E RID: 38718 RVA: 0x00051C9B File Offset: 0x0004FE9B
			public unsafe Vector2Int GiveNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeFieldInfoPtr_GiveNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem.NativeFieldInfoPtr_GiveNum)) = value;
				}
			}

			// Token: 0x0400620E RID: 25102
			private static readonly IntPtr NativeFieldInfoPtr_TypeNum;

			// Token: 0x0400620F RID: 25103
			private static readonly IntPtr NativeFieldInfoPtr_GiveNum;

			// Token: 0x04006210 RID: 25104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200069A RID: 1690
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardGiveItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600973F RID: 38719 RVA: 0x0028867C File Offset: 0x0028687C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr);
				DLC5_RogueLikeCardGiveItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardGiveItem.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr, "<>9__3_0");
				DLC5_RogueLikeCardGiveItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr, 100668003);
				DLC5_RogueLikeCardGiveItem.__c.NativeMethodInfoPtr__GetSelectedItem_b__3_0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr, 100668004);
			}

			// Token: 0x06009740 RID: 38720 RVA: 0x002886F8 File Offset: 0x002868F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009741 RID: 38721 RVA: 0x00288734 File Offset: 0x00286934
			[CallerCount(0)]
			public unsafe bool _GetSelectedItem_b__3_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItem.__c.NativeMethodInfoPtr__GetSelectedItem_b__3_0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009742 RID: 38722 RVA: 0x00051CB6 File Offset: 0x0004FEB6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700323B RID: 12859
			// (get) Token: 0x06009743 RID: 38723 RVA: 0x00288788 File Offset: 0x00286988
			// (set) Token: 0x06009744 RID: 38724 RVA: 0x00051CBF File Offset: 0x0004FEBF
			public unsafe static DLC5_RogueLikeCardGiveItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardGiveItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardGiveItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardGiveItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700323C RID: 12860
			// (get) Token: 0x06009745 RID: 38725 RVA: 0x002887B0 File Offset: 0x002869B0
			// (set) Token: 0x06009746 RID: 38726 RVA: 0x00051CD1 File Offset: 0x0004FED1
			public unsafe static Func<Product, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardGiveItem.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardGiveItem.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006211 RID: 25105
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006212 RID: 25106
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04006213 RID: 25107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006214 RID: 25108
			private static readonly IntPtr NativeMethodInfoPtr__GetSelectedItem_b__3_0_Internal_Boolean_Product_0;
		}
	}
}
