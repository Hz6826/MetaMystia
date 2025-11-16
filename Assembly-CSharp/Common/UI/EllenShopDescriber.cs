using System;
using Common.UI.DLC5_EllenShopPanel;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x0200035C RID: 860
	public class EllenShopDescriber : SellableDescriber
	{
		// Token: 0x060065C5 RID: 26053 RVA: 0x001F25CC File Offset: 0x001F07CC
		// Note: this type is marked as 'beforefieldinit'.
		static EllenShopDescriber()
		{
			Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "EllenShopDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr);
			EllenShopDescriber.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "amount");
			EllenShopDescriber.NativeFieldInfoPtr_extraCurrencyTextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "extraCurrencyTextElement");
			EllenShopDescriber.NativeFieldInfoPtr_extraCurrencyTextTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "extraCurrencyTextTransform");
			EllenShopDescriber.NativeFieldInfoPtr_extraTextInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "extraTextInstances");
			EllenShopDescriber.NativeMethodInfoPtr_Describe_Public_Void_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, 100684629);
			EllenShopDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, 100684630);
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x001F2674 File Offset: 0x001F0874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262798, RefRangeEnd = 262799, XrefRangeStart = 262699, XrefRangeEnd = 262798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(DLC5_EllenShopPanel.ProductCondition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.NativeMethodInfoPtr_Describe_Public_Void_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x001F26BC File Offset: 0x001F08BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262799, XrefRangeEnd = 262808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EllenShopDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00036F80 File Offset: 0x00035180
		public EllenShopDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x001F26F8 File Offset: 0x001F08F8
		// (set) Token: 0x060065CA RID: 26058 RVA: 0x00036F89 File Offset: 0x00035189
		public unsafe TextMeshProUGUI amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_amount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_amount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x001F2728 File Offset: 0x001F0928
		// (set) Token: 0x060065CC RID: 26060 RVA: 0x00036FA8 File Offset: 0x000351A8
		public unsafe GameObject extraCurrencyTextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_extraCurrencyTextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_extraCurrencyTextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x001F2758 File Offset: 0x001F0958
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x00036FC7 File Offset: 0x000351C7
		public unsafe Transform extraCurrencyTextTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_extraCurrencyTextTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_extraCurrencyTextTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x060065CF RID: 26063 RVA: 0x001F2788 File Offset: 0x001F0988
		// (set) Token: 0x060065D0 RID: 26064 RVA: 0x00036FE6 File Offset: 0x000351E6
		public unsafe List<GameObject> extraTextInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_extraTextInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.NativeFieldInfoPtr_extraTextInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004386 RID: 17286
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04004387 RID: 17287
		private static readonly IntPtr NativeFieldInfoPtr_extraCurrencyTextElement;

		// Token: 0x04004388 RID: 17288
		private static readonly IntPtr NativeFieldInfoPtr_extraCurrencyTextTransform;

		// Token: 0x04004389 RID: 17289
		private static readonly IntPtr NativeFieldInfoPtr_extraTextInstances;

		// Token: 0x0400438A RID: 17290
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_ProductCondition_0;

		// Token: 0x0400438B RID: 17291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E40 RID: 3648
		[ObfuscatedName("Common.UI.EllenShopDescriber+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x06010533 RID: 66867 RVA: 0x003CBCF0 File Offset: 0x003C9EF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr);
				EllenShopDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_productData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr, "productData");
				EllenShopDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				EllenShopDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100684631);
				EllenShopDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100684632);
				EllenShopDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__Describe_b__3_Internal_Boolean_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100684633);
			}

			// Token: 0x06010534 RID: 66868 RVA: 0x003CBD80 File Offset: 0x003C9F80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010535 RID: 66869 RVA: 0x003CBDBC File Offset: 0x003C9FBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262639, RefRangeEnd = 262640, XrefRangeStart = 262636, XrefRangeEnd = 262639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>(IEnumerable<KeyValuePair<T, int>> objectCollection) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c__DisplayClass4_0.MethodInfoStoreGeneric_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010536 RID: 66870 RVA: 0x003CBE00 File Offset: 0x003CA000
			[CallerCount(0)]
			public unsafe bool _Describe_b__3<T>(KeyValuePair<T, int> x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c__DisplayClass4_0.MethodInfoStoreGeneric__Describe_b__3_Internal_Boolean_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010537 RID: 66871 RVA: 0x0008E73A File Offset: 0x0008C93A
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700555D RID: 21853
			// (get) Token: 0x06010538 RID: 66872 RVA: 0x003CBE54 File Offset: 0x003CA054
			// (set) Token: 0x06010539 RID: 66873 RVA: 0x0008E743 File Offset: 0x0008C943
			public Product productData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_productData);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_productData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700555E RID: 21854
			// (get) Token: 0x0601053A RID: 66874 RVA: 0x003CBE84 File Offset: 0x003CA084
			// (set) Token: 0x0601053B RID: 66875 RVA: 0x0008E771 File Offset: 0x0008C971
			public unsafe EllenShopDescriber __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EllenShopDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A57C RID: 42364
			private static readonly IntPtr NativeFieldInfoPtr_productData;

			// Token: 0x0400A57D RID: 42365
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A57E RID: 42366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A57F RID: 42367
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0;

			// Token: 0x0400A580 RID: 42368
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__3_Internal_Boolean_KeyValuePair_2_T_Int32_0;

			// Token: 0x020010B1 RID: 4273
			private sealed class MethodInfoStoreGeneric_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400B837 RID: 47159
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EllenShopDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010B2 RID: 4274
			private sealed class MethodInfoStoreGeneric__Describe_b__3_Internal_Boolean_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400B838 RID: 47160
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EllenShopDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__Describe_b__3_Internal_Boolean_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x02000E41 RID: 3649
		[ObfuscatedName("Common.UI.EllenShopDescriber+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Il2CppSystem.Object
		{
			// Token: 0x0601053C RID: 66876 RVA: 0x003CBEB4 File Offset: 0x003CA0B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_1>.NativeClassPtr);
				EllenShopDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_currency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_1>.NativeClassPtr, "currency");
				EllenShopDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100684634);
				EllenShopDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100684635);
			}

			// Token: 0x0601053D RID: 66877 RVA: 0x003CBF1C File Offset: 0x003CA11C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenShopDescriber.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601053E RID: 66878 RVA: 0x003CBF58 File Offset: 0x003CA158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262640, XrefRangeEnd = 262682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601053F RID: 66879 RVA: 0x0008E790 File Offset: 0x0008C990
			public __c__DisplayClass4_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700555F RID: 21855
			// (get) Token: 0x06010540 RID: 66880 RVA: 0x003CBF9C File Offset: 0x003CA19C
			// (set) Token: 0x06010541 RID: 66881 RVA: 0x0008E799 File Offset: 0x0008C999
			public DLC5_EllenShopPanel.Currency currency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_currency);
					return new DLC5_EllenShopPanel.Currency(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenShopDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_currency), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A581 RID: 42369
			private static readonly IntPtr NativeFieldInfoPtr_currency;

			// Token: 0x0400A582 RID: 42370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A583 RID: 42371
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E42 RID: 3650
		[ObfuscatedName("Common.UI.EllenShopDescriber+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010542 RID: 66882 RVA: 0x003CBFCC File Offset: 0x003CA1CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EllenShopDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr);
				EllenShopDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr, "<>9");
				EllenShopDescriber.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr, "<>9__4_0");
				EllenShopDescriber.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr, "<>9__4_4");
				EllenShopDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr, 100684637);
				EllenShopDescriber.__c.NativeMethodInfoPtr__Describe_b__4_0_Internal_Void_UIElementCluster_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr, 100684638);
				EllenShopDescriber.__c.NativeMethodInfoPtr__Describe_b__4_4_Internal_KeyValuePair_2_Recipe_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr, 100684639);
			}

			// Token: 0x06010543 RID: 66883 RVA: 0x003CC070 File Offset: 0x003CA270
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenShopDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010544 RID: 66884 RVA: 0x003CC0AC File Offset: 0x003CA2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262682, XrefRangeEnd = 262695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__4_0(UIElementCluster cluster, DLC5_EllenShopPanel.Currency currency)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currency));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c.NativeMethodInfoPtr__Describe_b__4_0_Internal_Void_UIElementCluster_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010545 RID: 66885 RVA: 0x003CC108 File Offset: 0x003CA308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262695, XrefRangeEnd = 262699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Recipe, int> _Describe_b__4_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EllenShopDescriber.__c.NativeMethodInfoPtr__Describe_b__4_4_Internal_KeyValuePair_2_Recipe_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Recipe, int>(pointer);
			}

			// Token: 0x06010546 RID: 66886 RVA: 0x0008E7C7 File Offset: 0x0008C9C7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005560 RID: 21856
			// (get) Token: 0x06010547 RID: 66887 RVA: 0x003CC14C File Offset: 0x003CA34C
			// (set) Token: 0x06010548 RID: 66888 RVA: 0x0008E7D0 File Offset: 0x0008C9D0
			public unsafe static EllenShopDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EllenShopDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EllenShopDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EllenShopDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005561 RID: 21857
			// (get) Token: 0x06010549 RID: 66889 RVA: 0x003CC174 File Offset: 0x003CA374
			// (set) Token: 0x0601054A RID: 66890 RVA: 0x0008E7E2 File Offset: 0x0008C9E2
			public unsafe static Action<UIElementCluster, DLC5_EllenShopPanel.Currency> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EllenShopDescriber.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster, DLC5_EllenShopPanel.Currency>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EllenShopDescriber.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005562 RID: 21858
			// (get) Token: 0x0601054B RID: 66891 RVA: 0x003CC19C File Offset: 0x003CA39C
			// (set) Token: 0x0601054C RID: 66892 RVA: 0x0008E7F4 File Offset: 0x0008C9F4
			public unsafe static Func<int, KeyValuePair<Recipe, int>> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EllenShopDescriber.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, KeyValuePair<Recipe, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EllenShopDescriber.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A584 RID: 42372
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A585 RID: 42373
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400A586 RID: 42374
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x0400A587 RID: 42375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A588 RID: 42376
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__4_0_Internal_Void_UIElementCluster_Currency_0;

			// Token: 0x0400A589 RID: 42377
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__4_4_Internal_KeyValuePair_2_Recipe_Int32_Int32_0;
		}
	}
}
