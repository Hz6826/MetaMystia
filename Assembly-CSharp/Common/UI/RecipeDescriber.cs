using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000366 RID: 870
	public class RecipeDescriber : SellableDescriber
	{
		// Token: 0x060066FC RID: 26364 RVA: 0x001F6608 File Offset: 0x001F4808
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeDescriber()
		{
			Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "RecipeDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr);
			RecipeDescriber.NativeFieldInfoPtr_ingredeintObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "ingredeintObjectParent");
			RecipeDescriber.NativeFieldInfoPtr_ingredientField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "ingredientField");
			RecipeDescriber.NativeFieldInfoPtr_cookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "cookTime");
			RecipeDescriber.NativeFieldInfoPtr_cookerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "cookerName");
			RecipeDescriber.NativeFieldInfoPtr_cookerVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "cookerVisual");
			RecipeDescriber.NativeFieldInfoPtr_recipeVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "recipeVisuals");
			RecipeDescriber.NativeFieldInfoPtr_ingredientObjectInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "ingredientObjectInstances");
			RecipeDescriber.NativeFieldInfoPtr_OnToggleToRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "OnToggleToRecipe");
			RecipeDescriber.NativeMethodInfoPtr_add_OnToggleToRecipe_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684850);
			RecipeDescriber.NativeMethodInfoPtr_remove_OnToggleToRecipe_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684851);
			RecipeDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Recipe_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684852);
			RecipeDescriber.NativeMethodInfoPtr_Describe_Public_Void_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684853);
			RecipeDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684854);
			RecipeDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684855);
			RecipeDescriber.NativeMethodInfoPtr_InitializeElement_Private_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684856);
			RecipeDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684857);
			RecipeDescriber.NativeMethodInfoPtr_ToggleVisualForRecipes_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684858);
			RecipeDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684859);
			RecipeDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, 100684860);
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x001F67B4 File Offset: 0x001F49B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265354, XrefRangeEnd = 265358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggleToRecipe(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.NativeMethodInfoPtr_add_OnToggleToRecipe_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x001F67F8 File Offset: 0x001F49F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265358, XrefRangeEnd = 265362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggleToRecipe(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.NativeMethodInfoPtr_remove_OnToggleToRecipe_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x001F683C File Offset: 0x001F4A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265362, XrefRangeEnd = 265363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Recipe detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Recipe_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x001F6898 File Offset: 0x001F4A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265389, RefRangeEnd = 265391, XrefRangeStart = 265363, XrefRangeEnd = 265389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(Recipe detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.NativeMethodInfoPtr_Describe_Public_Void_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x001F68DC File Offset: 0x001F4ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265391, XrefRangeEnd = 265413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x001F6918 File Offset: 0x001F4B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265413, XrefRangeEnd = 265426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x001F6954 File Offset: 0x001F4B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265426, XrefRangeEnd = 265447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeElement(UIElementCluster elements, int ingredient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.NativeMethodInfoPtr_InitializeElement_Private_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x001F69A4 File Offset: 0x001F4BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265447, XrefRangeEnd = 265466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x001F69E0 File Offset: 0x001F4BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265466, XrefRangeEnd = 265478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ToggleVisualForRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeDescriber.NativeMethodInfoPtr_ToggleVisualForRecipes_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x001F6A1C File Offset: 0x001F4C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265478, XrefRangeEnd = 265506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x001F6A58 File Offset: 0x001F4C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265506, XrefRangeEnd = 265542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecipeDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x00037959 File Offset: 0x00035B59
		public RecipeDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06006709 RID: 26377 RVA: 0x001F6A94 File Offset: 0x001F4C94
		// (set) Token: 0x0600670A RID: 26378 RVA: 0x00037962 File Offset: 0x00035B62
		public unsafe GameObject ingredeintObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_ingredeintObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_ingredeintObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600670B RID: 26379 RVA: 0x001F6AC4 File Offset: 0x001F4CC4
		// (set) Token: 0x0600670C RID: 26380 RVA: 0x00037981 File Offset: 0x00035B81
		public unsafe RectTransform ingredientField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_ingredientField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_ingredientField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600670D RID: 26381 RVA: 0x001F6AF4 File Offset: 0x001F4CF4
		// (set) Token: 0x0600670E RID: 26382 RVA: 0x000379A0 File Offset: 0x00035BA0
		public unsafe TextMeshProUGUI cookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_cookTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_cookTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0600670F RID: 26383 RVA: 0x001F6B24 File Offset: 0x001F4D24
		// (set) Token: 0x06006710 RID: 26384 RVA: 0x000379BF File Offset: 0x00035BBF
		public unsafe TextMeshProUGUI cookerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_cookerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_cookerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06006711 RID: 26385 RVA: 0x001F6B54 File Offset: 0x001F4D54
		// (set) Token: 0x06006712 RID: 26386 RVA: 0x000379DE File Offset: 0x00035BDE
		public unsafe Image cookerVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_cookerVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_cookerVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06006713 RID: 26387 RVA: 0x001F6B84 File Offset: 0x001F4D84
		// (set) Token: 0x06006714 RID: 26388 RVA: 0x000379FD File Offset: 0x00035BFD
		public unsafe Il2CppReferenceArray<GameObject> recipeVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_recipeVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_recipeVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06006715 RID: 26389 RVA: 0x001F6BB4 File Offset: 0x001F4DB4
		// (set) Token: 0x06006716 RID: 26390 RVA: 0x00037A1C File Offset: 0x00035C1C
		public unsafe List<GameObject> ingredientObjectInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_ingredientObjectInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_ingredientObjectInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06006717 RID: 26391 RVA: 0x001F6BE4 File Offset: 0x001F4DE4
		// (set) Token: 0x06006718 RID: 26392 RVA: 0x00037A3B File Offset: 0x00035C3B
		public unsafe Action OnToggleToRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_OnToggleToRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.NativeFieldInfoPtr_OnToggleToRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004451 RID: 17489
		private static readonly IntPtr NativeFieldInfoPtr_ingredeintObjectParent;

		// Token: 0x04004452 RID: 17490
		private static readonly IntPtr NativeFieldInfoPtr_ingredientField;

		// Token: 0x04004453 RID: 17491
		private static readonly IntPtr NativeFieldInfoPtr_cookTime;

		// Token: 0x04004454 RID: 17492
		private static readonly IntPtr NativeFieldInfoPtr_cookerName;

		// Token: 0x04004455 RID: 17493
		private static readonly IntPtr NativeFieldInfoPtr_cookerVisual;

		// Token: 0x04004456 RID: 17494
		private static readonly IntPtr NativeFieldInfoPtr_recipeVisuals;

		// Token: 0x04004457 RID: 17495
		private static readonly IntPtr NativeFieldInfoPtr_ingredientObjectInstances;

		// Token: 0x04004458 RID: 17496
		private static readonly IntPtr NativeFieldInfoPtr_OnToggleToRecipe;

		// Token: 0x04004459 RID: 17497
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggleToRecipe_Public_add_Void_Action_0;

		// Token: 0x0400445A RID: 17498
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggleToRecipe_Public_rem_Void_Action_0;

		// Token: 0x0400445B RID: 17499
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Recipe_CancellationToken_0;

		// Token: 0x0400445C RID: 17500
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_Recipe_0;

		// Token: 0x0400445D RID: 17501
		private static readonly IntPtr NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0;

		// Token: 0x0400445E RID: 17502
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0;

		// Token: 0x0400445F RID: 17503
		private static readonly IntPtr NativeMethodInfoPtr_InitializeElement_Private_Void_UIElementCluster_Int32_0;

		// Token: 0x04004460 RID: 17504
		private static readonly IntPtr NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0;

		// Token: 0x04004461 RID: 17505
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisualForRecipes_Public_Virtual_New_Void_0;

		// Token: 0x04004462 RID: 17506
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004463 RID: 17507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E5F RID: 3679
		[ObfuscatedName("Common.UI.RecipeDescriber+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x06010687 RID: 67207 RVA: 0x003CF8CC File Offset: 0x003CDACC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDescriber>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr);
				RecipeDescriber.__c__DisplayClass14_0.NativeFieldInfoPtr_ingredientText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr, "ingredientText");
				RecipeDescriber.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr, 100684861);
				RecipeDescriber.__c__DisplayClass14_0.NativeMethodInfoPtr__InitializeElement_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr, 100684862);
				RecipeDescriber.__c__DisplayClass14_0.NativeMethodInfoPtr__InitializeElement_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr, 100684863);
			}

			// Token: 0x06010688 RID: 67208 RVA: 0x003CF948 File Offset: 0x003CDB48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDescriber.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010689 RID: 67209 RVA: 0x003CF984 File Offset: 0x003CDB84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeElement_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.__c__DisplayClass14_0.NativeMethodInfoPtr__InitializeElement_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601068A RID: 67210 RVA: 0x003CF9C8 File Offset: 0x003CDBC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeElement_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeDescriber.__c__DisplayClass14_0.NativeMethodInfoPtr__InitializeElement_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601068B RID: 67211 RVA: 0x0008F2D7 File Offset: 0x0008D4D7
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055BF RID: 21951
			// (get) Token: 0x0601068C RID: 67212 RVA: 0x003CFA0C File Offset: 0x003CDC0C
			// (set) Token: 0x0601068D RID: 67213 RVA: 0x0008F2E0 File Offset: 0x0008D4E0
			public unsafe ObjectLanguageBase ingredientText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.__c__DisplayClass14_0.NativeFieldInfoPtr_ingredientText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeDescriber.__c__DisplayClass14_0.NativeFieldInfoPtr_ingredientText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A639 RID: 42553
			private static readonly IntPtr NativeFieldInfoPtr_ingredientText;

			// Token: 0x0400A63A RID: 42554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A63B RID: 42555
			private static readonly IntPtr NativeMethodInfoPtr__InitializeElement_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A63C RID: 42556
			private static readonly IntPtr NativeMethodInfoPtr__InitializeElement_b__1_Internal_Void_Image_0;
		}
	}
}
