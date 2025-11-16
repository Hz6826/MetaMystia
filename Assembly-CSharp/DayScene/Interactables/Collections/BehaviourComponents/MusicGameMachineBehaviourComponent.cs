using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using MusicGame.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200018B RID: 395
	public class MusicGameMachineBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002AE3 RID: 10979 RVA: 0x0012CE60 File Offset: 0x0012B060
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMachineBehaviourComponent()
		{
			Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MusicGameMachineBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr);
			MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_PannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, "m_PannelPrefab");
			MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_TipIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, "m_TipIcon");
			MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_FirstOpenDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, "m_FirstOpenDialog");
			MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_IsMainMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, "m_IsMainMap");
			MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OnEnterMap_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, 100670750);
			MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, 100670751);
			MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OpenPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, 100670752);
			MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OpenPanelAsync_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, 100670753);
			MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, 100670754);
			MusicGameMachineBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, 100670755);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0012CF58 File Offset: 0x0012B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95839, XrefRangeEnd = 95848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnterMap(string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OnEnterMap_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0012CFA8 File Offset: 0x0012B1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95848, XrefRangeEnd = 95868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0012CFE4 File Offset: 0x0012B1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95868, XrefRangeEnd = 95874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OpenPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x0012D018 File Offset: 0x0012B218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95874, XrefRangeEnd = 95879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenPanelAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_OpenPanelAsync_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x0012D054 File Offset: 0x0012B254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMachineBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x0012D090 File Offset: 0x0012B290
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMachineBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMachineBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0001901C File Offset: 0x0001721C
		public MusicGameMachineBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0012D0CC File Offset: 0x0012B2CC
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x00019025 File Offset: 0x00017225
		public unsafe AssetReferenceT<GameObject> m_PannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_PannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_PannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x0012D0FC File Offset: 0x0012B2FC
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x00019044 File Offset: 0x00017244
		public unsafe GameObject m_TipIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_TipIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_TipIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x0012D12C File Offset: 0x0012B32C
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x00019063 File Offset: 0x00017263
		public unsafe DialogPackage m_FirstOpenDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_FirstOpenDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_FirstOpenDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x0012D15C File Offset: 0x0012B35C
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x00019082 File Offset: 0x00017282
		public unsafe bool m_IsMainMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_IsMainMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent.NativeFieldInfoPtr_m_IsMainMap)) = value;
			}
		}

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr_m_PannelPrefab;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_m_TipIcon;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstOpenDialog;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMainMap;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterMap_Public_Virtual_Void_String_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_OpenPannel_Private_Void_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelAsync_Private_UniTaskVoid_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C1 RID: 1985
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.MusicGameMachineBehaviourComponent+<OpenPanelAsync>d__7")]
		public sealed class _OpenPanelAsync_d__7 : ValueType
		{
			// Token: 0x0600A588 RID: 42376 RVA: 0x002B3694 File Offset: 0x002B1894
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenPanelAsync_d__7()
			{
				Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent>.NativeClassPtr, "<OpenPanelAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr);
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, "<>1__state");
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, "<>t__builder");
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, "<>4__this");
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, "<>u__1");
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, "<>u__2");
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, 100670756);
				MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr, 100670757);
			}

			// Token: 0x0600A589 RID: 42377 RVA: 0x002B374C File Offset: 0x002B194C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 95837, RefRangeEnd = 95839, XrefRangeStart = 95792, XrefRangeEnd = 95837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A58A RID: 42378 RVA: 0x002B3784 File Offset: 0x002B1984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A58B RID: 42379 RVA: 0x000597E9 File Offset: 0x000579E9
			public _OpenPanelAsync_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A58C RID: 42380 RVA: 0x000597F2 File Offset: 0x000579F2
			public _OpenPanelAsync_d__7() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x17003683 RID: 13955
			// (get) Token: 0x0600A58D RID: 42381 RVA: 0x002B37CC File Offset: 0x002B19CC
			// (set) Token: 0x0600A58E RID: 42382 RVA: 0x00059804 File Offset: 0x00057A04
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003684 RID: 13956
			// (get) Token: 0x0600A58F RID: 42383 RVA: 0x002B37F4 File Offset: 0x002B19F4
			// (set) Token: 0x0600A590 RID: 42384 RVA: 0x0005981F File Offset: 0x00057A1F
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003685 RID: 13957
			// (get) Token: 0x0600A591 RID: 42385 RVA: 0x002B3824 File Offset: 0x002B1A24
			// (set) Token: 0x0600A592 RID: 42386 RVA: 0x0005984D File Offset: 0x00057A4D
			public unsafe MusicGameMachineBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMachineBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003686 RID: 13958
			// (get) Token: 0x0600A593 RID: 42387 RVA: 0x002B3854 File Offset: 0x002B1A54
			// (set) Token: 0x0600A594 RID: 42388 RVA: 0x0005986C File Offset: 0x00057A6C
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003687 RID: 13959
			// (get) Token: 0x0600A595 RID: 42389 RVA: 0x002B3884 File Offset: 0x002B1A84
			// (set) Token: 0x0600A596 RID: 42390 RVA: 0x0005989A File Offset: 0x00057A9A
			public UniTask<MusicGameIntroInfoPannel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___u__2);
					return new UniTask<MusicGameIntroInfoPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<MusicGameIntroInfoPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMachineBehaviourComponent._OpenPanelAsync_d__7.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<MusicGameIntroInfoPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006B08 RID: 27400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006B09 RID: 27401
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006B0A RID: 27402
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B0B RID: 27403
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006B0C RID: 27404
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04006B0D RID: 27405
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006B0E RID: 27406
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
