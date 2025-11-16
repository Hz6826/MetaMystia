using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core
{
	// Token: 0x02000236 RID: 566
	public static class NonTradableObjectBaseBGSpriteHelper : Il2CppSystem.Object
	{
		// Token: 0x0600469A RID: 18074 RVA: 0x001929EC File Offset: 0x00190BEC
		// Note: this type is marked as 'beforefieldinit'.
		static NonTradableObjectBaseBGSpriteHelper()
		{
			Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core", "NonTradableObjectBaseBGSpriteHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Private_Static_Void_NonTradableObjectBase_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677290);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Private_Static_Void_Sprite_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677291);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignNull_Private_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677292);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Public_Static_Void_UIElementCluster_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677293);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Public_Static_Void_UIElementCluster_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677294);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignNull_Public_Static_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677295);
			NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_GetNonTradableObjectNum_Public_Static_String_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, 100677296);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x00192AA8 File Offset: 0x00190CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186141, XrefRangeEnd = 186143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignObjectBg(this NonTradableObjectBase nonTradableObjectBase, Image bgPic)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonTradableObjectBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgPic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Private_Static_Void_NonTradableObjectBase_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x00192AF0 File Offset: 0x00190CF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186151, RefRangeEnd = 186154, XrefRangeStart = 186143, XrefRangeEnd = 186151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignObjectBg(Sprite sprite, Image bgPic)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgPic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Private_Static_Void_Sprite_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x00192B38 File Offset: 0x00190D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186154, XrefRangeEnd = 186156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignNull(Image bgPic)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bgPic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignNull_Private_Static_Void_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x00192B70 File Offset: 0x00190D70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 186171, RefRangeEnd = 186176, XrefRangeStart = 186156, XrefRangeEnd = 186171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignObjectBg(this UIElementCluster cluster, NonTradableObjectBase nonTradableObjectBase)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nonTradableObjectBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Public_Static_Void_UIElementCluster_NonTradableObjectBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x00192BB8 File Offset: 0x00190DB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 186191, RefRangeEnd = 186198, XrefRangeStart = 186176, XrefRangeEnd = 186191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignObjectBg(this UIElementCluster cluster, Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignObjectBg_Public_Static_Void_UIElementCluster_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00192C00 File Offset: 0x00190E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186208, RefRangeEnd = 186210, XrefRangeStart = 186198, XrefRangeEnd = 186208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignNull(this UIElementCluster cluster)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_AssignNull_Public_Static_Void_UIElementCluster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00192C38 File Offset: 0x00190E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186210, XrefRangeEnd = 186213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNonTradableObjectNum<T>(this KeyValuePair<T, int> objectCollectionPair)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(objectCollectionPair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.MethodInfoStoreGeneric_GetNonTradableObjectNum_Public_Static_String_KeyValuePair_2_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00024AE3 File Offset: 0x00022CE3
		public NonTradableObjectBaseBGSpriteHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeMethodInfoPtr_AssignObjectBg_Private_Static_Void_NonTradableObjectBase_Image_0;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeMethodInfoPtr_AssignObjectBg_Private_Static_Void_Sprite_Image_0;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeMethodInfoPtr_AssignNull_Private_Static_Void_Image_0;

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr_AssignObjectBg_Public_Static_Void_UIElementCluster_NonTradableObjectBase_0;

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeMethodInfoPtr_AssignObjectBg_Public_Static_Void_UIElementCluster_Sprite_0;

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeMethodInfoPtr_AssignNull_Public_Static_Void_UIElementCluster_0;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeMethodInfoPtr_GetNonTradableObjectNum_Public_Static_String_KeyValuePair_2_T_Int32_0;

		// Token: 0x02000AA3 RID: 2723
		[ObfuscatedName("GameData.Core.NonTradableObjectBaseBGSpriteHelper+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC35 RID: 52277 RVA: 0x003263B0 File Offset: 0x003245B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0>.NativeClassPtr);
				NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_nonTradableObjectBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0>.NativeClassPtr, "nonTradableObjectBase");
				NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0>.NativeClassPtr, 100677297);
				NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__AssignObjectBg_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0>.NativeClassPtr, 100677298);
			}

			// Token: 0x0600CC36 RID: 52278 RVA: 0x00326418 File Offset: 0x00324618
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC37 RID: 52279 RVA: 0x00326454 File Offset: 0x00324654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186138, XrefRangeEnd = 186140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AssignObjectBg_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__AssignObjectBg_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC38 RID: 52280 RVA: 0x0006D96C File Offset: 0x0006BB6C
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423F RID: 16959
			// (get) Token: 0x0600CC39 RID: 52281 RVA: 0x00326498 File Offset: 0x00324698
			// (set) Token: 0x0600CC3A RID: 52282 RVA: 0x0006D975 File Offset: 0x0006BB75
			public unsafe NonTradableObjectBase nonTradableObjectBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_nonTradableObjectBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NonTradableObjectBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_nonTradableObjectBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400832C RID: 33580
			private static readonly IntPtr NativeFieldInfoPtr_nonTradableObjectBase;

			// Token: 0x0400832D RID: 33581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400832E RID: 33582
			private static readonly IntPtr NativeMethodInfoPtr__AssignObjectBg_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000AA4 RID: 2724
		[ObfuscatedName("GameData.Core.NonTradableObjectBaseBGSpriteHelper+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC3B RID: 52283 RVA: 0x003264C8 File Offset: 0x003246C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0>.NativeClassPtr);
				NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0>.NativeClassPtr, "sprite");
				NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0>.NativeClassPtr, 100677299);
				NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__AssignObjectBg_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0>.NativeClassPtr, 100677300);
			}

			// Token: 0x0600CC3C RID: 52284 RVA: 0x00326530 File Offset: 0x00324730
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC3D RID: 52285 RVA: 0x0032656C File Offset: 0x0032476C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186140, XrefRangeEnd = 186141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AssignObjectBg_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__AssignObjectBg_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC3E RID: 52286 RVA: 0x0006D994 File Offset: 0x0006BB94
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004240 RID: 16960
			// (get) Token: 0x0600CC3F RID: 52287 RVA: 0x003265B0 File Offset: 0x003247B0
			// (set) Token: 0x0600CC40 RID: 52288 RVA: 0x0006D99D File Offset: 0x0006BB9D
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonTradableObjectBaseBGSpriteHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400832F RID: 33583
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04008330 RID: 33584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008331 RID: 33585
			private static readonly IntPtr NativeMethodInfoPtr__AssignObjectBg_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000AA5 RID: 2725
		private sealed class MethodInfoStoreGeneric_GetNonTradableObjectNum_Public_Static_String_KeyValuePair_2_T_Int32_0<T>
		{
			// Token: 0x04008332 RID: 33586
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NonTradableObjectBaseBGSpriteHelper.NativeMethodInfoPtr_GetNonTradableObjectNum_Public_Static_String_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<NonTradableObjectBaseBGSpriteHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
