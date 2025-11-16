using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using Plugins.DEYU;
using TMPro;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000AC RID: 172
	public class DLC4_ChallengeCardSelectorPanel_Describer : MonoBehaviour
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x000DCCF4 File Offset: 0x000DAEF4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_ChallengeCardSelectorPanel_Describer()
		{
			Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_ChallengeCardSelectorPanel_Describer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr);
			DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "m_Scheduler");
			DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_DescriberCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "m_DescriberCanvas");
			DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_DescriberSecondaryCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "m_DescriberSecondaryCanvas");
			DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_ManualText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "m_ManualText");
			DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_HPText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "m_HPText");
			DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "m_NameText");
			DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, 100666516);
			DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_SetVisual_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, 100666517);
			DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_Describe_Public_Void_GuestGuardMapping_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, 100666518);
			DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, 100666519);
			DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, 100666520);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000DCE00 File Offset: 0x000DB000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51816, XrefRangeEnd = 51817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000DCE34 File Offset: 0x000DB034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51817, XrefRangeEnd = 51821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisual(bool enable, bool immediateMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_SetVisual_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000DCE80 File Offset: 0x000DB080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51821, XrefRangeEnd = 51835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(GuestGuardMapping mapping, CancellationToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_Describe_Public_Void_GuestGuardMapping_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000DCEE0 File Offset: 0x000DB0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51835, XrefRangeEnd = 51841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000DCF1C File Offset: 0x000DB11C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_ChallengeCardSelectorPanel_Describer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel_Describer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0000BCBB File Offset: 0x00009EBB
		public DLC4_ChallengeCardSelectorPanel_Describer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x000DCF58 File Offset: 0x000DB158
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x000DCF88 File Offset: 0x000DB188
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x0000BCE3 File Offset: 0x00009EE3
		public unsafe CanvasGroup m_DescriberCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_DescriberCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_DescriberCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x000DCFB8 File Offset: 0x000DB1B8
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x0000BD02 File Offset: 0x00009F02
		public unsafe CanvasGroup m_DescriberSecondaryCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_DescriberSecondaryCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_DescriberSecondaryCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x000DCFE8 File Offset: 0x000DB1E8
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x0000BD21 File Offset: 0x00009F21
		public unsafe TextMeshProUGUI m_ManualText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_ManualText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_ManualText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x000DD018 File Offset: 0x000DB218
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0000BD40 File Offset: 0x00009F40
		public unsafe TextMeshProUGUI m_HPText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_HPText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_HPText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x000DD048 File Offset: 0x000DB248
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0000BD5F File Offset: 0x00009F5F
		public unsafe TextMeshProUGUI m_NameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_NameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.NativeFieldInfoPtr_m_NameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberCanvas;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberSecondaryCanvas;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_m_ManualText;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_m_HPText;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr_m_NameText;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_SetVisual_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_GuestGuardMapping_CancellationToken_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005BC RID: 1468
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_ChallengeCardSelectorPanel_Describer+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x06008C94 RID: 35988 RVA: 0x00269DE0 File Offset: 0x00267FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr);
				DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeFieldInfoPtr_mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr, "mapping");
				DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr, 100666521);
				DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeMethodInfoPtr__Describe_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr, 100666522);
			}

			// Token: 0x06008C95 RID: 35989 RVA: 0x00269E5C File Offset: 0x0026805C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C96 RID: 35990 RVA: 0x00269E98 File Offset: 0x00268098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51812, XrefRangeEnd = 51816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeMethodInfoPtr__Describe_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C97 RID: 35991 RVA: 0x0004B960 File Offset: 0x00049B60
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F0D RID: 12045
			// (get) Token: 0x06008C98 RID: 35992 RVA: 0x00269ECC File Offset: 0x002680CC
			// (set) Token: 0x06008C99 RID: 35993 RVA: 0x0004B969 File Offset: 0x00049B69
			public unsafe DLC4_ChallengeCardSelectorPanel_Describer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel_Describer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F0E RID: 12046
			// (get) Token: 0x06008C9A RID: 35994 RVA: 0x00269EFC File Offset: 0x002680FC
			// (set) Token: 0x06008C9B RID: 35995 RVA: 0x0004B988 File Offset: 0x00049B88
			public GuestGuardMapping mapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeFieldInfoPtr_mapping);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel_Describer.__c__DisplayClass8_0.NativeFieldInfoPtr_mapping), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005BF5 RID: 23541
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BF6 RID: 23542
			private static readonly IntPtr NativeFieldInfoPtr_mapping;

			// Token: 0x04005BF7 RID: 23543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BF8 RID: 23544
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__0_Internal_Void_0;
		}
	}
}
