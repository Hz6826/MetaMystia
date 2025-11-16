using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000182 RID: 386
	public class GeneralPurposeBehaviourCompoent : EntityBehaviourComponent
	{
		// Token: 0x06002A13 RID: 10771 RVA: 0x0012A2F4 File Offset: 0x001284F4
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralPurposeBehaviourCompoent()
		{
			Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "GeneralPurposeBehaviourCompoent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr);
			GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_uiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, "uiType");
			GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_customUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, "customUI");
			GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_m_CustomUIAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, "m_CustomUIAssetReference");
			GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_dialogLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, "dialogLabel");
			GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, 100670622);
			GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_LoadAndOpenUIPanelAsset_Private_UniTaskVoid_AssetReferenceGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, 100670623);
			GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_GetComponentNotNull_Private_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, 100670624);
			GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, 100670625);
			GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, 100670626);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0012A3D8 File Offset: 0x001285D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94459, XrefRangeEnd = 94470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x0012A414 File Offset: 0x00128614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94470, XrefRangeEnd = 94475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid LoadAndOpenUIPanelAsset(AssetReferenceGameObject panelAssetReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panelAssetReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_LoadAndOpenUIPanelAsset_Private_UniTaskVoid_AssetReferenceGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x0012A464 File Offset: 0x00128664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94475, RefRangeEnd = 94476, XrefRangeStart = 94475, XrefRangeEnd = 94475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetComponentNotNull<T>(GameObject gameObjectInstance) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPurposeBehaviourCompoent.MethodInfoStoreGeneric_GetComponentNotNull_Private_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x0012A4A4 File Offset: 0x001286A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0012A4E0 File Offset: 0x001286E0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralPurposeBehaviourCompoent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00018962 File Offset: 0x00016B62
		public GeneralPurposeBehaviourCompoent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x0012A51C File Offset: 0x0012871C
		// (set) Token: 0x06002A1B RID: 10779 RVA: 0x0001896B File Offset: 0x00016B6B
		public unsafe GeneralPurposeBehaviourCompoent.EntryType uiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_uiType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_uiType)) = value;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x0012A544 File Offset: 0x00128744
		// (set) Token: 0x06002A1D RID: 10781 RVA: 0x00018986 File Offset: 0x00016B86
		public unsafe GameObject customUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_customUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_customUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002A1E RID: 10782 RVA: 0x0012A574 File Offset: 0x00128774
		// (set) Token: 0x06002A1F RID: 10783 RVA: 0x000189A5 File Offset: 0x00016BA5
		public unsafe AssetReferenceGameObject m_CustomUIAssetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_m_CustomUIAssetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceGameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_m_CustomUIAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x0012A5A4 File Offset: 0x001287A4
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x000189C4 File Offset: 0x00016BC4
		public unsafe string dialogLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_dialogLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent.NativeFieldInfoPtr_dialogLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeFieldInfoPtr_uiType;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr_customUI;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomUIAssetReference;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_dialogLabel;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndOpenUIPanelAsset_Private_UniTaskVoid_AssetReferenceGameObject_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentNotNull_Private_Static_T_GameObject_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007AE RID: 1966
		public enum EntryType
		{
			// Token: 0x04006A98 RID: 27288
			FoodStorage,
			// Token: 0x04006A99 RID: 27289
			BeverageStorage,
			// Token: 0x04006A9A RID: 27290
			Custom,
			// Token: 0x04006A9B RID: 27291
			YukariMapTeleport,
			// Token: 0x04006A9C RID: 27292
			Dialog
		}

		// Token: 0x020007AF RID: 1967
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.GeneralPurposeBehaviourCompoent+<LoadAndOpenUIPanelAsset>d__6")]
		public sealed class _LoadAndOpenUIPanelAsset_d__6 : ValueType
		{
			// Token: 0x0600A4C9 RID: 42185 RVA: 0x002B1578 File Offset: 0x002AF778
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndOpenUIPanelAsset_d__6()
			{
				Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr, "<LoadAndOpenUIPanelAsset>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr);
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, "<>1__state");
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, "<>t__builder");
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr_panelAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, "panelAssetReference");
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, "<>u__1");
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, "<>u__2");
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, 100670627);
				GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr, 100670628);
			}

			// Token: 0x0600A4CA RID: 42186 RVA: 0x002B1630 File Offset: 0x002AF830
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94457, RefRangeEnd = 94459, XrefRangeStart = 94397, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4CB RID: 42187 RVA: 0x002B1668 File Offset: 0x002AF868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4CC RID: 42188 RVA: 0x000591CB File Offset: 0x000573CB
			public _LoadAndOpenUIPanelAsset_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A4CD RID: 42189 RVA: 0x000591D4 File Offset: 0x000573D4
			public _LoadAndOpenUIPanelAsset_d__6() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6>.NativeClassPtr))
			{
			}

			// Token: 0x17003650 RID: 13904
			// (get) Token: 0x0600A4CE RID: 42190 RVA: 0x002B16B0 File Offset: 0x002AF8B0
			// (set) Token: 0x0600A4CF RID: 42191 RVA: 0x000591E6 File Offset: 0x000573E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003651 RID: 13905
			// (get) Token: 0x0600A4D0 RID: 42192 RVA: 0x002B16D8 File Offset: 0x002AF8D8
			// (set) Token: 0x0600A4D1 RID: 42193 RVA: 0x00059201 File Offset: 0x00057401
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003652 RID: 13906
			// (get) Token: 0x0600A4D2 RID: 42194 RVA: 0x002B1708 File Offset: 0x002AF908
			// (set) Token: 0x0600A4D3 RID: 42195 RVA: 0x0005922F File Offset: 0x0005742F
			public unsafe AssetReferenceGameObject panelAssetReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr_panelAssetReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceGameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr_panelAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003653 RID: 13907
			// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x002B1738 File Offset: 0x002AF938
			// (set) Token: 0x0600A4D5 RID: 42197 RVA: 0x0005924E File Offset: 0x0005744E
			public UniTask<GameObject>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___u__1);
					return new UniTask<GameObject>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<GameObject>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<GameObject>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003654 RID: 13908
			// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x002B1768 File Offset: 0x002AF968
			// (set) Token: 0x0600A4D7 RID: 42199 RVA: 0x0005927C File Offset: 0x0005747C
			public UniTask<UIPanel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___u__2);
					return new UniTask<UIPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<UIPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPurposeBehaviourCompoent._LoadAndOpenUIPanelAsset_d__6.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<UIPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006A9D RID: 27293
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A9E RID: 27294
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006A9F RID: 27295
			private static readonly IntPtr NativeFieldInfoPtr_panelAssetReference;

			// Token: 0x04006AA0 RID: 27296
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006AA1 RID: 27297
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04006AA2 RID: 27298
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006AA3 RID: 27299
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020007B0 RID: 1968
		private sealed class MethodInfoStoreGeneric_GetComponentNotNull_Private_Static_T_GameObject_0<T>
		{
			// Token: 0x04006AA4 RID: 27300
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GeneralPurposeBehaviourCompoent.NativeMethodInfoPtr_GetComponentNotNull_Private_Static_T_GameObject_0, Il2CppClassPointerStore<GeneralPurposeBehaviourCompoent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
