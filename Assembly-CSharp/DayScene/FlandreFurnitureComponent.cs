using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace DayScene
{
	// Token: 0x020000B3 RID: 179
	public class FlandreFurnitureComponent : MonoBehaviour
	{
		// Token: 0x06001356 RID: 4950 RVA: 0x000DF7E0 File Offset: 0x000DD9E0
		// Note: this type is marked as 'beforefieldinit'.
		static FlandreFurnitureComponent()
		{
			Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene", "FlandreFurnitureComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr);
			FlandreFurnitureComponent.NativeFieldInfoPtr_EditorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, "EditorColor");
			FlandreFurnitureComponent.NativeFieldInfoPtr_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, "NormalColor");
			FlandreFurnitureComponent.NativeFieldInfoPtr_OutlineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, "OutlineRenderer");
			FlandreFurnitureComponent.NativeFieldInfoPtr_pointArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, "pointArea");
			FlandreFurnitureComponent.NativeFieldInfoPtr_allSpriteRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, "allSpriteRenderers");
			FlandreFurnitureComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666643);
			FlandreFurnitureComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666644);
			FlandreFurnitureComponent.NativeMethodInfoPtr_ExitEditorMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666645);
			FlandreFurnitureComponent.NativeMethodInfoPtr_EnterEditorMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666646);
			FlandreFurnitureComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666647);
			FlandreFurnitureComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666648);
			FlandreFurnitureComponent.NativeMethodInfoPtr__Awake_b__5_0_Private_Boolean_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, 100666650);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000DF900 File Offset: 0x000DDB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53240, XrefRangeEnd = 53258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000DF934 File Offset: 0x000DDB34
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000DF968 File Offset: 0x000DDB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53277, RefRangeEnd = 53279, XrefRangeStart = 53258, XrefRangeEnd = 53277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitEditorMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.NativeMethodInfoPtr_ExitEditorMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000DF99C File Offset: 0x000DDB9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 53298, RefRangeEnd = 53302, XrefRangeStart = 53279, XrefRangeEnd = 53298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterEditorMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.NativeMethodInfoPtr_EnterEditorMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlandreFurnitureComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000DFA0C File Offset: 0x000DDC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53302, XrefRangeEnd = 53311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlandreFurnitureComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000DFA48 File Offset: 0x000DDC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53311, XrefRangeEnd = 53318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Awake_b__5_0(SpriteRenderer x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.NativeMethodInfoPtr__Awake_b__5_0_Private_Boolean_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000C34B File Offset: 0x0000A54B
		public FlandreFurnitureComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x000DFA98 File Offset: 0x000DDC98
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x0000C354 File Offset: 0x0000A554
		public unsafe static Color EditorColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(FlandreFurnitureComponent.NativeFieldInfoPtr_EditorColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreFurnitureComponent.NativeFieldInfoPtr_EditorColor, (void*)(&value));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x000DFAB4 File Offset: 0x000DDCB4
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0000C362 File Offset: 0x0000A562
		public unsafe static Color NormalColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(FlandreFurnitureComponent.NativeFieldInfoPtr_NormalColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreFurnitureComponent.NativeFieldInfoPtr_NormalColor, (void*)(&value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x000DFAD0 File Offset: 0x000DDCD0
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x0000C370 File Offset: 0x0000A570
		public unsafe SpriteRenderer OutlineRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureComponent.NativeFieldInfoPtr_OutlineRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureComponent.NativeFieldInfoPtr_OutlineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x000DFB00 File Offset: 0x000DDD00
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x0000C38F File Offset: 0x0000A58F
		public unsafe Vector2Int pointArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureComponent.NativeFieldInfoPtr_pointArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureComponent.NativeFieldInfoPtr_pointArea)) = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000DFB28 File Offset: 0x000DDD28
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x0000C3AA File Offset: 0x0000A5AA
		public unsafe List<SpriteRenderer> allSpriteRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureComponent.NativeFieldInfoPtr_allSpriteRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureComponent.NativeFieldInfoPtr_allSpriteRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_EditorColor;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_NormalColor;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderer;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr_pointArea;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr_allSpriteRenderers;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_ExitEditorMode_Public_Void_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_EnterEditorMode_Public_Void_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Boolean_SpriteRenderer_0;

		// Token: 0x020005CD RID: 1485
		[ObfuscatedName("DayScene.FlandreFurnitureComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008D3A RID: 36154 RVA: 0x0026B9CC File Offset: 0x00269BCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreFurnitureComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr);
				FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr, "<>9");
				FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr, "<>9__7_0");
				FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr, "<>9__8_0");
				FlandreFurnitureComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr, 100666652);
				FlandreFurnitureComponent.__c.NativeMethodInfoPtr__ExitEditorMode_b__7_0_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr, 100666653);
				FlandreFurnitureComponent.__c.NativeMethodInfoPtr__EnterEditorMode_b__8_0_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr, 100666654);
			}

			// Token: 0x06008D3B RID: 36155 RVA: 0x0026BA70 File Offset: 0x00269C70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreFurnitureComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D3C RID: 36156 RVA: 0x0026BAAC File Offset: 0x00269CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53230, XrefRangeEnd = 53235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExitEditorMode_b__7_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.__c.NativeMethodInfoPtr__ExitEditorMode_b__7_0_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D3D RID: 36157 RVA: 0x0026BAF0 File Offset: 0x00269CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53235, XrefRangeEnd = 53240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterEditorMode_b__8_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureComponent.__c.NativeMethodInfoPtr__EnterEditorMode_b__8_0_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D3E RID: 36158 RVA: 0x0004BF17 File Offset: 0x0004A117
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F38 RID: 12088
			// (get) Token: 0x06008D3F RID: 36159 RVA: 0x0026BB34 File Offset: 0x00269D34
			// (set) Token: 0x06008D40 RID: 36160 RVA: 0x0004BF20 File Offset: 0x0004A120
			public unsafe static FlandreFurnitureComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreFurnitureComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F39 RID: 12089
			// (get) Token: 0x06008D41 RID: 36161 RVA: 0x0026BB5C File Offset: 0x00269D5C
			// (set) Token: 0x06008D42 RID: 36162 RVA: 0x0004BF32 File Offset: 0x0004A132
			public unsafe static Action<SpriteRenderer> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F3A RID: 12090
			// (get) Token: 0x06008D43 RID: 36163 RVA: 0x0026BB84 File Offset: 0x00269D84
			// (set) Token: 0x06008D44 RID: 36164 RVA: 0x0004BF44 File Offset: 0x0004A144
			public unsafe static Action<SpriteRenderer> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlandreFurnitureComponent.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C4F RID: 23631
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C50 RID: 23632
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04005C51 RID: 23633
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04005C52 RID: 23634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C53 RID: 23635
			private static readonly IntPtr NativeMethodInfoPtr__ExitEditorMode_b__7_0_Internal_Void_SpriteRenderer_0;

			// Token: 0x04005C54 RID: 23636
			private static readonly IntPtr NativeMethodInfoPtr__EnterEditorMode_b__8_0_Internal_Void_SpriteRenderer_0;
		}
	}
}
