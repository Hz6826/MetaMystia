using System;
using DEYU.UniversalUISystem;
using GameData.Core;
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
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000367 RID: 871
	public class SellableDescriber : IngredientDescriber
	{
		// Token: 0x06006719 RID: 26393 RVA: 0x001F6C14 File Offset: 0x001F4E14
		// Note: this type is marked as 'beforefieldinit'.
		static SellableDescriber()
		{
			Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "SellableDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr);
			SellableDescriber.NativeFieldInfoPtr_foodTagObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "foodTagObjectParent");
			SellableDescriber.NativeFieldInfoPtr_bevTagObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "bevTagObjectParent");
			SellableDescriber.NativeFieldInfoPtr_bannedTagObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "bannedTagObjectParent");
			SellableDescriber.NativeFieldInfoPtr_addedTagObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "addedTagObjectParent");
			SellableDescriber.NativeFieldInfoPtr_removedTagObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "removedTagObjectParent");
			SellableDescriber.NativeFieldInfoPtr_addModifyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "addModifyParent");
			SellableDescriber.NativeFieldInfoPtr_sellableVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "sellableVisuals");
			SellableDescriber.NativeFieldInfoPtr_addedTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "addedTagInstances");
			SellableDescriber.NativeFieldInfoPtr_banTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "banTagInstances");
			SellableDescriber.NativeFieldInfoPtr_bevTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "bevTagInstances");
			SellableDescriber.NativeFieldInfoPtr_foodTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "foodTagInstances");
			SellableDescriber.NativeFieldInfoPtr_removedTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "removedTagInstances");
			SellableDescriber.NativeFieldInfoPtr_poolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "poolType");
			SellableDescriber.NativeFieldInfoPtr_m_IsSellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "m_IsSellable");
			SellableDescriber.NativeFieldInfoPtr_OnToggleToSellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "OnToggleToSellable");
			SellableDescriber.NativeMethodInfoPtr_add_OnToggleToSellable_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684864);
			SellableDescriber.NativeMethodInfoPtr_remove_OnToggleToSellable_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684865);
			SellableDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684866);
			SellableDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684867);
			SellableDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Sellable_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684868);
			SellableDescriber.NativeMethodInfoPtr_Describe_Public_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684869);
			SellableDescriber.NativeMethodInfoPtr_Describe_Public_Void_Sellable_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684870);
			SellableDescriber.NativeMethodInfoPtr_DescribeRecipe_Public_Void_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684871);
			SellableDescriber.NativeMethodInfoPtr_ShowSellableProperty_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684872);
			SellableDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684873);
			SellableDescriber.NativeMethodInfoPtr_ToggleVisualForSellables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684874);
			SellableDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_TradableObjectBase_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684875);
			SellableDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684876);
			SellableDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, 100684877);
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x001F6E88 File Offset: 0x001F5088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265624, RefRangeEnd = 265625, XrefRangeStart = 265620, XrefRangeEnd = 265624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggleToSellable(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_add_OnToggleToSellable_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x001F6ECC File Offset: 0x001F50CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265625, XrefRangeEnd = 265629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggleToSellable(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_remove_OnToggleToSellable_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x001F6F10 File Offset: 0x001F5110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265629, XrefRangeEnd = 265647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SellableDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x001F6F4C File Offset: 0x001F514C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265647, XrefRangeEnd = 265656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SellableDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x001F6F88 File Offset: 0x001F5188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265656, XrefRangeEnd = 265657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Sellable detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Sellable_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x001F6FE4 File Offset: 0x001F51E4
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 265668, RefRangeEnd = 265717, XrefRangeStart = 265657, XrefRangeEnd = 265668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(Sellable detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_Describe_Public_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x001F7028 File Offset: 0x001F5228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265727, RefRangeEnd = 265728, XrefRangeStart = 265717, XrefRangeEnd = 265727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(Sellable detail, Sprite bgSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgSprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_Describe_Public_Void_Sellable_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x001F707C File Offset: 0x001F527C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265734, RefRangeEnd = 265737, XrefRangeStart = 265728, XrefRangeEnd = 265734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeRecipe(Recipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_DescribeRecipe_Public_Void_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x001F70C0 File Offset: 0x001F52C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265825, RefRangeEnd = 265828, XrefRangeStart = 265737, XrefRangeEnd = 265825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowSellableProperty(Sellable detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_ShowSellableProperty_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x001F7104 File Offset: 0x001F5304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265828, XrefRangeEnd = 265843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SellableDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x001F7140 File Offset: 0x001F5340
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 265852, RefRangeEnd = 265892, XrefRangeStart = 265843, XrefRangeEnd = 265852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleVisualForSellables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_ToggleVisualForSellables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x001F7174 File Offset: 0x001F5374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265892, XrefRangeEnd = 265911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(TradableObjectBase data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_TradableObjectBase_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x001F71D0 File Offset: 0x001F53D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265931, RefRangeEnd = 265932, XrefRangeStart = 265911, XrefRangeEnd = 265931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SellableDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x001F720C File Offset: 0x001F540C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265961, RefRangeEnd = 265963, XrefRangeStart = 265932, XrefRangeEnd = 265961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SellableDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x00037A5A File Offset: 0x00035C5A
		public SellableDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06006729 RID: 26409 RVA: 0x001F7248 File Offset: 0x001F5448
		// (set) Token: 0x0600672A RID: 26410 RVA: 0x00037A63 File Offset: 0x00035C63
		public unsafe GameObject foodTagObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_foodTagObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_foodTagObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x0600672B RID: 26411 RVA: 0x001F7278 File Offset: 0x001F5478
		// (set) Token: 0x0600672C RID: 26412 RVA: 0x00037A82 File Offset: 0x00035C82
		public unsafe GameObject bevTagObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_bevTagObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_bevTagObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x0600672D RID: 26413 RVA: 0x001F72A8 File Offset: 0x001F54A8
		// (set) Token: 0x0600672E RID: 26414 RVA: 0x00037AA1 File Offset: 0x00035CA1
		public unsafe GameObject bannedTagObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_bannedTagObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_bannedTagObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0600672F RID: 26415 RVA: 0x001F72D8 File Offset: 0x001F54D8
		// (set) Token: 0x06006730 RID: 26416 RVA: 0x00037AC0 File Offset: 0x00035CC0
		public unsafe GameObject addedTagObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_addedTagObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_addedTagObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06006731 RID: 26417 RVA: 0x001F7308 File Offset: 0x001F5508
		// (set) Token: 0x06006732 RID: 26418 RVA: 0x00037ADF File Offset: 0x00035CDF
		public unsafe GameObject removedTagObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_removedTagObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_removedTagObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x001F7338 File Offset: 0x001F5538
		// (set) Token: 0x06006734 RID: 26420 RVA: 0x00037AFE File Offset: 0x00035CFE
		public unsafe Image addModifyParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_addModifyParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_addModifyParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x001F7368 File Offset: 0x001F5568
		// (set) Token: 0x06006736 RID: 26422 RVA: 0x00037B1D File Offset: 0x00035D1D
		public unsafe Il2CppReferenceArray<GameObject> sellableVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_sellableVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_sellableVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x06006737 RID: 26423 RVA: 0x001F7398 File Offset: 0x001F5598
		// (set) Token: 0x06006738 RID: 26424 RVA: 0x00037B3C File Offset: 0x00035D3C
		public unsafe List<GameObject> addedTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_addedTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_addedTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x06006739 RID: 26425 RVA: 0x001F73C8 File Offset: 0x001F55C8
		// (set) Token: 0x0600673A RID: 26426 RVA: 0x00037B5B File Offset: 0x00035D5B
		public unsafe List<GameObject> banTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_banTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_banTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x0600673B RID: 26427 RVA: 0x001F73F8 File Offset: 0x001F55F8
		// (set) Token: 0x0600673C RID: 26428 RVA: 0x00037B7A File Offset: 0x00035D7A
		public unsafe List<GameObject> bevTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_bevTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_bevTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x0600673D RID: 26429 RVA: 0x001F7428 File Offset: 0x001F5628
		// (set) Token: 0x0600673E RID: 26430 RVA: 0x00037B99 File Offset: 0x00035D99
		public unsafe List<GameObject> foodTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_foodTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_foodTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x001F7458 File Offset: 0x001F5658
		// (set) Token: 0x06006740 RID: 26432 RVA: 0x00037BB8 File Offset: 0x00035DB8
		public unsafe List<GameObject> removedTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_removedTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_removedTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06006741 RID: 26433 RVA: 0x001F7488 File Offset: 0x001F5688
		// (set) Token: 0x06006742 RID: 26434 RVA: 0x00037BD7 File Offset: 0x00035DD7
		public unsafe Sellable.SellableType poolType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_poolType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_poolType)) = value;
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x001F74B0 File Offset: 0x001F56B0
		// (set) Token: 0x06006744 RID: 26436 RVA: 0x00037BF2 File Offset: 0x00035DF2
		public unsafe bool m_IsSellable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_m_IsSellable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_m_IsSellable)) = value;
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x001F74D8 File Offset: 0x001F56D8
		// (set) Token: 0x06006746 RID: 26438 RVA: 0x00037C0D File Offset: 0x00035E0D
		public unsafe Action OnToggleToSellable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_OnToggleToSellable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.NativeFieldInfoPtr_OnToggleToSellable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004464 RID: 17508
		private static readonly IntPtr NativeFieldInfoPtr_foodTagObjectParent;

		// Token: 0x04004465 RID: 17509
		private static readonly IntPtr NativeFieldInfoPtr_bevTagObjectParent;

		// Token: 0x04004466 RID: 17510
		private static readonly IntPtr NativeFieldInfoPtr_bannedTagObjectParent;

		// Token: 0x04004467 RID: 17511
		private static readonly IntPtr NativeFieldInfoPtr_addedTagObjectParent;

		// Token: 0x04004468 RID: 17512
		private static readonly IntPtr NativeFieldInfoPtr_removedTagObjectParent;

		// Token: 0x04004469 RID: 17513
		private static readonly IntPtr NativeFieldInfoPtr_addModifyParent;

		// Token: 0x0400446A RID: 17514
		private static readonly IntPtr NativeFieldInfoPtr_sellableVisuals;

		// Token: 0x0400446B RID: 17515
		private static readonly IntPtr NativeFieldInfoPtr_addedTagInstances;

		// Token: 0x0400446C RID: 17516
		private static readonly IntPtr NativeFieldInfoPtr_banTagInstances;

		// Token: 0x0400446D RID: 17517
		private static readonly IntPtr NativeFieldInfoPtr_bevTagInstances;

		// Token: 0x0400446E RID: 17518
		private static readonly IntPtr NativeFieldInfoPtr_foodTagInstances;

		// Token: 0x0400446F RID: 17519
		private static readonly IntPtr NativeFieldInfoPtr_removedTagInstances;

		// Token: 0x04004470 RID: 17520
		private static readonly IntPtr NativeFieldInfoPtr_poolType;

		// Token: 0x04004471 RID: 17521
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSellable;

		// Token: 0x04004472 RID: 17522
		private static readonly IntPtr NativeFieldInfoPtr_OnToggleToSellable;

		// Token: 0x04004473 RID: 17523
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggleToSellable_Public_add_Void_Action_0;

		// Token: 0x04004474 RID: 17524
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggleToSellable_Public_rem_Void_Action_0;

		// Token: 0x04004475 RID: 17525
		private static readonly IntPtr NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0;

		// Token: 0x04004476 RID: 17526
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004477 RID: 17527
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Sellable_CancellationToken_0;

		// Token: 0x04004478 RID: 17528
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_Sellable_0;

		// Token: 0x04004479 RID: 17529
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_Sellable_Sprite_0;

		// Token: 0x0400447A RID: 17530
		private static readonly IntPtr NativeMethodInfoPtr_DescribeRecipe_Public_Void_Recipe_0;

		// Token: 0x0400447B RID: 17531
		private static readonly IntPtr NativeMethodInfoPtr_ShowSellableProperty_Private_Void_Sellable_0;

		// Token: 0x0400447C RID: 17532
		private static readonly IntPtr NativeMethodInfoPtr_HideElements_Protected_Virtual_Void_0;

		// Token: 0x0400447D RID: 17533
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisualForSellables_Public_Void_0;

		// Token: 0x0400447E RID: 17534
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_TradableObjectBase_CancellationToken_0;

		// Token: 0x0400447F RID: 17535
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004480 RID: 17536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E60 RID: 3680
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0601068E RID: 67214 RVA: 0x003CFA3C File Offset: 0x003CDC3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_0.NativeFieldInfoPtr_getTagNameMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, "getTagNameMethod");
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684878);
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__2_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684879);
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__3_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684880);
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__4_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684881);
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__5_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684882);
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__0_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684883);
				SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__1_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100684884);
			}

			// Token: 0x0601068F RID: 67215 RVA: 0x003CFB08 File Offset: 0x003CDD08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010690 RID: 67216 RVA: 0x003CFB44 File Offset: 0x003CDD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265542, XrefRangeEnd = 265555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__2(UIElementCluster iBase, int tags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__2_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010691 RID: 67217 RVA: 0x003CFB94 File Offset: 0x003CDD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265555, XrefRangeEnd = 265568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__3(UIElementCluster iBase, int tags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__3_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010692 RID: 67218 RVA: 0x003CFBE4 File Offset: 0x003CDDE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265568, XrefRangeEnd = 265581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__4(UIElementCluster iBase, int tags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__4_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010693 RID: 67219 RVA: 0x003CFC34 File Offset: 0x003CDE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265581, XrefRangeEnd = 265594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__5(UIElementCluster iBase, int tags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__5_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010694 RID: 67220 RVA: 0x003CFC84 File Offset: 0x003CDE84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265594, XrefRangeEnd = 265607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__0(UIElementCluster iBase, int tags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__0_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010695 RID: 67221 RVA: 0x003CFCD4 File Offset: 0x003CDED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265607, XrefRangeEnd = 265620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__1(UIElementCluster iBase, int tags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ShowSellableProperty_b__1_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010696 RID: 67222 RVA: 0x0008F2FF File Offset: 0x0008D4FF
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055C0 RID: 21952
			// (get) Token: 0x06010697 RID: 67223 RVA: 0x003CFD24 File Offset: 0x003CDF24
			// (set) Token: 0x06010698 RID: 67224 RVA: 0x0008F308 File Offset: 0x0008D508
			public unsafe Func<int, string> getTagNameMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_0.NativeFieldInfoPtr_getTagNameMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_0.NativeFieldInfoPtr_getTagNameMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A63D RID: 42557
			private static readonly IntPtr NativeFieldInfoPtr_getTagNameMethod;

			// Token: 0x0400A63E RID: 42558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A63F RID: 42559
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__2_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A640 RID: 42560
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__3_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A641 RID: 42561
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__4_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A642 RID: 42562
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__5_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A643 RID: 42563
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__0_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A644 RID: 42564
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__1_Internal_Void_UIElementCluster_Int32_0;
		}

		// Token: 0x02000E61 RID: 3681
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_1")]
		public sealed class __c__DisplayClass23_1 : Il2CppSystem.Object
		{
			// Token: 0x06010699 RID: 67225 RVA: 0x003CFD54 File Offset: 0x003CDF54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_1()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_1.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr, "tags");
				SellableDescriber.__c__DisplayClass23_1.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr, "CS$<>8__locals1");
				SellableDescriber.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr, 100684885);
				SellableDescriber.__c__DisplayClass23_1.NativeMethodInfoPtr__ShowSellableProperty_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr, 100684886);
			}

			// Token: 0x0601069A RID: 67226 RVA: 0x003CFDD0 File Offset: 0x003CDFD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601069B RID: 67227 RVA: 0x003CFE0C File Offset: 0x003CE00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_1.NativeMethodInfoPtr__ShowSellableProperty_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601069C RID: 67228 RVA: 0x0008F327 File Offset: 0x0008D527
			public __c__DisplayClass23_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055C1 RID: 21953
			// (get) Token: 0x0601069D RID: 67229 RVA: 0x003CFE50 File Offset: 0x003CE050
			// (set) Token: 0x0601069E RID: 67230 RVA: 0x0008F330 File Offset: 0x0008D530
			public unsafe int tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_1.NativeFieldInfoPtr_tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_1.NativeFieldInfoPtr_tags)) = value;
				}
			}

			// Token: 0x170055C2 RID: 21954
			// (get) Token: 0x0601069F RID: 67231 RVA: 0x003CFE78 File Offset: 0x003CE078
			// (set) Token: 0x060106A0 RID: 67232 RVA: 0x0008F34B File Offset: 0x0008D54B
			public unsafe SellableDescriber.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_1.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_1.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A645 RID: 42565
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400A646 RID: 42566
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x0400A647 RID: 42567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A648 RID: 42568
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__6_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E62 RID: 3682
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_2")]
		public sealed class __c__DisplayClass23_2 : Il2CppSystem.Object
		{
			// Token: 0x060106A1 RID: 67233 RVA: 0x003CFEA8 File Offset: 0x003CE0A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_2()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_2.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr, "tags");
				SellableDescriber.__c__DisplayClass23_2.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr, "CS$<>8__locals2");
				SellableDescriber.__c__DisplayClass23_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr, 100684887);
				SellableDescriber.__c__DisplayClass23_2.NativeMethodInfoPtr__ShowSellableProperty_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr, 100684888);
			}

			// Token: 0x060106A2 RID: 67234 RVA: 0x003CFF24 File Offset: 0x003CE124
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106A3 RID: 67235 RVA: 0x003CFF60 File Offset: 0x003CE160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_2.NativeMethodInfoPtr__ShowSellableProperty_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106A4 RID: 67236 RVA: 0x0008F36A File Offset: 0x0008D56A
			public __c__DisplayClass23_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055C3 RID: 21955
			// (get) Token: 0x060106A5 RID: 67237 RVA: 0x003CFFA4 File Offset: 0x003CE1A4
			// (set) Token: 0x060106A6 RID: 67238 RVA: 0x0008F373 File Offset: 0x0008D573
			public unsafe int tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_2.NativeFieldInfoPtr_tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_2.NativeFieldInfoPtr_tags)) = value;
				}
			}

			// Token: 0x170055C4 RID: 21956
			// (get) Token: 0x060106A7 RID: 67239 RVA: 0x003CFFCC File Offset: 0x003CE1CC
			// (set) Token: 0x060106A8 RID: 67240 RVA: 0x0008F38E File Offset: 0x0008D58E
			public unsafe SellableDescriber.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_2.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_2.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A649 RID: 42569
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400A64A RID: 42570
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x0400A64B RID: 42571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A64C RID: 42572
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__7_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E63 RID: 3683
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_3")]
		public sealed class __c__DisplayClass23_3 : Il2CppSystem.Object
		{
			// Token: 0x060106A9 RID: 67241 RVA: 0x003CFFFC File Offset: 0x003CE1FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_3()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_3.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr, "tags");
				SellableDescriber.__c__DisplayClass23_3.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr, "CS$<>8__locals3");
				SellableDescriber.__c__DisplayClass23_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr, 100684889);
				SellableDescriber.__c__DisplayClass23_3.NativeMethodInfoPtr__ShowSellableProperty_b__8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr, 100684890);
			}

			// Token: 0x060106AA RID: 67242 RVA: 0x003D0078 File Offset: 0x003CE278
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106AB RID: 67243 RVA: 0x003D00B4 File Offset: 0x003CE2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_3.NativeMethodInfoPtr__ShowSellableProperty_b__8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106AC RID: 67244 RVA: 0x0008F3AD File Offset: 0x0008D5AD
			public __c__DisplayClass23_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055C5 RID: 21957
			// (get) Token: 0x060106AD RID: 67245 RVA: 0x003D00F8 File Offset: 0x003CE2F8
			// (set) Token: 0x060106AE RID: 67246 RVA: 0x0008F3B6 File Offset: 0x0008D5B6
			public unsafe int tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_3.NativeFieldInfoPtr_tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_3.NativeFieldInfoPtr_tags)) = value;
				}
			}

			// Token: 0x170055C6 RID: 21958
			// (get) Token: 0x060106AF RID: 67247 RVA: 0x003D0120 File Offset: 0x003CE320
			// (set) Token: 0x060106B0 RID: 67248 RVA: 0x0008F3D1 File Offset: 0x0008D5D1
			public unsafe SellableDescriber.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_3.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_3.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A64D RID: 42573
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400A64E RID: 42574
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x0400A64F RID: 42575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A650 RID: 42576
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__8_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E64 RID: 3684
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_4")]
		public sealed class __c__DisplayClass23_4 : Il2CppSystem.Object
		{
			// Token: 0x060106B1 RID: 67249 RVA: 0x003D0150 File Offset: 0x003CE350
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_4()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_4.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr, "tags");
				SellableDescriber.__c__DisplayClass23_4.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr, "CS$<>8__locals4");
				SellableDescriber.__c__DisplayClass23_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr, 100684891);
				SellableDescriber.__c__DisplayClass23_4.NativeMethodInfoPtr__ShowSellableProperty_b__9_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr, 100684892);
			}

			// Token: 0x060106B2 RID: 67250 RVA: 0x003D01CC File Offset: 0x003CE3CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106B3 RID: 67251 RVA: 0x003D0208 File Offset: 0x003CE408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__9(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_4.NativeMethodInfoPtr__ShowSellableProperty_b__9_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106B4 RID: 67252 RVA: 0x0008F3F0 File Offset: 0x0008D5F0
			public __c__DisplayClass23_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055C7 RID: 21959
			// (get) Token: 0x060106B5 RID: 67253 RVA: 0x003D024C File Offset: 0x003CE44C
			// (set) Token: 0x060106B6 RID: 67254 RVA: 0x0008F3F9 File Offset: 0x0008D5F9
			public unsafe int tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_4.NativeFieldInfoPtr_tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_4.NativeFieldInfoPtr_tags)) = value;
				}
			}

			// Token: 0x170055C8 RID: 21960
			// (get) Token: 0x060106B7 RID: 67255 RVA: 0x003D0274 File Offset: 0x003CE474
			// (set) Token: 0x060106B8 RID: 67256 RVA: 0x0008F414 File Offset: 0x0008D614
			public unsafe SellableDescriber.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_4.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_4.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A651 RID: 42577
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400A652 RID: 42578
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x0400A653 RID: 42579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A654 RID: 42580
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__9_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E65 RID: 3685
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_5")]
		public sealed class __c__DisplayClass23_5 : Il2CppSystem.Object
		{
			// Token: 0x060106B9 RID: 67257 RVA: 0x003D02A4 File Offset: 0x003CE4A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_5()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_5.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr, "tags");
				SellableDescriber.__c__DisplayClass23_5.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr, "CS$<>8__locals5");
				SellableDescriber.__c__DisplayClass23_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr, 100684893);
				SellableDescriber.__c__DisplayClass23_5.NativeMethodInfoPtr__ShowSellableProperty_b__10_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr, 100684894);
			}

			// Token: 0x060106BA RID: 67258 RVA: 0x003D0320 File Offset: 0x003CE520
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106BB RID: 67259 RVA: 0x003D035C File Offset: 0x003CE55C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__10(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_5.NativeMethodInfoPtr__ShowSellableProperty_b__10_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106BC RID: 67260 RVA: 0x0008F433 File Offset: 0x0008D633
			public __c__DisplayClass23_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055C9 RID: 21961
			// (get) Token: 0x060106BD RID: 67261 RVA: 0x003D03A0 File Offset: 0x003CE5A0
			// (set) Token: 0x060106BE RID: 67262 RVA: 0x0008F43C File Offset: 0x0008D63C
			public unsafe int tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_5.NativeFieldInfoPtr_tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_5.NativeFieldInfoPtr_tags)) = value;
				}
			}

			// Token: 0x170055CA RID: 21962
			// (get) Token: 0x060106BF RID: 67263 RVA: 0x003D03C8 File Offset: 0x003CE5C8
			// (set) Token: 0x060106C0 RID: 67264 RVA: 0x0008F457 File Offset: 0x0008D657
			public unsafe SellableDescriber.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_5.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_5.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A655 RID: 42581
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400A656 RID: 42582
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x0400A657 RID: 42583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A658 RID: 42584
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__10_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E66 RID: 3686
		[ObfuscatedName("Common.UI.SellableDescriber+<>c__DisplayClass23_6")]
		public sealed class __c__DisplayClass23_6 : Il2CppSystem.Object
		{
			// Token: 0x060106C1 RID: 67265 RVA: 0x003D03F8 File Offset: 0x003CE5F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_6()
			{
				Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SellableDescriber>.NativeClassPtr, "<>c__DisplayClass23_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr);
				SellableDescriber.__c__DisplayClass23_6.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr, "tags");
				SellableDescriber.__c__DisplayClass23_6.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr, "CS$<>8__locals6");
				SellableDescriber.__c__DisplayClass23_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr, 100684895);
				SellableDescriber.__c__DisplayClass23_6.NativeMethodInfoPtr__ShowSellableProperty_b__11_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr, 100684896);
			}

			// Token: 0x060106C2 RID: 67266 RVA: 0x003D0474 File Offset: 0x003CE674
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableDescriber.__c__DisplayClass23_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106C3 RID: 67267 RVA: 0x003D04B0 File Offset: 0x003CE6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowSellableProperty_b__11(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableDescriber.__c__DisplayClass23_6.NativeMethodInfoPtr__ShowSellableProperty_b__11_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106C4 RID: 67268 RVA: 0x0008F476 File Offset: 0x0008D676
			public __c__DisplayClass23_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055CB RID: 21963
			// (get) Token: 0x060106C5 RID: 67269 RVA: 0x003D04F4 File Offset: 0x003CE6F4
			// (set) Token: 0x060106C6 RID: 67270 RVA: 0x0008F47F File Offset: 0x0008D67F
			public unsafe int tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_6.NativeFieldInfoPtr_tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_6.NativeFieldInfoPtr_tags)) = value;
				}
			}

			// Token: 0x170055CC RID: 21964
			// (get) Token: 0x060106C7 RID: 67271 RVA: 0x003D051C File Offset: 0x003CE71C
			// (set) Token: 0x060106C8 RID: 67272 RVA: 0x0008F49A File Offset: 0x0008D69A
			public unsafe SellableDescriber.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_6.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableDescriber.__c__DisplayClass23_6.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A659 RID: 42585
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400A65A RID: 42586
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x0400A65B RID: 42587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A65C RID: 42588
			private static readonly IntPtr NativeMethodInfoPtr__ShowSellableProperty_b__11_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
