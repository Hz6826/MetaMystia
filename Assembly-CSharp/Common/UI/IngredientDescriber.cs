using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x0200035D RID: 861
	public class IngredientDescriber : ObjectLanguageBaseDescriber
	{
		// Token: 0x060065D1 RID: 26065 RVA: 0x001F27B8 File Offset: 0x001F09B8
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientDescriber()
		{
			Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "IngredientDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr);
			IngredientDescriber.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "price");
			IngredientDescriber.NativeFieldInfoPtr_doNotDescribePriceSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "doNotDescribePriceSymbol");
			IngredientDescriber.NativeFieldInfoPtr_tradableLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "tradableLevel");
			IngredientDescriber.NativeFieldInfoPtr_ingredientTagObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "ingredientTagObjectParent");
			IngredientDescriber.NativeFieldInfoPtr_tagField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "tagField");
			IngredientDescriber.NativeFieldInfoPtr_ingredientVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "ingredientVisuals");
			IngredientDescriber.NativeFieldInfoPtr_ingredientTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "ingredientTagInstances");
			IngredientDescriber.NativeFieldInfoPtr_OnToggleToIngredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "OnToggleToIngredient");
			IngredientDescriber.NativeMethodInfoPtr_add_OnToggleToIngredient_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684640);
			IngredientDescriber.NativeMethodInfoPtr_remove_OnToggleToIngredient_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684641);
			IngredientDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684642);
			IngredientDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684643);
			IngredientDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Ingredient_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684644);
			IngredientDescriber.NativeMethodInfoPtr_Describe_Public_Void_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684645);
			IngredientDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684646);
			IngredientDescriber.NativeMethodInfoPtr_ToggleVisualForIngredient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684647);
			IngredientDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684648);
			IngredientDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, 100684649);
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x001F2950 File Offset: 0x001F0B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262822, XrefRangeEnd = 262826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggleToIngredient(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.NativeMethodInfoPtr_add_OnToggleToIngredient_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x001F2994 File Offset: 0x001F0B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262826, XrefRangeEnd = 262830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggleToIngredient(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.NativeMethodInfoPtr_remove_OnToggleToIngredient_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x001F29D8 File Offset: 0x001F0BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262835, RefRangeEnd = 262837, XrefRangeStart = 262830, XrefRangeEnd = 262835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x001F2A14 File Offset: 0x001F0C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262842, RefRangeEnd = 262844, XrefRangeStart = 262837, XrefRangeEnd = 262842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x001F2A50 File Offset: 0x001F0C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262844, XrefRangeEnd = 262845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Ingredient detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Ingredient_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x001F2AAC File Offset: 0x001F0CAC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 262883, RefRangeEnd = 262895, XrefRangeStart = 262845, XrefRangeEnd = 262883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(Ingredient detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.NativeMethodInfoPtr_Describe_Public_Void_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x001F2AF0 File Offset: 0x001F0CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262908, RefRangeEnd = 262910, XrefRangeStart = 262895, XrefRangeEnd = 262908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x001F2B2C File Offset: 0x001F0D2C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 262919, RefRangeEnd = 262930, XrefRangeStart = 262910, XrefRangeEnd = 262919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleVisualForIngredient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.NativeMethodInfoPtr_ToggleVisualForIngredient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x001F2B60 File Offset: 0x001F0D60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262940, RefRangeEnd = 262942, XrefRangeStart = 262930, XrefRangeEnd = 262940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x001F2B9C File Offset: 0x001F0D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262951, RefRangeEnd = 262953, XrefRangeStart = 262942, XrefRangeEnd = 262951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x00037005 File Offset: 0x00035205
		public IngredientDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x060065DD RID: 26077 RVA: 0x001F2BD8 File Offset: 0x001F0DD8
		// (set) Token: 0x060065DE RID: 26078 RVA: 0x0003700E File Offset: 0x0003520E
		public unsafe TextMeshProUGUI price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_price);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_price), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x001F2C08 File Offset: 0x001F0E08
		// (set) Token: 0x060065E0 RID: 26080 RVA: 0x0003702D File Offset: 0x0003522D
		public unsafe bool doNotDescribePriceSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_doNotDescribePriceSymbol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_doNotDescribePriceSymbol)) = value;
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x060065E1 RID: 26081 RVA: 0x001F2C30 File Offset: 0x001F0E30
		// (set) Token: 0x060065E2 RID: 26082 RVA: 0x00037048 File Offset: 0x00035248
		public unsafe TextMeshProUGUI tradableLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_tradableLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_tradableLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x060065E3 RID: 26083 RVA: 0x001F2C60 File Offset: 0x001F0E60
		// (set) Token: 0x060065E4 RID: 26084 RVA: 0x00037067 File Offset: 0x00035267
		public unsafe GameObject ingredientTagObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_ingredientTagObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_ingredientTagObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x060065E5 RID: 26085 RVA: 0x001F2C90 File Offset: 0x001F0E90
		// (set) Token: 0x060065E6 RID: 26086 RVA: 0x00037086 File Offset: 0x00035286
		public unsafe RectTransform tagField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_tagField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_tagField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x060065E7 RID: 26087 RVA: 0x001F2CC0 File Offset: 0x001F0EC0
		// (set) Token: 0x060065E8 RID: 26088 RVA: 0x000370A5 File Offset: 0x000352A5
		public unsafe Il2CppReferenceArray<GameObject> ingredientVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_ingredientVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_ingredientVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x060065E9 RID: 26089 RVA: 0x001F2CF0 File Offset: 0x001F0EF0
		// (set) Token: 0x060065EA RID: 26090 RVA: 0x000370C4 File Offset: 0x000352C4
		public unsafe List<GameObject> ingredientTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_ingredientTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_ingredientTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x001F2D20 File Offset: 0x001F0F20
		// (set) Token: 0x060065EC RID: 26092 RVA: 0x000370E3 File Offset: 0x000352E3
		public unsafe Action OnToggleToIngredient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_OnToggleToIngredient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.NativeFieldInfoPtr_OnToggleToIngredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400438C RID: 17292
		private static readonly IntPtr NativeFieldInfoPtr_price;

		// Token: 0x0400438D RID: 17293
		private static readonly IntPtr NativeFieldInfoPtr_doNotDescribePriceSymbol;

		// Token: 0x0400438E RID: 17294
		private static readonly IntPtr NativeFieldInfoPtr_tradableLevel;

		// Token: 0x0400438F RID: 17295
		private static readonly IntPtr NativeFieldInfoPtr_ingredientTagObjectParent;

		// Token: 0x04004390 RID: 17296
		private static readonly IntPtr NativeFieldInfoPtr_tagField;

		// Token: 0x04004391 RID: 17297
		private static readonly IntPtr NativeFieldInfoPtr_ingredientVisuals;

		// Token: 0x04004392 RID: 17298
		private static readonly IntPtr NativeFieldInfoPtr_ingredientTagInstances;

		// Token: 0x04004393 RID: 17299
		private static readonly IntPtr NativeFieldInfoPtr_OnToggleToIngredient;

		// Token: 0x04004394 RID: 17300
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggleToIngredient_Public_add_Void_Action_0;

		// Token: 0x04004395 RID: 17301
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggleToIngredient_Public_rem_Void_Action_0;

		// Token: 0x04004396 RID: 17302
		private static readonly IntPtr NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0;

		// Token: 0x04004397 RID: 17303
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004398 RID: 17304
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Ingredient_CancellationToken_0;

		// Token: 0x04004399 RID: 17305
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_Ingredient_0;

		// Token: 0x0400439A RID: 17306
		private static readonly IntPtr NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0;

		// Token: 0x0400439B RID: 17307
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisualForIngredient_Public_Void_0;

		// Token: 0x0400439C RID: 17308
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400439D RID: 17309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E43 RID: 3651
		[ObfuscatedName("Common.UI.IngredientDescriber+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0601054D RID: 66893 RVA: 0x003CC1C4 File Offset: 0x003CA3C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<IngredientDescriber.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientDescriber.__c__DisplayClass13_0>.NativeClassPtr);
				IngredientDescriber.__c__DisplayClass13_0.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber.__c__DisplayClass13_0>.NativeClassPtr, "tagId");
				IngredientDescriber.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber.__c__DisplayClass13_0>.NativeClassPtr, 100684650);
				IngredientDescriber.__c__DisplayClass13_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber.__c__DisplayClass13_0>.NativeClassPtr, 100684651);
			}

			// Token: 0x0601054E RID: 66894 RVA: 0x003CC22C File Offset: 0x003CA42C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientDescriber.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601054F RID: 66895 RVA: 0x003CC268 File Offset: 0x003CA468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262808, XrefRangeEnd = 262810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.__c__DisplayClass13_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010550 RID: 66896 RVA: 0x0008E806 File Offset: 0x0008CA06
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005563 RID: 21859
			// (get) Token: 0x06010551 RID: 66897 RVA: 0x003CC2AC File Offset: 0x003CA4AC
			// (set) Token: 0x06010552 RID: 66898 RVA: 0x0008E80F File Offset: 0x0008CA0F
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.__c__DisplayClass13_0.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientDescriber.__c__DisplayClass13_0.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x0400A58A RID: 42378
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x0400A58B RID: 42379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A58C RID: 42380
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E44 RID: 3652
		[ObfuscatedName("Common.UI.IngredientDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010553 RID: 66899 RVA: 0x003CC2D4 File Offset: 0x003CA4D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IngredientDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr);
				IngredientDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr, "<>9");
				IngredientDescriber.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr, "<>9__13_0");
				IngredientDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr, 100684653);
				IngredientDescriber.__c.NativeMethodInfoPtr__Describe_b__13_0_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr, 100684654);
			}

			// Token: 0x06010554 RID: 66900 RVA: 0x003CC350 File Offset: 0x003CA550
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010555 RID: 66901 RVA: 0x003CC38C File Offset: 0x003CA58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262810, XrefRangeEnd = 262822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__13_0(UIElementCluster interactableBase, int tagId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactableBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientDescriber.__c.NativeMethodInfoPtr__Describe_b__13_0_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010556 RID: 66902 RVA: 0x0008E82A File Offset: 0x0008CA2A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005564 RID: 21860
			// (get) Token: 0x06010557 RID: 66903 RVA: 0x003CC3DC File Offset: 0x003CA5DC
			// (set) Token: 0x06010558 RID: 66904 RVA: 0x0008E833 File Offset: 0x0008CA33
			public unsafe static IngredientDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IngredientDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IngredientDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IngredientDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005565 RID: 21861
			// (get) Token: 0x06010559 RID: 66905 RVA: 0x003CC404 File Offset: 0x003CA604
			// (set) Token: 0x0601055A RID: 66906 RVA: 0x0008E845 File Offset: 0x0008CA45
			public unsafe static Action<UIElementCluster, int> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IngredientDescriber.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IngredientDescriber.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A58D RID: 42381
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A58E RID: 42382
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400A58F RID: 42383
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A590 RID: 42384
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__13_0_Internal_Void_UIElementCluster_Int32_0;
		}
	}
}
