using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections
{
	// Token: 0x02000245 RID: 581
	public static class SellablePropertyHelper : Il2CppSystem.Object
	{
		// Token: 0x06004871 RID: 18545 RVA: 0x00199A8C File Offset: 0x00197C8C
		// Note: this type is marked as 'beforefieldinit'.
		static SellablePropertyHelper()
		{
			Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "SellablePropertyHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr);
			SellablePropertyHelper.NativeFieldInfoPtr__BGGetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, "<BGGetter>k__BackingField");
			SellablePropertyHelper.NativeMethodInfoPtr_get_BGGetter_Private_Static_get_Func_2_Sellable_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677779);
			SellablePropertyHelper.NativeMethodInfoPtr_set_BGGetter_Public_Static_set_Void_Func_2_Sellable_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677780);
			SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Private_Static_Void_Boolean_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677781);
			SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_Sellable_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677782);
			SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_UIElementCluster_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677783);
			SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_UIElementCluster_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677784);
			SellablePropertyHelper.NativeMethodInfoPtr_GetSellabeBGSprite_Public_Static_Sprite_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, 100677785);
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x00199B5C File Offset: 0x00197D5C
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x00199B90 File Offset: 0x00197D90
		public unsafe static Func<Sellable, Sprite> BGGetter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190355, XrefRangeEnd = 190357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_get_BGGetter_Private_Static_get_Func_2_Sellable_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Sellable, Sprite>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190357, XrefRangeEnd = 190361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_set_BGGetter_Public_Static_set_Void_Func_2_Sellable_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00199BC8 File Offset: 0x00197DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190361, XrefRangeEnd = 190363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignForSellableModify(bool hasModify, Image modifySign)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hasModify;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifySign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Private_Static_Void_Boolean_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00199C0C File Offset: 0x00197E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190363, XrefRangeEnd = 190372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignForSellableModify(this Sellable sellable, Image modifySign)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifySign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_Sellable_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00199C54 File Offset: 0x00197E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190387, RefRangeEnd = 190388, XrefRangeStart = 190372, XrefRangeEnd = 190387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignForSellableModify(this UIElementCluster cluster, Sellable sellable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_UIElementCluster_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00199C9C File Offset: 0x00197E9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190402, RefRangeEnd = 190405, XrefRangeStart = 190388, XrefRangeEnd = 190402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignForSellableModify(this UIElementCluster cluster, bool hasModify)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasModify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_UIElementCluster_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00199CE0 File Offset: 0x00197EE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 190409, RefRangeEnd = 190413, XrefRangeStart = 190405, XrefRangeEnd = 190409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite GetSellabeBGSprite(Sellable target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.NativeMethodInfoPtr_GetSellabeBGSprite_Public_Static_Sprite_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00025399 File Offset: 0x00023599
		public SellablePropertyHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x00199D24 File Offset: 0x00197F24
		// (set) Token: 0x0600487B RID: 18555 RVA: 0x000253A2 File Offset: 0x000235A2
		public unsafe static Func<Sellable, Sprite> _BGGetter_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SellablePropertyHelper.NativeFieldInfoPtr__BGGetter_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SellablePropertyHelper.NativeFieldInfoPtr__BGGetter_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeFieldInfoPtr__BGGetter_k__BackingField;

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeMethodInfoPtr_get_BGGetter_Private_Static_get_Func_2_Sellable_Sprite_0;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeMethodInfoPtr_set_BGGetter_Public_Static_set_Void_Func_2_Sellable_Sprite_0;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeMethodInfoPtr_AssignForSellableModify_Private_Static_Void_Boolean_Image_0;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_Sellable_Image_0;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_UIElementCluster_Sellable_0;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr_AssignForSellableModify_Public_Static_Void_UIElementCluster_Boolean_0;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr_GetSellabeBGSprite_Public_Static_Sprite_Sellable_0;

		// Token: 0x02000AC1 RID: 2753
		[ObfuscatedName("GameData.Core.Collections.SellablePropertyHelper+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE0D RID: 52749 RVA: 0x0032C7F4 File Offset: 0x0032A9F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass6_0>.NativeClassPtr);
				SellablePropertyHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_sellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass6_0>.NativeClassPtr, "sellable");
				SellablePropertyHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass6_0>.NativeClassPtr, 100677786);
				SellablePropertyHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__AssignForSellableModify_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass6_0>.NativeClassPtr, 100677787);
			}

			// Token: 0x0600CE0E RID: 52750 RVA: 0x0032C85C File Offset: 0x0032AA5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE0F RID: 52751 RVA: 0x0032C898 File Offset: 0x0032AA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190346, XrefRangeEnd = 190355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AssignForSellableModify_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__AssignForSellableModify_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE10 RID: 52752 RVA: 0x0006E5A3 File Offset: 0x0006C7A3
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FB RID: 17147
			// (get) Token: 0x0600CE11 RID: 52753 RVA: 0x0032C8DC File Offset: 0x0032AADC
			// (set) Token: 0x0600CE12 RID: 52754 RVA: 0x0006E5AC File Offset: 0x0006C7AC
			public unsafe Sellable sellable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellablePropertyHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_sellable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellablePropertyHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_sellable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008481 RID: 33921
			private static readonly IntPtr NativeFieldInfoPtr_sellable;

			// Token: 0x04008482 RID: 33922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008483 RID: 33923
			private static readonly IntPtr NativeMethodInfoPtr__AssignForSellableModify_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000AC2 RID: 2754
		[ObfuscatedName("GameData.Core.Collections.SellablePropertyHelper+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE13 RID: 52755 RVA: 0x0032C90C File Offset: 0x0032AB0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellablePropertyHelper>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass7_0>.NativeClassPtr);
				SellablePropertyHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_hasModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass7_0>.NativeClassPtr, "hasModify");
				SellablePropertyHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass7_0>.NativeClassPtr, 100677788);
				SellablePropertyHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__AssignForSellableModify_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass7_0>.NativeClassPtr, 100677789);
			}

			// Token: 0x0600CE14 RID: 52756 RVA: 0x0032C974 File Offset: 0x0032AB74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellablePropertyHelper.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE15 RID: 52757 RVA: 0x0032C9B0 File Offset: 0x0032ABB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AssignForSellableModify_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellablePropertyHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__AssignForSellableModify_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE16 RID: 52758 RVA: 0x0006E5CB File Offset: 0x0006C7CB
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FC RID: 17148
			// (get) Token: 0x0600CE17 RID: 52759 RVA: 0x0032C9F4 File Offset: 0x0032ABF4
			// (set) Token: 0x0600CE18 RID: 52760 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
			public unsafe bool hasModify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellablePropertyHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_hasModify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellablePropertyHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_hasModify)) = value;
				}
			}

			// Token: 0x04008484 RID: 33924
			private static readonly IntPtr NativeFieldInfoPtr_hasModify;

			// Token: 0x04008485 RID: 33925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008486 RID: 33926
			private static readonly IntPtr NativeMethodInfoPtr__AssignForSellableModify_b__0_Internal_Void_Image_0;
		}
	}
}
