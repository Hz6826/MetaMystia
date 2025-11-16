using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace DayScene.UI
{
	// Token: 0x020000C7 RID: 199
	public class DaySceneMusicPlayerSubPannel : UISubPanel<DaySceneMusicPlayerPannel>
	{
		// Token: 0x06001726 RID: 5926 RVA: 0x000EBE50 File Offset: 0x000EA050
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneMusicPlayerSubPannel()
		{
			Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneMusicPlayerSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr);
			DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, "PlayBtn");
			DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayCurrentInIzakayaBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, "PlayCurrentInIzakayaBtn");
			DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayWholeSetInIzakayaBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, "PlayWholeSetInIzakayaBtn");
			DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_hasAddReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, "hasAddReset");
			DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_m_CurrentPlayingBGMHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, "m_CurrentPlayingBGMHandle");
			DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_m_CurrentPlayingBGMId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, "m_CurrentPlayingBGMId");
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667488);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667489);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667490);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_PlayCurrentInIzakaya_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667491);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_PlayWholeSetInIzakaya_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667492);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_ResetIzakayaBGM_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667493);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_TryReleaseCurrentPlayingPackage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667494);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667495);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_ClearCurrentPlayingBGM_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667496);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667497);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667498);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667499);
			DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Method_Private_Void_AsyncOperationHandle_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr, 100667500);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000EBFFC File Offset: 0x000EA1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65124, XrefRangeEnd = 65173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000EC038 File Offset: 0x000EA238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65173, XrefRangeEnd = 65194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000EC06C File Offset: 0x000EA26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65194, XrefRangeEnd = 65205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000EC0A0 File Offset: 0x000EA2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65205, XrefRangeEnd = 65211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCurrentInIzakaya()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_PlayCurrentInIzakaya_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x000EC0D4 File Offset: 0x000EA2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65211, XrefRangeEnd = 65217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayWholeSetInIzakaya()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_PlayWholeSetInIzakaya_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x000EC108 File Offset: 0x000EA308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65217, XrefRangeEnd = 65223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIzakayaBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_ResetIzakayaBGM_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000EC13C File Offset: 0x000EA33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65223, XrefRangeEnd = 65228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseCurrentPlayingPackage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_TryReleaseCurrentPlayingPackage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000EC170 File Offset: 0x000EA370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65228, XrefRangeEnd = 65260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000EC1AC File Offset: 0x000EA3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65260, XrefRangeEnd = 65271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCurrentPlayingBGM(string _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_ClearCurrentPlayingBGM_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000EC1F0 File Offset: 0x000EA3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000EC22C File Offset: 0x000EA42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65271, XrefRangeEnd = 65274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneMusicPlayerSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMusicPlayerSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000EC268 File Offset: 0x000EA468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65274, XrefRangeEnd = 65282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_0(UIButtonToggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000EC2AC File Offset: 0x000EA4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65282, XrefRangeEnd = 65299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_AsyncOperationHandle_PDM_0(AsyncOperationHandle loadedBgmPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadedBgmPackage));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerSubPannel.NativeMethodInfoPtr_Method_Private_Void_AsyncOperationHandle_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0000E6F2 File Offset: 0x0000C8F2
		public DaySceneMusicPlayerSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x000EC2F4 File Offset: 0x000EA4F4
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x0000E6FB File Offset: 0x0000C8FB
		public unsafe UIButtonToggle PlayBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x000EC324 File Offset: 0x000EA524
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000E71A File Offset: 0x0000C91A
		public unsafe UIButtonToggle PlayCurrentInIzakayaBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayCurrentInIzakayaBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayCurrentInIzakayaBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000EC354 File Offset: 0x000EA554
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000E739 File Offset: 0x0000C939
		public unsafe UIButtonToggle PlayWholeSetInIzakayaBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayWholeSetInIzakayaBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_PlayWholeSetInIzakayaBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x000EC384 File Offset: 0x000EA584
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0000E758 File Offset: 0x0000C958
		public unsafe bool hasAddReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_hasAddReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_hasAddReset)) = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000EC3AC File Offset: 0x000EA5AC
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0000E773 File Offset: 0x0000C973
		public AsyncOperationHandle m_CurrentPlayingBGMHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_m_CurrentPlayingBGMHandle);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_m_CurrentPlayingBGMHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x000EC3DC File Offset: 0x000EA5DC
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0000E7A1 File Offset: 0x0000C9A1
		public Nullable<int> m_CurrentPlayingBGMId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_m_CurrentPlayingBGMId);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerSubPannel.NativeFieldInfoPtr_m_CurrentPlayingBGMId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr_PlayBtn;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeFieldInfoPtr_PlayCurrentInIzakayaBtn;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeFieldInfoPtr_PlayWholeSetInIzakayaBtn;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeFieldInfoPtr_hasAddReset;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPlayingBGMHandle;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPlayingBGMId;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_PlayCurrentInIzakaya_Private_Void_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_PlayWholeSetInIzakaya_Private_Void_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_ResetIzakayaBGM_Private_Void_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseCurrentPlayingPackage_Private_Void_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_ClearCurrentPlayingBGM_Private_Void_String_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_UIButtonToggle_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_AsyncOperationHandle_PDM_0;
	}
}
