using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Interactables.Collections.BehaviourComponents;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

// Token: 0x02000018 RID: 24
public class DLC5_Main_Part6_Tenshi : EntityBehaviourComponent
{
	// Token: 0x060001CC RID: 460 RVA: 0x000A4DCC File Offset: 0x000A2FCC
	// Note: this type is marked as 'beforefieldinit'.
	static DLC5_Main_Part6_Tenshi()
	{
		Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC5_Main_Part6_Tenshi");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr);
		DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_EntityKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, "m_EntityKey");
		DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_ShakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, "m_ShakeCoroutine");
		DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_InteractDialogAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, "m_InteractDialogAsset");
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663551);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663552);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663553);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnInteractAsync_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663554);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnToggleTrackedSwitch_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663555);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_StartShake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663556);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_StopShake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663557);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663558);
		DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr__OnInteractAsync_b__6_0_Private_UniTask_1_IAssetHandle_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, 100663559);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000A4EEC File Offset: 0x000A30EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19105, XrefRangeEnd = 19140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000A4F20 File Offset: 0x000A3120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19140, XrefRangeEnd = 19159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000A4F54 File Offset: 0x000A3154
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19159, XrefRangeEnd = 19166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnInteract()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x000A4F90 File Offset: 0x000A3190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19166, XrefRangeEnd = 19171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniTaskVoid OnInteractAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnInteractAsync_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x000A4FCC File Offset: 0x000A31CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19171, XrefRangeEnd = 19174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnToggleTrackedSwitch(string key, bool isOpen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_OnToggleTrackedSwitch_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x000A501C File Offset: 0x000A321C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19174, XrefRangeEnd = 19185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartShake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_StartShake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000A5050 File Offset: 0x000A3250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19185, XrefRangeEnd = 19187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopShake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr_StopShake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000A5084 File Offset: 0x000A3284
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19187, XrefRangeEnd = 19188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC5_Main_Part6_Tenshi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000A50C0 File Offset: 0x000A32C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19190, XrefRangeEnd = 19193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniTask<IAssetHandle<DialogPackage>> _OnInteractAsync_b__6_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr;
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi.NativeMethodInfoPtr__OnInteractAsync_b__6_0_Private_UniTask_1_IAssetHandle_1_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new UniTask<IAssetHandle<DialogPackage>>(pointer);
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002EA0 File Offset: 0x000010A0
	public DLC5_Main_Part6_Tenshi(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x000A50F8 File Offset: 0x000A32F8
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002EA9 File Offset: 0x000010A9
	public unsafe string m_EntityKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_EntityKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_EntityKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x000A5120 File Offset: 0x000A3320
	// (set) Token: 0x060001DA RID: 474 RVA: 0x00002EC8 File Offset: 0x000010C8
	public unsafe Coroutine m_ShakeCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_ShakeCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_ShakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060001DB RID: 475 RVA: 0x000A5150 File Offset: 0x000A3350
	// (set) Token: 0x060001DC RID: 476 RVA: 0x00002EE7 File Offset: 0x000010E7
	public unsafe AssetReferenceT<DialogPackage> m_InteractDialogAsset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_InteractDialogAsset);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<DialogPackage>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi.NativeFieldInfoPtr_m_InteractDialogAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000129 RID: 297
	private static readonly IntPtr NativeFieldInfoPtr_m_EntityKey;

	// Token: 0x0400012A RID: 298
	private static readonly IntPtr NativeFieldInfoPtr_m_ShakeCoroutine;

	// Token: 0x0400012B RID: 299
	private static readonly IntPtr NativeFieldInfoPtr_m_InteractDialogAsset;

	// Token: 0x0400012C RID: 300
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400012D RID: 301
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400012E RID: 302
	private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

	// Token: 0x0400012F RID: 303
	private static readonly IntPtr NativeMethodInfoPtr_OnInteractAsync_Private_UniTaskVoid_0;

	// Token: 0x04000130 RID: 304
	private static readonly IntPtr NativeMethodInfoPtr_OnToggleTrackedSwitch_Private_Void_String_Boolean_0;

	// Token: 0x04000131 RID: 305
	private static readonly IntPtr NativeMethodInfoPtr_StartShake_Private_Void_0;

	// Token: 0x04000132 RID: 306
	private static readonly IntPtr NativeMethodInfoPtr_StopShake_Private_Void_0;

	// Token: 0x04000133 RID: 307
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000134 RID: 308
	private static readonly IntPtr NativeMethodInfoPtr__OnInteractAsync_b__6_0_Private_UniTask_1_IAssetHandle_1_DialogPackage_0;

	// Token: 0x02000481 RID: 1153
	[ObfuscatedName("DLC5_Main_Part6_Tenshi+<OnInteractAsync>d__6")]
	public sealed class _OnInteractAsync_d__6 : ValueType
	{
		// Token: 0x06007CD5 RID: 31957 RVA: 0x0023BE9C File Offset: 0x0023A09C
		// Note: this type is marked as 'beforefieldinit'.
		static _OnInteractAsync_d__6()
		{
			Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi>.NativeClassPtr, "<OnInteractAsync>d__6");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr);
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, "<>1__state");
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, "<>t__builder");
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, "<>4__this");
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr__assetHandle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, "<assetHandle>5__2");
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, "<>u__1");
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, "<>u__2");
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, 100663560);
			DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr, 100663561);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x0023BF68 File Offset: 0x0023A168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19102, RefRangeEnd = 19104, XrefRangeStart = 19083, XrefRangeEnd = 19102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x0023BFA0 File Offset: 0x0023A1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19104, XrefRangeEnd = 19105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x00043306 File Offset: 0x00041506
		public _OnInteractAsync_d__6(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x0004330F File Offset: 0x0004150F
		public _OnInteractAsync_d__6() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6>.NativeClassPtr))
		{
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x0023BFE8 File Offset: 0x0023A1E8
		// (set) Token: 0x06007CDB RID: 31963 RVA: 0x00043321 File Offset: 0x00041521
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x06007CDC RID: 31964 RVA: 0x0023C010 File Offset: 0x0023A210
		// (set) Token: 0x06007CDD RID: 31965 RVA: 0x0004333C File Offset: 0x0004153C
		public AsyncUniTaskVoidMethodBuilder __t__builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___t__builder);
				return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x06007CDE RID: 31966 RVA: 0x0023C040 File Offset: 0x0023A240
		// (set) Token: 0x06007CDF RID: 31967 RVA: 0x0004336A File Offset: 0x0004156A
		public unsafe DLC5_Main_Part6_Tenshi __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_Main_Part6_Tenshi>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x06007CE0 RID: 31968 RVA: 0x0023C070 File Offset: 0x0023A270
		// (set) Token: 0x06007CE1 RID: 31969 RVA: 0x00043389 File Offset: 0x00041589
		public unsafe IAssetHandle<DialogPackage> _assetHandle_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr__assetHandle_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr__assetHandle_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x06007CE2 RID: 31970 RVA: 0x0023C0A0 File Offset: 0x0023A2A0
		// (set) Token: 0x06007CE3 RID: 31971 RVA: 0x000433A8 File Offset: 0x000415A8
		public UniTask<IAssetHandle<DialogPackage>>.Awaiter __u__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___u__1);
				return new UniTask<IAssetHandle<DialogPackage>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<DialogPackage>>.Awaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<DialogPackage>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x0023C0D0 File Offset: 0x0023A2D0
		// (set) Token: 0x06007CE5 RID: 31973 RVA: 0x000433D6 File Offset: 0x000415D6
		public UniTask.Awaiter __u__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___u__2);
				return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Main_Part6_Tenshi._OnInteractAsync_d__6.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400522A RID: 21034
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400522B RID: 21035
		private static readonly IntPtr NativeFieldInfoPtr___t__builder;

		// Token: 0x0400522C RID: 21036
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400522D RID: 21037
		private static readonly IntPtr NativeFieldInfoPtr__assetHandle_5__2;

		// Token: 0x0400522E RID: 21038
		private static readonly IntPtr NativeFieldInfoPtr___u__1;

		// Token: 0x0400522F RID: 21039
		private static readonly IntPtr NativeFieldInfoPtr___u__2;

		// Token: 0x04005230 RID: 21040
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005231 RID: 21041
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
	}
}
