using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003EE RID: 1006
	public class COM_ADialog_Manual_Init : PlayableAsset
	{
		// Token: 0x060076A8 RID: 30376 RVA: 0x00229A34 File Offset: 0x00227C34
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Manual_Init()
		{
			Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Manual_Init");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr);
			COM_ADialog_Manual_Init.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr, "dialogPackage");
			COM_ADialog_Manual_Init.NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr, "shouldHaveBlackBackgroundInDefault");
			COM_ADialog_Manual_Init.NativeFieldInfoPtr_PreservePreviousPannelVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr, "PreservePreviousPannelVisual");
			COM_ADialog_Manual_Init.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr, 100687519);
			COM_ADialog_Manual_Init.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr, 100687520);
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00229AC8 File Offset: 0x00227CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292831, XrefRangeEnd = 292848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Manual_Init.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00229B30 File Offset: 0x00227D30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Manual_Init() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Manual_Init>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Init.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00040365 File Offset: 0x0003E565
		public COM_ADialog_Manual_Init(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x00229B6C File Offset: 0x00227D6C
		// (set) Token: 0x060076AD RID: 30381 RVA: 0x0004036E File Offset: 0x0003E56E
		public unsafe DialogPackage dialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init.NativeFieldInfoPtr_dialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x00229B9C File Offset: 0x00227D9C
		// (set) Token: 0x060076AF RID: 30383 RVA: 0x0004038D File Offset: 0x0003E58D
		public unsafe bool shouldHaveBlackBackgroundInDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init.NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init.NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault)) = value;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x00229BC4 File Offset: 0x00227DC4
		// (set) Token: 0x060076B1 RID: 30385 RVA: 0x000403A8 File Offset: 0x0003E5A8
		public unsafe bool PreservePreviousPannelVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init.NativeFieldInfoPtr_PreservePreviousPannelVisual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init.NativeFieldInfoPtr_PreservePreviousPannelVisual)) = value;
			}
		}

		// Token: 0x04004E83 RID: 20099
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

		// Token: 0x04004E84 RID: 20100
		private static readonly IntPtr NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault;

		// Token: 0x04004E85 RID: 20101
		private static readonly IntPtr NativeFieldInfoPtr_PreservePreviousPannelVisual;

		// Token: 0x04004E86 RID: 20102
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E87 RID: 20103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
